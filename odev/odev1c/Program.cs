namespace odev1c;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir sayi giriniz");
        int sayi = int.Parse(System.Console.ReadLine());
        string[] dizi = new string[sayi];
        for (int i = 0; i < sayi; i++)

        {
            System.Console.WriteLine($"{i+1}. kelimeyi giriniz");
            dizi[i] = System.Console.ReadLine();

        }

        for (int j = sayi; j > 0; j--)
        {
             System.Console.WriteLine($"{j}. kelime:");
            System.Console.WriteLine(dizi[j-1]);
        }

    }
}

