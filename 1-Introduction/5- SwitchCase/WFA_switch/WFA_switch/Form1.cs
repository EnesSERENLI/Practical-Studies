using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            //Karar yapıları
            //mevsimlere göre aylar gelsin..
            #region İf else
            /*
              string mevsim;
              mevsim = txtMevsim.Text.ToLower();
              if (mevsim == "kış")
              {
                  lblSonuc.Text = "Aralık , Ocak , Şubat";
              }
              else if (mevsim == "yaz")
              {
                  lblSonuc.Text = "Haziran , Temmuz , Ağustos";
              }
              else if (mevsim == "Sonbahar")
              {
                  lblSonuc.Text = "Eylül , Ekim , Kasım";
              }
              else if(mevsim == "ilkbahar")
              {
                  lblSonuc.Text = "Mart , Nisan , Mayıs";
              }
              else
              {
                  lblSonuc.Text = "Böyle bir mevsim yoktur";
              }
              */
            #endregion
            string mevsim;
            mevsim = txtMevsim.Text.ToLower();

            switch (mevsim) //Kullanıcı kış girmiş olsun
            {
                case "kış":
                    lblSonuc.Text = "Aralık , Ocak , Şubat";
                    break;
                case "yaz":
                    lblSonuc.Text = "Haziran , Temmuz , Ağustos";
                    break;
                case "İlkbahar":
                    lblSonuc.Text = "Mart , Nisan , Mayıs";
                    break;
                case "Sonbahar":
                    lblSonuc.Text = "Eylül , Ekim , Kasım";
                    break;
                default:
                    lblSonuc.Text = "Böyle bir mevsim yoktur.";
                    break;
            }

        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            //eğer txtKotrol'e girilen değer "admin" , "moderatör" , "yönetici" "ceo" "başkan" girilirse yönetim paneline yönlendiriliyorsunuz.
            //"üye" girilirse anasayfaya yönlendiriliyorsunuz.
            //harici bir değer girilirse bu sayfayı görüntüleme yetkiniz bulunmamaktadır.

            string gelenDeger = txtKontrol.Text.ToLower();
            switch (gelenDeger)
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "ceo":
                case "başkan":
                    lblSonuc.Text = "yönetim paneline yönlendiriliyorsunuz.";
                    break ;
                case "üye":
                    lblSonuc.Text = "anasayfaya yönlendiriliyorsunuz.";
                    break;
                default :
                    lblSonuc.Text = "bu sayfayı görüntüleme yetkiniz bulunmamaktadır.";
                    break;

            }

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            //ÖDEV


            //eğer kullanıcı adına girilen değer bilgeadam ve şifreye girilen değer 1234 ise profil sayfasına yönlendiriliyorsunuz.
            //kullanıcı adı doğru şifre yanlışsa "kullanıcı adınız doğru ancak şifreniz yanlış"
            //kullanıcı adı yanlışsa "kullanıcı adınız yanlış şifreye bakmadım bile"
            //mesajını verin
            string gelenKullaniciAdi = txtKullaniciAdi.Text.ToLower();
            string gelenSifre = txtSifre.Text.ToLower();



            switch (gelenKullaniciAdi)
            {
                case "bilgeadam":
                    switch (gelenSifre)
                    {
                        case "1234":
                            MessageBox.Show("profil sayfasına yönlendiriliyorsunuz.");
                            break;
                        default:
                            MessageBox.Show("kullanıcı adınız doğru ancak şifreniz yanlış");
                            break;                        
                    }                       
                    break;
                default:
                    MessageBox.Show("kullanıcı adınız yanlış şifreye bakmadım bile");
                    break;
            }
            
        }
    }
}
