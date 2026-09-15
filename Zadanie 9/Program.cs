using System;

public class HelloWorld
{
    static int IleParzystych(int[,] liczby)
    {
        int parzyste = 0;
        for (int w = 0; w < liczby.GetLength(0); w++)
        {
            for (int k = 0; k < liczby.GetLength(1); k++)
            {
                if (liczby[w, k] % 2 == 0)
                {
                    parzyste++;
                    Console.WriteLine($"{liczby[w,k]}");
                }
            }
        }
        return parzyste;
    }
    /*Nazwa funkcji: WypelnijZestaw
     *
     * 
     * 
     * 
     * 
     * 
     *Autor: notatka 
     */
    static void WypelnijZestaw(int[] liczby, Random generator)
    {
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = generator.Next(1, 50); 
        }
    }
 /*Nazwa funkcji: WyswietlZestaw
 *
 * 
 * 
 * 
 * 
 * 
 *Autor: notatka 
 */
    static void WyswietlZestaw(int numer, int[] liczby)
    {
        Console.Write($"Zestaw {numer}: ");
        foreach (int liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Random generator = new Random();

        Console.Write("Ile zestawow chcesz wylosowac:");
        int n = int.Parse(Console.ReadLine());
        int[,] zestawy = new int[n, 6];

        for (int zestaw = 0; zestaw < n; zestaw++)
        {
            int[] liczby = new int[6];
            WypelnijZestaw(liczby, generator);
            WyswietlZestaw(zestaw, liczby);
            for (int k = 0; k < 6; k++)
            {
                zestawy[zestaw, k] = liczby[k];
            }

        }

        Console.WriteLine("\nWylosowane liczby parzyste:");
        int wynik = IleParzystych(zestawy);
        Console.WriteLine($"Liczba parzystych: {wynik}");
    }
    }