using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPizzaOtomasyonu.Model
{
    class Sepet
    {
        public Sepet()
        {
            Malzemeler = new List<Malzeme>();
        }
        public Ebat Ebat { get; set; }
        public Pizza Pizza { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
        public HamurTipi HamurTipi { get; set; }
        public int Adet { get; set; }
        public double Tutar { get; set; }
    }
}
