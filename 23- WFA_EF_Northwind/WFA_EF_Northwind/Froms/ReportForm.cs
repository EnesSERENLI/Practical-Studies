using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Northwind.Froms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void ReportForm_Load(object sender, EventArgs e)
        {
            //Hangi kategoride kaç adet ürün var ?
            //select c.CategoryName,count(c.CategoryName) from Products p join Categories c on p.CategoryID=c.CategoryID group by CategoryName
            var result1 = db.Products.GroupBy(x => x.Category.CategoryName).Select(y => new
            {
                CName = y.Key,
                Tp = y.Count()
            }).ToList();
            listBox1.DataSource = result1;

            //Çalışanların sipariş sayıları
            //select (select FirstName from Employees e where e.EmployeeID=o.EmployeeID),count(OrderID) from orders o group by EmployeeID
            var result2 = db.Orders.GroupBy(x => x.Employee.FirstName).Select(y=> new
            {
                Ad=y.Key,Tp=y.Count()
            }).ToList();
            listBox2.DataSource = result2;

            //Hangi Ülkede kaç çalışan var ?
            //select Country,count(Country) from Employees group by Country
            var result3 = db.Employees.GroupBy(y => y.Country).Select(z => new
            {
                Country = z.Key,
                Toplam = z.Count()
            }).ToList();

            listBox3.DataSource = result3;

            

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //Çalışan ismine göre siparişlerin gelmesi
            //select * from Orders Where EmployeeID=(select EmployeeID from Employees where FirstName = 'Nancy')
            var result = db.Orders.Where(y => y.Employee.FirstName == textBox1.Text).Select(x => new
            {
                x.OrderID
            }).ToList();
            listBox5.DataSource = result;
        }

        private void btnFiyatlaGetir_Click(object sender, EventArgs e)
        {
            //Belirtilen 2 fiyat arası ürünlerin gelmesi
            //select ProductName from Products where UnitPrice>20 and UnitPrice<25
            var result = db.Products.Where(x=>x.UnitPrice>nudFiyat1.Value && x.UnitPrice<nudFiyat2.Value).Select(y => new
            {
                y.ProductName
            }).ToList();
            listBox6.DataSource = result;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Belirtilen 2 tarih arası siparişleri listeyelen kod
            //select OrderID,OrderDate from Orders where OrderDate >'1997-01-01' and OrderDate<='1998-01-01'
            var result = db.Orders.Where(x=>x.OrderDate>=dateTimePicker1.Value && x.OrderDate<=dateTimePicker2.Value).Select(y => new
            {
                y.OrderID,
                y.OrderDate
            }).ToList();
            listBox4.DataSource = result;
        }
    }
}
