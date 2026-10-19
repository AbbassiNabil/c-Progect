using System.Collections.Generic;
using System.Linq;

public class BulletinDeNotes
{
    public static void Esegui()
    {
        List<string> notes = new List<string>();

        Console.WriteLine("Saisir des notes et tapper 'fin' pour terminer");

        while (true)
        {
            Console.WriteLine("Saisir une note");
            string choix = Console.ReadLine();

            if (choix == "fin")
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(choix))
            {
                notes.Add(choix);
            }
        }
        Console.WriteLine($"Tu as rentree {notes.Count} notes");

        if (notes.Count > 0)
        {
            double sum = 0;
            for (int i = 0; i < notes.Count; i++)
            {
                sum += Convert.ToDouble(notes[i]);
            }
            double moienne = sum / notes.Count;
            Console.WriteLine($"La moienne est: {moienne}");
        }
        double min = notes.Select(double.Parse).Min();
        double max = notes.Select(double.Parse).Max();
        Console.WriteLine($"la Note minime est {min} et la maximal est {max}");
    }
}