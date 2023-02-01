namespace odev1d;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir cumle giriniz");
        string deneme = Console.ReadLine();

        Console.WriteLine($"cumlenin uzunlugu {deneme.Length} karakterdir");
        string[] dizi = deneme.Split(" ");
      System.Console.WriteLine($"kelime sayisi {dizi.Length}");
    }
}
