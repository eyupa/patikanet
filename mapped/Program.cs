internal class Program


{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();
        int mapSize = int.Parse(Console.ReadLine());
        for (int i = 0; i < mapSize; i++)
        {
            string[] namePhone = Console.ReadLine().Split(" ");
            phoneBook.Add(namePhone[0], int.Parse(namePhone[1]));

        }

        while (true)
        {
            string name = Console.ReadLine();
            if (name == null) break;
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }


    }
}