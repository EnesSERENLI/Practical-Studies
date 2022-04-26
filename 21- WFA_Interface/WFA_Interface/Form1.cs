using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Interface (Arayüz/ Sözleşme / Yetenek) 
            /*
             
             */

            Audi audi = new Audi();
            audi.Model = "A5";
            audi.KapiSayisi = 5;
        

            Tesla tesla = new Tesla();
            tesla.Model = "Model s";
            tesla.KapiSayisi = 5;
            tesla.OtoPilot();

            
        
        }
    }
}
