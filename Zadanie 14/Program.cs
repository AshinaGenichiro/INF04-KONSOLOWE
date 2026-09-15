using System;
using System.Transactions;
using System.Xml.Linq;
using System.IO;
using System.Runtime.CompilerServices;
public class pracaNaPlikach
{
    public static void Main(string[] args)
    {
        Random generator = new Random();

        int liczba = 0;
        int suma = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        string linia;
        using (StreamWriter liczby = new StreamWriter("wynik.txt"))
        for (int i = 0; i <= 9; i++)
        {
            liczba =  generator.Next(0, 101);
            liczby.WriteLine(liczba.ToString());
            if (liczba < min) min = liczba;
            if (liczba > max) max = liczba;
        }
        if (File.Exists("wynik.txt"))
        {     
        using(StreamReader czytnik = new StreamReader("wynik.txt"))
        while ((linia = czytnik.ReadLine()) != null)
        {
          Console.WriteLine("Odczytano: " + linia);
          suma = suma + int.Parse(linia);
        }
        Console.WriteLine($"Suma cyfr: {suma}");
        Console.WriteLine($"Najmniejsza: {min}");
        Console.WriteLine($"Najwieksza: {max}");
        }
        else
        {
        Console.WriteLine("Ten plik nie istnieje");
        }
    }
}