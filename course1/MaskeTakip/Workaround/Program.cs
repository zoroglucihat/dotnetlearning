//Degiskenler();

//static void Degiskenler()
//{
//    string mesaj = "Merhaba";
//    double tutar = 100_00; //dbden gelir
//    int sayi = 100;
//    bool girisYapmisMi = false;
//    Console.WriteLine(mesaj);

//    string ad = "Cihat";
//    string soyad = "Zoroglu";
//    string dogumYili = "1994";
//    long tcNo = 12345678910;
//}

//Vatandas vatandas1 new Vatandas();
//static void SelamVer(string isim ="No Name")
//{
//    Console.WriteLine("Merhaba " + isim);
//}
//static int Topla()
//{
//    return 5;
//}

//static int Topla(int sayi1, int sayi2)
//{
//    int sonuc = sayi1 + sayi2;

//    Console.WriteLine("Toplam: " + sonuc.ToString());
//    return sonuc;
//}

//SelamVer("Cihat");
//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNO { get; set; }
//}


//Array
using Business.Concrete;
using Entities.Concrete;
using System;

string[] ogrenciler = new string[3];
ogrenciler[0] = "Ali";
ogrenciler[1] = "Veli";
ogrenciler[2] = "Ayşe";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
//Stack Heap'te yer açmadıysan NullReference Exception hatası alırsın.
//Referans tipi Array, Class, abstract bunlar hep referans tipli
string[] sehirler1 = new[] { "Ankara", "Istanbul", "Yozgat" };

foreach (string s in sehirler1)
{
    Console.WriteLine($"{s}");
    Console.WriteLine("------");
}

//Collections

List<string> yeniSehirler1 = new List<string> { "Ankara", "Istanbul", "Yozgat" };
yeniSehirler1.Add("Ankara");
foreach (string s in yeniSehirler1)
{
    Console.WriteLine($"{s}");
}

Person person1 = new Person();
person1.FirstName = "Cihat";
person1.LastName = "Zoroglu";
person1.DateOfBirthYear = 1994;
person1.NationalIdentity = 12333243;


PttManager pttManager =  new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.ReadLine();
