namespace odev2a;
class Program
{
    static void Main(string[] args)
    {
        int n, m;
        System.Console.WriteLine("bu uygulama bir sayının bir sayı dizesindeki sayılara eşit ya da tam bölen olduğunu bulur");
        System.Console.WriteLine("kaç sayıyı kontrol etmek istiyorsunuz?");
        n = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("sayılara eşit olacak ya da tam bölecek sayıyı giriniz");
        m = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[n];
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"{i + 1}, sayi");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (dizi[i] % m == 0)
            {
                System.Console.WriteLine($"{dizi[i]} sayısı {m} sayısına eşit ya da tam bölünür");
            }
            else
            {
                System.Console.WriteLine($"{dizi[i]} sayısı {m} sayısına eşit ya da tam bölünmez");
            }
        }
    }
}
