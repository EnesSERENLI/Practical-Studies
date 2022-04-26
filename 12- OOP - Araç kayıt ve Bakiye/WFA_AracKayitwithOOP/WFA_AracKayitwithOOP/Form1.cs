using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKayitwithOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Instance
        Araba araba = new Araba();
        //Arrays
        string[] arabaMarka = { "Alfa Romeo", "Renault", "Ferrari", "Porsche", "Tesla" };
        string[] yakit = { "Dizel", "Benzin", "Elektrik" };
        string[] vites = { "Otomatik", "Manuel" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arabaMarka.Length; i++)
            {
                araba.Marka = arabaMarka[i];
                cmbMarka.Items.Add(araba.Marka);
            }
            for (int i = 0; i < yakit.Length; i++)
            {
                araba.yakitTipi = yakit[i];
                cmbYakit.Items.Add(araba.yakitTipi);
            }
            for (int i = 0; i < vites.Length; i++)
            {
                araba.vitesTipi = vites[i];
                cmbVites.Items.Add(araba.vitesTipi);
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {          
            switch (cmbMarka.Text)
            {
                case "Alfa Romeo":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Gulietta");
                    cmbModel.Items.Add("159");
                    break;
                case "Renault":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Symbol");
                    break;
                case "Ferrari":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("143 California");
                    cmbModel.Items.Add("Cayane");
                    break;
                case "Porsche":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Carrera");
                    break;
                case "Tesla":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Model s");
                    break;
            }            
        }
        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
                araba.renk = colorDialog1.Color.ToArgb();
            }
            else
            {
                MessageBox.Show("Renk seçimi yapılmadı!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            araba.Marka = cmbMarka.Text;
            araba.model = cmbModel.Text;
            araba.yakitTipi =cmbYakit.Text;
            araba.vitesTipi = cmbVites.Text;
            araba.Yil = dateTimePicker1.Value.Year;
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = araba.Marka;
            lvi.SubItems.Add(araba.model);
            lvi.SubItems.Add(araba.yakitTipi);
            lvi.SubItems.Add(araba.vitesTipi);
            lvi.SubItems.Add("");
            lvi.SubItems[4].BackColor = Color.FromArgb(araba.renk);
            lvi.SubItems.Add(araba.Yil.ToString());
            listView1.Items.Add(lvi);
            lblAdet.Text = listView1.Items.Count.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                }
            }
            lblAdet.Text = listView1.Items.Count.ToString();
        }
    }
}