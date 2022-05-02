using BLL;
using BLL.Repository;
using DataAccess.Entity;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        Factory factory = new Factory(); //Factory
        BaseRepository<Hamburger> newHamburger = new BaseRepository<Hamburger>(); //Factory
        BaseRepository<Extra> newExtra = new BaseRepository<Extra>(); //Factory
        private void btnAddHamburger_Click(object sender, EventArgs e)
        {
            try
            {
                BaseEntity entity = factory.FactoryMethod(Model.Hamburger); //Factory + Singleton
                entity.Name = txtAddHamburger.Text;
                entity.Price = nudAddHamburger.Value;
                Hamburger hamburger = (Hamburger)entity;
                string result = newHamburger.Create(hamburger);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnUpdateHamburger_Click(object sender, EventArgs e)
        {
            try
            {
                BaseEntity entity = factory.FactoryMethod(Model.Hamburger);
                entity.ID = int.Parse(txtUpdateHamburgerID.Text);
                entity.Name = txtUpdateHamburger.Text;
                entity.Price = nudUpdateHamburger.Value;
                Hamburger hamburger = (Hamburger)entity;
                string result = newHamburger.Update(hamburger);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDeleteHamburger_Click(object sender, EventArgs e)
        {
            try
            {
                string result = newHamburger.Delete(int.Parse(txtDeleteHamburger.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            try
            {
                BaseEntity entity = factory.FactoryMethod(Model.Extra);
                entity.Name = txtAddExtra.Text;
                entity.Price = nudAddExtra.Value;
                Extra extra = (Extra)entity;
                string result = newExtra.Create(extra);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdateExtra_Click(object sender, EventArgs e)
        {
            try
            {
                BaseEntity entity = factory.FactoryMethod(Model.Extra);
                entity.ID = int.Parse(txtUpdateExtraID.Text);
                entity.Name = txtUpdateExtra.Text;
                entity.Price = nudUpdateExtra.Value;
                Extra extra = (Extra)entity;
                string result = newExtra.Update(extra);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDeleteExtra_Click(object sender, EventArgs e)
        {
            try
            {
                string result = newExtra.Delete(int.Parse(txtDeleteExtra.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
