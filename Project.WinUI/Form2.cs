using Project.BLL.DesignPatterns.SingletonPattern;
using Project.BLL.GenericRepository.ConcRep;
using Project.BLL.GenericRepository.BaseEFRep;
using Project.ENTITIES.Models;
using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {

        CustomerRep _customerRep;
        IssueRep _issueRep;
        RequestRep _requestRep;
        SaloonRep _saloonRep;
        SponsorRep _sponsorRep;
        AppUserRepository _appUserRep;
        CustomerRequestRep _customerRequestRep;
        RequestIssueRep _requestIssueRep;
        int delayTime;
        List<Request> req;
        List<Issue> iss;
        List<Customer> cus;
        List<Saloon> saloons;
        Saloon _selectedSaloon;
        CustomerRequest customerReq;
        Customer _selectedCustomer;
        Request _selectedRequest;
        Request _slcReq;
        Issue _selectedIssue;
        RequestIssue requestIss;
        decimal totalPrice;


        public Form2()
        {
            _requestIssueRep = new RequestIssueRep();
            _customerRequestRep= new CustomerRequestRep();
            _appUserRep = new AppUserRepository();
            _customerRep = new CustomerRep();
            _issueRep = new IssueRep();
            _requestRep = new RequestRep();
            _saloonRep = new SaloonRep();
            _sponsorRep= new SponsorRep();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
             Aldığımız instance'lar zaten veritabanında var olması gereken şeyler. Veri kalabalığını önleme amaçlı burası komple düzenlenecek.
             Teslimat süresiyle ilgili kod grubu öğrenildi. Teslimat süreleri eklenecek ve gerekli işlemler kod grubuna dahil edilecek.
             
             */

            dtmStartDateLast.Visible = false;
            dtmEndDateLast.Visible = false;
            label28.Visible= false;
            label29.Visible= false;
            dtmStartDate.MinDate = DateTime.Now;
            dtmEndDate.MinDate= DateTime.Now;


            req = _requestRep.GetAll();
            foreach (Request item in req)
            {
                cmbRequests.Items.Add(item);
            }
            iss = _issueRep.GetAll();
            foreach (Issue item in iss)
            {
                lstIssues.Items.Add(item);
            }
            cus = _customerRep.GetAll();
            foreach (Customer item in cus)
            {
                lstCustomers.Items.Add(item);
            }
            saloons = _saloonRep.GetAll();
            foreach (Saloon item in saloons)
            {
                lstSaloons.Items.Add(item);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text != "" && txtSector.Text != "" && txtCountry.Text != "")
                {
                    Customer cst = new Customer()
                    {
                        CompanyName = txtCompanyName.Text,
                        Sector = txtSector.Text,
                        Country = txtCountry.Text,
                        //TODO   AppUser = _appUserRep.Find(2), 
                    };
                    _customerRep.Add(cst);
                    lstCustomers.Items.Add(cst);
                }
                else
                {
                    MessageBox.Show("Müşteri bilgilerini giriniz.");
                    return;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm boşlukları doldurduğunuza emin olunuz.");

            }
                
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtmStartDate.Value == DateTime.Now && dtmEndDate.Value == DateTime.Now && txtCapacity.Text != "" && dtmStartDate.Value <= dtmEndDate.Value && txtSaloonSector.Text != "" && txtLocation.Text != "")
                {
                    if (lstCustomers.SelectedIndex > -1)
                    {
                        Saloon sln = new Saloon()
                        {
                            StartingDate = dtmStartDate.Value,
                            EndingDate = dtmEndDate.Value,
                            Location = txtLocation.Text,
                            Capacity = Convert.ToInt32(txtCapacity.Text),
                            Sector = txtSaloonSector.Text,
                            Customer = lstCustomers.SelectedItem as Customer,
                        };
                        _saloonRep.Add(sln);
                        lstSaloons.Items.Add(sln);
                        delayTime += 3;
                    }
                    else
                    {
                        MessageBox.Show("Bir müşteri seçiniz.");
                        return;
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm boşlukları doldurduğunuzdan emin olunuz.");
            }
            
        }

        private void btnAddSponsor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSponsorName.Text != "" && txtSponsorSector.Text != "")
                {
                    if (lstSaloons.SelectedIndex > -1)
                    {
                        Sponsor sp = new Sponsor();
                        sp.CompanyName = txtSponsorName.Text;
                        sp.Sector = txtSponsorSector.Text;
                        SaloonSponsor slnSponsor = new SaloonSponsor();
                        slnSponsor.Sponsor = sp;
                        slnSponsor.Saloon = _selectedSaloon;
                        _sponsorRep.Add(sp);
                    }
                    else
                    {
                        MessageBox.Show("Bir salon seçiniz.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tüm boşlukları doldurduğunuza emin olunuz.");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm boşlukları doldurduğunuzdan emin olunuz.");
            }
            
        }

        private void lstSaloons_Click(object sender, EventArgs e)
        {
            if (lstSaloons.SelectedIndex>-1)
            {
                _selectedSaloon = lstSaloons.SelectedItem as Saloon;
            }
            
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {

            if (lstCustomers.SelectedIndex > -1 && cmbRequests.SelectedIndex > -1)
            {
                _selectedCustomer = lstCustomers.SelectedItem as Customer;
                _selectedRequest = cmbRequests.SelectedItem as Request;
                customerReq = new CustomerRequest()
                {
                    CustomerID = _selectedCustomer.ID,
                    RequestID = _selectedRequest.ID
                };
                _customerRequestRep.Add(customerReq);
                foreach (CustomerRequest item in _selectedCustomer.CustomerRequests)
                {
                    delayTime += item.Request.DelayTime;
                }
            }
            else
            {
                MessageBox.Show("Bir müşteri ve talep seçtiğinizden emin olunuz.");
                return;
            }
            
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex > -1)
            {
                //customerReq = (lstCustomers.SelectedItem as Customer).CustomerRequests.a;
                lstRequests.Items.Clear();
                _selectedCustomer = lstCustomers.SelectedItem as Customer;
                foreach (CustomerRequest item in _selectedCustomer.CustomerRequests)
                {
                    _customerRequestRep.GetAll();
                    lstRequests.Items.Add(item.Request);
                    _slcReq = item.Request;
                }
            }

        }

        private void btnRequestIssue_Click(object sender, EventArgs e)
        {
            if (lstIssues.SelectedIndex >-1 && lstRequests.SelectedIndex > -1)
            {
                _slcReq = lstRequests.SelectedItem as Request;
                _selectedIssue = lstIssues.SelectedItem as Issue;
                requestIss = new RequestIssue()
                {
                    RequestID = _slcReq.ID,
                    IssueID = _selectedIssue.ID,
                };
                _requestIssueRep.Add(requestIss);
                delayTime += requestIss.Issue.DelayTime;
            }
            else
            {
                MessageBox.Show("Talep ve problem seçtiğinizden emin olunuz.");
                return;
            }
        }

        private void btnCalculateDate_Click(object sender, EventArgs e)
        {
            if (lstSaloons.SelectedIndex > -1)
            {
                _saloonRep.Find(_selectedSaloon.ID);
                dtmStartDateLast.Value = _selectedSaloon.StartingDate.AddDays(delayTime);
                dtmEndDateLast.Value = _selectedSaloon.EndingDate.AddDays(delayTime);
                dtmStartDateLast.Visible = true;
                dtmEndDateLast.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
            }
            else
            {
                MessageBox.Show("Salon seçiniz.");
            }

        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            totalPrice = 1000;
            if (lstCustomers.SelectedIndex > -1)
            {
                //customerReq = (lstCustomers.SelectedItem as Customer).CustomerRequests.a;
                _selectedCustomer = lstCustomers.SelectedItem as Customer;
                foreach (CustomerRequest item in _selectedCustomer.CustomerRequests)
                {
                    _customerRequestRep.GetAll();

                    totalPrice += item.Request.UnitPrice;

                }
                lblResult.Text = $"{totalPrice:C2}";
            }
            else
            {
                MessageBox.Show("Müşteri seçiniz.");
            }
        }
    }
}
