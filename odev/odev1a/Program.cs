namespace odev1a;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir sayı giriniz");
        int sayi = int.Parse(System.Console.ReadLine());
        int[] dizi = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            System.Console.WriteLine($"{i + 1}. sayıyı giriniz");
            dizi[i] = int.Parse(System.Console.ReadLine());
        }
        for (int i = 0; i < sayi; i++)
        {
            if (dizi[i] % 2 == 0)
            {
                System.Console.Write($"{dizi[i]}, ");
            }

        }
        System.Console.WriteLine("Sayiları çift sayilardir.");
    }
}