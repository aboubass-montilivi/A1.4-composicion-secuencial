namespace ProgramaPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            string operacion;

            Console.Write("Ingresa el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Ingresa el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Elige una operación (+, -, *, /): ");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine("El resultado es: " + (numero1 + numero2));
                    break;
                case "-":
                    Console.WriteLine("El resultado es: " + (numero1 - numero2));
                    break;
                case "*":
                    Console.WriteLine("El resultado es: " + (numero1 * numero2));
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        Console.WriteLine("El resultado es: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break

            }
        }
    }
}
