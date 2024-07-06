
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru(1, "Hngisi programlama dili değildir ? ", new string[4] { "Python", "C#", "Java", "Html" }, "Html");

            var soru2 = new Soru(2, "Hngisi en popüler programlama dilidir ? ", new string[4] { "Python", "C#", "Java", "Html" }, "C#");

            var soru3 = new Soru(3, "Hngisi web programlama platformu değildir ? ", new string[4] { "Python", "Asp.net", "Django", "Spring" }, "Python");

            var soru4 = new Soru(4, "constructor ile soru oluşturuldu mu ", new string[2] { "evet", "hayır" }, "evet");

            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("html"));

            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru3.cevapKontrol("c#"));

            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru4.cevapKontrol("python"));

            Console.WriteLine(soru4.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("evet"));

        }


    }
}

class Soru
{

    public Soru(int soruId, string soruMetni, string[] secenkler, string cevap)
    {
        this.SoruId = soruId;
        this.SoruMetni = soruMetni;
        this.Secenekler = secenkler;
        this.Cevap = cevap;
    }
    private int SoruId { get; set; }
    private string SoruMetni { get; set; }

    private string[] Secenekler { get; set; }

    private string Cevap { get; set; }

    public string SoruYazdir()
    {
        string soru = "";

        soru += this.SoruMetni + "\n";

        foreach (var secenek in this.Secenekler)
        {
            soru += secenek + "\n";
        }

        return soru;
    }


    public bool cevapKontrol(string cevap)
    {
        return this.Cevap.ToLower() == cevap.ToLower();
    }
}