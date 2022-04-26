using BussinessLogicLayer.Service;
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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        //BLL Instance
        MovieService movieService = new MovieService(); 

        private void btnSerialMovies_Click(object sender, EventArgs e)
        {
            //Seri filmler
            movieService.SerialMovies(listView1);
            lblTotalMovie.Text =listView1.Items.Count.ToString();
            
        }

        private void btnAllMovies_Click(object sender, EventArgs e)
        {
            //Bitin filmler
            movieService.MovieList(listView1);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void rbDurationAcs_CheckedChanged(object sender, EventArgs e)
        {
            //Artan sıralama
            movieService.MovieSorting(true, listView1);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void rbDurationDesc_CheckedChanged(object sender, EventArgs e)
        {
            //Azalan Sıralama
            movieService.MovieSorting(false, listView1);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void btnMyTopFive_Click(object sender, EventArgs e)
        {
            //Top 5 movie
            movieService.FiveMovie(listView1);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void btnWatchBeforeDie_Click(object sender, EventArgs e)
        {
            movieService.WatchBeforeDie(listView1);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            movieService.ListWithCategory(cmbSelectCategory);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
            lblTotalCategory.Text = cmbSelectCategory.Items.Count.ToString();
        }

        private void cmbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cmbSelectCategory.SelectedValue);
            movieService.MovieList(listView1, categoryId);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            movieService.SearchMovie(listView1,txtSearch.Text);
            lblTotalMovie.Text = listView1.Items.Count.ToString();
        }
    }
}
