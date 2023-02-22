﻿namespace kurucuMetotlar;
class Program
{
    static void Main(string[] args)
    {
       Calisan calisan1 = new Calisan();
        calisan1.Ad = "Eyup";
        calisan1.Soyad = "Agaogullari";
        calisan1.No = 123;
        calisan1.Departman = "Bilgi İşlem";

        calisan1.CalisanBilgileri();
        System.Console.WriteLine("*************************");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Ahmet";
        calisan2.Soyad = "Yılmaz";
        calisan2.No = 456;
        calisan2.Departman = "Satın Alma";

        calisan2.CalisanBilgileri();
        System.Console.WriteLine("*************************");
        Calisan calisan3=new Calisan("Ali","Veli",789,"Muhasebe");
        calisan3.CalisanBilgileri();

    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan() {}
    public Calisan(string ad, string soyad, int no)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
    }


    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: " + Ad);
        Console.WriteLine("Çalışan Soyadı: " + Soyad);
        Console.WriteLine("Çalışan No: " + No);
        Console.WriteLine("Çalışan Departman: " + Departman);
    }

}
