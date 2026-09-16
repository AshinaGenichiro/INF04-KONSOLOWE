using System;

class Program
{
    static void WykonajSito(bool[] czyPierwsza)
    {
        int n = czyPierwsza.Length - 1; 
        for (int i = 2; i <= n; i++)
        {
            czyPierwsza[i] = true;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (czyPierwsza[i])
            {
                for (int wielokrotnosc = i * i; wielokrotnosc <= n; wielokrotnosc += i)
                {
                    czyPierwsza[wielokrotnosc] = false; 
                }
            }
        }
    }

    static int WczytajLiczbeDodatnia(string komunikat)
    {
        int liczba;
        bool poprawne;
        do
        {
            Console.Write(komunikat);
            poprawne = int.TryParse(Console.ReadLine(), out liczba) && liczba > 0;
            if (!poprawne)
            {
                Console.WriteLine("Błąd: należy podać liczbę całkowitą dodatnią.");
            }
        } while (!poprawne);
        return liczba;
    }

    static void Main()
    {
        int n = WczytajLiczbeDodatnia("Podaj górny zakres przedziału (n): ");
        bool[] czyPierwsza = new bool[n + 1];
        WykonajSito(czyPierwsza);
        Console.WriteLine($"\nLiczby pierwsze w przedziale od 2 do {n}:");
        for (int liczba = 2; liczba <= n; liczba++)
        {
            if (czyPierwsza[liczba])
            {
                Console.Write(liczba + " ");
            }
        }
        PoliczLiczbyPierwsze(czyPierwsza);
        Console.WriteLine();
        Console.ReadKey();
    }

    static int PoliczLiczbyPierwsze(bool[] czyPierwsza)
    {
        int pierwsze = 0;
        for (int i = 0; i< czyPierwsza.Length; i++)
        {
            if (czyPierwsza[i] == true)
            {
                pierwsze++;
            }
        }
        Console.WriteLine($"Jest: {pierwsze} liczb pierwszych");

        
        return 0;
    }
}