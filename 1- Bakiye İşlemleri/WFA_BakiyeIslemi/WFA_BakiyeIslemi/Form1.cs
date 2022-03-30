using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Bakiye İşlemleri
        //UYgulama çalıştırıldığında bakiye otomatik olarak 500 TL şeklinde gösterilecek. +
        //Para çek butonuna basıldığında belirtilen miktar kadar tanımlı olan bakiyeden azaltılacak. +
        //para yatır butonuna tıklandığında yine belirtilen miiktar kadar tanımlı olan bakiyeye eklenecek.
        //bakiye 0 veya 0'dan küçük ise para çekme işlemi gerçekleştirilmeyecek kullanıcıya mesaj gösterilecek ve para çek isimli buton tıklanamayacak. +
        //para yatır bölümünde en az 1 TL olması durumunda bakiyeye eklenebilecek.+
        //heryapılan işlemde bakiye değeri güncellenecek.+
        //Yapılan her işlem listbox'a eklenecek. Format => Para Çekme:Miktar güncel bakiye: , Para Yatırm:Miktar güncel bakiye:+

        //Alışveriş İşlemeleri
        //alışverişi tamamla butonuna tıklandığında seçili olan checkbox ların fiyatları toplanacak, toplanan fiyat alışveriş listesi altında bulunan listBox a yazdırılacak. Örneğin => Yumurta(10'lu) Ekmek (4 TL) => 14 TL
        //yukaridaki işlemin gerçekleştirilmesi için toplam tutarın bakiyeye eşit yada bakiyeden küçük olması gerekmektedir.
        //Her alışverişte bakiye güncellenecek.
        //Yapılan bütün harcamalar güncel bakiye olan box'ta gösterilecek.

        decimal bakiye = 500;
        decimal cekilenPara;
        decimal yatirilanPara;
        decimal ekmekFiyat = 4;
        decimal yumurtaFiyat = 20;
        decimal cayFiyat = 35;
        decimal cikolataFiyat = 30;
        decimal peynirFiyat = 45;
        decimal toplamTutar;        
        string ekmekMesaj;
        string yumurtaMesaj;
        string cayMesaj;
        string cikolataMesaj;
        string peynirMesaj;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = bakiye.ToString();

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToDecimal(lblBakiye.Text);
            cekilenPara = nudParaCek.Value;
            bakiye = Convert.ToDecimal(lblBakiye.Text) - cekilenPara;
          
            if (bakiye<0)
            {
                
                MessageBox.Show("Yeterli Bakiyeniz Yoktur.");
                
            }
            else if(bakiye==0)
            {
                btnParaCek.Enabled=false;
                lblBakiye.Text = bakiye.ToString();               
                listBox1.Items.Add("Para Çekme: " + cekilenPara + " Güncel Bakiyeniz: " + bakiye);
                MessageBox.Show("Bakiyeniz sıfırlandı, bakiyenizi arrtırmak için para yatırınız.");

            }
            else
            {
                lblBakiye.Text = bakiye.ToString();
                listBox1.Items.Add("Para Çekme: " + cekilenPara +" TL" + " Güncel Bakiyeniz: " + bakiye+ " TL");
            }

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            yatirilanPara = nudParaYatir.Value;
            bakiye = Convert.ToDecimal(lblBakiye.Text) + yatirilanPara;
            
            if(yatirilanPara>=1)
            {
                lblBakiye.Text = bakiye.ToString();
                btnParaCek.Enabled = true;
                listBox1.Items.Add("Para Yatırma: "+yatirilanPara+" TL"+" Güncel Bakiyeniz: "+bakiye+ " TL");
            }
            else
            {
                MessageBox.Show("Para yatırma işlemi için en az 1 TL olması gerekmektedir.");
            }
        }

        private void btnAlisveris_Click(object sender, EventArgs e)
        {
         
            
            bool ekmek = chkEkmek.Checked;
            bool yumurta = chkYumurta.Checked;
            bool cay = chkCay.Checked;
            bool cikolata = ChkCikolata.Checked;
            bool peynir = chkPeynir.Checked;


                if (ekmek)
                {
                ekmekMesaj = "Ekmek (4 TL)";
                }

                if (bakiye < 4 && ekmek)
                {

                    MessageBox.Show("Ekmek için bakiyeniz yetersiz lütfen para ekleyiniz.");
                    ekmekMesaj = "";
                }

                else if (bakiye >= 4 && ekmek)
                {
                    bakiye = Convert.ToDecimal(lblBakiye.Text) - ekmekFiyat;
                    lblBakiye.Text = bakiye.ToString();                    
                    toplamTutar += ekmekFiyat;
                
                }
                               
                if (yumurta)
                {
                yumurtaMesaj = "Yumurta (20 TL)";
                }
            

                if (bakiye < 20 && yumurta)
                {
                    MessageBox.Show("Yumurta için bakiyeniz yetersiz lütfen para ekleyiniz.");
                    yumurtaMesaj = "";

                }

                else if (bakiye >= 20 && yumurta)
                {
                    bakiye = Convert.ToDecimal(lblBakiye.Text) - yumurtaFiyat;
                    lblBakiye.Text = bakiye.ToString();                    
                    toplamTutar += yumurtaFiyat;               
                }
                             
                if (cay)
                {
                cayMesaj = "Çay (35 TL)";
                }

                if (bakiye < 35 && cay)
                {
                    MessageBox.Show("Çay için bakiyeniz yetersiz lütfen para ekleyiniz.");
                    cayMesaj = "";
                }

                else if (bakiye >= 35 && cay)
                {
                    bakiye = Convert.ToDecimal(lblBakiye.Text) - cayFiyat;
                    lblBakiye.Text = bakiye.ToString();                    
                    toplamTutar += cayFiyat;
                }

                if (cikolata)
                {
                cikolataMesaj = "Çikolata (30 TL)";
                }
    
                if (bakiye < 30 && cikolata)
                {
                    MessageBox.Show("Çikolata için bakiyeniz yetersiz lütfen para ekleyiniz.");
                    cikolataMesaj = "";
                }

                else if (bakiye >= 30 && cikolata)
                {
                    bakiye = Convert.ToDecimal(lblBakiye.Text) - cikolataFiyat;
                    lblBakiye.Text = bakiye.ToString();                    
                    toplamTutar += cikolataFiyat;                
                }

                if (peynir)
                {
                peynirMesaj = "Peynir (45 TL)";
                }
               
                if (bakiye < 45 && peynir)
                {
                    MessageBox.Show("Peynir için bakiyeniz yetersiz lütfen para ekleyiniz.");
                    peynirMesaj = "";
                }

                else if (bakiye >= 45 && peynir)
                {
                    bakiye = Convert.ToDecimal(lblBakiye.Text) - peynirFiyat;
                    lblBakiye.Text = bakiye.ToString();                    
                    toplamTutar += peynirFiyat;
                    
                }
            
            listBox1.Items.Add("Harcanan alışveriş tutarınız: " + toplamTutar.ToString());   
            listBox2.Items.Add(ekmekMesaj +" "+ yumurtaMesaj +" "+ cayMesaj +" "+ cikolataMesaj +" "+ peynirMesaj + "  => Alışveriş Toplam Tutarınız: " + toplamTutar + " TL");
            listBox2.Items.Add("------------------------------------------------------------------------------------------");
            ekmekMesaj = "";
            yumurtaMesaj = "";
            cayMesaj="";
            cikolataMesaj = "";
            peynirMesaj = "";
            toplamTutar = 0;
            
        }

        

       
    }
}
