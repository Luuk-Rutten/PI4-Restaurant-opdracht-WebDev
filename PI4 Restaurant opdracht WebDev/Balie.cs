using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PI4_Restaurant_opdracht_WebDev
{
   
    public class Balie : Restaurant
    {
        public string? BalieLocatie {  get; set; }

        //public Random randbereidtijd { get; private set; }

        List<Bestelling>? Bestellingen { get; set; }
        List<Maaltijd>? Maaltijden { get; set; }

        public Balie(string BalieLocatie) 
        {
            Balie balie = new Balie("Centrale Hal");
            
            
        }

        public bool ErZijnNogBestellingen()
        {
            while (ErZijnNogBestellingen() == true)
            {
                if (Bestellingen.Count == 0)
                {
                    ToonAantalBestellingen();
                    return false;
                }

                else
                {
                    ToonAantalBestellingen();
                    //return true;
                }
              //  return false;
            }
 
        }
        public bool ErZijnNogMaaltijden()
        {


        }
        public void GenereerBestellingen()  
        {


            for (var i = 0; i < AANTALBESTELLINGEN; i++)
            {
                int randbereidtijd = new Random().Next(MINIMALE_BEREIDINGSTIJD, MAXIMALE_BEREIDINGSTIJD);
                int tafelnummer = new Random().Next(1, AANTALTAFELS);
                Bestelling bestelling = new Bestelling(randbereidtijd, tafelnummer);
            }

        }
        public void PakBestelling()
        {
            ErZijnNogBestellingen();

        }
        public void PakMaaltijd()
        {
        }
        public void PlaatsBestelling(Bestelling bestelling) 
        {
            Bestellingen.Add(bestelling);
        }
        public void PlaatsMaaltijd(Maaltijd maaltijd)
        {
            Maaltijden.Add(maaltijd);
        }
        public int ToonAantalBestellingen()
        {
            int BestellingenCounter = Bestellingen.Count;
            Console.WriteLine(BestellingenCounter);
            return BestellingenCounter;
        }
        public int ToonAantalMaaltijden()
        {
            int MaaltijdenCounter = Maaltijden.Count;
            Console.WriteLine(MaaltijdenCounter);
            return MaaltijdenCounter;
        }
    }
}
