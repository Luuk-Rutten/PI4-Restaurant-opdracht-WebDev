using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PI4_Restaurant_opdracht_WebDev
{
    public class Kok : Balie
    {
        public int Tafelnummer { get; set; }
      
        public Kok() 
        {
            Balie balie = new Balie(BalieLocatie);
           Kok kok = new Kok();
        }
        public void BereidMaaltijd(Bestelling Bestelling)
        {
            Maaltijd maaltijd = new Maaltijd(Tafelnummer);

        }

       

        public void BereidMaaltijden()
        {

        }
    }
}
