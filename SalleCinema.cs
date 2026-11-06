public class SalleDeCinema
{
    static bool[,] places = new bool[5, 8];

    public static void Esegui()
    {
        while (true)
        {
            Console.WriteLine("Que veux-tu faire ?");
            Console.WriteLine("1 - Afficher");
            Console.WriteLine("2 - Reserver");
            Console.WriteLine("3 - Annuler");
            Console.WriteLine("4 - Statistiques");
            Console.WriteLine("5 - Quitter");

            Console.WriteLine("Choix: ");

            string? choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Afficher();
                    break;
                case "2":
                    Reserver();
                    break;
                case "3":
                    Annuler();
                    break;
                case "4":
                    Statistiques();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Le choix n'est pas valide.");
                    break;
            }
        }
    }

    static void Afficher()
    {
        Console.WriteLine("    1 2 3 4 5 6 7 8 ");
        for (int r = 0; r < places.GetLength(0); r++)
        {
            char lettre = (char)('A' + r);
            Console.Write($"{lettre}   ");
            for (int s = 0; s < places.GetLength(1); s++)
            {
                if (places[r, s] == true)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Reserver()
    {
        Console.Write("Place à réserver (ex: C4) : ");

        if (!LirePlace(out int r, out int s))
        {
            Console.WriteLine("Place invalide.");
            return;
        }

        if (places[r, s] == true)
        {
            Console.WriteLine("Cette place est déjà prise.");
            return;
        }


        places[r, s] = true;

        Console.WriteLine("Réservation confirmée.");
    }

    static void Annuler()
    {
        Console.Write("Place à annuler (ex: C4) : ");

        if (!LirePlace(out int r, out int s))
        {
            Console.WriteLine("Place invalide.");
            return;
        }

        if (places[r, s] == false)
        {
            Console.WriteLine("Cette place est déjà libre.");
            return;
        }

        places[r, s] = false;
        Console.WriteLine("Réservation annulée.");
    }

    static void Statistiques()
    {
        Console.WriteLine("A faire");
    }

    static bool LirePlace(out int r, out int s)
    {
        r = 0;
        s = 0;
        string saisie = (Console.ReadLine() ?? "").Trim().ToUpper();
        // qui i controlli: return false se qualcosa non va
        if (saisie.Length != 2)
            return false;

        char lettre = saisie[0];
        char chiffre = saisie[1];

        if (lettre < 'A' || lettre > 'E')
            return false;

        if (chiffre < '1' || chiffre > '8')
            return false;

        // Conversione in indici dell'array
        r = lettre - 'A';      // 'A' -> 0, 'B' -> 1, ... 'E' -> 4
        s = chiffre - '1';     // '1' -> 0, '2' -> 1, ... '8' -> 7

        return true;
    }
}
