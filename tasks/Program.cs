class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();



        int count=0;
        int biggest=0;
        foreach( var items in a)
        {
            count++;
        }
        List<int> arr = new List<int>();
        for(int i=0; i<=count; i++)
        {
            biggest=0;
            foreach( var item in a)
            {
                if(item>biggest)
                {
                    biggest=item;
                }
            }
            count--;
            arr[count]=biggest;

        }
        foreach(var item in arr)
        {
            Console.Write(item+" ");
        }

    }
}