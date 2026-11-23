// ------------------------------
// Uebung_2_3
// ------------------------------

namespace Uebung_2_3;

class Bankkonto
{
    public double Kontostand;
    public double Zinssatz;
    public string Inhaber;

    public Bankkonto() : this(500,0.5,"Ahmad Gourah")
    {
        
    }
    public  Bankkonto(double Kontostand, double Zinssatz, string Inhaber)
    {
        this.Kontostand = Kontostand;
        this.Zinssatz = Zinssatz;
        this.Inhaber = Inhaber;
    }


    public void Ein(double Wert)
    {
        Kontostand+=Wert;
    }

    public void Aus(double Wert)
    {
        Kontostand-=Wert;
    }

    public double JahresAbschluss()
    {
        double Zinsen = Kontostand * (Zinssatz/100);
        Kontostand+=Zinsen;
        return Zinsen;
    }

    public void ZinsPlus(double wert)
    {
        Zinssatz+=(wert/10);
    }

    public void ZinsMinus(double wert)
    {
        Zinssatz-=(wert/10);
    }

    public override string ToString()
    {
        return "Kontostand: " + Kontostand + "\nZinssatz: " + Zinssatz + "\nInhaber: " + Inhaber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bankkonto AG = new Bankkonto();

        AG.ZinsMinus(5);
        Console.WriteLine(AG.ToString() + "\nZinsen: " + AG.JahresAbschluss());
    }
}
