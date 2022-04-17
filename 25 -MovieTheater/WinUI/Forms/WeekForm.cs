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
    public partial class WeekForm : Form
    {
        public WeekForm()
        {
            InitializeComponent();
        }
        WeekService weekService = new WeekService();
        private void btnListWeeks_Click(object sender, EventArgs e)
        {
            weekService.WeekList(listView1);
        }

        private void btnAddWeek_Click(object sender, EventArgs e)
        {
            if (dtpAddWeekFirstDay.Value >= DateTime.Today && dtpAddWeekLastDay.Value>dtpAddWeekFirstDay.Value)
            {
                try
                {
                    string result = weekService.AddWeek(txtAddWeekName.Text, dtpAddWeekFirstDay.Value, dtpAddWeekLastDay.Value);
                    MessageBox.Show(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please check the dates!");
            }
            
        }

        private void btnDeleteWeek_Click(object sender, EventArgs e)
        {
            try
            {
                string result = weekService.DeleteWeek(int.Parse(txtDeleteWeekID.Text));
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("WeekID must be an integer.");
            }
            
        }

        private void btnUpdateWeek_Click(object sender, EventArgs e)
        {
            if (txtUpdateWeekID.Text == String.Empty)
            {
                MessageBox.Show("WeekID cannot be blank and must be an integer.");
            }
            else
            {
                if (dtpUpdateWeekFirstDay.Value >= DateTime.Today && dtpUpdateWeekLastDay.Value > dtpUpdateWeekFirstDay.Value)
                {
                    string result = weekService.UpdateWeek(int.Parse(txtUpdateWeekID.Text), txtUpdateWeekName.Text, dtpUpdateWeekFirstDay.Value, dtpUpdateWeekLastDay.Value);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Please check the dates or ID!");
                }
            }           
        }
    }
}
