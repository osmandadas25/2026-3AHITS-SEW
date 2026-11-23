// ------------------------------
// Uebung_4_7
// ------------------------------

namespace Uebung_4_7;

class Program
{
    static void Main(string[] args)
    {
        
        /*
        Code:
        string input = "apple,banana,orange,grape";
        string[] substrings = input.Split(',');
        for(int i=0;i<substrings.Length;i++)
        {
            Console.WriteLine(substrings[i]);
        }
        #########################################################
        Output:
        apple
        banana
        orange
        grape
        */

        string input = "2+2+3+4+5";
        string[] substrings = input.Split('+');
        int[] subintegers = new int[substrings.Length];
        

        for(int i=0;i<substrings.Length;i++)
        {
           subintegers[i]=int.Parse(substrings[i]);
        }
        int sum=0;
        for(int i=0;i<substrings.Length;i++)
        {
           sum+=subintegers[i];
        }
        Console.WriteLine(sum);
    }
}
