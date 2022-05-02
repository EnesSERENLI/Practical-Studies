using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BonusOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Uygulama açıldığında kategorilerin gelmesi
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Add("Kitap");
            cmbKategori.Items.Add("Bilgisayar");
            cmbKategori.Items.Add("Oyun");
            cmbKategori.Items.Add("Riot Games");
            cmbKategori.Items.Add("Kıyafet");

        }
        //Kullanıcının seçtiği kategoriye göre alabileceği ürünler hakkında bilgilendirme. Bu ürünlerden birini girmezse listeye ekleme yapamayacak.
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbKategori.Text)
            {
                case "Kitap":
                    MessageBox.Show("Roman, Şiir, Öykü, Anı ve Biyografi ürünlerinden birini alabilirsiniz.", "Kitap Kategori ürünleri", MessageBoxButtons.OK);
                    break;
                case "Bilgisayar":
                    MessageBox.Show("Monster, Msi, Asus, Toshiba ve Apple ürünlerinden birini alabilirsiniz.", "Bilgisayar Kategori ürünleri", MessageBoxButtons.OK);
                    break;
                case "Oyun":
                    MessageBox.Show("God of War IV, Mosnter Hunter World, Elden Ring, The Last of Us Part II ve Detroit Become Human ürünlerinden birini alabilirsiniz.", "Oyun Kategori ürünleri", MessageBoxButtons.OK);
                    break;
                case "Riot Games":
                    MessageBox.Show("400 RP, 805 RP, 1050 RP, 3620 RP ve 6450 RP ürünlerinden birini alabilirsiniz.", "Riot Games Kategori ürünleri", MessageBoxButtons.OK);
                    break;
                case "Kıyafet":
                    MessageBox.Show("Gömlek, Kazak, T-Shirt, Hırka ve Mont ürünlerinden birini alabilirsiniz.", "Kıyafet Kategori ürünleri", MessageBoxButtons.OK);
                    break;
            }
        }
        //Kategori ve ürünü belirleyince fiyatın belirlenmesi ve daha sonra değişmemesi için fiyatın kapanması
        private void txtUrun_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKategori.Text)
            {
                case "Kitap":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "roman":
                            nudFiyat.Value = 20;
                            nudFiyat.Enabled = false;
                            break;
                        case "şiir":
                            nudFiyat.Value = 6.5m;
                            nudFiyat.Enabled = false;
                            break;
                        case "öykü":
                            nudFiyat.Value = 8;
                            nudFiyat.Enabled = false;
                            break;
                        case "anı":
                            nudFiyat.Value = 5;
                            nudFiyat.Enabled = false;
                            break;
                        case "biyografi":
                            nudFiyat.Value = 13;
                            nudFiyat.Enabled = false;
                            break;
                    }
                    break;
                case "Bilgisayar":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "monster":
                            nudFiyat.Value = 17800m;
                            nudFiyat.Enabled = false;
                            break;
                        case "msi":
                            nudFiyat.Value = 16000m;
                            nudFiyat.Enabled = false;
                            break;
                        case "asus":
                            nudFiyat.Value = 13500m;
                            nudFiyat.Enabled = false;
                            break;
                        case "toshiba":
                            nudFiyat.Value = 16000m;
                            nudFiyat.Enabled = false;
                            break;
                        case "apple":
                            nudFiyat.Value = 21500m;
                            nudFiyat.Enabled = false;
                            break;
                    }
                    break;
                case "Oyun":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "god of war ıv":
                            nudFiyat.Value = 179;
                            nudFiyat.Enabled = false;
                            break;
                        case "monster hunter world":
                            nudFiyat.Value = 179;
                            nudFiyat.Enabled = false;
                            break;
                        case "elden ring":
                            nudFiyat.Value = 599;
                            nudFiyat.Enabled = false;
                            break;
                        case "the last of us ıı":
                            nudFiyat.Value = 263.4m;
                            nudFiyat.Enabled = false;
                            break;
                        case "detroit become human":
                            nudFiyat.Value = 129.5m;
                            nudFiyat.Enabled = false;
                            break;
                    }
                    break;
                case "Riot Games":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "400 rp":
                            nudFiyat.Value = 22.5m;
                            nudFiyat.Enabled = false;
                            break;
                        case "805 rp":
                            nudFiyat.Value = 42.5m;
                            nudFiyat.Enabled = false;
                            break;
                        case "1050 rp":
                            nudFiyat.Value = 58;
                            nudFiyat.Enabled = false;
                            break;
                        case "3620 rp":
                            nudFiyat.Value = 190;
                            nudFiyat.Enabled = false;
                            break;
                        case "6450 rp":
                            nudFiyat.Value = 333;
                            nudFiyat.Enabled = false;
                            break;
                    }
                    break;
                case "Kıyafet":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "gömlek":
                            nudFiyat.Value = 120;
                            nudFiyat.Enabled = false;
                            break;
                        case "kazak":
                            nudFiyat.Value = 150;
                            nudFiyat.Enabled = false;
                            break;
                        case "t-shirt":
                            nudFiyat.Value = 35;
                            nudFiyat.Enabled = false;
                            break;
                        case "hırka":
                            nudFiyat.Value = 90;
                            nudFiyat.Enabled = false;
                            break;
                        case "mont":
                            nudFiyat.Value = 350;
                            nudFiyat.Enabled = false;
                            break;
                    }
                    break;
            }
        }
        //Renk seçimi yapması ve ardından kaydet butonuna bastığında ürünlerin ListView'e eklenmesi ve kutuların temizlenmesi.
        string beyaz;
        string kirmizi;
        string mavi;
        string titanBeyazi;
        string yavruAgzi;
        string siyah;
        string sari;
        string yesil;
        string toricelliMavisi;
        string fusya;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (chkBeyaz.Checked)
            {
                beyaz = "Beyaz";
            }
            else
            {
                beyaz = "";
            }
            if (chkKirmizi.Checked)
            {
                kirmizi = "Kırmızı";
            }
            else
            {
                kirmizi = "";
            }
            if (chkMavi.Checked)
            {
                mavi = "Mavi";
            }
            else
            {
                mavi = "";
            }
            if (chkTitanBeyazi.Checked)
            {
                titanBeyazi = "Titan Beyazı";
            }
            else
            {
                titanBeyazi = "";
            }
            if (chkYavruAgzi.Checked)
            {
                yavruAgzi = "Yavru Ağzı";
            }
            else
            {
                yavruAgzi = "";
            }
            if (chkSiyah.Checked)
            {
                siyah = "Siyah";
            }
            else
            {
                siyah = "";
            }
            if (chkSari.Checked)
            {
                sari = "Sarı";
            }
            else
            {
                sari = "";
            }
            if (chkYeşil.Checked)
            {
                yesil = "Yeşil";
            }
            else
            {
                yesil = "";
            }
            if (chkToricelliMavisi.Checked)
            {
                toricelliMavisi = "Toriçelli Mavisi";
            }
            else
            {
                toricelliMavisi = "";
            }
            if (chkFusya.Checked)
            {
                fusya = "Fuşya";
            }
            else
            {
                fusya = "";
            }
            switch (cmbKategori.Text)
            {
                case "Kitap":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "roman":
                        case "şiir":
                        case "öykü":
                        case "anı":
                        case "biyografi":
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = txtUrun.Text.ToUpper();
                            lvi.SubItems.Add(cmbKategori.Text);
                            lvi.SubItems.Add(nudFiyat.Text);
                            lvi.SubItems.Add(beyaz + "" + kirmizi + "" + mavi + "" + titanBeyazi + "" + yavruAgzi + "" + siyah + "" + sari + "" + yesil + "" + toricelliMavisi + "" + fusya);
                            listView1.Items.Add(lvi);
                            txtUrun.Text = "";
                            cmbKategori.Text = "";
                            nudFiyat.Value = 0;
                            chkBeyaz.Checked = false;
                            chkFusya.Checked = false;
                            chkKirmizi.Checked = false;
                            chkMavi.Checked = false;
                            chkSari.Checked = false;
                            chkSiyah.Checked = false;
                            chkTitanBeyazi.Checked = false;
                            chkToricelliMavisi.Checked = false;
                            chkYavruAgzi.Checked = false;
                            chkYeşil.Checked = false;
                            nudFiyat.Enabled = true;
                            break;
                        default:
                            MessageBox.Show("Seçtiğiniz kategoride böyle bir ürün yoktur.!", "Yanlış ürün seçimi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
                case "Bilgisayar":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "monster":
                        case "msi":
                        case "asus":
                        case "toshiba":
                        case "apple":
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = txtUrun.Text.ToUpper();
                            lvi.SubItems.Add(cmbKategori.Text);
                            lvi.SubItems.Add(nudFiyat.Text);
                            lvi.SubItems.Add(beyaz + "" + kirmizi + "" + mavi + "" + titanBeyazi + "" + yavruAgzi + "" + siyah + "" + sari + "" + yesil + "" + toricelliMavisi + "" + fusya);
                            listView1.Items.Add(lvi);
                            txtUrun.Text = "";
                            cmbKategori.Text = "";
                            nudFiyat.Value = 0;
                            chkBeyaz.Checked = false;
                            chkFusya.Checked = false;
                            chkKirmizi.Checked = false;
                            chkMavi.Checked = false;
                            chkSari.Checked = false;
                            chkSiyah.Checked = false;
                            chkTitanBeyazi.Checked = false;
                            chkToricelliMavisi.Checked = false;
                            chkYavruAgzi.Checked = false;
                            chkYeşil.Checked = false;
                            nudFiyat.Enabled = true;
                            break;
                        default:
                            MessageBox.Show("Seçtiğiniz kategoride böyle bir ürün yoktur.!", "Yanlış ürün seçimi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
                case "Oyun":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "god of war ıv":
                        case "monster hunter world":
                        case "elden ring":
                        case "the last of us ıı":
                        case "detroit become human":
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = txtUrun.Text.ToUpper();
                            lvi.SubItems.Add(cmbKategori.Text);
                            lvi.SubItems.Add(nudFiyat.Text);
                            lvi.SubItems.Add(beyaz + "" + kirmizi + "" + mavi + "" + titanBeyazi + "" + yavruAgzi + "" + siyah + "" + sari + "" + yesil + "" + toricelliMavisi + "" + fusya);
                            listView1.Items.Add(lvi);
                            txtUrun.Text = "";
                            cmbKategori.Text = "";
                            nudFiyat.Value = 0;
                            chkBeyaz.Checked = false;
                            chkFusya.Checked = false;
                            chkKirmizi.Checked = false;
                            chkMavi.Checked = false;
                            chkSari.Checked = false;
                            chkSiyah.Checked = false;
                            chkTitanBeyazi.Checked = false;
                            chkToricelliMavisi.Checked = false;
                            chkYavruAgzi.Checked = false;
                            chkYeşil.Checked = false;
                            nudFiyat.Enabled = true;
                            break;
                        default:
                            MessageBox.Show("Seçtiğiniz kategoride böyle bir ürün yoktur.!", "Yanlış ürün seçimi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
                case "Riot Games":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "400 rp":
                        case "805 rp":
                        case "1050 rp":
                        case "3620 rp":
                        case "6450 rp":
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = txtUrun.Text.ToUpper();
                            lvi.SubItems.Add(cmbKategori.Text);
                            lvi.SubItems.Add(nudFiyat.Text);
                            lvi.SubItems.Add(beyaz + "" + kirmizi + "" + mavi + "" + titanBeyazi + "" + yavruAgzi + "" + siyah + "" + sari + "" + yesil + "" + toricelliMavisi + "" + fusya);
                            listView1.Items.Add(lvi);
                            txtUrun.Text = "";
                            cmbKategori.Text = "";
                            nudFiyat.Value = 0;
                            chkBeyaz.Checked = false;
                            chkFusya.Checked = false;
                            chkKirmizi.Checked = false;
                            chkMavi.Checked = false;
                            chkSari.Checked = false;
                            chkSiyah.Checked = false;
                            chkTitanBeyazi.Checked = false;
                            chkToricelliMavisi.Checked = false;
                            chkYavruAgzi.Checked = false;
                            chkYeşil.Checked = false;
                            nudFiyat.Enabled = true;
                            break;
                        default:
                            MessageBox.Show("Seçtiğiniz kategoride böyle bir ürün yoktur.!", "Yanlış ürün seçimi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
                case "Kıyafet":
                    switch (txtUrun.Text.ToLower())
                    {
                        case "gömlek":
                        case "kazak":
                        case "t-shirt":
                        case "hırka":
                        case "mont":
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = txtUrun.Text.ToUpper();
                            lvi.SubItems.Add(cmbKategori.Text);
                            lvi.SubItems.Add(nudFiyat.Text);
                            lvi.SubItems.Add(beyaz + "" + kirmizi + "" + mavi + "" + titanBeyazi + "" + yavruAgzi + "" + siyah + "" + sari + "" + yesil + "" + toricelliMavisi + "" + fusya);
                            listView1.Items.Add(lvi);
                            txtUrun.Text = "";
                            cmbKategori.Text = "";
                            nudFiyat.Value = 0;
                            chkBeyaz.Checked = false;
                            chkFusya.Checked = false;
                            chkKirmizi.Checked = false;
                            chkMavi.Checked = false;
                            chkSari.Checked = false;
                            chkSiyah.Checked = false;
                            chkTitanBeyazi.Checked = false;
                            chkToricelliMavisi.Checked = false;
                            chkYavruAgzi.Checked = false;
                            chkYeşil.Checked = false;
                            nudFiyat.Enabled = true;
                            break;
                        default:
                            MessageBox.Show("Seçtiğiniz kategoride böyle bir ürün yoktur.!", "Yanlış ürün seçimi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
            }
        }
        //ListView'deki seçili item'a doubleclick yapıldığında bilgilerin groupbox3'e aktarılması.
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            lblSeciliUrunAd.Text = listView1.SelectedItems[0].Text;
            lblSeciliKategori.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lblSeciliFiyat.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lblRenk.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}

