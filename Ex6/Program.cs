namespace Ex6
{
    /// <summary>
    ///  Feu un programa que llegeixi (per aquest ordre), nom d’equip local, gols fets per
    ///  l’equip local, nom d’equip visitant, gols fets per l’equip visitant. El programa ha
    ///  d’informar de qui ha guanyat o bé si han empatat i el número de gols amb un missatge
    ///  de l’estil: “El Girona FC ha guanyat al Barcelona FC amb un resultat de 4 a 1”
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomEquipLocal, nomEquipVisitant, resultat;
            int golsEquipLocal, golsEquipVisitant;

            Console.Write("Nom de l'equip local: ");
            nomEquipLocal = Console.ReadLine();

            Console.Write("Gols de l'equip local: ");
            golsEquipLocal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nom de l'equip visitant: ");
            nomEquipVisitant = Console.ReadLine();

            Console.Write("Gols de l'equip visitant: ");
            golsEquipVisitant = Convert.ToInt32(Console.ReadLine());

            resultat = InformeResultat(nomEquipLocal, golsEquipLocal, nomEquipVisitant, golsEquipVisitant);

            Console.WriteLine(resultat);
        }

        public static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)
        {
            string informe;

            if (golsEquipLocal > golsEquipVisitant)
            {
                informe = $"{nomEquipLocal} ha guanyat al {nomEquipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            }

            else if (golsEquipVisitant > golsEquipLocal)
            {
                informe = $"{nomEquipVisitant} ha guanyat al {nomEquipLocal} amb un resultat de {golsEquipVisitant} a {golsEquipLocal}";
            }
            else
            {
                informe = "Han quedat empat";
            }
            return informe;
        }
    }
}
