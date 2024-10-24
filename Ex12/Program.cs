namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any;
            Console.WriteLine("Entra un any");
            any = Convert.ToInt32(Console.ReadLine());

            if (AnyTraspas(any))
            {
                Console.WriteLine($"{any} es any de traspas");
            }
            else
            {
                Console.WriteLine($"{any} no es any de traspas");

            }
        }
        /// <summary>
        /// Enra un int i retorna un boolea
        /// </summary>
        /// <param name="any"></param>
        /// <returns></returns>
        static bool AnyTraspas(int any)
        {
            bool resultat;

            resultat = (any % 4 == 0 && any % 100 != 0) || any % 400 == 0;

            return resultat;
            
        }
    }
}
