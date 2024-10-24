namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edat;
            bool esMajorEdat;
            Console.WriteLine("ENTRA LA TEVA EDAT: ");
                edat = Convert.ToInt32(Console.ReadLine());

            esMajorEdat = edat >= 18;

            if (esMajorEdat)
            {
                Console.WriteLine("ETS MAJOR D'EDAT");
            }
            else
            {
                Console.WriteLine("ETS MENOR D'EDAT");
            }

        }
    }
}
