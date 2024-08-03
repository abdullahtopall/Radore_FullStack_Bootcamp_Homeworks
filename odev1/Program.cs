using odev1.concretes;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenelMudur genelMudur = new GenelMudur();
            genelMudur.name = "Ali";
            genelMudur.surName = "Demir";
            genelMudur.title = "Genel Müdür";
            genelMudur.salary = 80000.0;

            Mudur mudur = new Mudur();
            mudur.name = "Ali";
            mudur.surName = "Demir";
            mudur.title = "Genel Müdür";
            mudur.salary = 60000.0;

            Programci programci = new Programci();
            programci.name = "Ali";
            programci.surName = "Demir";
            programci.title = "Genel Müdür";
            programci.salary = 40000.0;

            Stajyer stajyer = new Stajyer();
            stajyer.name = "Ali";
            stajyer.surName = "Demir";
            stajyer.title = "Genel Müdür";
            stajyer.salary = 5000.0;

            Hesaplamalar hesaplamalar = new Hesaplamalar();

            Calisan[] calisanlar = new Calisan[] { genelMudur, mudur, programci, stajyer };
            double toplamMaaslar = hesaplamalar.tumMaaslariHesapla(calisanlar);
            Console.WriteLine(toplamMaaslar);

            Console.WriteLine("Hello, World!");
        }
    }
}
