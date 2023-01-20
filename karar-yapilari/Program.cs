// See https://aka.ms/new-console-template for more information
Console.WriteLine("öğrencinin notunu giriniz:");
int not = Convert.ToInt32(Console.ReadLine());
if (not >= 90)
{
    Console.WriteLine("AA");
    System.Console.WriteLine("Mükemmel");
}
else if (not >= 80)
{
    Console.WriteLine("BA");
    System.Console.WriteLine("Harika");
}
else if (not >= 70)
{
    Console.WriteLine("BB");
    System.Console.WriteLine("Çok iyi");
}
else if (not >= 60)
{
    Console.WriteLine("CB");
    System.Console.WriteLine("tebrikler");
}
else if (not >= 50)
{
    Console.WriteLine("CC");
    System.Console.WriteLine("Geçtiniz");
}
else if (not >= 40)
{
    Console.WriteLine("DC");
    System.Console.WriteLine("Şartli Geçtiniz");
}
else if (not >= 30)
{
    Console.WriteLine("DD");
    System.Console.WriteLine("Şartli Geçtiniz");
}
else if (not >= 20)
{
    Console.WriteLine("FD");
    System.Console.WriteLine("Kaldınız");
}
else
{
    Console.WriteLine("FF");
    System.Console.WriteLine("geri Kaldınız");
}
