using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any;
            string resultat;
            Console.WriteLine("Entra un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            resultat = Segle(any);

            Console.WriteLine(resultat);


        }
        public static string Segle (int any)
        {
            string info;

            if (any >= 1701 && any <= 1800)
            {
                info = "XVIII";
            }
            else if (any >= 1801 && any <= 1900)
            {
                info = "XIX";
            }
            else if (any >= 1901 && any <= 2000)
            {
                info = "XX";
            }
            else if (any >= 2001 && any <= 2100)
            {
                info = "XXI";
            }
            else
            {
                info = "ANY NO VÀLID";
            }

            return info;


        }
    }
}
