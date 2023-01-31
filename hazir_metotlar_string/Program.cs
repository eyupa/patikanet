namespace hazir_metotlar_string;
class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
        // Length
        Console.WriteLine(degisken.Length);
        System.Console.WriteLine("----");

        // ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        System.Console.WriteLine("----");

        // Concat
        string degisken2 = "Merhaba";
        Console.WriteLine(String.Concat(degisken, " ", degisken2));

        System.Console.WriteLine("----");
        // Compare, CompareTo
        string compare1 = "hello world";
        string compare2 = "Hello World";

        Console.WriteLine(compare2.CompareTo(compare1));
        System.Console.WriteLine(String.Compare(compare1, compare2, false));
        System.Console.WriteLine(String.Compare(compare1, compare2, true));
        System.Console.WriteLine("----");

        //contains
        System.Console.WriteLine("contains");
        System.Console.WriteLine(compare1.Contains("hello"));
        System.Console.WriteLine(compare1.EndsWith("world"));
        System.Console.WriteLine(compare1.StartsWith("hello"));
        System.Console.WriteLine("----");

        System.Console.WriteLine("");
        System.Console.WriteLine("index of");
        System.Console.WriteLine(compare1.IndexOf("ll"));
        System.Console.WriteLine(compare1.IndexOf("zz"));
        System.Console.WriteLine("----");

        System.Console.WriteLine("Insert");
        System.Console.WriteLine(compare1.Insert(0, "eyup"));
        System.Console.WriteLine(compare2.LastIndexOf("d"));
        System.Console.WriteLine("----");
        System.Console.WriteLine("padleft padRight");

        System.Console.WriteLine(compare1 + compare2.PadLeft(30, '*'));
        System.Console.WriteLine(compare1.PadRight(15, '-') + compare2.PadLeft(30, '*'));


        System.Console.WriteLine("----");

        //remove

        System.Console.WriteLine("remove");

        System.Console.WriteLine(compare1.Remove(10));
        System.Console.WriteLine(compare1.Remove(5, 2));
        System.Console.WriteLine(compare1.Remove(0, 2));

        System.Console.WriteLine("---");
        System.Console.WriteLine(compare1.Replace("hello", "merhaba c#"));
        System.Console.WriteLine(compare1.Replace(' ', '*'));
        System.Console.WriteLine("---");
        System.Console.WriteLine("split");
        System.Console.WriteLine(degisken.Split(' ')[2]);

        System.Console.WriteLine("substring");

        System.Console.WriteLine(degisken.Substring(5));
        System.Console.WriteLine(degisken.Substring(5,10));


      










}
}
