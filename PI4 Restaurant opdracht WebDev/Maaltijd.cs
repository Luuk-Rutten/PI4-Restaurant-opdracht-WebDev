using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4_Restaurant_opdracht_WebDev
{
    public class Maaltijd
    {
        public int Tafelnummer { get; set; }

        public Maaltijd(int tafelnummer)
        {
            Tafelnummer = tafelnummer;
             List<Maaltijd> Maaltijden = new List<Maaltijd>();
        }
        public int getTafelnummer()
        {
            return Tafelnummer;

        }

        public string toString()
        {
            

        }
    }
}
