using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4_Restaurant_opdracht_WebDev
{
    public class Bestelling
    {
        public int Bereidingstijd {  get; set; }
        public int Tafelnummer { get; set; }


        public Bestelling(int bereidingstijd, int tafelnummer) 
        {
            Bereidingstijd = bereidingstijd;
            Tafelnummer = tafelnummer;
            List<Bestelling> Bestellingen = new List<Bestelling>();
            Bestelling b = new Bestelling(bereidingstijd, tafelnummer);
        }

  
    }
}
