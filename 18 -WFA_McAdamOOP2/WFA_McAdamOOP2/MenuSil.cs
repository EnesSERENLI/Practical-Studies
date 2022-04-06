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
    public partial class MenuSil : Form
    {
        public MenuSil()
        {
            InitializeComponent();
        }

        private void btnDeleteHamburger_Click(object sender, EventArgs e)
        {
            Hambuger hambuger = new Hambuger();
            hambuger.HambugerName = txtDeleteHamburger.Text;
            hambuger.Delete(hambuger);
        }
    }
}
