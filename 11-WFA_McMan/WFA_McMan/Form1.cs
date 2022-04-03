using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables..
        int menuPrice = 0;
        string menu;
        string size;
        string extras;
        int orderAmount = 0;
        int orders = 0;
        int totalAmount = 0;
        int orderQuantity = 0;
        int i = 0;
        int a = 0;
        //Arrays..

        ListViewItem[] lvis = new ListViewItem[1000];
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("Whooper - 25 TL");
            cmbMenu.Items.Add("SteakHouse - 35 TL");
            cmbMenu.Items.Add("Chicken Burger - 20 TL");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            while (i < 1000)
            {
                ListViewItem lvi = new ListViewItem();
                if (nudQuantity.Value > 0)
                {
                    switch (cmbMenu.Text)
                    {
                        case "Whooper - 25 TL":
                            menuPrice += 25;
                            cmbMenu.SelectedIndex = -1;
                            menu = "Whooper";
                            lvi.Text = menu;
                            break;
                        case "SteakHouse - 35 TL":
                            menuPrice += 35;
                            cmbMenu.SelectedIndex = -1;
                            menu = "SteakHouse";
                            lvi.Text = menu;
                            break;
                        case "Chicken Burger - 20 TL":
                            menuPrice += 20;
                            cmbMenu.SelectedIndex = -1;
                            menu = "Chicken Burger";
                            lvi.Text = menu;
                            break;
                        default:
                            MessageBox.Show("You didn't make a menu selection.!");
                            break;                            
                    }
                    if (rbLarge.Checked)
                    {
                        menuPrice += 5;
                        rbLarge.Checked = false;
                        size = " Large";
                        lvi.SubItems.Add(size);
                    }
                    else if (rbMiddle.Checked)
                    {
                        menuPrice += 3;
                        rbMiddle.Checked = false;
                        size = " Middle";
                        lvi.SubItems.Add(size);
                    }
                    else if (rbSmall.Checked)
                    {
                        menuPrice += 0;
                        rbSmall.Checked = false;
                        size = " Small";
                        lvi.SubItems.Add(size);
                    }
                    else
                    {
                        MessageBox.Show("Please choose a size!");
                        break;
                    }
                    foreach (Control ctrl in groupBox1.Controls)
                    {
                        if (ctrl is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ctrl;
                            if (chk.Checked)
                            {
                                menuPrice += 2;
                                chk.Checked = false;
                                extras += chk.Text + " ";
                            }
                            else
                            {
                                extras += "";
                            }
                        }
                    }
                    try
                    {
                        menuPrice = Convert.ToInt32(nudQuantity.Value) * menuPrice;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter integer number.!");
                    }
                    string format = string.Format("{0} {1} ({2}) {3} Adet {4} TL", menu, size, extras, nudQuantity.Value, menuPrice);

                    listBox1.Items.Add(format);
                    lvi.SubItems.Add(extras);
                    lvi.SubItems.Add(nudQuantity.Value.ToString());
                    lvi.SubItems.Add(menuPrice.ToString("C2"));
                    nudQuantity.Value = 0;
                    extras = "";
                    orderAmount += menuPrice;
                    lblListAmount.Text = orderAmount.ToString("C2");
                    menuPrice = 0;
                }
                else
                {
                    break;
                }
                lvis[i] = lvi;
                orderQuantity++;
                i++;
                break;
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Your order quantity: " + orderQuantity + "\n" + "Total amount you have to pay: " + lblListAmount.Text, "Order Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    orders += listBox1.Items.Count;
                    do
                    {
                        listView1.Items.Add(lvis[a]);
                        a++;
                    }
                    while (a < orders);

                    listBox1.Items.Clear();
                    totalAmount += orderAmount;
                    orderAmount = 0;
                    lblLstViewAmount.Text = totalAmount.ToString("C2");
                    lblListAmount.Text = "0";
                    orderQuantity = 0;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("You haven't ordered yet.!");
            }
        }
    }
}
