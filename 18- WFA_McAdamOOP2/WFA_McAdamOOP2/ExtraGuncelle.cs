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
    public partial class ExtraGuncelle : Form
    {
        public ExtraGuncelle()
        {
            InitializeComponent();
        }

        private void btnUpdateExtra_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra();
            extra.ExtraName = txtUpdateOldExtra.Text;
            extra.Update(extra, txtUpdateNewExtra.Text, nudUpdateExtra.Value);
        }
    }
}
