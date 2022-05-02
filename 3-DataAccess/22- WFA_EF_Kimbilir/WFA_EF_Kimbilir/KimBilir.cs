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
    public partial class KimBilir : Form
    {
        public KimBilir()
        {
            InitializeComponent();            
        }
        void Settings()
        {
            foreach (Person p in db.Persons)
            {
                string format = $"{p.Firstname} {p.Lastname}";
                listBox1.Items.Add(p);
            }
        }
        KimBilirDBEntities db = new KimBilirDBEntities();
        private void btnSec_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            Random rnd = new Random();
            int rastgeleKisi = rnd.Next(0,listBox1.Items.Count);
            if (listBox1.Items.Count > 0)
            {
                Person secilenKisi = (Person)listBox1.Items[rastgeleKisi];
                foreach (Person kisi in db.Persons)
                {
                    if (kisi.Firstname == secilenKisi.Firstname)
                    {
                        DialogResult dr = MessageBox.Show(kisi.Firstname + " " + kisi.Lastname + "\n" + "Soruyu bildi mi ?", "Puanlamaca", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            lvi.Text = kisi.Firstname;
                            lvi.SubItems.Add(kisi.Lastname);
                            kisi.Score += 5;                            
                            lvi.SubItems.Add(kisi.Score.ToString());
                            listView1.Items.Add(lvi);
                            listBox1.Items.RemoveAt(rastgeleKisi);
                            break;
                        }
                        else
                        {
                            lvi.Text = kisi.Firstname;
                            lvi.SubItems.Add(kisi.Lastname);
                            lvi.SubItems.Add(kisi.Score.ToString());
                            listView1.Items.Add(lvi);
                            listBox1.Items.RemoveAt(rastgeleKisi);
                            break;
                        }
                    }
                }
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Seçilecek kimse kalmadı!");
            }
        }

        private void KimBilir_Load(object sender, EventArgs e)
        {
            Settings();
        }
    }
}
