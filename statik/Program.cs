namespace statik;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
        Calisan calisan0 =new Calisan("Eyup", "Agaogullari", "Bilgi İşlem");
        System.Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
        Calisan calisan1 =new Calisan("Eyup", "ylek", "Bilgi İşlem");
        Calisan calisan2 =new Calisan("ahmet", "ylek", "Bilgi İşlem");
        System.Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

        //Islemler islemler = new Islemler();

        System.Console.WriteLine("Toplama: {0}", Islemler.Topla(5, 6));
        System.Console.WriteLine("Çıkarma: {0}", Islemler.Cikar(8, 6));



    }
}
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }
    //statik olmayan elemanlar o siniftan nesne uretilmeden erisilemez
    //statik elemanlar o siniftan ancak ve ancak nesne uretilmeden erisilebilir
    //statik elemanlar o siniftan uretilen tum nesneler tarafindan paylasilir

    //statik değişkenler global değişkenler gibidir
    //sadece kurucuda erişien değişkenler aşağidaki gibi tanımlanır
    private string Isim;
    private string Soyisim;
    private string Departman;

    //bir statik konstruktör oluşturulabilir
    //statik kurucularin erişim belirteci olmaz
    //statik kurucular sınıfın ilk nesnesi oluşturulduğunda çalışır
    //aşağidaki örnekte statik kurucu çalıştıktan sonra normal kurucu çalışır
    //calisan siniftan her bir nesne uretilmeden once calisan sayisi 0 olur
    static Calisan()
    {
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        //calisan sinifindan her bir nesne uretildiğinde calisan sayisi 1 artar
        calisanSayisi++;
    }



}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar (int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}