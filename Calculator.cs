public static class Calculator
{

    public static void Esegui()
    {

        Console.WriteLine("--- Exercice 1: LA CALCULATRIC ---");

        float num1;
        float num2;
        float affichage = 0;
        float r;
        float b;
        float h;

        Console.WriteLine(" Entree le premier nombre");
        string rep1 = Console.ReadLine();
        bool succes1 = float.TryParse(rep1, out num1);

        Console.WriteLine(" entree l'operateur choisi");
        string oper = Console.ReadLine();

        Console.WriteLine(" Entree le deusiemme nombre");
        string rep2 = Console.ReadLine();
        bool succes2 = float.TryParse(rep2, out num2);





        if (oper == "+")
        {
            float result = add(num1, num2);
            affichage = result;
        }
        else if (oper == "-")
        {
            float result = sous(num1, num2);
            affichage = result;
        }
        else if (oper == "*")
        {
            float result = molt(num1, num2);
            affichage = result;
        }
        else if (oper == "/")
        {
            float result = divi(num1, num2);
            affichage = result;
        }
        else if (oper == "%")
        {
            float result = rest(num1, num2);
            affichage = result;
        }

        Console.WriteLine($"le resultat est {affichage}");

        // ------------------------------------------------------------------------------------------------------------------------------
        // calcul de l'aire d un cercle


        float a_cer = 0;

        Console.WriteLine(" Entree le raion du cercle");
        string rai = Console.ReadLine();
        bool succes3 = float.TryParse(rai, out r);

        if (rai != null)
        {
            float result = cercle(r);
            a_cer = result;

        }

        Console.WriteLine($"l'air du cercle est de {a_cer}");

        // ------------------------------------------------------------------------------------------------------------------------------
        // Clcule de l'aire de un rectangle


        float Aret = 0;

        Console.WriteLine(" Entree la base du rectangle");
        string Bret = Console.ReadLine();
        bool succes4 = float.TryParse(Bret, out b);

        Console.WriteLine(" Entree l'hauteur du rectangle");
        string Hret = Console.ReadLine();
        bool succes5 = float.TryParse(Hret, out h);

        if (Bret != null && Hret != null)
        {
            float result = rettan(b, h);
            Aret = result;
        }

        Console.WriteLine($"l'air du rectangle est {Aret}");


        // ------------------------------------------------------------------------------------------------------------------------------
        // La suit de Fibonacci


        Console.WriteLine("Combient de nombres de la suite de Fibonacci tu veut generer ?");
        float n = float.Parse(Console.ReadLine());

        float a = 0;
        float b1 = 1;

        Console.WriteLine($"Les premier {n} nombres de Fibonacci");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            float t = a + b1;
            a = b1;
            b1 = t;
        }




        // ------------------------------------------------------------------------------------------------------------------------------


        float add(float a, float b) { float som = 0; som = a + b; return som; }
        float sous(float a, float b) { float moin = 0; moin = a - b; return moin; }
        float molt(float a, float b) { float mol = 0; mol = a * b; return mol; }
        float divi(float a, float b) { float div = 0; div = a / b; return div; }
        float rest(float a, float b) { float res = 0; res = a % b; return res; }

        float cercle(float r) { float a_cer = 0; a_cer = (float)Math.PI * (r * r); return a_cer; }
        float rettan(float b, float h) { float Aret = 0; Aret = b * h; return Aret; }

        Console.WriteLine("Calculatrice en function...");

    }

}

