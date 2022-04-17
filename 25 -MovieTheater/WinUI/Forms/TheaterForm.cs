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
    public partial class TheaterForm : Form
    {
        public TheaterForm()
        {
            InitializeComponent();
        }
        TheatherService theatherService = new TheatherService();
        private void btnListMovie_Click(object sender, EventArgs e)
        {
            theatherService.TheatherList(listView1);
        }

        private void btnAddTheather_Click(object sender, EventArgs e)
        {
            try
            {
                string result = theatherService.AddTheather(int.Parse(txtAddMovieId.Text), int.Parse(txtAddSaloonId.Text), int.Parse(txtAddSessionId.Text), int.Parse(txtAddWeekId.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTheather_Click(object sender, EventArgs e)
        {
            try
            {
                string result = theatherService.DeleteTheater(int.Parse(txtDeleteTheather.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID number cannot be blank and must be an integer.");
            }
        }

        private void btnUpdateTheather_Click(object sender, EventArgs e)
        {
            try
            {
                string result = theatherService.UpdateTheather(int.Parse(txtUpdateTheatherId.Text), int.Parse(txtUpdateMovieId.Text), int.Parse(txtUpdateSaloonId.Text), int.Parse(txtUpdateSessionId.Text), int.Parse(txtUpdateWeekId.Text));
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("IDs must be integers");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            theatherService.TheatherDetail(listView1,flowLayoutPanel1);
        }
    }
}
