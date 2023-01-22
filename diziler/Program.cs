//dizi tanimlama
string[] renkler= new string[5];

string[] hayvanlar={"Kedi","Köpek","Kuş","Böcek"};

int[] dizi;
dizi = new int[5];


//dizilere deger atama ve erisim

renkler[0]= "Mavi";
dizi[3]= 10;
System.Console.WriteLine(hayvanlar[1]);
System.Console.WriteLine(renkler[2]);
System.Console.WriteLine(dizi[2]);

//donguler dizi kullanimi
//klavyeden girilen n tane sayinin ortalamasini alan program

System.Console.WriteLine("lütfen dizinin eleman sayisini giriniz");
int diziuzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziuzunlugu];
int toplam = 0;
for (int i = 0; i < diziuzunlugu; i++)
{
    System.Console.WriteLine($"lütfen {i+1} sayisini giriniz");
    sayiDizisi[i] = int.Parse(Console.ReadLine());


}

foreach (var sayi in sayiDizisi)
{
    toplam += sayi;
}

System.Console.WriteLine($"Ortalama: {toplam/diziuzunlugu}");

