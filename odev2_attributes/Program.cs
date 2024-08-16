using AttributesLibrary;

namespace odev2_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                adi = "Abdullah",
                soyadi = "Topal",
                bolum = "Bilgisayar Mühendisliği"
            };

            Araba araba = new Araba
            {
                marka = "BMW",
                model = "2012"
            };

            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                Console.WriteLine("Bilgilerin girilmesi zorunludur");
            }
            else
            {
                Console.WriteLine("Form başarılı");
            }

            if (!ZorunlulukKontrolu.Dogrula(araba))
            {
                Console.WriteLine("Araba bilgileri eksik");
            }
            else
            {
                Console.WriteLine("Araba bilgileri tamam");
            }
        }
    }
}
