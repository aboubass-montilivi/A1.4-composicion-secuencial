using System.Text;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int velocitat;
            string infoSancio;
            Console.WriteLine("Entra la velocitat: ");
            velocitat = Convert.ToInt32(Console.ReadLine()):
            
            //infoSancio = Sancio(velocitat);

            Console.WriteLine(Sancio(velocitat));
        }

        public static string Sancio(int velocitat)
        {
            String info;
            if (velocitat >= 80 && velocitat <= 99)
            {
                info = "100€";
            }
            else if (velocitat >= 100 && velocitat <= 129)
            {
                info = "300€";
            }
            else if (velocitat >= 130)
            {
                info = "600€ i retirada de carnet";
            }
            else
            {
                info = "no hi ha sanció";
            }

            return info;
        }

    }
}
