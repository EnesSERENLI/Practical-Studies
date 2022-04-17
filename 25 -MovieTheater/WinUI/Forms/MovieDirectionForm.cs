using BussinessLogicLayer.Service;
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
    public partial class MovieDirectionForm : Form
    {
        public MovieDirectionForm()
        {
            InitializeComponent();
        }
        MovieService movieService = new MovieService();
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string result = movieService.AddMovie(txtAddMovie.Text, txtAddDesciription.Text, int.Parse(txtAddDuration.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duration must be an integer!");
            }
        }

        private void btnListMovie_Click(object sender, EventArgs e)
        {
            movieService.MovieList(listView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            movieService.SearchMovie(listView1, txtSearch.Text);
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string result = movieService.DeleteMovie(int.Parse(txtDeleteMovieID.Text));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MovieID cannot be blank and must be an integer.!");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (txtUpdateMovieID.Text==String.Empty)
            {
                MessageBox.Show("MovieID cannot be blank.!");
            }
            else
            {
                if (txtUpdateMovieName.Text == String.Empty)
                {
                    MessageBox.Show("MovieName cannot be blank.!");
                }
                else
                {
                    if (txtUpdateDescription.Text == String.Empty && txtUpdateDuration.Text == String.Empty)
                    {
                        try
                        {
                            string result = movieService.UpdateMovie(int.Parse(txtUpdateMovieID.Text), txtUpdateMovieName.Text);
                            MessageBox.Show(result);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("MovieID must be an integer.!");
                        }
                    }
                    else if (txtUpdateDescription.Text == String.Empty)
                    {
                        try
                        {
                            string result = movieService.UpdateMovie(int.Parse(txtUpdateMovieID.Text), txtUpdateMovieName.Text, int.Parse(txtUpdateDuration.Text));
                            MessageBox.Show(result);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("MovieID and Duration must be an integer.");
                        }
                    }
                    else
                    {
                        try
                        {
                            string result = movieService.UpdateMovie(int.Parse(txtUpdateMovieID.Text), txtUpdateMovieName.Text, int.Parse(txtUpdateDuration.Text), txtUpdateDescription.Text);
                            MessageBox.Show(result);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("MovieID and Duration must be an integer");
                        }
                    }
                }                
            }    
        }
    }
}
