//var kdvOrani = 1.08;
//var urunA = 5000;
//var urunB = 6000;
//var urunC = 7000;
//var urunD = 5500;



//Console.WriteLine(urunA * kdvOrani); //urunA
//Console.WriteLine(urunB * kdvOrani); //urunB
//Console.WriteLine(urunC * kdvOrani); //urunC
//Console.WriteLine(urunD * kdvOrani); //urunD


/*Değişken tanımlama kuralları*/
//değişken tanımlarken boşluk içermemelidir
// değişken tanımlarken sayı ile başlayamaz
//camelCase yapısına sahiptir
//Büyük - küçük harf duyarlılığı vardır

/*
var sayi = 20;
var urun_adi = "Samsung S23";
//var urunAdi = "Samsung S23";

var sayi2 = 30;
sayi2 = 50;
var sayi3 = 50;

var fiyat = 1000.25;

var satistaMi = true;

var ogrenciNo = "1025";



Console.WriteLine(sayi);
Console.WriteLine(urun_adi);
Console.WriteLine(sayi2);
Console.WriteLine(sayi3);
Console.WriteLine(fiyat);
Console.WriteLine(satistaMi);
Console.WriteLine(ogrenciNo);
*/




/*--------------------------            UYGULAMA    -------------------------------*/


/*
    Uygulama 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri doldurunuz

    Öğrenci adı
    Öğrenci soyadı
    Öğrenci ad ve soyad
    Öğrenci numarası
    Öğrenci cinsiyet
    Öğrenci tc kimlik
    Öğrenci doğum yılı
    Öğrenci adres bilgisi
    Öğrenci yaşı



    Uygulama 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız
    
    Ürün 1 => 50     TL
    Ürün 2 => 60,5   TL
    Ürün 3 => 356.45 TL   

 */

//Uygulama 1

//var ogr_ad = "Enes";
//var ogr_soyad = "Bacaksız";
//var ogrAdSoyad = "Enes Bacaksız";
//var ogrNo = "20410082505";
//var ogrCinsiyet = "Erkek";
//var ogrTc = "11111111111";
//var ogr_dogum_yili = "2000";
//var ogrAdres = "Ankara / Çankaya";
//var ogrYas = 24;

//Console.WriteLine(ogr_ad + ogr_soyad + "\n" + ogrAdSoyad + "\n" + ogrNo + "\n" + ogrCinsiyet + "\n" + ogrTc + "\n" + ogr_dogum_yili + "\n" + ogrAdres + "\n" + ogrYas);

//Console.WriteLine("\n" + "\n");

////Uygulama 2 

//var urun1 = 50;
//var urun2 = 60.5;
//var urun3 = 356.45;

//var toplam = urun1 + urun2 + urun3;
//Console.WriteLine(toplam);



/* C# Veri tipleri*/
/*
    value types:
    Tam sayı :              byte, short ,int, long
    Ondalıklı sayılar :     float,double,decimal
    Diğer veri tipleri :    char, boolean, struct

    reference types:
    string,class,array,interface


 */

//int sayi = 10;
//float kdvOrani = 1.18f;
//char cinsiyet = 'E';
//string cinsiyet2 = "Kadın";
//string urunAdi = "Samsung S23";
//var satistaMi = false;


/*

Veri tipi dönüşümüne neden ihtiyaç duyarız

 */

//Console.Write("1. sayı ");


//var sayi1 = Console.ReadLine(); ;

//Console.Write("2. sayı ");


//var sayi2 = Console.ReadLine(); ;

//var toplam = sayi2 + sayi2;
//Console.Write(toplam);


/*
veri tipi dönüşümü
//implicit casting --> bilinçsiz tür dönüşümü
// explicit casting --> bilinçli tür döüşümü
 */

//int a = 10;
//long b = a;

//long d = 20;
//int e = (int)d;

//double f = 20.5;
//float g = (float)f;

//double h = 10.5;
//int i = (int)h;





//string to int

//Console.Write("1. sayı ");


//var sayi1 = Convert.ToInt32(Console.ReadLine()); 

//Console.Write("2. sayı ");


//var sayi2 = Convert.ToInt32(Console.ReadLine());

//var toplam = sayi1 + sayi2;
//Console.WriteLine(toplam);



/*
    Nullable types 
 */

//int? a = null;


//Console.WriteLine(a.HasValue);
//HasValue => değer var mı yok mu diye bakar geriye true ya da false döner
//Console.WriteLine(a.GetValueOrDefault());







/*STRİNG VE DATE*/

// string => karakter dizileri 
//string cinsiet = "Erkek";

/*
Console.Write("Adı: ");
string ad = Console.ReadLine();

Console.Write("Soyadı: ");
string soyad = Console.ReadLine();

Console.Write("Yaşı: ");
string yas = Console.ReadLine();
*/


//string concat
//string mesaj = ad + " " + soyad + " " + " isimli kişi " +  yas + " yaşındadır";




//string interpolation
/*
string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır";

Console.WriteLine(mesaj);
*/

/*String metotları */

/*
     

 */

//string mesaj = $"Enes Bacaksız isimli kişi 24 yaşındadır.";

//int sonuc = mesaj.Length; //stringin kaç karakterkden olduğunu gösterir

//var sonuc = mesaj.ToLower(); //bütün karakterler küçük harfe çevrilir

//var sonuc = mesaj.ToUpper(); //bütün karakterler büyük harfe çevrilir

/*var sonuc = mesaj.Trim();*/ //baştaki ve sondaki bütün boşlukları sil 

//var sonuc = mesaj.Split(" ")[3]; // boşluklardan arındırıp kelimeleri diziye göre dizer ve istenileni getirir
//var sonuc = mesaj[3];

//var sonuc = mesaj.StartsWith("Eness"); // ilgili string .... ile mi başlıyor --> true/false

//var sonuc = mesaj.EndsWith("."); // ilgili string .... ile mi bitiyor --> true/false

//var sonuc = mesaj.Contains("Enes"); // ilgili yerde .... var mı diye arar ---> true/false döner

//var sonuc = mesaj.IndexOf("24"); // ilgili stringte .... var mı --> 0 / -1;

//var sonuc = mesaj.Substring(4);

//Console.WriteLine(sonuc);





/*Uygulama Strings*/

//string kursAdi = ".NET 7 ile C# Programlama Dili";

//1- Kaç karaktere sahiptir
/*var sonuc = kursAdi.Length;*/

//2- Hepsini küçük harf yapınız 
/*var sonuc = kursAdi.ToLower();*/

//3- '.' ile mi başlamaktadır
/*var sonuc = kursAdi.StartsWith(".");*/

//4- C# bilgisi hangi konumda bulunmaktadır
//var sonuc = kursAdi.IndexOf("C#");

//5- String 'C#' bilgisini içeriyor mu 
//var sonuc = kursAdi.Contains("C#");

//6- 'Dili' kelimesi yerine dersleri yazınız (replace)
//var sonuc = kursAdi.Replace("Dili", "Dersleri");

//Console.WriteLine(sonuc);



/*DateTime*/

/*
var simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);


DateTime dt = new DateTime(2018,6,10,12,38,55);
DateTime dt2 = dt.AddYears(2);
Console.WriteLine(dt2);

*/






/*Diziler ---- Arrays*/

//Tek boyutlu diziler
/*
string[] adlar = new string[5];

adlar[0] = "Ahmet";
adlar[1] = "Veli";
adlar[2] = "Ayşe";
adlar[3] = "Ali";
adlar[4] = "Mehmet";

string[] adlar  = {"Ahmet","Veli","Ayşe","Ali","Mehmet"}
*/

//Çok boyutlu diziler -->  ???
/*
int[,] sayilar = new int[3, 5];

sayilar[0, 0] = 10;
sayilar[0, 1] = 20;
sayilar[0, 2] = 30;
sayilar[0, 3] = 40;
sayilar[0, 4] = 50;


sayilar[1, 0] = 10;
sayilar[1, 1] = 20;
sayilar[1, 2] = 30;
sayilar[1, 3] = 40;
sayilar[1, 4] = 50;


sayilar[2, 0] = 10;
sayilar[2, 1] = 20;
sayilar[2, 2] = 30;
sayilar[2, 3] = 40;
sayilar[2, 4] = 50;



int[,] sayilar =
{
    {10,20,30,40,50}
    {10,20,30,40,50}
    {10,20,30,40,50}

};
*/



/*Dizi tanımlama tek boyutlu */

//var kursAdi = ".net 7 ile C# propgramlama dersleri".Split(" ");

//string[] isimler = new string[5];

//isimler[0] = "Ahmet";
//isimler[1] = "Ali";
//isimler[2] = "Canan";
//isimler[3] = "Çınar";
//isimler[4] = "Esra";

//int[] numaralar = [ 100, 200, 300, 400, 500 ];


//Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");



/*Dizi metotları     (Array Methods)*/

//string[] sehirler = {"Zonguldak","Rize","Kocaeli"};
//int[] plakalar = { 67, 53, 41 };

////sehirler[0] = "Sakarya";
//sehirler.SetValue("Sakarya",1);

//Console.WriteLine(string.Join("," , sehirler));
//Console.WriteLine(sehirler.Length);
//Console.WriteLine(Array.IndexOf(sehirler, "Rize"));

//Array.Sort(sehirler);    // sort metotu verilen arrayi alfabetik sıralar
//Console.WriteLine(string.Join(",", sehirler));

//Array.Sort(plakalar);
//Console.WriteLine(string.Join(" , " , plakalar));


////silme işlemleri

//Array.Clear(sehirler);

//Console.WriteLine(sehirler.GetValue(0));



// dizi parçalama işlemi   array slicing
/*

string[] sehirler = { "zonguldak", "rize", "kocaeli", "istanbul","ankara" };

//var sonuc = sehirler[0..3];

foreach (var sehir in sehirler[0..3])
{
    Console.WriteLine(sehir);
}

Console.WriteLine("-------------------------------------");

foreach (var sehir in sehirler[..3])
{
    Console.WriteLine(sehir);
}

Console.WriteLine("-------------------------------------");


foreach (var sehir in sehirler[2..])
{
    Console.WriteLine(sehir);
}

//Console.WriteLine(sonuc[0]);
//Console.WriteLine(sonuc[1]);
//Console.WriteLine(sonuc[2]);
*/


/*Uygulama Diziler*/

//öğrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerle doldurunuz (3 öğrenci)

//öğrenciler dizisi kaç elemandır yazdırınız

//ilk 2 elemanın ad ve not bilgisini yazdırınız

//tüm öğrencilerin not ortalaması nedir?


/*
var ogrenciler = new string[3];
var notlar = new int[3];

Console.Write("1. öğrenci adı : ");
ogrenciler[0] = Console.ReadLine() ?? "";  //?? "" olası bir boş olma durumunda ?? opeartörü default tanımlamaya olanak tanıdr

Console.Write("1. öğrenci notu : ");
notlar[0] = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("2. öğrenci adı : ");
ogrenciler[1] = Console.ReadLine() ?? "";

Console.Write("2. öğrenci notu : ");
notlar[1] = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("3. öğrenci adı : ");
ogrenciler[2] = Console.ReadLine() ?? "";

Console.Write("3. öğrenci notu : ");
notlar[2] = Convert.ToInt32(Console.ReadLine() ?? "");



foreach (var ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}


foreach (var not in notlar)
{
    Console.WriteLine(not);
}


Console.WriteLine(ogrenciler.Length);


foreach (var ogrenci in ogrenciler[..2])
{
    Console.WriteLine(ogrenci);
}


foreach (var not in notlar[..2])
{
    Console.WriteLine(not);
}


var not1 = notlar[0];
var not2 = notlar[1];
var not3 = notlar[2];

var ortalama = (not1 + not2 + not3) / 3;

Console.WriteLine("ORTALAMA = " + ortalama);
*/


/*Çok boyutlu diziler*/

// Ali => 50,60,70
// Ahmet => 60,80,90
// Canan => 50,70,30

// Her öğrencinin not ortalmasını hesaplayınız

/*

string[] ogrenciler = { "Ali", "Ahmet", "Canan" };
int[,] notlar = new int[3, 3];

//ali
notlar[0, 0] = 50;
notlar[0, 1] = 60;
notlar[0, 2] = 70;

//ahmet
notlar[1, 0] = 60;
notlar[1, 1] = 80;
notlar[1, 2] = 90;

//canan
notlar[2, 0] = 50;
notlar[2, 1] = 70;
notlar[2, 2] = 30;

var ortalama_1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
var ortalama_2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
var ortalama_3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;


Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1} ");
Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2} ");
Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3} ");
*/


/*Referans tipler */

//int[] x = { 10, 20 };
//int[] y = x;
//Console.WriteLine(x[0]);  //10
//Console.WriteLine(y[0]);  //10

//x[0] = 20;

//Console.WriteLine(x[0]);  //20
//Console.WriteLine(y[0]);  //20



/*OPERATORLER*/
/*Aritmetik Operatörler*/

/*
 a++    --->     a=a+1
 a-    --->      a=a-1

    int a = 2
    
    int b = a++;

    a = 3    b =2


    int a = 2

    int b = ++a;

    a = 3    b =3
 */

//var a = 10;
//var b = 5;
//var c = 2;

//var sonuc = a + b ;
//var sonuc = a - b;
//var sonuc = a * b;
//var sonuc = (float)a / (float)b;
//var sonuc = (a + b) * c;
//var sonuc = a % b;
/*var sonuc = a++;*/  //10
                      //var sonuc = ++a; //11


//Console.WriteLine(sonuc);

/*Uygulama aritmetik operatörler*/

// a =10, b=5, c=20 ise c-a farkının b katı kaçtır?

/*
var a = 10;
var b = 5;
var c = 20;

var sonuc = (c - a) * b;
Console.WriteLine(sonuc);
*/

//int? a =50; int b = 20 ise a+b değerini hesaplayınız. (eğer a null ise sonuç nedir?)

/*
int? a = 50;
int b = 20;

var sonuc = a + b;
Console.WriteLine(sonuc);
*/

/*
int? a = null;
int b = 20;

//eğer a değeri null ise sonuç boş döner
var sonuc = (a ?? 0) + b;
Console.WriteLine(sonuc);
*/



//a = 10 b=20 ise a=b--; atamasından sonra a ve b değerleri ne olur ?

/*
int a = 10;
int b = 20;
a = b--;

Console.WriteLine(a); //20
Console.WriteLine(b); //19
*/




// klavyeden girilen sayının tek / çift kontrolünü yapınız

/*

Console.Write("sayıyı giriniz ");
int s1 = int.Parse(Console.ReadLine() ?? "0");

var sonuc = s1%2;
Console.WriteLine(sonuc);  // sonuc 1 ise sayı te , 0 ise sayı çift

*/


/*Atama Operatorleri*/
/*

var a = 6;
var b = 10;
a += b; // a = a + b
a += 5; // a = a + 5
a -= b; // a = a - b
a *= b; // a = a * b
a /= b; // a = a / b
a %= b; // a = a % b

//MATH 
double sonuc;

sonuc = Math.Pow(2, 3); // 2 üzeri 3 
sonuc = Math.Sqrt(25); //karekök alır
sonuc = Math.Abs(-10); // mutlak değer alma
sonuc = Math.Round(4.5); // yuvarlama işlemi yapar
sonuc = Math.Ceiling(3.4); // her zaman yukarı yuvarlar
sonuc = Math.Floor(4.6); // her zaman aşağı yuvarlar
sonuc = Math.Max(10, 20); //girilen değerlerden büyük olanı karşına çıkar
sonuc = Math.Min(10, 20); //girilen değerlerden küçük olanı karşına çıkar
Console.Write(sonuc);

*/

/*Karşılaştırma Operatörleri*/

/*
int a = 5, b = 5, c = 10, d = 3;
string username = "enesbacaksiz";
string password = "1234";


var sonuc = (a == b); // true
sonuc = (c == d);
sonuc = username == "enesbacaksiz"; //true
sonuc = password == "12345";       // false

sonuc = (a != b);
sonuc = (a > c);
sonuc = (a < c);
sonuc = (a >= b);
//ternary
var sonuc2 = (a > b) ? "a büyük" : "b büyük";

Console.WriteLine(sonuc);
Console.WriteLine(sonuc2);

*/


/*Uygulama Karşılaştırma Operatorleri*/

// Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.

/*
Console.WriteLine("Yaşınızı giriniz");
int yas = int.Parse(Console.ReadLine());
var sonuc = (yas > 18) ? "Oy kullanabilir" : "Oy kullanamaz";
Console.WriteLine(sonuc);
*/


// Girilen bir sayının işaretini kontrol ediniz.
/*

Console.WriteLine("Sayıyı griniiz");
var sayi = Convert.ToInt32(Console.ReadLine());

var sonuc = sayi>0 ? "+" : "-";
Console.WriteLine(sonuc);
*/

// Girilen bir sayının tek/çift durumunu kontrol ediniz

/*

Console.WriteLine("Sayı giriniz");

int sayi = int.Parse(Console.ReadLine());
var sonuc = sayi % 2 == 0 ? "girilen sayı çifttir" : "girilen sayı tektir";
Console.WriteLine(sonuc);
*/




/*Mantıksal Operatörler*/

/*
 
    && => ve => true && true   => true
                true && false  => false
                false && false => false


    || => veya =>  true || true   => true
                   true || false  => true
                   false || false => false


    ! => değil => !(true)  => false
                  !(false) => true
 */


/*
var a = true;
var b = true;
var c = false;
var d = false;

//1 - ve - -&&

var sonuc = (a && b);
sonuc = (a && c);


//2 - veya - ||

sonuc = (a || b);
sonuc = (b || d);

//3 - değil - !
sonuc = !a;
sonuc = !d;


Console.WriteLine(sonuc);
*/


/*Mantıksal Operatörler Uygulama*/

// 1- Yaşı 18 ' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz

/*
Console.Write("Yaşınızı giriniz: ");
var yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veli izni var mı? (evet/hayır)");
string cevap = Console.ReadLine().Trim().ToLower(); 

bool onay = cevap == "evet"; 

var sonuc = (yas > 18) || onay ? "çalışabilir" : "çalışamaz";
Console.WriteLine("DURUMU : " + sonuc);
*/



// 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

/*
Console.Write("Ders notunuzu giriniz. ");
var not = Convert.ToInt32(Console.ReadLine());
var sonuc = (not >= 50) ? "geçti" : "kaldı";
Console.WriteLine(sonuc);
*/

// 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz

/*
Console.Write("Ders ortalamanızı giriniz ");
var ort = Convert.ToInt32(Console.ReadLine());

Console.Write("Hiç zayıfın var mı ? (evet/hayır) ");
string cevap = Console.ReadLine().Trim().ToLower();
bool onay = cevap == "hayır";

var sonuc = (ort >= 70) && onay ? "Teşekkür belgesi almaya hak kazandınız" : "Maalesef herhangi belge alamadınız";
Console.WriteLine(sonuc);
*/


// 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol edinizç Sigara kullanmama koşulu

/*
Console.Write("Ne mezunusunuz? ");
var cevap1 = Console.ReadLine();

Console.Write("Sigara kullanıyor musunuz ");
string cevap2 = Console.ReadLine().Trim().ToLower();
bool onay = cevap2 == "hayır";

var sonuc = (cevap1 == "lisans" || cevap1 == "önlisans") && onay ? "Aramıza hoşgeldiniz" : "Maalesef işe alınmadınız";
Console.WriteLine(sonuc);
*/


// 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım 

/*
Console.WriteLine("Kullanıcı adı ya da parolanızı giriniz ");
var userpass = Console.ReadLine();

var sonuc = userpass =="enesbacaksiz" ||+ userpass =="12345" ? "hoşgeldiniz" : "hatalı giriş";
Console.WriteLine(sonuc);
*/


/*RANDOM */
//nesne oluşturmak için new keywordu gereklidir

/*
var rnd = new Random();

int sayi = rnd.Next(1,100); //rastgele tam sayı üretir

Console.Write(sayi);
*/


/*
string[] takimlar = { "Fenerbahçe", "Beşiktaş", "Denizlispor", "Galatasaray" };
var random = new Random();
int sayi = random.Next(takimlar.Length);

Console.WriteLine(sayi);
Console.WriteLine(takimlar[sayi]);
*/



/*KOŞULLU BLOKLAR*/

/*if/else bloğu*/

// soru
//soru
// diğer
/*
string username = "enesbacaksiz";
string password = "12345";


if (username == "enesbacaksiz")
{
    if (password == "12345")
    {
        Console.WriteLine("Merhaba BTK AKADEMİ");
    }
    else
    {
        Console.WriteLine("Parola yanlış ");
    }
}
else
{
    Console.WriteLine("Username hatalı ");
}
*/

/*if/else/else if*/

/*
string username = "enesbacaksiz";
string password = "12345";

if (username != "enesbacaksiz")
{
    Console.WriteLine("username yanlış");
} else if (password != "12345")
{
    Console.WriteLine("parola yanlış");
}
else
{
    Console.WriteLine("Merhaba BTK AKADEMİ");
}
*/

/*
int x = 10;
int y = 20;

if (x > y)
{
    Console.WriteLine("X y den büyük");
}
else if (x == y)
{
    Console.WriteLine("x y ye eşit");
}
else
{
    Console.WriteLine("x y den küçük");
}
*/




/*Uygulama if else - 1*/

// 1- Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız

/*
Console.Write("a sayısını giriniz ");
var a = Convert.ToInt32(Console.ReadLine());

Console.Write("b sayısını giriniz ");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak istediğiiz işlemi seçiniz :");
Console.WriteLine("1. Topla");
Console.WriteLine("2. Çıkar");
Console.WriteLine("3. Çarp");
Console.WriteLine("4. Böl");

string secim = Console.ReadLine();


if (secim == "1")
{
    var sonuc = a + b;
    Console.WriteLine(sonuc);
}
else if (secim == "2")
{
    var sonuc = a - b;
    Console.WriteLine(sonuc);
}
else if (secim == "3")
{
    var sonuc = a * b;
    Console.WriteLine(sonuc);
}
else if (secim == "4")
{
    var sonuc = a / b;
    Console.WriteLine(sonuc);
}
else
{
    Console.WriteLine("Geçerli sayı girilmedi");
}
*/



// 2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazın

// 0     -   24   => 0
// 25    -   44   => 0
// 45    -   54   => 0
// 55    -   69   => 0
// 70    -   84   => 0
// 85    -   100  => 0


/*
Console.Write("1. sınav notunuzu giriniz: ");
var sinav1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sınav notunuzu giriniz: ");
var sinav2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sözlü notunuzu giriniz: ");
var sozlu = Convert.ToInt32(Console.ReadLine());

int ort = (sinav1 + sinav2 + sozlu) / 3;

Console.Write("Ortalamanız: " + ort);

if (ort >= 0 && ort <= 24)
{
    Console.WriteLine("Karşılık gelen not bilgisi :  0" );
}
else if (ort >= 25 && ort <= 44)
{
    Console.WriteLine("Karşılık gelen not bilgisi :  1");

}
else if (ort >= 45 && ort <= 54)
{
    Console.WriteLine("Karşılık gelen not bilgisi :  2");

}
else if (ort >= 55 && ort <= 69)
{
    Console.WriteLine("Karşılık gelen not bilgisi :  3");

}
else if (ort >= 70 && ort <= 89)
{
    Console.WriteLine("Karşılık gelen not bilgisi :  4");

}
else if (ort >= 89 && ort <= 100)
{
    Console.WriteLine(" Karşılık gelen not bilgisi :  5");

}
else
{
    Console.WriteLine("Öğrenci sınava girmemiştir");
}
*/



// 3- Girilen 2 sayıdan en büyüğünü alınız

/*
Console.Write("İlk sayıyı giriniz ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayıyı giriniz ");
var sayi2 = Convert.ToInt32(Console.ReadLine());


if (sayi1 > sayi2)
{
    Console.WriteLine("sayi 1 sayı 2 den daha büyüktür " + " " + sayi1);
}
else if (sayi1 < sayi2)
{
    Console.WriteLine("sayi 2 sayı 1 den daha büyüktür " + " " + sayi2);
}
else
{
    Console.WriteLine("Sayılar eşittir " + sayi1 + " " + sayi2);
}

*/

/*********************************************************************************/
// 4- Girilen 3 sayıdan en büyüğünü alınız



/*SWITCH*/

//switch-case

/*
Console.WriteLine("gün giriniz 0 dan başlar 0 => pazar");
var gun = Convert.ToInt32(Console.ReadLine()); // 0 => pazar 1 => pazartesi ... 6 => cumartesi

switch (gun)
{
    case 0:
        Console.WriteLine("pazar");
        break;
    case 1:
        Console.WriteLine("pazartesi");
        break;
    case 2:
        Console.WriteLine("salı");
        break;
    case 3:
        Console.WriteLine("çarşamba");
        break;
    case 4:
        Console.WriteLine("perşembe");
        break;
    case 5:
        Console.WriteLine("cuma");
        break;
    case 6:
        Console.WriteLine("cumartesi");
        break;
    default:
        Console.WriteLine("Hatalı gün ");
        break;
}
*/
/*
int ay = 12;

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar");
        break;
    default:
        Console.WriteLine("hatalı ay");
        break;
}
*/


/*TERNARY operatoru*/

/*
int sayi = -10;

var sonuc = (sayi % 2 == 0) ?
                   (sayi > 0) ? "sayı pozitif çift sayı" : "sayı negatif çift sayı" :
                   (sayi>0) ? "sayı pozitif tek" : "sayı negatif tek";
Console.WriteLine(sonuc);
*/




/*DÖNGÜLER*/

/*For döngüsü*/

/*
for (var i = 0; i <= 100; i++)
{
    Console.WriteLine("Enes");
}
*/



//For döngüsü uygulamalar

// 1- "1-100 arasındaki sayıların toplamını hesaplayın


/*
var toplam = 0;
for (var i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        toplam += i;

    }
}
    Console.WriteLine(toplam);
*/



// 2- Klavyeden girilen başlangıç ve bitiş değerleri arasındaki tüm sayıların toplamını hesaplayınız


/*
Console.Write("Başlangıç: ");
var baslangic = Convert.ToInt32(Console.ReadLine());

Console.Write("Bitiş: ");
var bitis = Convert.ToInt32(Console.ReadLine());

Console.Write("Artış Miktarı: ");
var artis = Convert.ToInt32(Console.ReadLine());

var toplam = 0;

for (int i = baslangic; i <= bitis; i = i + artis)
{
    toplam += i;
}

Console.WriteLine(toplam);
*/


// 3- {"ali","ahmet","can","yelda","seda"} dizisindeki tüm elemanları ekrana yazdıerınız

/*
string[] isim = { "ali", "ahmet", "can", "yelda", "seda" };

for (int i = 0; i < isim.Length; i++)
{
    Console.WriteLine(isim[i]);
}
*/


// 4- {1,3,4,34,41,56,89} dizisindeki sayılardan hangisi 3 ün katıdır?

/*
int[] sayilar = { 1, 3, 4, 34, 41, 56, 89 };

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 3 == 0)
    {
        Console.WriteLine(sayilar[i]);
    }
}
*/

/*While Döngüsü*/

/*
var i = 0;

while (i<10)
{
    Console.WriteLine(i);
    i++;
}
*/

/*
string[] isimler = { "ali", "ahmet", "canan" };

var i = 0;
while (i < isimler.Length)
{
    Console.WriteLine(isimler[i]);
    i++;
}
*/

/*
var secim = "e";
var sayac = 1;
var toplam = 0;

while (secim=="e")
{
    Console.WriteLine($"{sayac}. sayı : ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Devam etmek istiyor musunuz ? (e/h) ");
    secim = Console.ReadLine();
    sayac++;
}

Console.WriteLine($"{sayac - 1} adet sayının toplamı =  {toplam}");
*/


/*Break & contiune*/
//contiune --> ilgili yeri alır e döngüye devam eder 
//break --> döngüyü direk bitirir

/*
string isim = "Enes Bacaksız";

for (var i = 0; i < isim.Length; i++)
{
    if (isim[i] == 'e')
        break;
    
    Console.WriteLine(isim[i]);
}

Console.WriteLine("döngü bitti");
*/

/*
int x =0;

while (x < 5)
{
    x++;
    if (x == 3)
    {
        continue;
    }
    Console.WriteLine(x);
}

Console.WriteLine("döngü bitti");
*/


/*Uygulama while döngüsü*/

//sayı tahmin
// 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın
// tanımlanan hak bittiğinde uygulama bitmeli


/*
var rnd = new Random();

int tutulansayi = rnd.Next(1, 100);
int hak = 3;

while (hak > 0)
{
    Console.WriteLine(tutulansayi);
    Console.Write("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if (sayi == tutulansayi)
    {
        Console.WriteLine("TEBRİKLER BİLDİNİZ");
        break;
    }
    else
    {
        if (hak == 0)
        {
            Console.WriteLine("oyun bitti");
            break;
        }
        if (tutulansayi > sayi)
        {
            Console.WriteLine("yukarı");
        }
        else
        {
            Console.WriteLine("aşağı");
        }
    }
}
*/



/*DO WHİLE*/
//herhangi bir koşul olmadan kodlar en az 1 kere çalışır sonraki turların çalışması için while ın true dönmesi gereklidir

//int i = 1;

//do
//{
//    //kodlar
//    Console.WriteLine(i);
//    i++;
//} while (i<10);

/*
Console.Write("adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;
do
{
    Console.Write("Ürün adı ");
    urunler[i] = Console.ReadLine() ?? "ürün adı tanımlanmadı ";

    i++;
} while (adet != i);

Console.WriteLine(" ");
Console.WriteLine("ürünler listeleniyor ...");
Console.WriteLine(" ");


for (int j = 0; j < urunler.Length; j++)
{
    Console.WriteLine(urunler[j]);
}
*/

/*forEach döngüsü*/

string ad = "Ahmet";
//for (var i = 0; i < ad.Length; i++)
//{
//    Console.WriteLine(ad[i]);
//}

/*
foreach (var harf in ad)
{
    Console.WriteLine(harf);
}
*/

/*
int[] sayilar = { 10, 20, 40, 45 };

foreach (var sayi in sayilar)
{
    if (sayi == 20)
    {
        continue;
    }
    Console.WriteLine(sayi);
}
*/




/*DOSYA YÖNETİMİ*/
/*
Stream
File
Directory
Path
 */

