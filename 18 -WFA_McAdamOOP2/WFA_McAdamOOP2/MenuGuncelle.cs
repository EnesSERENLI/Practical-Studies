using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdamOOP2
{
    public partial class MenuGuncelle : Form
    {
        public MenuGuncelle()
        {
            InitializeComponent();
        }

        private void btnUpdateHamburger_Click(object sender, EventArgs e)
        {
            Hambuger hambuger = new Hambuger();
            hambuger.HambugerName = txtUpdateOldHamburger.Text;
            hambuger.Update(hambuger, txtUpdateNewHamburger.Text, nudUpdateHamburger.Value);
        }
    }
}
