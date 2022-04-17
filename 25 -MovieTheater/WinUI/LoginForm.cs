using System;
using System.Windows.Forms;
using WinUI.Forms;

namespace WinUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void Settings(Form childForm)
        {
            bool durum = false;
            this.Width = childForm.Width+5;
            this.Height = childForm.Height+30;
            foreach (Form _child in MdiChildren)
            {
                if (_child.Text == childForm.Text)
                {
                    durum = true;
                    _child.Activate();
                }
                else
                {
                    _child.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.StartPosition = FormStartPosition.Manual;
                childForm.Show();
            }
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new MovieForm());
        }

        private void movieDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new MovieDirectionForm());
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new CategoryForm());
        }

        private void moviesCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new MoviesCategoriesForm());
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new SessionForm());
        }

        private void weeksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new WeekForm());
        }

        private void saloonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new SaloonForm());
        }

        private void theathersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new TheaterForm());
        }
    }
}
