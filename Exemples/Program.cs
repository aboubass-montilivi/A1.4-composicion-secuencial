namespace Exemples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esMajorEdat;

            //valor true
            esMajorEdat = true;
            Console.WriteLine(esMajorEdat);

            //valor false
            esMajorEdat = false;
            Console.WriteLine(esMajorEdat);

            //negar el valor que li poses a la variable
            esMajorEdat = true;
            Console.WriteLine(!esMajorEdat);

            //major edat
            int edat = 18;
            esMajorEdat = (edat >= 18);
            esMajorEdat = edat >= 18;

            //operacions arimètiques
            int a = 2;
            int b = 3;
            double c= 3.00001;
            bool resultat;


            resultat = a > b;
            Console.WriteLine($"a>b => {resultat}");

            resultat = !(a > b);
            Console.WriteLine($"a>b => {resultat}");

            resultat = b < c;
            Console.WriteLine($"b < c => {resultat}");

            char ca = 'a';

            char cA = 'A';
            char cZ = 'Z';

            resultat = ca < cA;
            Console.WriteLine($"ca < cA => {resultat}");

            resultat = ca < 'b'; //97 i 98
            Console.WriteLine($"ca < cA => {resultat}");


            /*
Console.OutputEncoding = System.Text.Encoding.UTF8;

int velocitat, limitVelocitat;
Console.WriteLine("Introdueix la velocitat del cotxe: ");
velocitat = Convert.ToInt32(Console.ReadLine());

limitVelocitat = 120;
if (velocitat > limitVelocitat)
{
    int exces = velocitat - limitVelocitat;
    Console.WriteLine($"\u26A0 Estàs excedint el límit de velocitat! Redueix la velocitat. Vas {exces} km/h per sobre del límit.");
}
else
{
    Console.WriteLine("😊 Vas a una velocitat segura. \u270C");

}
*/


            int sinco = 5;
            bool bex;
            /*Console.WriteLine(a >= 0 && a > 10);
            Console.WriteLine(!(a >= 0 && a > 10));


            Console.WriteLine(a < 0 || a > 10);
            Console.WriteLine(!(a < 0 || a > 10));*/

            //MINI PROJECTE PERSONAL 
            /*
            int age;
            string name, estatMissatge;
            bool stat;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Are you okey?");
            stat = Convert.ToBoolean(Console.ReadLine());

            if (stat == true)
            {
                estatMissatge = "Are you okey!";
            }
            else
            {
                estatMissatge = "Are you sad... Don't worry!";
            }

            Console.WriteLine($"Your name is {name}, you have {age} old, and {estatMissatge}");
            */

            //petit programa que et pregunta si estas be o no
            string resposta;
            Console.WriteLine("Estas bien? (si o no)");
            resposta = Console.ReadLine();

            if (resposta == "si")
            {
                Console.WriteLine("Me alegro que estés bien!");
            }
            else if (resposta == "no")
            {
                Console.WriteLine("Oh, espero que te sientas mejor pronto!");
            }
            else
            {
                Console.WriteLine("Resposta no vàlida, introdueix 'si' o 'no'.\"");
            }

        }
    }
}
