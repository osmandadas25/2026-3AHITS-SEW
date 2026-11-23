// ------------------------------
// Uebung_4_3
// ------------------------------

namespace Uebung_4_3;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine(Reverse("namsO"));
    }

    static string Reverse(string s)
    {
        string ret="";
        for(int i=0;i<s.Length;i++)ret=s[i]+ret;
        return ret;
    }
}
