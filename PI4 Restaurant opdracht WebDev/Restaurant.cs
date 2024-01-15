using PI4_Restaurant_opdracht_WebDev;

public class Restaurant
{
    Bestelling bestelling;
    Maaltijd maaltijd;

    public int AANTALTAFELS = 20;
    public int AANTALBESTELLINGEN = 50;
    public int MINIMALE_BEREIDINGSTIJD = 750;
    public int MAXIMALE_BEREIDINGSTIJD = 1500;

    public Restaurant()
    {
        Restaurant restaurant = new Restaurant();
    }

    public void start() 
    {
        new Kok().BereidMaaltijden(bestelling, maaltijd);

        return;     
    }
   
}