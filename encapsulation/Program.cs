namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci("Kemal", 123, 1);
        Ogrenci ogrenci2 = new Ogrenci("Ayşe", 456, 2);


        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci2.OgrenciBilgileriniGetir();
        ogrenci1.SinifAtlat();
        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci2.SinifDusur();
        ogrenci2.OgrenciBilgileriniGetir();
    }
}
class Ogrenci
{
    private string ad;
    private string soyad;
    private int ogrenciNo;
    private int sinif;
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }

    public string Soyad { get; set; }
    public int OgrenciNo { get; set; }
    public int Sinif { get; set; }

    public Ogrenci(string soyad, int ogrenciNo, int sinif)
    {
        Ad=ad;
        Soyad = soyad;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci() { }
    public void OgrenciBilgileriniGetir()
    {
        System.Console.WriteLine("********Öğrenci Bilgileri********");
        Console.WriteLine("Ad\t:{0}", Ad);
        Console.WriteLine("Soyad\t: {0}", Soyad);
        Console.WriteLine("Ögr. No\t: {0}", OgrenciNo);
        Console.WriteLine("Sınıf\t: {0}", Sinif);
    }

    public void SinifAtlat()
    {
        Sinif++;
    }
    public void SinifDusur()
    {
        Sinif--;
    }

}
