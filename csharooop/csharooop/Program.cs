namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //class tanımladık => object tanımlamak gerekiyor (ogr1, ogr2)

            Ogrenci ogr1 = new Ogrenci()
            {
                OgrenciNo = "100",
                AdSoyad = "Ada Bilgi",
                Sube = "6/A"
            };

            Ogrenci ogr2 = new Ogrenci()
            {
                OgrenciNo = "200",
                AdSoyad = "Ada Bilgi",
                Sube = "7/A"
            };

            Ogrenci ogr3 = new Ogrenci()
            {
                OgrenciNo = "300",
                AdSoyad = "Çınar Ada",
                Sube = "1/A"
            };



            Ogrenci[] ogrenciler = new Ogrenci[3]
            {
                ogr1,ogr2,ogr3
            };

            foreach (var ogrenci in ogrenciler)
            {
                // Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.AdSoyad} ve şubesi {ogrenci.Sube}");
                string sonuc = ogrenci.BilgileriYazdır();
                Console.WriteLine(sonuc);

            }



        }
    }

    class Ogrenci
    {

        //property => string, int

        public string OgrenciNo { get; set; }

        public string AdSoyad { get; set; }

        public string Sube { get; set; }

        //methods tanımlamaları


        //geriye değer döndürülmediğinde void yazarız döndürülecek değer var ise dönen değerin tipine göre yazarız string int gibi
        public string BilgileriYazdır()
        {
            return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}";


        }
    }
}; 



//ConsoleApp(namespace) => Program(class), Ogrenci(class)
// System => Console
// System.IO => File, Directory, Path
