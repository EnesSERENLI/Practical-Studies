using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KitapKutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //List<Category> categories = new List<Category>
            //{
            //    new Category{categoryId = 1,categoryName ="Edebiyat" },
            //    new Category{categoryId = 2,categoryName ="Roman" },
            //    new Category{categoryId = 3,categoryName ="Felsefe" }

            //};
            //settings(categories);
        }
        
        List<Urun> unurunlerKutusu = new List<Urun>();// Koleksiyon olarak en genel class'ı aldık. Bu bize bütün türler için döngü yzamak yerine tek döngüde işimiz görmemizi sağlayabilir.
        Edebiyat edebiyat = new Edebiyat();
        Roman roman = new Roman();
        Felsefe felsefe = new Felsefe();
        Psikoloji psikoloji = new Psikoloji();
        Tarih tarih = new Tarih();
        Elektronik elektronik = new Elektronik();
        ErkekGiyim erkekGiyim = new ErkekGiyim();
        KadinGiyim kadinGiyim = new KadinGiyim();
        Telefon telefon = new Telefon();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Label lbl1 = new Label();
        Label lbl2 = new Label();
        Button btn = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Ad ve Fiyat girilecek. Ardından kategori seçilecek ve ilgili kategorinin özellikleri runtime olarak gelecek. Kullanıcı özellikleride girecek ve ekle butonuna basınca ilgili listbox'lara alınan değerler gönderilecek. 
            #region Listbox'a ekleme ve Inheritance
            //Edebiyat edebiyat = new Edebiyat();
            //edebiyat.KitapAd = "Çalıkuşu";
            //edebiyat.YayinEvi = "Çınar";
            //edebiyat.Fiyat = 15;
            //edebiyat.KitapTuru = "Edebiyat";
            //edebiyat.YazarAd = "R.N.Güntekin";

            //Edebiyat edebiyat2 = new Edebiyat();
            //edebiyat2.KitapAd = "Edebiyat 2";
            //edebiyat2.YayinEvi = "Çınar";
            //edebiyat2.Fiyat = 40;
            //edebiyat2.KitapTuru = "Edebiyat";
            //edebiyat2.YazarAd = "R.N.Güntekin";

            //Roman roman = new Roman();
            //roman.KitapAd = "Yaban";
            //roman.YayinEvi = "can";
            //roman.Fiyat = 20;
            //roman.KitapTuru = "Roman";
            //roman.YazarAd = "Yakup Kadri";

            //Felsefe felsefe = new Felsefe();
            //felsefe.KitapAd = "asdasd";
            //felsefe.YayinEvi = "Sırma";
            //felsefe.Fiyat = 20;
            //felsefe.KitapTuru = "Düşünüyorumm";
            //felsefe.YazarAd = "Eflatun";

            //Psikoloji psikoloji = new Psikoloji();
            //psikoloji.KitapAd = "fldg";
            //psikoloji.YayinEvi = "Kardeşler";
            //psikoloji.Fiyat = 20;
            //psikoloji.KitapTuru = "Hayır deme sanatı";
            //psikoloji.YazarAd = "fghoşdlmfg";

            //Tarih tarih = new Tarih();
            //tarih.KitapAd = "fldg";
            //tarih.YayinEvi = "Kardeşler";
            //tarih.Fiyat = 20;
            //tarih.KitapTuru = "Hayır deme sanatı";
            //tarih.YazarAd = "fghoşdlmfg";

            //kitapListesi.Add(edebiyat);
            //kitapListesi.Add(edebiyat2);
            //kitapListesi.Add(roman);
            //kitapListesi.Add(felsefe);
            //kitapListesi.Add(psikoloji);
            //kitapListesi.Add(tarih);

            //foreach (Kitap kitap in kitapListesi)
            //{
            //    if (kitap is Edebiyat)
            //    {
            //        lstEdebiyat.Items.Add(kitap.KitapAd);
            //    }
            //    if (kitap is Roman)
            //    {
            //        lstRoman.Items.Add(kitap.KitapAd);
            //    }
            //    if (kitap is Felsefe)
            //    {
            //        lstFelsefe.Items.Add(kitap.KitapAd);
            //    }
            //    if (kitap is Psikoloji)
            //    {
            //        lstPiskoloji.Items.Add(kitap.KitapAd);
            //    }
            //    if (kitap is Tarih)
            //    {
            //        lstTarih.Items.Add(kitap.KitapAd);
            //    }
            //}
            #endregion
            cmbKategori.Items.Add("Edebiyat");
            cmbKategori.Items.Add("Roman");
            cmbKategori.Items.Add("Felsefe");
            cmbKategori.Items.Add("Psikoloji");
            cmbKategori.Items.Add("Tarih");
            cmbKategori.Items.Add("Erkek Giyim");
            cmbKategori.Items.Add("Kadın Giyim");
            cmbKategori.Items.Add("Elektronik");
            cmbKategori.Items.Add("Telefon");
        }
        //private void settings(List<Category> categories)
        //{
        //    foreach (Category item in categories)
        //    {
        //        cmbKategori.Items.Add(item.categoryName);
        //    }
        //}
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Burada seçilen kategori bulunacak 

            switch (cmbKategori.SelectedItem)
            {
                case "Edebiyat":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Yazar Ad :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Yayın Evi :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Roman":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Yazar Ad :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Yayın Evi :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Felsefe":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Yazar Ad :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Yayın Evi :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Psikoloji":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Yazar Ad :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Yayın Evi :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                   
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Tarih":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Yazar Ad :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Yayın Evi :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                   
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Elektronik":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Marka :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Renk :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Erkek Giyim":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Beden :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Renk :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Kadın Giyim":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Beden :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Renk :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
                case "Telefon":
                    groupBox1.Controls.Remove(lbl1);
                    groupBox1.Controls.Remove(lbl2);
                    groupBox1.Controls.Remove(txt1);
                    groupBox1.Controls.Remove(txt2);
                    groupBox1.Controls.Remove(btn);
                    txt1.Location = new Point(100, 140);
                    txt1.Width = 185;
                    txt1.Height = 23;
                    txt2.Location = new Point(100, 170);
                    txt2.Width = 185;
                    txt2.Height = 23;
                    lbl1.Text = "Marka :";
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(6, 142);
                    lbl2.Text = "Renk :";
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(6, 172);
                    btn.Location = new Point(100, 200);
                    btn.Text = "EKLE";
                    btn.Width = 185;
                    btn.Height = 23;                    
                    groupBox1.Controls.Add(lbl1);
                    groupBox1.Controls.Add(lbl2);
                    groupBox1.Controls.Add(txt1);
                    groupBox1.Controls.Add(txt2);
                    groupBox1.Controls.Add(btn);
                    break;
            }
            btn.Click -= Btn_Click;
            btn.Click += Btn_Click;          
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            switch (cmbKategori.SelectedIndex)
            {
                case 0:
                    unurunlerKutusu.Clear();
                    edebiyat.KitapAd = txtAd.Text;
                    edebiyat.Fiyat = nudFiyat.Value;
                    edebiyat.YazarAd = txt1.Text;
                    edebiyat.YayinEvi = txt2.Text;
                    unurunlerKutusu.Add(edebiyat);
                    break;
                case 1:
                    unurunlerKutusu.Clear();
                    roman.KitapAd = txtAd.Text;
                    roman.Fiyat = nudFiyat.Value;
                    roman.YazarAd = txt1.Text;
                    roman.YayinEvi = txt2.Text;
                    unurunlerKutusu.Add(roman);
                    break;
                case 2:
                    unurunlerKutusu.Clear();
                    felsefe.KitapAd = txtAd.Text;
                    felsefe.Fiyat = nudFiyat.Value;
                    felsefe.YazarAd = txt1.Text;
                    felsefe.YayinEvi = txt2.Text;
                    unurunlerKutusu.Add(felsefe);
                    break;
                case 3:
                    unurunlerKutusu.Clear();
                    psikoloji.KitapAd = txtAd.Text;
                    psikoloji.Fiyat = nudFiyat.Value;
                    psikoloji.YazarAd = txt1.Text;
                    psikoloji.YayinEvi = txt2.Text;
                    unurunlerKutusu.Add(psikoloji);
                    break;
                case 4:
                    unurunlerKutusu.Clear();
                    tarih.KitapAd = txtAd.Text;
                    tarih.Fiyat = nudFiyat.Value;
                    tarih.YazarAd = txt1.Text;
                    tarih.YayinEvi = txt2.Text;
                    unurunlerKutusu.Add(tarih);
                    break;
                case 5:
                    unurunlerKutusu.Clear();
                    erkekGiyim.urunName = txtAd.Text;
                    erkekGiyim.Fiyat = nudFiyat.Value;
                    erkekGiyim.Beden = txt1.Text;
                    erkekGiyim.Renk = txt2.Text;
                    unurunlerKutusu.Add(erkekGiyim);
                    break;
                case 6:
                    unurunlerKutusu.Clear();
                    kadinGiyim.urunName = txtAd.Text;
                    kadinGiyim.Fiyat = nudFiyat.Value;
                    kadinGiyim.Beden = txt1.Text;
                    kadinGiyim.Renk = txt2.Text;
                    unurunlerKutusu.Add(kadinGiyim);
                    break;

                case 7:
                    unurunlerKutusu.Clear();
                    elektronik.Model = txtAd.Text;
                    elektronik.Fiyat = nudFiyat.Value;
                    elektronik.Marka = txt1.Text;
                    elektronik.Renk = txt2.Text;
                    unurunlerKutusu.Add(elektronik);
                    break;
                case 8:
                    unurunlerKutusu.Clear();
                    telefon.Model = txtAd.Text;
                    telefon.Fiyat = nudFiyat.Value;
                    telefon.Marka = txt1.Text;
                    telefon.Renk = txt2.Text;
                    unurunlerKutusu.Add(telefon);
                    break;
            }
            foreach (Urun u in unurunlerKutusu)
            {
                if (u is Kitap)
                {
                    Kitap k = (Kitap)u;
                    if (k is Edebiyat)
                    {
                        Edebiyat edebiyat = (Edebiyat)k;
                        lstEdebiyat.Items.Add(edebiyat.KitapAd + " " + edebiyat.Fiyat + " " + edebiyat.YazarAd + " " + edebiyat.YayinEvi);
                        
                    }
                    else if (k is Roman)
                    {
                        Roman roman = (Roman)k;
                        lstRoman.Items.Add(roman.KitapAd + " " + roman.Fiyat + " " + roman.YazarAd + " " + roman.YayinEvi);
                       
                    }
                    else if (k is Felsefe)
                    {
                        Felsefe felsefe = (Felsefe)k;
                        lstFelsefe.Items.Add(felsefe.KitapAd + " " + felsefe.Fiyat + " " + felsefe.YazarAd + " " + felsefe.YayinEvi);
                    }
                    else if (k is Psikoloji)
                    {
                        Psikoloji psikoloji = (Psikoloji)k;
                        lstPiskoloji.Items.Add(psikoloji.KitapAd + " " + psikoloji.Fiyat + " " + psikoloji.YazarAd + " " + psikoloji.YayinEvi);
                    }
                    else if (k is Tarih)
                    {
                        Tarih tarih = (Tarih)k;
                        lstTarih.Items.Add(tarih.KitapAd + " " + tarih.Fiyat + " " + tarih.YazarAd + " " + tarih.YayinEvi);
                    }
                }
                else if (u is Elektronik)
                {
                    Elektronik elektronik = (Elektronik)u;
                    if (elektronik is Telefon)
                    {
                        Telefon telefon = (Telefon)u;
                        lstTelefon.Items.Add(telefon.urunName + " " + telefon.Fiyat + " " + telefon.Marka + " " + telefon.Renk);
                    }
                    else
                    {
                        lstElektronik.Items.Add(elektronik.Model + " " + elektronik.Fiyat + " " + elektronik.Marka + " " + elektronik.Renk);
                    }                    
                }
                else if (u is Giyim)
                {
                    Giyim giyim = (Giyim)u;
                    if(giyim is ErkekGiyim)
                    {
                        ErkekGiyim erkekGiyim = (ErkekGiyim)giyim;
                        lstErkekGiyim.Items.Add(erkekGiyim.urunName + " " + erkekGiyim.Fiyat + " " + erkekGiyim.Beden + " " + erkekGiyim.Renk);
                    }
                    else if (giyim is KadinGiyim)
                    {
                        KadinGiyim kadinGiyim = (KadinGiyim)giyim;
                        lstKadinGiyim.Items.Add(kadinGiyim.urunName + " " + kadinGiyim.Fiyat + " " + kadinGiyim.Beden + " " + kadinGiyim.Renk);
                    }
                }            
            }            
        }
    }
}



