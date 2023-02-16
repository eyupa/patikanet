namespace chick;
class Program
{
    static void Main(string[] args)
    {
        public static int migratoryBirds(List<int> arr)
        {

            List<int> ar = new List<int>();
            foreach (var item in arr)
            {
                ar.Add(item);
            }

            int biggest = 0;
            int chick = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }

                }
                if (count > biggest)
                {
                    biggest = count;
                    chick = arr[i];

                }
                count = 0;
            }
            switch (switch_on)
            {

               case:1
            }


            return chick;
        }
    }
}
