// ------------------------------
// Uebung_4_8
// ------------------------------

namespace Uebung_4_8;

class Program
{
    class idk
    {
        public int index;
        public char buchstabe;

        public idk()
        {
            index=-1;
            buchstabe = '\0';
        }
    }
    static void Main(string[] args)
    {
        string s = "SEPTE#Hallo#MBR";
        Console.WriteLine(Is09(s));

    }

    static bool Is09(string s)
    {
        /*s = s.ToLower();
        for(int i = 0; i < s.Length; i++)
        {
            char sadoh = ' ';
            if(!(s[i]>=97 && s[i]<=122))s=s.Replace(s[i],sadoh);
        }
        s=s.Replace(" ","");
        if(s=="september")return true;
        else return false;
        */
        s = s.ToLower();
        idk[] array = new idk[9];
        for(int i=0;i<array.Length;i++)array[i] = new idk();
        array[0].buchstabe='s';
        array[1].buchstabe='e';
        array[2].buchstabe='p';
        array[3].buchstabe='t';
        array[4].buchstabe='e';
        array[5].buchstabe='m';
        array[6].buchstabe='b';
        array[7].buchstabe='e';
        array[8].buchstabe='r';

        for(int i = 0; i < array.Length; i++)
        {
            for(int k = 0; k < s.Length; k++)
            {
                if(s[k]==array[i].buchstabe)
                {
                    array[i].index=k;
                }
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i].index==-1)return false;
        }

        string New_s = "";
        for(int i = 0; i < array.Length; i++)
        {
            New_s += s.Substring(array[i].index,1);
        }
        Console.WriteLine(New_s);
        if(New_s=="september")return true;
        else return false;

    }
}
