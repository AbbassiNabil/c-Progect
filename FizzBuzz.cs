public class FizzBuzz
{

    public static void Esegui()
    {
        Console.WriteLine("--- Exercice 3: FIZZBUZZ ---");
        Console.WriteLine("Vous allez travailler sur des nombres de 1 à 100. Pour les multiples de 3, afficher 'Fizz'. Pour les multiples de 5, afficher 'Buzz'. Pour les multiples des deux, afficher « FizzBuzz ».");


        int num1;
        int div1 = 3;
        int div2 = 5;
        int div3 = 2;

        Console.WriteLine("Entree un nombre entre 1 et 100:");
        string choix = Console.ReadLine();
        bool succes1 = int.TryParse(choix, out num1);


        if (num1 % div3 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num1 % div1 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (num1 % div2 == 0)
        {
            Console.WriteLine("Buzz");
        }


    }

}
