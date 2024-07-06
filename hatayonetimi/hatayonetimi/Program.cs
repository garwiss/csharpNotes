/*---------------------------------------- Hata Yönetimi -------------------------------------------------------*/
/*
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // hata yönetimi exception
            // System.FormatException
            // System.DivideByZeroException
            // System.NullReferenceException
            try
            {
                Console.Write("1. sayı giriniz ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. sayı giriniz ");
                int sayi2 = Convert.ToInt32(Console.ReadLine()); //TryParse -> gelen bilginini inte çevirilip çevrilme olasılığını kontrol edebiliriz

                var sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch (FormatException) //özel hata
            {
                Console.WriteLine("sayısal bilgileri düzgün giriniz");

            }
            catch (DivideByZeroException) //özel hata
            {
                Console.WriteLine("Sayı 2 0 olmamalıdır");
            }
            catch (Exception ex) //genel hata kontrolü
            {
                Console.WriteLine("bir hata oluştu");
                Console.WriteLine(ex.Message);
            }


            // exception handing  hatayı ele almak daha güvenli hale getirme


        }

      
    }
}
*/



/*---------------------------------------- Hata Fırlatma -------------------------------------------------------*/

/*
using System.Linq;

namespace ConsoleApp
{
    class Program
    {

        static void parola_kontrol(string password)
        {
            if (password.Length < 6 || password.Length >10)
            {
                throw new Exception("parola 6-10 karakter aralığında olmalıdır");
            }

            if (!password.Any(char.IsDigit)) //parola içerisindeki herhangi bir karaktere değil ise sorgusu yapılır any metodu ile burada yapılan sorgu ise içinde en az bir sayı içermedlidir diye hata fırlatır
            {
                throw new Exception("PAROLA EN AZ BİR RAKAM İÇERMELİDİR");
            }

            if (!password.Any(char.IsLetter)) //parola içerisindeki herhangi bir karaktere değil ise sorgusu yapılır any metodu ile burada ise içinde en az bir harf içermelidir hata fırlatması yapılır
            {
                throw new Exception("PAROLA EN AZ BİR HARF İÇERMELİDİR");
            }
        }
        static void Main(string[] args)
        {
    
            

            Console.Write("parola: ");
            string parola = Console.ReadLine();


            try
            {
                parola_kontrol(parola);
                Console.WriteLine("parola geçerli");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
*/



/*---------------------------------------- Debug -------------------------------------------------------*/

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi1 = 10;
            var sayi2 = 20;

            var sonuc = Toplam(sayi1, sayi2);

            Console.WriteLine(sonuc);
        }

        static int Toplam(int a, int b)
        {
            var toplam = a + b;
            return toplam;
        }
    }
}
