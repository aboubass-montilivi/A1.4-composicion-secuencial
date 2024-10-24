namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool parell, multiple7;
            Console.WriteLine("Entra un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            parell = EsParell(num);

            if (parell)
            {
                Console.WriteLine("Es parell");
            }
            else
            {
                Console.WriteLine("No es parell");
            }

            multiple7 = EsMultipleDe7(num);

            if (multiple7)
            {
                Console.WriteLine("Es multiple de 7");
            }
            else
            {
                Console.WriteLine("No es multiple de 7");
            }
        }

        public static bool EsParell(int n)
        {
            bool parell;
            parell = n % 2 == 0;
            return parell;
        }

        public static bool EsMultipleDe7(int n)
        {
            return n % 7 == 0;

        }

    }
}
