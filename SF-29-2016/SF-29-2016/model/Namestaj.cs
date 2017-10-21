using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016.model
{
    public class Namestaj
    {
        public int ID { get; set; }
        public string Naziv { get; set;}
        public string Sifra { get; set; }
        public double Cena { get; set; }
        public int KolicinaUmagacinu { get; set; }
        public Namestaj TipNamestaja { get; set; }
        public Akcija   Akcija { get; set; }
        public TipNamestaja TipNamestaja { get; set; }

    }
}
