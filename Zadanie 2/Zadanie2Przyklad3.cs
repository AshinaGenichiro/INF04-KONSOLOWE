using System;

public class HelloWorld

{

    public static void Main(string[] args)

    {

        Console.WriteLine("Kalkulator sredniej");

        Console.WriteLine("Podaj 1 ocene");

        double fistgrade = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj 2 ocene");

        double secondgrade = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj 3 ocene");

        double thirdgrade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Twoja srednia z 3 ocen to {(fistgrade + secondgrade + thirdgrade) / 3.0}");

    }

}
