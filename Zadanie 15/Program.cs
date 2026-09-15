using System;
using System.Transactions;
using System.Xml.Linq;
using System.IO;
using System.Runtime.CompilerServices;
public class dokumentacjafunkcji
{
    /*Nazwa funkcji: liczbaUczniow
     *Opis : funkcja pyta sie uzytkownika o liczbe uczniów, po czym sprawdza czy wpisał poprawną wartość (czyli nie ciąg znaków, nie -20 uczniow)
     *Argumenty:
     *-String wejscie - jest to początkowa liczba uczniow ktora wpisuje uzytkownik, sluzy ona do sprawdzenia czy nie wpisał ciągu znaków
     *-int liczba uczniow - zmienna ktora trzyma ostateczna liczbe uczniow
     *-bool suckes - sprawdza czy zmiana tego co napisal uzytkownik zakończyła sie suckcsesem
     *Wartość zwracana 
     *-int liczbauczniow - ostateczna liczba uczniow
     *autor:  zdajacy nr 1
     */
    static int liczbaUczniow()
    {
        do
        {
        string wejscie;
        int liczbauczniow = 0;
        bool sukces;

        Console.Write("Podaj liczbe uczniow:");
        wejscie = Console.ReadLine();
        sukces = int.TryParse(wejscie, out liczbauczniow);
        
        if (sukces)
        {
            liczbauczniow = int.Parse(wejscie);
            if(liczbauczniow > 1)
                {
                 return liczbauczniow;
                }
                else
                {
                    Console.WriteLine("Musi byc minimalnie dwoch uczniow");
                }
        }
        if (!sukces)
        {
            Console.WriteLine("Prosze podac prawidlowa liczbe");
        }
        }while(true);
    }

    static int wynikUcznia()
    {
          int wynik = 0;
          string wejscie;
          bool sukces;
        do
        {
            Console.Write("Podaj wynik ucznia (0-100): ");
            wejscie = Console.ReadLine();
            sukces = int.TryParse(wejscie, out wynik);
            if (sukces)
            {
                if (wynik >= 50)
                {
                    Console.WriteLine("Zdałeś, gratulacje!");
                    return wynik; 
                }
                else
                {
                    Console.WriteLine("Nie zdałeś.");
                    return wynik; 
                }
            }
            else
            {
                Console.WriteLine("Proszę podać prawidłową liczbę.");
            }

        } while (!sukces); 

        return wynik;
    }
    static void wynikKlasy(int[] uczniowie)
    {
        int srednia = 0;
        int ileZdalo = 0;
        for (int i = 0; i < uczniowie.Length; i++)
        {
            uczniowie[i] = wynikUcznia();
            if(uczniowie [i] >= 50)
            {
                ileZdalo++;
            }

            srednia = (uczniowie[i] + srednia);
        }
        Console.WriteLine($"Średnia klasy: {srednia/uczniowie.Length}, a zdało {ileZdalo} uczniow");
    }
    public static void Main(string[] args)
    {
        int[] uczniowie = new int[liczbaUczniow()];
        wynikKlasy (uczniowie);


    }
}