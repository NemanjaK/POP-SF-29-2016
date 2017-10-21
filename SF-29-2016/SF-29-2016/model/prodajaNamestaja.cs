using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016.model
{
    class prodajaNamestaja
    {
        List<Namestaj> NamestajZaProdaju { get; set; }
        public int Id { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string BrojRacuna { get; set; }
        public string kupac { get; set; }
        public List<DodatneUsluge> dodatneusluge { get; set; }
        public double PDV { get; set; }
        public double UkupnaCena { get; set; }
    }
}
