using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1.concretes
{
    public class Hesaplamalar
    {
        public double tumMaaslariHesapla(Calisan[] calisanlar)
        {
            double toplam = 0.0;
            foreach (var calisan in calisanlar)
            {
                toplam += calisan.salary;
            }
            return toplam;
        }
    }
}
