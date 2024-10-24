namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaPractiques, notaExamen, nota;
            string notaQualificativa;

            Console.WriteLine("Introdueix la nota que has tret en practiques: ");
            notaPractiques = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdueix la nota que has tret a l'examen: ");
            notaExamen = Convert.ToInt32(Console.ReadLine());

            if (notaPractiques <3 || notaExamen <3)
            {
                notaQualificativa = "Has suspes";
            }

            else
            {
                nota=0.8*notaExamen + 0.2 * notaPractiques;
                if (nota <5)
                {
                     notaQualificativa = "Has suspes";
                }
                
            }
        }
    }
}
