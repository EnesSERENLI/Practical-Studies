﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_AbstructProduct.FakeDatabase;

namespace WFA_AbstructProduct
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        Supplier s;
        private void btnGoCategories_Click(object sender, EventArgs e)
        {
            CategoryForm cForm = new CategoryForm();
            cForm.Show();
            this.Hide();
        }

        private void btnGoProducts_Click(object sender, EventArgs e)
        {
            ProductForm pForm = new ProductForm();
            pForm.Show();
            this.Hide();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            s = new Supplier(txtCompanyName.Text,txtPhoneNumber.Text,txtAddress.Text);
            lstSuppliers.Items.Add(s.Add(s));            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Update(txtCompanyName.Text, txtUpdate.Text);
        }
    }
}