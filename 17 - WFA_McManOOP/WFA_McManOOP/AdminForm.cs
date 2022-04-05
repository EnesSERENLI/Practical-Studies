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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {      
            HamburgerForm hForm = new HamburgerForm(Roles.Admin);
            hForm.Show();
            this.Hide();
        }

        private void btnAddHamburger_Click(object sender, EventArgs e)
        {
            Hambuger hambuger = new Hambuger();
            hambuger.HambugerName = txtAddHamburger.Text;
            hambuger.Price = nudAddHamburger.Value;
            hambuger.Add(hambuger);
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            Extra ex = new Extra();
            ex.ExtraName = txtAddExtra.Text;
            ex.Price = nudAddExtra.Value;
            ex.Add(ex);
        }

        private void btnUpdateHamburger_Click(object sender, EventArgs e)
        {
            Hambuger hambuger = new Hambuger();
            hambuger.HambugerName = txtUpdateOldHamburger.Text;
            hambuger.Update(hambuger,txtUpdateNewHamburger.Text,nudUpdateHamburger.Value);
        }

        private void btnUpdateExtra_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra();
            extra.ExtraName = txtUpdateOldExtra.Text;
            extra.Update(extra, txtUpdateNewExtra.Text, nudUpdateExtra.Value);
        }

        private void btnDeleteExtra_Click(object sender, EventArgs e)
        {
            Extra ex = new Extra();
            ex.ExtraName = txtDeleteExtra.Text;
            ex.Delete(ex);
        }

        private void btnDeleteHamburger_Click(object sender, EventArgs e)
        {
            Hambuger hambuger = new Hambuger();
            hambuger.HambugerName = txtDeleteHamburger.Text;
            hambuger.Delete(hambuger);
        }
    }
}
