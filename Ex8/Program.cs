using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora24;
            int hores, minuts, segons;

            Console.WriteLine("Entra una hora en format 24H [HHMMSS]:");
            hora24 = Convert.ToInt32(Console.ReadLine());

            hores = hora24 / 10000;
            minuts = hora24 / 100 % 100;
            segons = hora24 % 100;

            if (HoraValida(hores, minuts, segons))
            {
                Console.WriteLine($"La hora {hores:00}:{minuts:00}:{segons:00} es valida");
            } 
            
            else
            {
                Console.WriteLine($"LA HORA {hores:00}:{minuts:00}:{segons:00} NO ÉS VÀLIDA");
            }
        }

        /// <summary>
        /// Funció que indica si una hora es correcte
        /// </summary>
        /// <param name="h">Numero enter positiu que conté les hores</param>
        /// <param name="m">Numero enter positiu que conte els minuts</param>
        /// <param name="s">Numero enter positiu que conte els segons</param>
        /// <returns></returns>
        public static bool HoraValida(int h, int m, int s)
        {
            bool valid;
            valid = h < 24 && m < 60 && s < 60;
            return valid;
        }
    }
}
