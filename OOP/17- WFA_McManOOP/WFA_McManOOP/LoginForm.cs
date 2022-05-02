using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McManOOP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<Users> userList = new List<Users>() 
        { 
            new Users {UserName="admin", Password ="1234", Role=Roles.Admin },
            new Users {UserName="employee", Password ="1234", Role=Roles.Employee }
        };
        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Users user in userList)
            {
                if (txtUserName.Text == user.UserName && txtPassword.Text == user.Password)
                {
                    switch (user.Role)
                    {
                        case Roles.Admin:
                            AdminForm aForm = new AdminForm();
                            HamburgerForm hbForm = new HamburgerForm(Roles.Admin);
                            aForm.Show();                            
                            this.Hide();                            
                            break;
                        case Roles.Employee:
                            HamburgerForm hForm = new HamburgerForm(Roles.Employee);
                            hForm.Show();
                            this.Hide();
                            break;
                    }
                }
            }
        }
    }
}
