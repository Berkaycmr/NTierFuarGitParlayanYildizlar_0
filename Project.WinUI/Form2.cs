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
        int delayTime;
        List<Request> req;
        List<Issue> iss;
        List<Customer> cus;
        List<Saloon> saloons;
        Saloon _selectedSaloon;
        CustomerRequest customerReq;
        Customer _selectedCustomer;


        public Form2()
        {
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

        private void btnAddSaloon_Click(object sender, EventArgs e)
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

        private void btnAddSponsor_Click(object sender, EventArgs e)
        {
            if (lstSaloons.SelectedIndex >-1)
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

        private void lstSaloons_Click(object sender, EventArgs e)
        {
            if (lstSaloons.SelectedIndex>-1)
            {
                _selectedSaloon = lstSaloons.SelectedItem as Saloon;
            }
            
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            /*
             Buradan devam edilecek.
             
             
             */





            //if (lstCustomers.SelectedIndex > -1 && cmbRequests.SelectedIndex>-1)
            //{
            //    customerReq = new CustomerRequest();
            //    customerReq.Customer = lstCustomers.SelectedItem as Customer;
            //    customerReq.Request = cmbRequests.SelectedItem as Request;
            //    _selectedCustomer = lstCustomers.SelectedItem as Customer;
            //    foreach (CustomerRequest item in _selectedCustomer.CustomerRequests)
            //    {
            //        _customerRequestRep.Add(item);
            //    }
            //    (lstCustomers.SelectedItem as Customer).CustomerRequests.Add(customerReq);
            //    (cmbRequests.SelectedItem as Request).CustomerRequests.Add(customerReq);

            //}
            //else
            //{
            //    MessageBox.Show("Bir müşteri ve talep seçtiğinizden emin olunuz.");
            //    return;
            //}
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (lstCustomers.SelectedIndex>-1)
            //{
                
            //    _selectedCustomer = lstCustomers.SelectedItem as Customer;
            //    foreach (CustomerRequest item in _selectedCustomer.CustomerRequests)
            //    {
            //        _customerRequestRep.GetAll();
            //        lstRequests.Items.Add(item.Request);
            //    }
            //}
            
        }
    }
}
