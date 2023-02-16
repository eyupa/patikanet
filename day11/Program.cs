namespace day11;
class Program
{
    static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();
        Random rastgele = new Random();


        for (int i = 0; i < 6; i++)
        {
            arr.Add(new List<int>());
            for (int j = 0; j < 6; j++)
            {
                arr[i].Add(rastgele.Next(-10,0));
            }
        }
        foreach (var item in arr)
        {
            foreach (var item2 in item)
            {
                Console.Write(item2 + " ");
            }
            Console.WriteLine();
        }
        int count = 0;
        int toplam = 0;
        int max = -100;
        for (int i = 0; i < arr.Count - 2; i++)
        {
            for (int j = 0; j < arr[i].Count - 2; j++)
            {

                toplam = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                System.Console.WriteLine("sayı"+count);
                count++;
                System.Console.WriteLine(arr[i][j] + " " + arr[i][j + 1] + " " + arr[i][j + 2] + " " + "\n" + arr[i + 1][j + 1] + "\n" + arr[i + 2][j] + " " + arr[i + 2][j + 1] + " " + arr[i + 2][j + 2]);
                if (toplam > max)
                {
                    max = toplam;
                }
                System.Console.WriteLine("max:"+max); System.Console.WriteLine("toplam:" + toplam);

            }


        }

System.Console.WriteLine();


    }
}





