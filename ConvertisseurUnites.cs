using System.Security.Cryptography.X509Certificates;

public class ConvertisseurDUnités
{
    public static void Esegui()
    {
        Console.WriteLine("--- Exercice 4 : Convertisseur d’unités ---");
        Console.WriteLine("Créer un menu : °C <> °F, km <> miles, kg <> livres. Chaque conversion doit être une méthode séparée, par exemple float CelsiusVersFahrenheit(double c).");


        Console.WriteLine("Quel conversion veu-tu executer?");
        Console.WriteLine("1 - °C <> °F");
        Console.WriteLine("2 - km <> miles");
        Console.WriteLine("3 - kg <> livres");


        Console.WriteLine("Choix: ");

        string choix = Console.ReadLine();

        int num = 0;
        string result = "";

        switch (choix)
        {
            case "1":
                result = CelsiusToFahrenheit(num);
                break;
            case "2":
                result = KmToMiles(num);
                break;
            case "3":
                result = KgtoLivres(num);
                break;
            default:
                Console.WriteLine("Le choix n'est pas valide.");
                break;

        }

        Console.WriteLine(result);


        // --------------------------------------------------------------------------------------------


        string CelsiusToFahrenheit(int num)
        {
            Console.WriteLine("1 - C° to F°");
            Console.WriteLine("2 - F° to C°");

            Console.WriteLine("Choix: ");
            string choix = Console.ReadLine();


            int Fahrenheit;
            int Celsius;
            Console.WriteLine("Choisir une temperature");
            string rep1 = Console.ReadLine(), res = "Erreur";
            bool succes1 = int.TryParse(rep1, out num);

            if (choix == "1")
            {
                Fahrenheit = (num * (9 / 5)) + 32;
                res = $"{num}C° correspond a {Fahrenheit}F°";
            }
            else if (choix == "2")
            {
                Celsius = (num - 32) * (5 / 9);
                res = $"{num}F° correspond a {Celsius}C°";
            }
            return res;
        }

        // ---------------------------------------------------------------------------------------

        string KmToMiles(double num)
        {
            Console.WriteLine("1 - Km to Miles");
            Console.WriteLine("2 - Miles to Km");

            Console.WriteLine("Choix: ");
            string choix = Console.ReadLine();

            double Km;
            double Miles;
            Console.WriteLine("Choisir une longeur");
            string rep1 = Console.ReadLine(), res = "Erreur";
            bool succes1 = double.TryParse(rep1, out num);

            if (choix == "1")
            {
                Miles = num * 0.621371;
                res = $"{num} Km correspond a {Miles} Miles";
            }
            else if (choix == "2")
            {
                Km = num * 1.60934;
                res = $"{num} Miles correspond a {Km} Km";
            }
            return res;
        }

        // ---------------------------------------------------------------------------------------

        string KgtoLivres(double num)
        {
            Console.WriteLine("1 - Kg to Livres");
            Console.WriteLine("2 - Livre to Kg");

            Console.WriteLine("Choix: ");
            string choix = Console.ReadLine();

            double Kg;
            double Livres;
            Console.WriteLine("Choisir une longeur");
            string rep1 = Console.ReadLine(), res = "Erreur";
            bool succes1 = double.TryParse(rep1, out num);

            if (choix == "1")
            {
                Livres = num * 2.20462;
                res = $"{num} Kg correspond a {Livres} Livres";
            }
            else if (choix == "2")
            {
                Kg = num * 0.453592;
                res = $"{num} Livres correspond a {Kg} Kg";
            }
            return res;
        }

    }

}