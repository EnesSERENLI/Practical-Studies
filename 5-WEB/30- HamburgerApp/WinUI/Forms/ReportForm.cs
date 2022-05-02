using DataAccess.Context;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (db.Orders.Any()) //Hiç sipariş yoksa
            {
                var result1 = db.Orders.Sum(x => x.TotalPrice * 1.18m);

                listBox1.Items.Add($"Toplam Gelir (KDV Dahil) =>{result1.ToString("C2")}"); //KDV dahil ciro
            }
            else //En az 1 sipariş varsa
            {
                listBox1.Items.Add($"Toplam Gelir (KDV Dahil) =>{0.ToString("C2")}");
            }

            if (db.Orders.Any())
            {
                var result2 = db.Orders.Sum(x => x.TotalPrice);

                listBox2.Items.Add($"Toplam Gelir (KDV Dahil) =>{result2.ToString("C2")}"); //KDV olmadan gelir miktarı
            }
            else
            {
                listBox2.Items.Add($"Toplam Gelir (KDV Dahil) =>{0.ToString("C2")}");
            }
            
            var result3 = db.Orders.GroupBy(x => x.Hamburger.Name).Select(x => new //Hangi Hamburgerden kaç adet satıldığını gösteren sorgu
            {
                Hamburger = x.Key,
                Adet = x.Sum(y => y.Quantity)
            }).ToList();
            listBox3.DataSource = result3;

            var result4 = db.Order_Details.GroupBy(x => x.Extra.Name).Select(x => new //Hangi Extradan kaç adet satıldığını gösteren sorgu
            {
                Extra = x.Key,
                Adet = x.Sum(y => y.Quantity)
            }).ToList();
            listBox4.DataSource = result4;
        }
    }
}
