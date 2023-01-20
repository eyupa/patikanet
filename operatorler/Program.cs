// See https://aka.ms/new-console-template for more information
Console.WriteLine("Buraya bir toplama işlemi yapalim \n lütfen birinci sayiyi giriniz:");

int a, b;
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("lütfen ikinci sayiyi giriniz:");
b=Convert.ToInt32(Console.ReadLine());
int c=a+b;
Console.WriteLine("Toplam: "+c);

Console.WriteLine("Şimdi de bir çıkarma işlemi yapalim \n lütfen birinci sayiyi giriniz:");

int d, e;
d=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("lütfen ikinci sayiyi giriniz:");
e=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Çıkarma: "+(d-e));

Console.WriteLine("Şimdi de bir çarpma işlemi yapalim \n lütfen birinci sayiyi giriniz:");
int f, g;
f=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("lütfen ikinci sayiyi giriniz:");
g=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Çarpma: "+(f*g));
Console.WriteLine("Şimdi de bir bölme işlemi yapalim \n lütfen birinci sayiyi giriniz:");
int h, i;
h=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("lütfen ikinci sayiyi giriniz:");
i=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bölme: "+(h/i));
Console.WriteLine("Şimdi de bir mod alma işlemi yapalim \n lütfen birinci sayiyi giriniz:");
int j, k;
j=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("lütfen ikinci sayiyi giriniz:");
k=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mod: "+(j%k));
