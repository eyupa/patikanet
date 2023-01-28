namespace recursive;
class Program
{
    static void Main(string[] args)
    {


        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
        Console.ReadLine();

        //rekürsif fonksiyon

        //3^4 = 3*3*3*3
        //3^4 = 3*3^3
        Islemler instance = new Islemler();
        int result = instance.power(3, 4);


        Console.WriteLine(result);

        //extension method

        string ifade = "merhaba dünya";

        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        Console.WriteLine(ifade.CheckSpaces());
        if (sonuc)
        {
            System.Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        System.Console.WriteLine(ifade.MakeUpperCase());
        System.Console.WriteLine(ifade.MakeLowerCase());
        arr.SortArray();
        arr.EkranaYazdir();




    }


    public class Islemler
    {
        public int power(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return sayi * power(sayi, us - 1);
        }


    }

}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }


    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {

        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {

        foreach (var item in param)
        {
            System.Console.Write(item+", ");
        }
    }

}





