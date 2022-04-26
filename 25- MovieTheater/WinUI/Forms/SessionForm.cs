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
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
        }
        SessionService sessionService = new SessionService();
        private void btnListSession_Click(object sender, EventArgs e)
        {
            sessionService.SessionList(listView1);
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            string result = sessionService.AddSession(txtAddSessionDuration.Text);
            MessageBox.Show(result);
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            try
            {
               string result = sessionService.DeleteSession(int.Parse(txtDeleteSessionID.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SessionID must be an integer!");
            }
        }

        private void btnUpdateSession_Click(object sender, EventArgs e)
        {
            try
            {
               string result = sessionService.UpdateSessions(int.Parse(txtUpdateSessionID.Text),txtUpdateDuration.Text);
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
