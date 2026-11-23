// ------------------------------
// Uebung_4_5
// ------------------------------

namespace Uebung_4_5;

class Program
{
    static void Main(string[] args)
    {
       string s="abcd#dies#12345";
       Console.WriteLine(Stufe2(s));

    }

    static void Stufe1(string s)
    {
        for(int i=0;i<s.Length;i++)if(s[i]=='#')Console.WriteLine(i);
    }
    static string Stufe2(string s)
    {
        int i=0;
        for(;i<s.Length;i++)if(s[i]=='#')break;
        return s.Substring(i+1);
    }
    static string Stufe3(string s)
    {
        int count=0;
        int[] numbers = {0,0};
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]=='#'){
                numbers[count]=i;
                count++;
            }
            if(count==2)break;
        }

        return s.Substring(numbers[0]+1,numbers[1]-numbers[0]-1);
    }

    static string Stufe4(string s)
    {
        int count=0;
        int[] numbers = {0,0};
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]=='#'){
                numbers[count]=i;
                count++;
            }
            if(count==2)break;
        }

        return  s.Substring(0,numbers[0]+1) + s.Substring(numbers[0]+1,numbers[1]-numbers[0]-1).ToUpper() + s.Substring(numbers[1],s.Length-numbers[1]);
    }
}
