// ------------------------------
// Uebung_4_4
// ------------------------------

using System.Net;

namespace Uebung_4_4;

class Program
{
    static void Main(string[] args)
    {
        string s="Lager  r eg   al   ";
        
        Console.Write(prufen(s));
    }
    static bool prufen(string s)
    {
        s = s.Replace(" ", "");
        s=s.ToLowerInvariant();
        string pruf = Reverse(s);
        int bestatigung=0;
        for(int i=0;i<s.Length;i++)
        {
            Console.WriteLine(s[i]+"      "+pruf[i]);
            if(s[i]==pruf[i])bestatigung++;
        }
        Console.Write(bestatigung);
        if(bestatigung==pruf.Length)return true;
        else return false;
    }
    static string Reverse(string s)
    {
        string ret="";
        for(int i=0;i<s.Length;i++)ret=s[i]+ret;
        return ret;
    }
}
