// See https://aka.ms/new-console-template for more information

//string mesaj = "Selam";
//Console.WriteLine(mesaj);
//Console.WriteLine(mesaj);
//Console.WriteLine(mesaj);
//Console.WriteLine(mesaj);
//Console.WriteLine(mesaj);
//Console.WriteLine(mesaj);


//double tutar = 100000;
//Console.WriteLine(tutar*0.18);


//int sayi = 100;
//bool girisYapmisMi=false;

//Diziler /array

using Business.Concrete;
using Entities.Concrete;

string[] ogrenciler = new string[3];
ogrenciler[0] = "Deniz";
ogrenciler[1] = "Bahar";
ogrenciler[2] = "Ece";
ogrenciler =new string[4];
ogrenciler[3] = "Su";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = { "Ankara", "adana", "Bursa" };
string[] sehirler2 = { "İst", "Ant", "izmir" };
sehirler2 = sehirler1;
sehirler1[0] = "Muğla";
Console.WriteLine(sehirler2[0]);

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//ceneric collection
List<string> sehirler3 = new List<string> { "İst 1", "Ant 2", "izmir 3" };
sehirler3.Add("adana");
foreach (var sehir in sehirler3)
{
    Console.WriteLine(sehir);
}

Person person1= new Person();
person1.firstName = "Deniz";

SelamVer("Deniz");
SelamVer("Merve");
SelamVer();

int sonuc = topla(3,5);

Vatandas vatandas1 = new Vatandas();

PttManager pttManager = new PttManager(new ForeignerManager());
pttManager.GiveMask(person1);


Console.ReadLine();

//resharper
static void SelamVer(string isim="İsimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

//default parametreler sona yazılır
static int topla(int sayi1=5 , int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: "+ sonuc);
    return sonuc;
}

public class Vatandas
{
    public string Ad  { get; set; }
    public string Soyad  { get; set; }
    public int DogumYili { get; set; }
    public long Tc { get; set; }

 //   public string ad = "Deniz";
	//public string soyad = "Alan";
	//public int dogumyili = 1991;
	//public long tcNo = 12345678910;
}