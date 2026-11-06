public class Morpion
{
    static char[,] grille = new char[3, 3];

    public static void Esegui()
    {
        // Inizializza la griglia con caselle vuote
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                grille[r, c] = ' ';
            }
        }

        char joueur = 'X';
        int coupsJoues = 0;

        while (true)
        {
            Afficher();
            Console.Write($"Joueur {joueur}, choisis une case (ex: B2) : ");

            if (!LireCase(out int r, out int c))
            {
                Console.WriteLine("Case invalide.");
                continue;
            }

            if (grille[r, c] != ' ')
            {
                Console.WriteLine("Cette case est déjà prise.");
                continue;
            }

            grille[r, c] = joueur;
            coupsJoues++;

            // Prima la vittoria, poi il pareggio
            if (AGagne(joueur))
            {
                Afficher();
                Console.WriteLine($"Le joueur {joueur} a gagné !");
                return;
            }

            if (coupsJoues == 9)
            {
                Afficher();
                Console.WriteLine("Match nul !");
                return;
            }

            // Cambio giocatore
            if (joueur == 'X')
            {
                joueur = 'O';
            }
            else
            {
                joueur = 'X';
            }
        }
    }

    static void Afficher()
    {
        Console.WriteLine();
        Console.WriteLine("    1   2   3");
        for (int r = 0; r < 3; r++)
        {
            char lettre = (char)('A' + r);
            Console.WriteLine($"{lettre}   {grille[r, 0]} | {grille[r, 1]} | {grille[r, 2]}");
            if (r < 2)
            {
                Console.WriteLine("   ---+---+---");
            }
        }
        Console.WriteLine();
    }

    static bool LireCase(out int r, out int c)
    {
        r = 0;
        c = 0;
        string saisie = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (saisie.Length != 2)
        {
            return false;
        }

        char lettre = saisie[0];
        char chiffre = saisie[1];

        if (lettre < 'A' || lettre > 'C')
        {
            return false;
        }

        if (chiffre < '1' || chiffre > '3')
        {
            return false;
        }

        r = lettre - 'A';
        c = chiffre - '1';
        return true;
    }

    static bool AGagne(char j)
    {
        // Righe e colonne
        for (int i = 0; i < 3; i++)
        {
            if (grille[i, 0] == j && grille[i, 1] == j && grille[i, 2] == j)
            {
                return true;
            }
            if (grille[0, i] == j && grille[1, i] == j && grille[2, i] == j)
            {
                return true;
            }
        }

        // Diagonali
        if (grille[0, 0] == j && grille[1, 1] == j && grille[2, 2] == j)
        {
            return true;
        }
        if (grille[0, 2] == j && grille[1, 1] == j && grille[2, 0] == j)
        {
            return true;
        }

        return false;
    }
}