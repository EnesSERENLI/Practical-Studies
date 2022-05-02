using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KimAnlatir
{
    public class Sinif
    {
        public Sinif(string ad, string soyad, short puan)
        {
            Ad = ad;
            Soyad = soyad;
            Puan = puan;
        }

        public static List<Sinif> sinifListesi = new List<Sinif>()
        {
            new Sinif("AZAD", "MAJIDLI", 0),
            new Sinif("SILA", "ŞİRİN", 0),
            new Sinif("UMUT", "YILBAŞ", 0),
            new Sinif("SARUHAN MERT", "DEMİRAY", 0),
            new Sinif("ONUR", "DOĞRU", 0),
            new Sinif("Emre", "Bektaşoğlu", 0),
            new Sinif("ENES", "SERENLİ", 0),
            new Sinif("FURKAN SEMİH", "GÜNEŞ", 0),
            new Sinif("KAAN", "ÜNAL", 0),
            new Sinif("BAHADIR", "ARDA", 0),
            new Sinif("BURAK", "UYSAL", 0),
            new Sinif("AHMET CANER", "TATLI", 0),
            new Sinif("TUBA", "BUĞDAY KARADUT", 0),
            new Sinif("MAHMURE", "OKAN", 0),
            new Sinif("ARYA", "KAPIKIRAN", 0),
            new Sinif("BERK", "BASAT", 0)
        };

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public short Puan { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
    public enum Konu
    {
        Değişkenler,
        Operatörler,
        Dönüşümler,
        TryCatch,
        KararYapıları,
        Döngüler,
        Runtime,
        Metotlar,
        Encapsulation,
        Inheritance,
        Polymorphism,
        Abstruction,
        Enum,
        Interface
    }
}
