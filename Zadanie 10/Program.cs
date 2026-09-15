using System;

public class tablice
{
    public static void Main(string[] args)
    {
       bool isValid = false;
        string wejscie;
        int liczba;
        bool sukces;
        do
        {
            Console.Write("Podaj liczbe: ");
            wejscie = Console.ReadLine();
            sukces = int.TryParse(wejscie, out liczba);
            if (sukces)
            {
                isValid = true;
                Console.WriteLine("Wybraleś poprawna liczbe, mozesz przejsc dalej");
            }
            if (!sukces)
            {
                Console.WriteLine("Prosze podac prawidlowa liczbe");
            }
        } while (!isValid);
    }
}

//pomoc : notatka jak uzyc int.TryParse