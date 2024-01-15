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
        public new bool ErZijnNogBestellingen { get; set; }
        public string? BalieLocatie { get; set; }


        public Kok()
        {
            Kok kok = new Kok();
            Balie balie = new Balie(BalieLocatie);
           
        }
        public void BereidMaaltijd(Bestelling bestelling)
        {
            Maaltijd maaltijd = new Maaltijd(Tafelnummer);

        }


        //Checken of dit hieronder wel werkt met deze parameters Bestelling en maaltijd//

        public void BereidMaaltijden(Bestelling bestelling, Maaltijd maaltijd)
        { 
            while (ErZijnNogBestellingen == true)
            {
                ToonAantalBestellingen();
                PakBestelling();
                BereidMaaltijd(bestelling);
                PlaatsMaaltijd(maaltijd);

            }
        }
    }
}
