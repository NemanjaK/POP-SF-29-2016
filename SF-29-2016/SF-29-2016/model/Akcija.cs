using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016.model
{
    publi class Akcija
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public bool  obrisan { get; set; }
    }
}
