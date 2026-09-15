using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj dlugosc tablicy:");
        
        int arrayLength = int.Parse(Console.ReadLine());
        int[] liczby = new int[arrayLength];

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.WriteLine($"Podaj liczbe nr {i+1}:");
            liczby[i] = int.Parse(Console.ReadLine());
        }

        int min = liczby.Min();
        int max = liczby.Max();
        int pozycjaMin = Array.IndexOf(liczby, min);
        int pozycjaMax = Array.IndexOf(liczby, max);

        for (int i = 0; i < arrayLength - 1; i++)
            for (int j = 0; j < arrayLength - i - 1; j++)
                if (liczby[j] > liczby[j + 1])
                {
                    var tempVar = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = tempVar;
                }
        Console.WriteLine("Posortowana tablica:");
        foreach(int i in liczby)
        {
            Console.WriteLine($"{i}");
            
        }
        Console.WriteLine($"\nNajmniejsza liczba ({min}) była na pozycji: {pozycjaMin + 1}");
        Console.WriteLine($"Największa liczba ({max}) była na pozycji: {pozycjaMax + 1}");
    }
}