using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public interface IUrun
    {
        ListViewItem SepeteEkle(object obj);

        decimal TutarHesapla(object obj);
    }
    public interface IUrunYonetimi
    {
        //Ürün Ekleme
        void UrunEkle(string deger1, string deger2, decimal fiyat);

        //Ürün Silme
        void UrunSil(string deger1, string deger2);

        //Ürün Güncelleme
        void UrunGuncelle(string eskiDeger, string eskiDeger2, string yeniDeger, string yeniDeger2, decimal fiyat);
    }
}
