// ------------------------------
// Uebung_4_2
// ------------------------------

namespace Uebung_4_2;

class Program
{
    static void Main(string[] args)
    {
       Reverse("namsO");
    }

    static void Reverse(string s)
    {
        Console.WriteLine(s.Length);
        
        for(int i=s.Length-1;i>=0;i--)Console.Write(s[i]);
    }
}
