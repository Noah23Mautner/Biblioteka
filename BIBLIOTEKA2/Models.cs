using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTEKA2
{
    [Serializable]
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string Kontakt { get; set; }
    }

    [Serializable]
    public class Knjiga
    {
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public int Godina { get; set; }
        public string ISBN { get; set; }
        public int BrojPrimjeraka { get; set; }
    }

    [Serializable]
    public class Posudba
    {
        public string KorisnikIme { get; set; }
        public string KnjigaNaslov { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public DateTime DatumPovrata { get; set; }
    }
    internal class Models
    {
        
    }
}
