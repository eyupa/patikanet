// See https://aka.ms/new-console-template for more information
//ekrandan girilen sayi kadar olan tek sayilari ekrana yazdiran program
// System.Console.WriteLine("bir sayi giriniz");
// int sayac = int.Parse(Console.ReadLine());
// for (int i = 0; i <= sayac; i++)
// {
//     if (i%2==1)
//     {
//         System.Console.WriteLine(i);
//     }
// }


// int tt=0, ct=0;
// for (int i = 0; i <=1000 ; i++)
// {
//     if (i%2==1)
//     {
//         tt = tt+i;
//     }else
//     {
//         ct = ct+i;
//     }
// }

// System.Console.WriteLine(ct+"çift toplam");
// System.Console.WriteLine(tt+"tek toplam");

//break
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue;

    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i % 2 < 1)
    {
        break;

    }
    Console.WriteLine(i);
}


