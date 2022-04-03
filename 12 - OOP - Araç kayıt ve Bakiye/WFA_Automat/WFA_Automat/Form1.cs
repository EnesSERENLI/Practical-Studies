using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Automat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Automat bkm = new Automat();
        string alisveris;
        private void Form1_Load(object sender, EventArgs e)
        {
            bkm.bakiye = 500;
            lblBakiye.Text = bkm.bakiye.ToString();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            bkm.ParaCek = Convert.ToInt32(nudParaCek.Value);
            if (nudParaCek.Value > bkm.bakiye)
            {              
                MessageBox.Show("Yeterli bakiyeniz yok!");
            }
            else if (nudParaCek.Value == 0)
            {
                MessageBox.Show("0'dan yüksek bir miktar giriniz!");
            }
            else
            {
                bkm.bakiye = Convert.ToInt32(lblBakiye.Text) - bkm.ParaCek;
                lblBakiye.Text = bkm.bakiye.ToString();
                string mesaj = $"Para çekme : {bkm.ParaCek} TL - Güncel bakiyeniz : {bkm.bakiye} TL";
                listBox1.Items.Add(mesaj);
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            bkm.ParaYatir = Convert.ToInt32(nudParaYatir.Value);
            if (nudParaYatir.Value >= 1)
            {
                bkm.bakiye = Convert.ToInt32(lblBakiye.Text) + bkm.ParaYatir;
                lblBakiye.Text = bkm.bakiye.ToString();
                string mesaj = $"Para yatırma : {bkm.ParaYatir} TL - Güncel bakiyeniz : {bkm.bakiye} TL";
                listBox1.Items.Add(mesaj);
            }
            else
            {
                MessageBox.Show("En az 1 TL yatırabilirsiniz!");
            }
        }

        private void btnAlisveris_Click(object sender, EventArgs e)
        {
            if (chkEkmek.Checked)
            {
                bkm.Alisveris += 4;
            }
            if (chkYumurta.Checked)
            {
                bkm.Alisveris += 20;
            }
            if (chkCay.Checked)
            {
                bkm.Alisveris += 35;
            }
            if (ChkCikolata.Checked)
            {
                bkm.Alisveris += 30;
            }
            if (chkPeynir.Checked)
            {
                bkm.Alisveris += 45;
            }
            if (bkm.Alisveris <= bkm.bakiye && bkm.Alisveris > 0)
            {
                foreach (Control ctrl in groupBox3.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ctrl;
                        if (chk.Checked)
                        {
                            alisveris += chk.Text + " ";
                        }
                    }
                }
                bkm.bakiye = bkm.bakiye - bkm.Alisveris;
                lblBakiye.Text = bkm.bakiye.ToString();
                string format = $"{alisveris} => {bkm.Alisveris} TL";
                string format2 = $"Alışveriş harcamanız : {bkm.Alisveris} TL - Güncel Bakiyeniz : {bkm.bakiye} TL";
                listBox2.Items.Add(format);
                listBox1.Items.Add(format2);
                alisveris = "";
                bkm.Alisveris = 0;
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur!");
            }
        }
    }
}
