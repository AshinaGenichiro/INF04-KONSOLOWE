using System;


public class HelloWorld
{
    static int[] wpiszDane()
    {
        int[] liczby = new int[5];
        for (int i = 0; i < liczby.Length; i++)
        {
            int liczba = 0;
            string wejscie;
            bool sukces;
            do
            {
                Console.Write($"Podaj {i + 1} liczbe:");
                wejscie = Console.ReadLine();
                sukces = int.TryParse(wejscie, out liczba);
                if(!sukces)
                {
                    Console.WriteLine("Prosze o poprawne wpisanie poprawnej liczby.");
                }
            } while (!sukces);
            liczby[i] = liczba;
        }
        return liczby;
    }
    static int sumaTablicy(int[] liczby)
    {
        int suma = 0;
        for(int i = 0; i< liczby.Length; i++)
        {
            suma = suma + liczby[i];
        }
        return suma;
    }
    static int sumaTablicyDodatnie(int[] liczby)
    {
        int sumaDodatnich = 0;
        for(int i = 0; i< liczby.Length; i++)
        {
            if (liczby[i] > 0)
            {
                sumaDodatnich = sumaDodatnich + liczby[i];
            }
        }
        return sumaDodatnich;
    }
    public static void Main(string[] args)
    {
        int[] liczby = new int[5];
        liczby = wpiszDane();
  
        int suma = sumaTablicy(liczby);
        Console.WriteLine($"Suma tablicy: {suma}");

        int sumaDodatnich = sumaTablicyDodatnie(liczby);
        Console.WriteLine($"Suma tablicy: {sumaDodatnich}");

    }
}