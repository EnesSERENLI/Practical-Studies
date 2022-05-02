using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Kimbilir
{
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }
        // Db Instance
        KimBilirDBEntities db = new KimBilirDBEntities();

        //Methods
        void Settings()
        {
            listView1.Items.Clear();
            foreach (Person p in db.Persons)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.Firstname);
                lvi.SubItems.Add(p.Lastname);
                lvi.SubItems.Add(p.Score.ToString());
                lvi.Tag = p;
                listView1.Items.Add(lvi);
            }
        }
        ListViewItem PersonDetail(Person peson)
        {
            ListViewItem lvi = new ListViewItem();
            foreach (Person p in db.Persons)
            {
                if(p.ID == peson.ID)
                {                    
                    lvi.Text = p.Person_Details.PersonID.ToString();
                    lvi.SubItems.Add(p.Person_Details.Age.ToString());
                    lvi.SubItems.Add(p.Person_Details.Adress);
                    lvi.SubItems.Add(p.Person_Details.GithubProfile);
                    lvi.SubItems.Add(p.Score.ToString());
                    break;
                }                           
            }
            return lvi;
        }
        //--------------------------------------------------------------------------
        private void Kisiler_Load(object sender, EventArgs e)
        {
            Settings();
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            //Database Kişi Ekleme
            if (txtAd.Text != String.Empty && txtSoyad.Text != String.Empty && txtPuan.Text != String.Empty)
            {
                Person p = new Person();
                p.Firstname = txtAd.Text;
                p.Lastname = txtSoyad.Text;
                try
                {
                    p.Score = short.Parse(txtPuan.Text);
                    db.Persons.Add(p);
                    db.SaveChanges();
                    Settings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kişi bilgilerini tam doldurunuz!");
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            //Database Kişi Silme
            if (listView1.SelectedItems.Count > 0)
            {
                if (txtAd.Text != String.Empty || txtSoyad.Text != String.Empty || txtPuan.Text != String.Empty)
                {
                    Person p = (Person)listView1.SelectedItems[0].Tag;
                    db.Persons.Remove(p);
                    db.SaveChanges();
                    Settings();
                }
            }
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            //Database Kişi Güncelleme
            if (listView1.SelectedItems.Count > 0)
            {
                if (txtAd.Text != String.Empty || txtSoyad.Text != String.Empty || txtPuan.Text != String.Empty)
                {
                    Person p = (Person)listView1.SelectedItems[0].Tag;
                    p.Firstname = txtAd.Text;
                    p.Lastname = txtSoyad.Text;
                    try
                    {
                        p.Score = short.Parse(txtPuan.Text);
                        db.SaveChanges();
                        Settings();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Kişiye çift tıklayınca kişi detayları gelmesi
            flowLayoutPanel1.Controls.Clear();
            Person person = (Person)listView1.SelectedItems[0].Tag;
            ListView listView2 = new ListView();
            listView2.Columns.Add("PersonID", 50);
            listView2.Columns.Add("Age", 50);
            listView2.Columns.Add("Adress", 200);
            listView2.Columns.Add("GithubProfile", 250);
            listView2.Columns.Add("Score", 50);
            listView2.GridLines = true;
            listView2.View = View.Details;
            listView2.Width = flowLayoutPanel1.Width-5;
            listView2.Height = flowLayoutPanel1.Height-5;
            flowLayoutPanel1.Controls.Add(listView2);
            listView2.Items.Add(PersonDetail(person));
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtPuan.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}
