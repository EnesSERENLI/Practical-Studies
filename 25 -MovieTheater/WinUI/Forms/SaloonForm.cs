using BussinessLogicLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Forms
{
    public partial class SaloonForm : Form
    {
        public SaloonForm()
        {
            InitializeComponent();
        }
        SaloonService saloonService = new SaloonService();
        private void btnListSession_Click(object sender, EventArgs e)
        {
            saloonService.SaloonList(listView1);
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            try
            {
                string result = saloonService.AddSaloon(txtAddSaloonName.Text,short.Parse(txtAddCapacity.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Capacity must be an short value");
            }
        }

        private void btnDeleteSaloon_Click(object sender, EventArgs e)
        {
            try
            {
                string result = saloonService.DeleteSaloon(int.Parse(txtDeleteSaloon.Text));
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("SaloonID cannot be blank and must be an integer.");
            }
        }

        private void btnUpdateSaloon_Click(object sender, EventArgs e)
        {
            if (txtUpdateSaloonID.Text==String.Empty)
            {
                MessageBox.Show("SaloonID cannot be blank!");
            }
            else
            {
                try
                {
                    string result = saloonService.UpdateSaloon(int.Parse(txtUpdateSaloonID.Text), txtUpdateSaloonName.Text, short.Parse(txtUpdateCapacity.Text));
                    MessageBox.Show(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SaloonID and Capacity must be an integer");
                }
            }
           
        }
    }
}
