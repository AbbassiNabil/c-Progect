

class Program
{
    static void Main()
    {
        Console.WriteLine("Quel exercice veu-tu executer?");
        Console.WriteLine("1 - Calculator");
        Console.WriteLine("2 - Le juste prix");
        Console.WriteLine("3 - FizzBuzz");
        Console.WriteLine("4 - Convertisseur d’unités");
        Console.WriteLine("5 - Bulletin de notes");
        Console.WriteLine("6 - Le carnet de contacts");
        Console.WriteLine("7 - Salle de cinema");

        Console.WriteLine("Choix: ");

        string? choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                Calculator.Esegui();
                break;
            case "2":
                Lejustprix.Esegui();
                break;
            case "3":
                FizzBuzz.Esegui();
                break;
            case "4":
                ConvertisseurDUnités.Esegui();
                break;
            case "5":
                BulletinDeNotes.Esegui();
                break;
            case "6":
                CarnetDeContacts.Esegui();
                break;
            case "7":
                SalleDeCinema.Esegui();
                break;
            default:
                Console.WriteLine("Le choix n'est pas valide.");
                break;

        }
    }
}
