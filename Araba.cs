using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Kullanımı
{
    public class Araba
    {
        public string arabarengi;

        public int arabamodeli;

        public Araba(string _arabarengi, int _arabamodeli)
        {
            arabarengi = _arabarengi;
            arabamodeli = _arabamodeli;

        }

        public void ozellik()
        {
            Console.WriteLine("Araba rengi : " + arabarengi);
            Console.WriteLine("Araba Modeli : " + arabamodeli);
        }

        public void Motorcalistir()
        {
            Console.WriteLine("Motor çalışıyor.....");
        }



    }


}
