﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_29.Model
{
    [Serializable]

    public class ProdajaNamestaja
    {

        public int Id { get; set; }

        public List<Namestaj> NamestajZaProdaju { get; set; }

        public DateTime DatumProdaje { get; set; }

        public string BrojRacuna { get; set; }

        public string Kupac { get; set; }

        public const double PDV = 0.02;

        public List<DodatnaUsluga> DodatnaUsluga { get; set; }

        public double UkupanIznos { get; set; }

        public Akcija Akcija { get; set; }



    }
}
