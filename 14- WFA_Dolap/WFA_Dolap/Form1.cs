using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Collection
        List<Giyim> giyimListesi = new List<Giyim>();

        //Variables
        decimal toplamTutar;
        decimal genelToplam;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             uygulama açıldığında;
            3 adet ayakkabı
            3 adet tshirt
            3 adet pantolon
            3 adet mont

            tanımlayarak ilgili list boxlarda özellikleri ile listeleyin. Kullanıcı listbox içerisinde tanımlı olan item'a çift tıkladıktan sonra lstSepet'e            seçili olan item özellikleri ile eklensin ve toplam tutar'a ilgili ürünün fiyatı dahil edilsin.

            alışverişi tamamla butonuna basıldıktan sonra lstSepet içerisinde bulunan itemlar listview içerisinde göserilsin ve lstSepet temizlensin.

            listboxlar içerisinde fiyatlar kdv hariç sepete eklenildiğinde kdv dahil olarak hem gösterilecek hem de hesaplanacak.
             */
            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Marka = "Skechers";
            ayakkabi1.Model = "Spor";
            ayakkabi1.Numara = 41;
            ayakkabi1.Renk = "Gri";
            ayakkabi1.Fiyat = 350;
            
            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi2.Marka = "Timberland";
            ayakkabi2.Model = "Bot";
            ayakkabi2.Numara = 43;
            ayakkabi2.Renk = "Kahve";
            ayakkabi2.Fiyat = 1150;

            Ayakkabi ayakkabi3 = new Ayakkabi();
            ayakkabi3.Marka = "Polo";
            ayakkabi3.Model = "Classic";
            ayakkabi3.Numara = 42;
            ayakkabi3.Renk = "Siyah";
            ayakkabi3.Fiyat = 400;

            Mont mont1 = new Mont();
            mont1.Marka = "Under Armour";
            mont1.Renk = "Haki";
            mont1.Beden = "S";
            mont1.Fiyat = 1600;

            Mont mont2 = new Mont();
            mont2.Marka = "Loft";
            mont2.Renk = "Lacivert";
            mont2.Beden = "M";
            mont2.Fiyat = 400;

            Mont mont3 = new Mont();
            mont3.Marka = "National Geographic";
            mont3.Renk = "Siyah";
            mont3.Beden = "L";
            mont3.Fiyat = 650;

            T_shirt ts1 = new T_shirt();
            ts1.Beden = "S";
            ts1.Renk = "Kırmızı";
            ts1.Marka = "Koton";
            ts1.Fiyat = 40;
            ts1.KumasTipi = "Dokuma";

            T_shirt ts2 = new T_shirt();
            ts2.Beden = "XL";
            ts2.Renk = "Beyaz";
            ts2.Marka = "Defacto";
            ts2.Fiyat = 20;
            ts2.KumasTipi = "Pamuklu";

            T_shirt ts3 = new T_shirt();
            ts3.Beden = "M";
            ts3.Renk = "Pembe";
            ts3.Marka = "Puma";
            ts3.Fiyat = 80;
            ts3.KumasTipi = "Organik Pamuk";

            Pantolon pt1 = new Pantolon();
            pt1.Marka = "SÜVARİ";
            pt1.PacaTipi = "Normal";
            pt1.Renk = "Kahve";
            pt1.Desen = "Kadife";
            pt1.Fiyat = 150;

            Pantolon pt2 = new Pantolon();
            pt2.Marka = "Casharal";
            pt2.PacaTipi = "Dar";
            pt2.Renk = "Siyah";
            pt2.Desen = "Çizgili";
            pt2.Fiyat = 400;

            Pantolon pt3 = new Pantolon();
            pt3.Marka = "Pierre Cardin";
            pt3.PacaTipi = "Normal";
            pt3.Renk = "Koyu Mavi";
            pt3.Desen = "Düz";
            pt3.Fiyat = 200;

            giyimListesi.Add(pt1);
            giyimListesi.Add(pt2);
            giyimListesi.Add(pt3);
            giyimListesi.Add(ts1);
            giyimListesi.Add(ts2);
            giyimListesi.Add(ts3);
            giyimListesi.Add(mont1);
            giyimListesi.Add(mont2);
            giyimListesi.Add(mont3);
            giyimListesi.Add(ayakkabi1);
            giyimListesi.Add(ayakkabi2);
            giyimListesi.Add(ayakkabi3);
            foreach (Giyim kıyafet in giyimListesi)
            {
                if (kıyafet is Ayakkabi)
                {
                    Ayakkabi ayakkabi = (Ayakkabi)kıyafet;
                    lstAyakkabi.Items.Add(ayakkabi);
                }
                else if(kıyafet is Mont)
                {
                    Mont mont = (Mont)kıyafet;
                    lstMont.Items.Add(mont);
                }
                else if (kıyafet is T_shirt)
                {
                    T_shirt t_Shirt = (T_shirt)kıyafet;
                    lstTshirt.Items.Add(t_Shirt);
                }
                else if (kıyafet is Pantolon)
                {
                    Pantolon pantolon = (Pantolon)kıyafet;
                    lstPantolon.Items.Add(pantolon);
                }
            }
        }

        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = (Ayakkabi)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(ayakkabi);
            toplamTutar += ayakkabi.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            T_shirt tShirt = (T_shirt)lstTshirt.SelectedItem;
            lstSepet.Items.Add(tShirt);
            toplamTutar += tShirt.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {
            Mont mont = (Mont)lstMont.SelectedItem;
            lstSepet.Items.Add(mont);
            toplamTutar += mont.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Pantolon pantolon = (Pantolon)lstPantolon.SelectedItem;
            lstSepet.Items.Add(pantolon);
            toplamTutar += pantolon.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void btnAlisveris_Click(object sender, EventArgs e)
        {           
            foreach (Giyim kıyafet in lstSepet.Items)
            {               
                if (kıyafet is Ayakkabi)
                {
                    ListViewItem lvi = new ListViewItem();
                    Ayakkabi ayakkabi = (Ayakkabi)kıyafet;
                    lvi.Text = ayakkabi.Marka;
                    lvi.SubItems.Add(ayakkabi.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(ayakkabi.KdvFiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    genelToplam += ayakkabi.KdvFiyat;
                    lblGenelToplam.Text = genelToplam.ToString("C2");                    
                }
                if (kıyafet is Mont)
                {
                    ListViewItem lvi = new ListViewItem();
                    Mont mont = (Mont)kıyafet;
                    lvi.Text = mont.Marka;
                    lvi.SubItems.Add(mont.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(mont.KdvFiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    genelToplam += mont.KdvFiyat;
                    lblGenelToplam.Text = genelToplam.ToString("C2");                    
                }
                if (kıyafet is T_shirt)
                {
                    ListViewItem lvi = new ListViewItem();
                    T_shirt tShirt = (T_shirt)kıyafet;
                    lvi.Text = tShirt.Marka;
                    lvi.SubItems.Add(tShirt.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(tShirt.KdvFiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    genelToplam += tShirt.KdvFiyat;
                    lblGenelToplam.Text = genelToplam.ToString("C2");                    
                }
                if (kıyafet is Pantolon)
                {
                    ListViewItem lvi = new ListViewItem();
                    Pantolon pantolon = (Pantolon)kıyafet;
                    lvi.Text = pantolon.Marka;
                    lvi.SubItems.Add(pantolon.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(pantolon.KdvFiyat.ToString("C2")+ " KDV");
                    listView1.Items.Add(lvi);
                    genelToplam += pantolon.KdvFiyat;
                    lblGenelToplam.Text = genelToplam.ToString("C2");                   
                }
            }
            lstSepet.Items.Clear();
            toplamTutar = 0;
            lblToplamTutar.Text = toplamTutar.ToString();
            lstAyakkabi.SelectedItem = null;
            lstMont.SelectedItem = null;
            lstPantolon.SelectedItem = null;
            lstTshirt.SelectedItem = null;
        }
    }
}
