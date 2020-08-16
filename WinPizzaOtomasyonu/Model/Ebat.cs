using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPizzaOtomasyonu.Model
{
    public class Ebat
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Carpan { get; set; }

        public List<Ebat> ebatGetir()
        {
            List<Ebat> ebatlar = new List<Ebat>()
            {
                new Ebat {Id = 1 , Adi = "Küçük", Carpan = 1},
                new Ebat {Id = 2 , Adi = "Orta", Carpan = 1.25},
                new Ebat {Id = 3 , Adi = "Büyük", Carpan = 1.75},
                new Ebat {Id = 4 , Adi = "Maxi", Carpan = 2}
            };

            return ebatlar;
        }
    }
}
