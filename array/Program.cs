// See https://aka.ms/new-console-template for more information
//sort siralma
int[] sayilar = { 1, 5, 3, 2, 4, 56, 65 };
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("*****Sirali Dizi*******");

Array.Sort(sayilar);
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//clear diziyi temizleme
// System.Console.WriteLine("*****Clear Dizi*******");
// Array.Clear(sayilar, 2, 2);
// foreach (var sayi in sayilar)
// {
//     Console.WriteLine(sayi);
// }
//reverse
System.Console.WriteLine("*****Reverse Dizi*******");
Array.Reverse(sayilar);
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//indexof

System.Console.WriteLine("*****Indexof Dizi*******");

int index = Array.IndexOf(sayilar, 56);
System.Console.WriteLine(index);

//resize diziyi yeniden boyutlandırma

System.Console.WriteLine("*****Resize Dizi*******");
Array.Resize<int>(ref sayilar, 8);
sayilar[7] = 99;
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
