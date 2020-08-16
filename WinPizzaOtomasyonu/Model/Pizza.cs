using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPizzaOtomasyonu.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }

        public List<Pizza> getirPizza()
        {
            List<Pizza> pizzalar = new List<Pizza>()
            {
                new Pizza {Id = 1,Adi = "Klasik",Fiyat = 14 },
                new Pizza {Id = 2,Adi = "Karışık",Fiyat = 17 },
                new Pizza {Id = 3,Adi = "Extravaganza",Fiyat = 21 },
                new Pizza {Id = 4,Adi = "Italiano",Fiyat = 20 },
                new Pizza {Id = 5,Adi = "Turkish",Fiyat = 23 },
                new Pizza {Id = 6,Adi = "Tuna",Fiyat = 18 },
                new Pizza {Id = 7,Adi = "Seafood",Fiyat = 19 },
                new Pizza {Id = 8,Adi = "Kastamonu",Fiyat = 20 },
                new Pizza {Id = 9,Adi = "Calypso",Fiyat = 24 },
                new Pizza {Id = 10,Adi = "Akdeniz",Fiyat = 21 },
                new Pizza {Id = 11,Adi = "Karadeniz",Fiyat = 21 }
            };
            return pizzalar;
        }
    }
}
