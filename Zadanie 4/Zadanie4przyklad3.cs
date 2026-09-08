using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe calkowita:");
        int liczba = int.Parse(Console.ReadLine());
        int liczbaCalkowita = 0;
        for (int i = 1; i <= liczba; i++)
        {
            if (i % 2 == 0)
            {
                liczbaCalkowita = liczbaCalkowita + i;
                Console.WriteLine($"Liczby podzielne przez 2: {i}");
            }
        }
        Console.WriteLine($"{liczbaCalkowita}");
    }
}