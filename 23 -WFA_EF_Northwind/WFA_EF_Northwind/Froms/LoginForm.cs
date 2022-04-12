using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Northwind.Froms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            foreach (User u in db.Users)
            {
                if(u.Username.ToLower() == txtUserName.Text.ToLower() && u.Password.ToLower() == txtPassword.Text.ToLower())
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!");
                }
            }
        }
    }
}
