using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_NorthwindCodeFirst.ORM.Context;
using WFA_NorthwindCodeFirst.ORM.Entity;

namespace WFA_NorthwindCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
