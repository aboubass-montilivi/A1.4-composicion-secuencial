using System.Linq.Expressions;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;

            iguals = (t1 == t2) && !(t2 != t3) && (t1 == t3);

            //simplificat
            iguals = t1 == t2 && t2 == t3;

            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }

        }
    }
}
