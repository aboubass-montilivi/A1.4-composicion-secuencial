using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora24;
            int hores, minuts, segons;
            Console.WriteLine("Entra una hora");
            hora24 = Convert.ToInt32(Console.ReadLine());

            hores = hora24 / 10000;
            minuts = hora24 / 100 % 100;
            segons = hora24 % 100;

            if (HoraValida(hores, minuts, segons))
            {
                Console.WriteLine(Incrementa1Segon(hores,minuts,segons));
            }
            else
            {
                Console.WriteLine("Hora no vàlida");
            }


            Console.WriteLine(Incrementa1Segon);

        }

        public static string Incrementa1Segon(int h, int m, int s)
        {
            s = s + 1;

            if (s>59)
            {
                s = 0;
                m = m + 1;
            }

            if(m>60)
            {
                m = 0;
                h = h + 1;
            }

            if (h>23)
            {
                h = 0;
            }

            return $"{h:00}:{m:00}:{s:00}";


            /*
            s++;
            
            if (s==60)
            {
                m++;
            }
            
            if (m==60)
            {
                h++;
            }

            if (h==24)
            {
                h = 0;
            }

            return $"{h:D2}:{m:D2}:{s:D2}";*/

        }
        public static bool HoraValida(int h, int m, int s)
        {
            bool valid;
            valid = h < 24 && m < 60 && s < 60;
            return valid;
        }
    }
}
