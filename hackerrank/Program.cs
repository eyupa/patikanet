class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for(int i=1; i<=n; i++)
        {
            for(int j=1; j<=n; j++)
            {
                if(j<=n-i)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}