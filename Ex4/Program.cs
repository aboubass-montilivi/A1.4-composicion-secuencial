using System.Xml;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool ordreCreixent;
            // se ha quitado "&& t1<t3" 
            ordreCreixent = t1<t2  && t2<t3;

            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }
        }
    }
}
