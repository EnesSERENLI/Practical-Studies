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
    public partial class ExtraSil : Form
    {
        public ExtraSil()
        {
            InitializeComponent();
        }

        private void btnDeleteExtra_Click(object sender, EventArgs e)
        {
            Extra ex = new Extra();
            ex.ExtraName = txtDeleteExtra.Text;
            ex.Delete(ex);
        }
    }
}
