using BussinessLogicLayer.Service;
using DataAccess.Context;
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
    public partial class MoviesCategoriesForm : Form
    {
        public MoviesCategoriesForm()
        {
            InitializeComponent();
        }        
        MoviesCategoriesService moviesCategoriesService = new MoviesCategoriesService();
        private void btnAddMoviesCategoroies_Click(object sender, EventArgs e)
        {
            try
            {
               string result = moviesCategoriesService.AddMoviesCategories(int.Parse(txtAddMovieId.Text),int.Parse(txtAddCategoriId.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MovieId and CategoryId cannot be blank and must be an integer.!");
            }
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            moviesCategoriesService.ListMoviesCategories(listView1);
        }

        private void btnDeleteMovieCategories_Click(object sender, EventArgs e)
        {
            try
            {
                string result = moviesCategoriesService.DeleteMoviesCategories(int.Parse(txtDeleteID.Text));
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ID cannot be blank and must be an integer.!");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string result = moviesCategoriesService.UpdateMoviesCategories(int.Parse(txtUpdateID.Text), int.Parse(txtUpdateMovieId.Text), int.Parse(txtUpdateCategoryId.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID,MovieId and CategoryId cannot be blank and must be and integer value.!");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            moviesCategoriesService.ListMoviesCategories(listView1,listView2);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
