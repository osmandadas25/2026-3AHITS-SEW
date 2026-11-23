// ------------------------------
// Uebung_4_6
// ------------------------------

namespace Uebung_4_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calc("3*5",'*'));
    }

    static int Calc(string s,char variante)
    {
        int i=0;
        for(;i<s.Length;i++)if(s[i]==variante)break;
        int num1 = int.Parse(s.Substring(0,s.Length-i-1));
        int num2 = int.Parse(s.Substring(i+1));
        if(variante=='+')return num1 + num2;
        else if(variante=='-')return num1 - num2;
        else if(variante=='*')return num1 * num2;
        else if(variante=='/')return num1 / num2;
        else return -1;
    }
}
