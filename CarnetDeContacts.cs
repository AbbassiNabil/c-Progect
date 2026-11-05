using System.ComponentModel.DataAnnotations;
// ligne 80

public class CarnetDeContacts
{
    static List<string> noms=[];
    static List<string> tels=[];
    static List<string> mails=[];
    public static void Esegui()
    {
        while (true)
        {
        Console.WriteLine("Que veux-tu faire ?");
        Console.WriteLine("1 - Ajouter");
        Console.WriteLine("2 - Afficher");
        Console.WriteLine("3 - Rechercher");
        Console.WriteLine("4 - Supprimer");
        Console.WriteLine("5 - Quitter");

        Console.WriteLine("Choix: ");

        string? choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Show();
                    break;
                case "3":
                    Find();
                    break;
                case "4":
                    Delete();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Le choix n'est pas valide.");
                    break;
            }
        }
    }
    static void Add()
    {
        Console.WriteLine("Entre un Nom");
        string nvNom = Console.ReadLine() ?? "";
        noms.Add(nvNom);

        Console.WriteLine("Entre le numero de telephone");
        string nvTel = Console.ReadLine() ?? "";
        tels.Add(nvTel);

        Console.WriteLine("Entre l'adresse e-mail");
        string nvMail = Console.ReadLine()?? "";
        mails.Add(nvMail);

        Console.WriteLine($"Contact ajouté : {noms.Count}");

    }
    static void Show()
    {
        if (noms.Count == 0) {
            Console.WriteLine("Aucun contact dans la liste");
            return;
        }
        for (int i = 0; i < noms.Count; i++)
        {
            Console.WriteLine($"{noms[i]} - {tels[i]} - {mails[i]}");
        }
    }
    static void Find()
    {
        Console.WriteLine("Chercher un contact");
        string nomCherche = Console.ReadLine() ?? "";
        bool trouve = false;
        for (int i = 0; i < noms.Count; i++)
        {
            // string.Equals confronta le due stringhe, e OrdinalIgnoreCase gli dice di non badare alle maiuscole.
            if (string.Equals(nomCherche, noms[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{noms[i]} - {tels[i]} - {mails[i]}");
                trouve = true;
            }
        }
        if  (trouve == false)
            {
                Console.WriteLine("Aucun contact trouve");
            }
    }
    static void Delete()
    {
        Console.WriteLine("Quel contact souhaitez-vous supprimer?");
        string nomRemove = Console.ReadLine() ?? "";

        for (int i = 0; i < noms.Count; i++)
        {
            if (string.Equals(nomRemove, noms[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Contact supprimé : ({noms[i]} - {tels[i]} - {mails[i]})");
                noms.RemoveAt(i);
                tels.RemoveAt(i);
                mails.RemoveAt(i);
                return;
            }
        }
        Console.WriteLine("Aucun contact trouve");
    }
    
}