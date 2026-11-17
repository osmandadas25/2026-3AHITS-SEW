// ------------------------------
// HelloWorld
// ------------------------------
 
using System;

class KoOr
{
    
    public int[] x = new int[6];
}
class Program
{
    private static void Main(string[] args)
    {
        int Length_y=8;
        int Length_x=6;

        KoOr[] y = new KoOr[Length_y];

        for (int i = 0; i < y.Length; i++)
        {
            y[i] = new KoOr();
        }

        y[1].x[1]=1;
        y[1].x[4]=1;
        y[2].x[1]=1;
        y[2].x[4]=1;

        y[4].x[1]=1;
        y[4].x[4]=1;
        y[5].x[1]=1;
        y[5].x[2]=1;
        y[5].x[3]=1;
        y[5].x[4]=1;

        for(int i = 0; i < Length_y*4; i++)
        {
            for(int k=0;k<Length_x*4;k++)
            {
                if(i%2==1 && k % 2 == 0)
                {
                    if(y[i].x[k]==1)Console.Write("O");
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}