namespace sinif;
class Program
{
    static void Main(string[] args)
    {
        //söz dizimi
        //class sınıfAdı
        //{
        //    //değişkenler
        //    //metotlar
        //}


        //sınıfAdı nesneAdı = new sınıfAdı();
        //nesneAdı.metotAdı();
        //nesneAdı.değişkenAdı = değer;
        //değer = nesneAdı.değişkenAdı;
        //nesneAdı.değişkenAdı = nesneAdı.değişkenAdı;
        //nesneAdı.değişkenAdı = nesneAdı.metotAdı();
        //nesneAdı.metotAdı(nesneAdı.değişkenAdı);
        //nesneAdı.metotAdı(nesneAdı.metotAdı());
        //nesneAdı.metotAdı(nesneAdı.metotAdı(nesneAdı.değişkenAdı));
        //
        //nesneAdı.metotAdı(nesneAdı.metotAdı(nesneAdı.değişkenAdı), nesneAdı.değişkenAdı);
        //nesneAdı.metotAdı(nesneAdı.değişkenAdı, nesneAdı.metotAdı(nesneAdı.değişkenAdı));
        //nesneAdı.metotAdı(nesneAdı.değişkenAdı, nesneAdı.değişkenAdı);
        //nesneAdı.metotAdı(nesneAdı.değişkenAdı, nesneAdı.değişkenAdı, nesneAdı.değişkenAdı);

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
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: " + Ad);
        Console.WriteLine("Çalışan Soyadı: " + Soyad);
        Console.WriteLine("Çalışan No: " + No);
        Console.WriteLine("Çalışan Departman: " + Departman);
    }

}
