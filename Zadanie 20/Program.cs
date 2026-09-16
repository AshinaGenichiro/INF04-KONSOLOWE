using System;

public class HelloWorld
{
    static int podajUczniow()
    {
       int liczbaUczniow = 0;
       bool sukces;
       string wynik;
        bool isValid= false;
       do
       {
            Console.WriteLine("Podaj liczbe uczniow(od 1 do 40):");
            wynik = Console.ReadLine();
            sukces = int.TryParse(wynik, out liczbaUczniow);
            if(sukces)
            {
                if(liczbaUczniow >= 1 && liczbaUczniow <=40)
                {
                Console.WriteLine($"Wybrałes {liczbaUczniow} uczniow");
                isValid = true;
                }
                else
                {
                    Console.WriteLine("Musi sie miescic w zakresie 1-40");
                }
            }
            if(!sukces)
            {
                Console.WriteLine("Prosze o wpisanie poprawnych danych");
            }
        } while(!isValid);
        return liczbaUczniow;
    }
    static int[] dodajOcene(int liczbauczniow)
    {
        int[] ocenyUczniow = new int[liczbauczniow];
        for (int i = 0; i < ocenyUczniow.Length; i++)
        {
            int ocenaUcznia = 0;
            bool sukces;
            string wynik;
            bool isValid = false;
            do
            {
                Console.WriteLine("Podaj ocene ucznia(od 1 do 6):");
                wynik = Console.ReadLine();
                sukces = int.TryParse(wynik, out ocenaUcznia);
                if (sukces)
                {
                    if (ocenaUcznia >= 1 && ocenaUcznia <= 6)
                    {
                        Console.WriteLine($"Wybrałes {ocenaUcznia} dla ucznia { i+1}");
                        isValid = true;
                        ocenyUczniow[i] = ocenaUcznia;
                    }
                    else
                    {
                        Console.WriteLine("Ocena musi sie miescic w zakresie 1-6");
                    }
                }
                if (!sukces)
                {
                    Console.WriteLine("Prosze o wpisanie poprawnych danych");
                }

            } while (!isValid);
        }

        return ocenyUczniow;
    }
    static double obliczSrednia(int[] ocenyUczniow)
    {
        double srednia = 0;
        for (int i = 0; i < ocenyUczniow.Length; i++)
        {
            srednia = srednia+ocenyUczniow[i];
        }
        srednia = srednia / ocenyUczniow.Length;
        return srednia;
    }
    static int ileNDST(int[] ocenyUczniow)
    {
        int licznikNDST = 0;
        for (int i = 0; i < ocenyUczniow.Length; i++)
        {
            if(ocenyUczniow [i] == 1)
            {
                licznikNDST++;
            }
        }
        return licznikNDST;
    }

    public static void Main(string[] args)
    {
        int liczbaUczniow = podajUczniow();
        Console.WriteLine(liczbaUczniow);

        int[] ocenyUczniow = new int[liczbaUczniow];
        ocenyUczniow = dodajOcene(liczbaUczniow);
        int min = ocenyUczniow.Min();
        int max = ocenyUczniow.Max();

        Console.WriteLine("Podsumowanie ocen:");
        for (int i = 0; i < ocenyUczniow.Length; i++)
        {
            Console.WriteLine($"Uczeń {i + 1}: {ocenyUczniow[i]}");
        }
        Console.WriteLine($"Najwyższa ocena {max}, a najniższa {min}");
        Console.WriteLine($"Średnia klasy {obliczSrednia(ocenyUczniow)}");
        Console.WriteLine($"Jest {ileNDST(ocenyUczniow)} NDST");
    }
}