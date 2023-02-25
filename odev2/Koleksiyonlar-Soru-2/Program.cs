namespace Koleksiyonlar_Soru_2;
class Program
{
    static void Main(string[] args)
    {
         System.Console.WriteLine("20 tane sayı giriniz: ");
        int[] sayilar = new int[20];
        int[] buyukSayilar = new int[3];
        int[] kucukSayilar = new int[3];
        for (int i = 0; i < 20; i++)
        {

            string line = Console.ReadLine();
            try
            {
                int sayi = Int32.Parse(line);
                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                    i--;
                }
                else
                {
                    sayilar[i] = Int32.Parse(line);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("{0} tam sayı değil", line);
                i--;
            }
            System.Console.WriteLine($"Sayı {i + 1} : {sayilar[i]}");

        }

        Array.Sort(sayilar);
        for (int i = 0; i < 3; i++)
        {
            buyukSayilar[i] = sayilar[19 - i];
            kucukSayilar[i] = sayilar[i];
        }
        System.Console.WriteLine("En büyük 3 sayı: ");
        foreach (var item in buyukSayilar)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("En küçük 3 sayı: ");
        foreach (var item in kucukSayilar)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine($"en buyuk sayıların toplamı:{buyukSayilar.Sum()} ortalaması:{buyukSayilar.Average()} ");
        System.Console.WriteLine($"en kucuk sayıların toplamı:{kucukSayilar.Sum()} ortalaması:{kucukSayilar.Average()} ");
        System.Console.WriteLine($"ortalamaların toplamları:{buyukSayilar.Average() + kucukSayilar.Average()}");


    }

}
