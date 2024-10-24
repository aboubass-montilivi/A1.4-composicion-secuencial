namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int nombre;
            bool resultat;
            Console.WriteLine("Introdueix un nombre enter de 3 xifres");
            nombre = Convert.ToInt32(Console.ReadLine());

            resultat = EsCapICua(nombre);

            if (resultat)
            {
                Console.WriteLine("Es cap i cua");
            }
            else
            {
                Console.WriteLine("No es cap i cua");
            }*/
            int num;
            Console.WriteLine("Entra un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (EsCapICua(num))
            {
                Console.WriteLine($"El numero {num} es cap i cua");
            }
            else
            {
                Console.WriteLine($"El numero {num} no es cap i cua");
            }

        }

        public static bool EsCapICua(int nombre)
        {
            bool resultat;
            int d1, d3;

            d1 = nombre % 10;
            d3 = nombre / 100;

            //es fa sense condicions dins d'aquesta funció 
            resultat = d1 == d3;
            return resultat;

            /*
            int centenes, unitats;
            bool resultat;

            centenes = nombre / 100;
            unitats = nombre % 10;

            if (centenes == unitats)
            {
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;*/
        }
    }
}
