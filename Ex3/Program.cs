using System.Linq.Expressions;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
{
            int t1 = 25;
            int t2 = 25;
            int t3 = 24;
            bool diferents;

            diferents = (t1 != t2) && (t2 != t3) && (t1 != t3);
            if (diferents)
            {
                Console.WriteLine("Les tres temperatures són totes diferents.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són totes diferents.");
            }

        }
    }
}
