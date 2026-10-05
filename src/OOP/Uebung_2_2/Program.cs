// ------------------------------
// Uebung_2_2
// ------------------------------

namespace Uebung_2_2;

class Rechteck
{
    public double a;
    public double b;


    public Rechteck() : this(10,20)
    {
        
    }
    public  Rechteck(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void Resize()
    {
        if (a > b)
        {
            a-=b;
        }
        if (a <= b)
        {
            b-=a;
        }
    }

    public void Inflate(double PW)
    {
        a=a + a*(PW/100);
        b=b + b*(PW/100);
    }
    public double AspectRatio()
    {
        return a/b;
    }

    public void SetMaxSide(double Neu)
    {
        double ratio = AspectRatio();
        if (a <= b)
        {
            b=Neu;
            a=Neu*ratio;
        }
        if (b < a)
        {
            a=Neu;
            b=Neu/ratio;
        }
    }

    public double Area()
    {
        return a*b;
    }

    public int Tile(Rechteck r)
    {
        
        return (int)Math.Round(Area()/r.Area());
    }

    public override string ToString()
    {
        return "Seite a: " + a + ", Seite b: " + b;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Rechteck OSMAN = new Rechteck();
        Rechteck Lemi = new Rechteck(2,1);
        
        //Console.WriteLine(OSMAN.ToString() + "\nSeitenverhältnis: " + OSMAN.AspectRatio());
        Console.WriteLine("Passt " + OSMAN.Tile(Lemi) + " mal.") ;
    }
}
