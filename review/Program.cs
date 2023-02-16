internal class Program
{
    public static void Main(string[] args)
    {
        int  sayi = Convert.ToInt32(Console.ReadLine());
        string[] inputs = new string[sayi];
        for (int i = 0; i < sayi; i++)
        {
            inputs[i] = Console.ReadLine();
        }
        System.Console.WriteLine(sayi);
        Method method = new Method();
        for (int i = 0; i < sayi; i++)
        {
            string ver = inputs[i];
            method.ayir(ver);

        }



    }


}
class Method
{
    public void ayir(string _inputs)
    {
        string output = "";


        for (int i = 0; i < _inputs.Length; i++)
        {
            if (i % 2 == 0)
            {
                output += _inputs[i];


            }
        }

        output += " ";

        for (int j = 0; j < _inputs.Length; j++)
        {
            if (j % 2 == 1)
            {
                output += _inputs[j];


            }
        }
        System.Console.WriteLine(output);

    }
}