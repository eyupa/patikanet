namespace metotlar_overloading;
class Program
{
    static void Main(string[] args)
    {
        //out parameter
        string sayi = "999";
        //int outSayi;

        //return ifadeler yerine out parametreler de kullanabiliriz.


        bool sonuc = int.TryParse(sayi, out int outSayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }
        Metotlar instance = new Metotlar();
        instance.Topla(4, 5, out int sonucTopla);
        System.Console.WriteLine(sonucTopla);
        //metotlar_overloading
        //string ifade = "merhaba dünya";

        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade.ToString());
        instance.EkranaYazdir("eyup", "programlama");

        //metot imzasi

        // metotAdi +parametre sayisi + parametre





        //Metotlar instance = new Metotlar();




    }
}
class Metotlar
{
    public int Topla(int a, int b , out int toplam)
    {
        toplam = a + b;
        return toplam;
    }

    //overloading yaptik
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri, string veri2)
    {
        Console.WriteLine(veri + veri2);
    }
    
}
