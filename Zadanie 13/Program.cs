using System;
using System.Transactions;
using System.Xml.Linq;
public class obslugaWyjatkow
{
    public static void Main(string[] args)
    {
        string tekst;
        int ocena = 0;
        double srednia = 0;
        List<int>oceny = new List<int>();
        do
        {
            Console.Write("Podaj ocene: ");
            tekst = Console.ReadLine();
            if(tekst == "koniec")
            {
                break;
            }

            try
            {
                ocena = int.Parse(tekst);
                if (ocena < 1 || ocena > 6)
                {
                    Console.WriteLine("Ocena musi miescic sie w zakresie 1-6");
                    continue;
                }
                else
                {
                oceny.Add(ocena);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Podano bleda wartosc ");
            }
        } while (true);

        foreach (int i in oceny)
        {
            Console.WriteLine($" Ocena : {i}");
            srednia = srednia + i;
        }
        Console.WriteLine($"Liczba ocen: {oceny.Count}");
        Console.WriteLine($"Średnia ocen: {srednia / oceny.Count}");
    }
}