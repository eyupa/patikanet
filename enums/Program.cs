namespace enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        //int bir cast dönüşüm işlemi yapılıyor.
        System.Console.WriteLine((int)Gunler.Pazar);
        System.Console.WriteLine((int)Gunler2.Pazartesi);
        System.Console.WriteLine((int)Gunler2.Pazar);

        System.Console.WriteLine((int)HavaDurumu.Soguk);

        int sicaklik = 32;
        if (sicaklik < (int)HavaDurumu.Normal)
        {
            System.Console.WriteLine("Hava soğuk");
        }
        else if (sicaklik > (int)HavaDurumu.Normal)
        {
            System.Console.WriteLine("Hava sıcak");
        }
        else
        {
            System.Console.WriteLine("Hava normal");
        }

    }
}
enum Gunler
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum Gunler2
{
    Pazartesi = 1,
    Sali,
    Carsamba,
    Persembe=23,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk=5,
    
    Soguk=5,
    Normal=20,
    Soguk=5,
    Sicak=25,
    CokSicak=30
}
