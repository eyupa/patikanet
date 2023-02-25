namespace Koleksiyonlar_Soru_3;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir şeyler yazın");
        string input = System.Console.ReadLine();
        List<string> vowels = new List<string>();
        foreach (var a in input)
        {
            if (a == 'a' || a == 'e' || a == 'ı' || a == 'i' || a == 'o' || a == 'ö' || a == 'u' || a == 'ü')
            {
                vowels.Add(a.ToString());
            }
        }

        // System.Console.WriteLine(input);
        // foreach (var a in vowels)
        // {
        //     System.Console.Write(a+" ");
        // }
        vowels.Sort();

        foreach (var a in vowels)
        {
            System.Console.WriteLine(a);
        }

    }
}
