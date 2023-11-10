using System;

namespace encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "Ayşe";
        ogrenci.Soyad = "Yılmaz";
        ogrenci.OrgrenciNo = 293;
        ogrenci.Sinif = 3;
        ogrenci.OgrenciBilgileriGetir();

        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgileriGetir();

        Ogrenci ogrenci1 = new Ogrenci("Derya", "Kuzu", 256, 1);
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileriGetir();
    }
}

class Ogrenci
{
    private string ad;
    private string soyad;
    private int orgrenciNo;
    private int sinif;

    internal string Ad 
    { 
        get { return ad; }
        set { ad = value; }
    }

    internal string Soyad { get => soyad; set => soyad = value; }
    internal int OrgrenciNo { get => orgrenciNo; set => orgrenciNo = value; }
    internal int Sinif 
    {
        get => sinif;
        set 
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az bir olabilir.");
                sinif = 1;
            }
            else
                sinif = value;
        } 
    }

    internal Ogrenci(){}
    internal Ogrenci(string ad, string soyad, int orgrenciNo, int sinif)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.orgrenciNo = orgrenciNo;
        Sinif = sinif;
    }

    internal void OgrenciBilgileriGetir()
    {
        Console.WriteLine("******* Öğrenci Bilgileri *******");
        Console.WriteLine("Adı:     {0}", this.ad);
        Console.WriteLine("Soyadı:  {0}", this.soyad);
        Console.WriteLine("No:      {0}", this.orgrenciNo);
        Console.WriteLine("Sınıfı:  {0}", this.sinif);
    }

    internal void SinifAtlat()
    {
        Sinif++;
    }

    internal void SinifDusur()
    {
        Sinif--;
    }
}
