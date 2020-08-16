using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPizzaOtomasyonu.Model
{
    public class Malzeme
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public List<Malzeme> getirMalzeme()
        {
            List<Malzeme> malzemeler = new List<Malzeme>()
            {
                new Malzeme {Id = 1 , Adi = "Dana Janbon"},
                new Malzeme {Id = 2 , Adi = "Sosis"},
                new Malzeme {Id = 3 , Adi = "Mantar"},
                new Malzeme {Id = 4 , Adi = "Mısır"},
                new Malzeme {Id = 5 , Adi = "Ançüez"},
                new Malzeme {Id = 6 , Adi = "Kabak"},
                new Malzeme {Id = 7 , Adi = "Zeytin"},
                new Malzeme {Id = 8 , Adi = "Salam"},
                new Malzeme {Id = 9 , Adi = "Sucuk"},
                new Malzeme {Id = 10 , Adi = "Ton Balığı"},
                new Malzeme {Id = 11 , Adi = "Peynir"}
            };

            return malzemeler;
        }
    }
}
