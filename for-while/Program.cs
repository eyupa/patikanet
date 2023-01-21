// See https://aka.ms/new-console-template for more information
//while
//1'den girilen sayiya kadar ortalama hesaplama programi

System.Console.WriteLine("bir sayi giriniz");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;
}
System.Console.WriteLine(toplam / sayi);

char character = 'a';
while (character < 'z')
{
    System.Console.WriteLine(character);
    character++;
}

System.Console.WriteLine("foreach");

string[] arabalar = { "bmw", "ford", "toyota", "nissan" };
foreach (var item in arabalar)
{
    System.Console.WriteLine(item);
}
