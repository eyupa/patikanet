using System;
namespace Metotlar;
class Program
{
    static void Main(string[] args)
    {
        //erisim_belirteci geriDOnusTipi metotAdi(parametreListesi/argumanListesi)
        //{
        //metot içeriği
        //return
        //}

        //void geri dönüş tipi olmayan metotlardır.

        //metotlar iç içe tanımlanabilir.

        //metotlar içerisinde başka metotlar çağrılabilir.


        int a = 10;
        int b = 20;

        //System.Console.WriteLine(a + b);

        int sonuc = Topla(a, b);
        //System.Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        Metotlar ornek2 = new Metotlar();

        int int2 = ornek2.ArtirVeTopla(ref a, ref b);
        ornek2.EkranaYazdir(Convert.ToString(int2));





    }

    //metotlari class icine yazdik. ama classlarin disinda da yazilabilir.
    //erisilebilir olmasi icin public anahtar kelimesini verdik.

    //static keyword verdik cunku main methodu static oldugu icin. static bir methodun icinde static olmayan bir methodu cagiramiyoruz.
    static int Topla(int deger1, int deger2)
    {

        //bu methodun icindeki degerlerin methodun disindaki degerlerle ayni olmasi icin parametrelerini verdik.
        System.Console.WriteLine(deger1 + deger2);
        return deger1 + deger2;
    }
}

class Metotlar
{
    //erisilebilir olmasi icin public anahtar kelimesini verdik.
    public void EkranaYazdir(string deger)
    {
        System.Console.WriteLine(deger);
    }


    public int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }
    //ref anahtar kelimesini kullanimi
    public int ArtirVeTopla(ref int deger1, ref int deger2)
    {
        deger1++;
        deger2++;
        return deger1 + deger2;
    }
}
