using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
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
    public partial class Form1 : Form
    {

        AppUserRepository _appUserRep;


        public Form1()
        {
            _appUserRep = new AppUserRepository();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
             AppUser kısmı düzenlenecek. Veritabanıyla eşleşip eşleşmediği kontrol edilecek. Gerekli düzenlemeler yapılacak.

             
             */

            if (_appUserRep.Any(x => x.UserName == txtUsername.Text && x.Password == txtPassword.Text))
            {
                MessageBox.Show("Hoş geldiniz.");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                return;
            }


            //AppUser au = new AppUser();
            //au.UserName = txtUsername.Text;
            //au.Password = txtPassword.Text;


            //if (au.UserName == "admin" && au.Password == "123")
            //{
            //    MessageBox.Show("Hoş geldiniz");
            //    Form2 frm2 = new Form2();               
            //    frm2.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            //    return;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (_appUserRep.Any(x => x.UserName == txtUsername.Text && x.Password == txtPassword.Text))
            //{

            //}
        }
    }
}
