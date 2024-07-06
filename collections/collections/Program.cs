/* ---------------------------------------------ArrayList------------------------------------------------*/
/*
using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            //non-generic => object
            //dinamik dizi tanımlanabilir

            ArrayList liste = new ArrayList(); //arraylist tanımlaması
            liste.Add(10);
            liste.Add("10");
            liste.Add("ali");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList()
            {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            int[] sayilar = { 10, 20, 30 };

            liste.AddRange(sayilar);

            //elemanlara erişmek

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();

            //Console.WriteLine(eleman);
            //Console.WriteLine(isim);


            //insert aracıyla herhangi bir tanımlanan yere eleman eklemek istiyorum

            liste.Insert(1,"bacaksız");
            liste.InsertRange(2,liste2);

            //eleman silmek istediğimizde

            liste.Remove(null); //bulduğu ilk belirtilen elemanı siler

            //belli bir indexteki elemanı silmek istiyorsak
            liste.RemoveAt(2);

            //belli bir başlangıç indeksinden sonra şu kadar elemanı sil demek istersek de 
            liste.RemoveRange(2,3); // 2 numaralı indexten başla 3 tane elemanı sil demek istedik 


            //herangi bir elemanın dizide olup olmadığını contains ya da indexOf aracılığı ile kontrol edebiliriz
            Console.WriteLine(liste.Contains(10)); //cevap true döner

            Console.WriteLine(liste.IndexOf(10)); // ilgili aranan elemanın index numarasını bize verier

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
*/








/* ---------------------------------------------Generic List------------------------------------------------*/

/*
using System.Collections.Generic;
namespace ConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List

            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);

            List<String> isimler = new List<String>()
            {
                "ali",
                "ahmet",
                "ayşe",
                 null
            };

            List<Product> urunler = new List<Product>();

            urunler.Add(new Product()
            {
                Id = 1,
                Title = "Iphone 14",
                Price = 40000

            });

            urunler.Add(new Product()
            {
                Id = 2,
                Title = "Iphone 15",
                Price = 50000

            });

            urunler.Add(new Product()
            {
                Id = 3,
                Title = "Iphone 16",
                Price = 60000

            });

            //eleman eklemek istendiğinde insert ya da insertrange kullanılabilir
            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Iphone 17", Price = 70000 });

            //ürünü silmek istediğimizde removeat index numarasına göre silebilirz
            urunler.RemoveAt(2);

            //ilgili referans adres vererek de silinebilir bunu da direkt remove metodu üzerinden yapabiliriz
            urunler.Remove(urunler[0]); //ürünlerin 0. indexteki elemanını sil dedik bu şekilde iphone 14 bilgisi silindi

            //elemanlara erişilmek istendiğinde bir foreach döngüsü kullanılabilir
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }


        }

        class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
        }
    }
}

*/


/* ---------------------------------------------Dictionary------------------------------------------------*/

using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            // key-value => plaka - şehir

            Dictionary<int,string> plakalar = new Dictionary<int,string>();

            plakalar.Add(20, "Denizli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(35, "İzmir");


            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {4,"Dört"},
            };

            //bu elemanlara erişmek istediğimizde keybilgilerine göre erişiriz
            Console.WriteLine(plakalar[34]);
            if (plakalar.ContainsKey(61))
            {
                Console.WriteLine(plakalar[36]);

            }
            else
            {
                Console.WriteLine("yok");
            }

            //tüm hepsini yazdırmak istediğimizde foreach kullnabiliriz 
            /*
            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka);
            }
            */

            // foreach de de key value mantığı olduğu için değişken tanımlamak yerine direkt dictionary listimizi yazabiliriz

            foreach (KeyValuePair<int,string> plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);

            }

            //liste üzerine bir güncelleme (update ) yapmak istediğimzide ise 

            sayilar[1] = "one";
            Console.WriteLine(sayilar[1]);

            //bir bilgiyi  silmek istediğimizde ise remove metodu ile  key tanımlaması yapabiliriz
            sayilar.Remove(1);

            //eğer tüm elemanları silmek istersek clear metodunu kullanabiliriz
            sayilar.Clear();

            Console.WriteLine(sayilar);

        }
    }
}

