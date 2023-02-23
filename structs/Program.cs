namespace structs;
class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 5;
        dikdortgen.UzunKenar = 10;
        Console.WriteLine("class alan hesabi:" + dikdortgen.Alanhesapla());
        D4g_struct dikdortgen2 = new D4g_struct();
        dikdortgen2.KisaKenar = 5;
        dikdortgen2.UzunKenar = 10;
        Console.WriteLine(dikdortgen2.Alanhesapla());
        D4g_struct dikdortgen3;
        Dikdortgen dikdortgen4 = new Dikdortgen();
        Console.WriteLine("class ile defauld değerler: {0} ", dikdortgen4.Alanhesapla());

        //struct ile default değerler
        D4g_struct dikdortgen5 = new D4g_struct(3, 7);
        Console.WriteLine("struct ile initial değerler: {0} ", dikdortgen5.Alanhesapla());

        //struct değer atanmadan kullanılamaz
    }
}
class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen()
    {
        this.KisaKenar = 3;
        this.UzunKenar = 4;
    }
    public long Alanhesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

struct D4g_struct
{
    public int KisaKenar;
    public int UzunKenar;
    //parametresiz constructor oluşturulamaz
    //public D4g_struct()
    //{
    //    this.KisaKenar = 3;
    //    this.UzunKenar = 4;
    //}
    //ancak parametreli constructor oluşturulabilir
    public D4g_struct(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }

    public long Alanhesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}
