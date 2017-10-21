using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016.model
{
    public class salon
    {
        public int id { get; set; }       
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string WebSajt { get; set; }
        public string PIB { get; set; }
        public string MaticniBroj { get; set; }
        public string ZiroRacun { get; set; }
        public bool Obirsan { get; set; }

    }
}
