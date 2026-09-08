using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe puntkow:");
        int liczbaPunktow = int.Parse(Console.ReadLine());
        if (liczbaPunktow >= 90 && liczbaPunktow <= 100)
        {
            Console.WriteLine("Ocena bardzo dobra");
        }
        else if (liczbaPunktow >= 75 && liczbaPunktow <= 89)
        {
            Console.WriteLine("Ocena  dobra");
        }
        else if (liczbaPunktow >= 50 && liczbaPunktow <= 74)
        {
            Console.WriteLine("Ocena  dostateczna");
        }
        else if (liczbaPunktow < 50)
        {
            Console.WriteLine("Ocena niedostateczna");
        }
    }
}