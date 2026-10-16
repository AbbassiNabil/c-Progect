
public class Lejustprix
{
    public static void Esegui()
    {
        Console.WriteLine("--- Exercice 2: LE JUST PRIX ---");
        Console.WriteLine("L’utilisateur propose des nombres, et le programme répond 'Plus grand' ou 'Plus petit' jusqu’à ce qu’il trouve.");

        int num1;

        string choix = Console.ReadLine();
        bool succes1 = int.TryParse(choix, out num1);

        int random = Random.Shared.Next(0, 101);

        while (num1 != random)
        {

            if (num1 > random)
            {
                Console.WriteLine("Plus petit!");
            }
            else if (num1 < random)
            {
                Console.WriteLine("Plus grand!");
            }

            string choix1 = Console.ReadLine();
            bool succes2 = int.TryParse(choix1, out num1);

        }

        Console.WriteLine("bravo!");


    }
}