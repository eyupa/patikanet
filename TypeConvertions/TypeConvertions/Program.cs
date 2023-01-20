// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type Convertions");

System.Console.WriteLine("implicit type convertion");
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;
System.Console.WriteLine("d: " + d);

long h = d;
System.Console.WriteLine("h: " + h);
float i = h;
System.Console.WriteLine("i: " + i);
string e = "eyup";
char f = 'k';
object g = e + f + d;
System.Console.WriteLine("g: " + g);
//explicit type convertion

System.Console.WriteLine("explicit type convertion");
int x = 4;
byte y = (byte)x;
System.Console.WriteLine("y: " + y);
int z = 300;
byte t = (byte)z;
System.Console.WriteLine("t: " + t);
float w = 10.3f;
byte v = (byte)w;
System.Console.WriteLine("v: " + v);


//tosring method
System.Console.WriteLine("tosring method");
int xx = 6;
string yy = xx.ToString();
System.Console.WriteLine("yy: " + yy);
string zz = 12.5f.ToString();
System.Console.WriteLine("zz: " + zz);
//system convertion
System.Console.WriteLine("system.convert");
string s1 = "10", s2 = "20";
int sayi1, sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
toplam = sayi1 + sayi2;
System.Console.WriteLine("toplam: " + toplam);

//parse method

System.Console.WriteLine("parse method");
ParseMethod();




       static void ParseMethod()
 {
        string metin1 = "10";
        string metin2 = "10.32";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);

        System.Console.WriteLine("rakam1: " + rakam1);
        System.Console.WriteLine("double1: " + double1);
 }

