using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool resultat;
            Console.WriteLine("Introduce un número de 4 dígitos:");
            num = Convert.ToInt32(Console.ReadLine());


            resultat = EsCapiCua(num);


            if (resultat)
            {
                Console.WriteLine($"El número {num} es capicúa.");
            }
            else
            {
                Console.WriteLine($"El número {num} no es capicúa.");
            }
        }

        public static bool EsCapiCua(int num)
        {
            bool resultat;
            int d1, d2, d3, d4;

            d1 = num % 10;
            d2 = num / 10 % 10;
            d3 = num / 100 % 10;
            d4 = num / 1000;

            resultat = d1 == d4 && d2 == d3;

            return resultat;

            //mas simplificado seria return num % 10 == num / 10 % 10 && num / 100 % 10 == num / 1000;
        }
    }

       
}
