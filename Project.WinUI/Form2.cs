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
        AppUser _appUser;



        public Form2()
        {
            _appUser = new AppUser();
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

            


            //List<Request> requests= new List<Request>
            //{
            //    new Request{Name = "Toilet",UnitPrice = 100},
            //    new Request{Name = "Restaurant",UnitPrice = 250 },
            //    new Request{Name = "Cafe",UnitPrice = 200},
            //    new Request{Name = "Conference Hall",UnitPrice= 350 }
            //};

            //List<Issue> issues = new List<Issue>
            //{
            //    new Issue{Description = "Tuvalet tıkanıklığı",RecoveryTime = 2 },
            //    new Issue{Description = "Elektrik kesintisi",RecoveryTime = 1 },
            //    new Issue{Description = "İnternet kesintisi",RecoveryTime = 1 },
            //    new Issue{Description = "Ses arızası", RecoveryTime = 3 }
            //};

            //cmbRequests.DataSource= requests;

            //foreach (Request item in requests)
            //{
            //    _requestRep.Add(item);
            //}

            //lstIssues.DataSource = issues;

            //foreach (Issue item in issues)
            //{
            //    _issueRep.Add(item);
            //}

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                AppUser user = new AppUser();
                _appUser = user;
                Customer cst = new Customer();
                cst.CompanyName = txtCompanyName.Text;
                cst.Sector = txtSector.Text;
                cst.Country = txtCountry.Text;
                cst.AppUser = user;
                _customerRep.Add(cst);
                lstCustomers.Items.Add(cst);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            
                Saloon sln = new Saloon();
                sln.StartingDate = dtmStartDate.Value;
                sln.EndingDate= dtmEndDate.Value;
                sln.Location = txtLocation.Text;
                sln.Capacity = Convert.ToInt32(txtCapacity.Text);
                sln.Sector = txtSaloonSector.Text;                
                if (lstCustomers.SelectedIndex>-1)
                {
                    sln.Customer = lstCustomers.SelectedItem as Customer;
                    _saloonRep.Add(sln);
                    return;
                }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
            }
                
        }
    }
}
