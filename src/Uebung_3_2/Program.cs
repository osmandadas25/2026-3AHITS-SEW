// ------------------------------
// Uebung_3_2
// ------------------------------

namespace Uebung_3_2;

class Program
{
    static void Main(string[] args)
    {
        Complex c = new Complex(0,0.8);
        Complex z = new Complex(0,0);

        for(int i = 0; i < 100 ; i++)
        {
            z=z.Times(z);
            z=z.Plus(c);
            //Console.WriteLine((i+1) +": " + z.ToString());
            if (z.CheckenMandelbrotmenge() == -1)
            {
                Console.WriteLine("Außerhalb!!!");
                break;
            }
            else if(i==99)Console.WriteLine("Innerhalb!!!");
        }
        

    }
}
