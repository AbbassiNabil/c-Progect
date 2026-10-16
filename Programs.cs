

class Program
{
    static void Main()
    {
        Console.WriteLine("Quel exercice veu-tu executer?");
        Console.WriteLine("1 - Calculator");
        Console.WriteLine("2 - Le juste prix");
        Console.WriteLine("Choix: ");

        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                Calculator.Esegui();
                break;
            case "2":
                Lejustprix.Esegui();
                break;
            default:
                Console.WriteLine("Le choix n'est pas valide.");
                break;
        }
    }
}
