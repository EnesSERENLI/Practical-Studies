using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdamOOP2
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
            McMenu.Settings(cmbMenu,flpExtra);
        }
        //Variables
        decimal menuPrice = 0;
        object obj;
        string extras = string.Empty;
        decimal exGelir = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal hbPrice = 0;
            List<Hambuger> hbList = new List<Hambuger>();
            List<Extra> exList = new List<Extra>();
            if (nudAdet.Value >= 1)
            {
                foreach (Hambuger h in Hambuger.hambugerList)
                {
                    if (rbBuyuk.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Büyük;
                            h.Price += 5;
                            obj = h;
                            break;
                        }
                    }
                    else if (rbOrta.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Orta;
                            h.Price += 3;
                            obj = h;
                            break;
                        }
                    }
                    else if (rbKucuk.Checked == true)
                    {
                        if (cmbMenu.SelectedItem.ToString() == h.HambugerName)
                        {
                            hbPrice = h.Price;
                            h.Dimension = Dimensions.Küçük;
                            h.Price += 0;
                            obj = h;
                            break;
                        }
                    }
                }
                foreach (CheckBox chk in flpExtra.Controls)
                {
                    if (chk.Checked == true)
                    {
                        foreach (Extra ex in Extra.extraList)
                        {
                            if (chk.Text == ex.ExtraName)
                            {
                                Hambuger h = (Hambuger)obj;
                                h.Price += ex.Price;
                                exGelir +=ex.Price;
                                exList.Add(ex);
                                extras += ex.ExtraName + " ";
                                obj = h;
                                break;
                            }
                        }
                        chk.Checked = false;
                    }
                }
                Hambuger hamburger = (Hambuger)obj;
                hamburger.Price = nudAdet.Value * hamburger.Price;
                menuPrice += hamburger.Price;
                lblToplamTutar.Text = menuPrice.ToString("C2");                
                hbList.Add(hamburger);                             
                string format = $"{hamburger.HambugerName} {hamburger.Dimension} ({extras}) Adet=>{nudAdet.Value} Fiyat =>{hamburger.Price.ToString("C2")} ";
                Database.Database.siparislerListesi.Add(format);
                listBox1.Items.Add(format);
                Database.Database.ciroListesi.Add(hamburger.Price);
                exGelir *= nudAdet.Value;
                Database.Database.extraGelirListesi.Add(exGelir);
                Database.Database.SatilanUrunAdetListesi.Add(nudAdet.Value);                 
                extras = String.Empty;
                hamburger.Price = hbPrice;
            }
            else
            {
                MessageBox.Show("Sipariş adedi giriniz!");
            }
        }
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Siparişi tamamlamak istiyor musunuz?"+" Sipariş adedi: "+listBox1.Items.Count+" Sipariş Fiyatı: "+menuPrice.ToString("C2"),"Sipariş",MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Database.Database.toplamSiparisListesi.Add(listBox1.Items.Count);
                cmbMenu.SelectedIndex = 0;
                nudAdet.Value = 0;
                menuPrice = 0;
                rbKucuk.Checked = true;
                lblToplamTutar.Text = menuPrice.ToString();
                listBox1.Items.Clear();
            }            
        }
    }
}
