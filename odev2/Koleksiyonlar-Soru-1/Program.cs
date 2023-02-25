namespace Koleksiyonlar_Soru_1;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("20 tane sayı giriniz: ");
        int[] sayilar = new int[20];
        int[] asalSayilar = new int[20];
        int[] nonAsalSayilar = new int[20];
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
        for (int i = 0; i < 20; i++)
        {
            int j = 2;
            while (j < sayilar[i])
            {
                if (sayilar[i] % j == 0)
                {
                    nonAsalSayilar[i] = sayilar[i];
                    break;
                }
                else
                {
                    asalSayilar[i] = sayilar[i];
                }
                j++;
            }


        }
        System.Console.WriteLine("Asal Sayılar: ");
        Array.Sort(asalSayilar);
        Array.Sort(nonAsalSayilar);

    Array.Reverse(asalSayilar);
    Array.Reverse(nonAsalSayilar);
        for (int i = 0; i < 20; i++)
        {
            if (asalSayilar[i] != 0)
            {
                System.Console.WriteLine(asalSayilar[i]);
            }
        }
        System.Console.WriteLine("Asal Olmayan Sayılar: ");
        for (int i = 0; i < 20; i++)
        {
            if (nonAsalSayilar[i] != 0)
            {
                System.Console.WriteLine(nonAsalSayilar[i]);
            }
        }
        System.Console.WriteLine("Asal Sayıların Ortalaması: {0}", asalSayilar.Average());
        System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması: {0}", nonAsalSayilar.Average());
        System.Console.WriteLine("Asal Sayıların Uzunluğu: {0}", asalSayilar.Length);
        System.Console.WriteLine("Asal Sayıların Uzunluğu: {0}", nonAsalSayilar.Length);

    }
}
