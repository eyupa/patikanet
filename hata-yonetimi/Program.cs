// See https://aka.ms/new-console-template for more information
// try
// {
//     System.Console.WriteLine("bir sayi giriniz");
//     int sayi = Convert.ToInt32(System.Console.ReadLine());
//     System.Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
// }
// catch (System.Exception ex)
// {

//     System.Console.WriteLine("Hata: " + ex.Message);
// }
// finally
// {
//     System.Console.WriteLine("İşlem tamamlandı");
// }

try
{
    System.Console.WriteLine("bir sayi giriniz");
    int sayi = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
    // int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse(" -2000000000");

}
catch (ArgumentNullException ex)
{
    System.Console.WriteLine("Hata : Boş Değer Girdiniz");
    System.Console.WriteLine(ex.Message);

}

catch (FormatException ex)
{
    System.Console.WriteLine("veri tipi uygun değil");
    System.Console.WriteLine(ex);
}
catch (OverflowException)
{

    System.Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz");
}

finally
{
    System.Console.WriteLine("İşlem tamamlandı");
}