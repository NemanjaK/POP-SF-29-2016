using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016.model
{
    
    public enum TipKorisnika { 
        Administrator,
        Prodavac
}
    public class korisnik
    {
        public int Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String KorisnickoIme { get; set; }
        public String lozinka { get; set; }
        public  bool obrisan { get; set; }

    }
}
