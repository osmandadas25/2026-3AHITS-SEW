// ------------------------------
// OOP
// ------------------------------

namespace OOP;

class Schule
{
    public string name;
    public int anzahlSchueler;
    public int anzahlLehrer;

    public int AnzahlPersonen()
    {
        return anzahlSchueler+anzahlLehrer;
    }

    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahlSchueler}, Lehrer: {anzahlLehrer}";
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        for(int i=0;i<5;i++)Console.WriteLine("     |");

        Schule HTL = new Schule();
        HTL.name = "HTL Braunau";
        HTL.anzahlLehrer=100;
        HTL.anzahlSchueler=800;

        Console.WriteLine($"AnzahlPersonen: " + HTL.AnzahlPersonen());

        Schule HLW = new Schule();
        HLW.name = "HLW Braunau";
        HLW.anzahlLehrer=80;
        HLW.anzahlSchueler=600;

        Console.WriteLine(HTL.ToString());

        for(int i=0;i<5;i++)Console.WriteLine("     |");
    }
}
