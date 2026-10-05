// ------------------------------
// Uebung_2_1
// ------------------------------

namespace Uebung_2_1;

class Schulklasse
{
    public int schuler;
    public string lehrer;

    public Schulklasse() : this(26, "Strasser")
    {
        
    }
    public  Schulklasse(int schuler, string lehrer)
    {
        this.schuler = schuler;
        this.lehrer = lehrer;
    }


    /*public  Schulklasse(int anzahlSchueler, string klassenvorstand)
    {
        this.schuler = anzahlSchueler;
        this.lehrer = klassenvorstand;
    }*/

    public void Dazu()
    {
        schuler++;
    }

    public void Raus(int zahl)
    {
        schuler-=zahl;
    }


    public override string ToString()
    {
        return "Anzahl Schüler: " + schuler + ", Klassenvorstand: " + lehrer;
    }

    public void KlassenwechselNach(Schulklasse target)
    {
        schuler--;
        target.Dazu();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Schulklasse AHITS = new Schulklasse();

        Schulklasse BHME = new Schulklasse(90,"Hurensohn");
        AHITS.KlassenwechselNach(BHME);
        Console.WriteLine(AHITS.ToString());
        Console.WriteLine(BHME.ToString());
    }
}
