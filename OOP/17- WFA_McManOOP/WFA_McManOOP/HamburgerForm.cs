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
    public partial class HamburgerForm : Form
    {
        public HamburgerForm(Roles role)
        {
            InitializeComponent();
            Menus.Settings(cmbMenu, flpExtra);
            user.Role = role;
        }        
        //Variables
        decimal menuPrice = 0;
        object obj;
        string extras = string.Empty;
        Users user = new Users();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hbPrice = 0;
            List<Hambuger> hbList = new List<Hambuger>();
            List<Extra> exList = new List<Extra>();
            if (nudQuantity.Value >= 1)
            {
                foreach (Hambuger h in Hambuger.hambugerList)
                {
                    if (rbLarge.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Large;
                            h.Price += 5;
                            obj = h;
                            break;
                        }
                    }
                    else if (rbMiddle.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Middle;
                            h.Price += 3;
                            obj = h;
                            break;
                        }
                    }
                    else if (rbSmall.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Small;
                            h.Price += 0;
                            obj = h;
                            break;
                        }
                    }
                }
                foreach (CheckBox chk in flpExtra.Controls)
                {
                    if (chk.Checked == true)
                    {
                        foreach (Extra ex in Extra.extraList)
                        {
                            if (chk.Text == ex.ExtraName)
                            {
                                Hambuger h = (Hambuger)obj;
                                h.Price += ex.Price;
                                exList.Add(ex);
                                extras += ex.ExtraName + " ";
                                obj = h;
                                break;
                            }
                        }
                        chk.Checked = false;
                    }
                }
                Hambuger hamburger = (Hambuger)obj;
                hamburger.Price = nudQuantity.Value * hamburger.Price;
                hbList.Add(hamburger);
                menuPrice += hamburger.Price;
                lblListAmount.Text = menuPrice.ToString("C2");
                string format = $"{hamburger.HambugerName} {hamburger.Dimension} ({extras}) Quantity=>{nudQuantity.Value} Price =>{hamburger.Price.ToString("C2")} ";
                listBox1.Items.Add(format);
                extras = String.Empty;
                hamburger.Price = hbPrice;
            }
            else
            {
                MessageBox.Show("Please enter quantity!");
            }
        }

        private void HamburgerForm_Load(object sender, EventArgs e)
        {
            if (user.Role == Roles.Admin)
            {
                btnAdmin.Visible = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }
    }
}
