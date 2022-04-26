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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        void GetEmployeeList()
        {
            listView1.Items.Clear();
            foreach (Employee e in db.Employees)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = e.EmployeeID.ToString();
                lvi.SubItems.Add(e.FirstName);
                lvi.SubItems.Add(e.LastName);
                lvi.Tag = e;
                listView1.Items.Add(lvi);
            }
        }
        void AddEmployee(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            GetEmployeeList();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            AddEmployee(employee);
        }
    }
}
