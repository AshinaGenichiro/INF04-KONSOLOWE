using System;

public class HelloWorld

{

    public static void Main(string[] args)

    {

        Console.WriteLine("Gra zgadnij liczbe");

        int correctNumber = 60;

        int proby = 0;

        do

        {

            proby++;

            Console.Write("Zgadnij liczbe: ");

            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber == correctNumber)

            {

                Console.WriteLine($"Gratulacje, zgadles za {proby} razem!");

                break;

            }

            if (proby == 7)

            {

                Console.WriteLine($"Niestety skonczyly ci sie proby, prawidlowa liczba to {correctNumber}.");

                break;

            }

            if (guessedNumber > correctNumber)

            {

                Console.WriteLine($"Twoja liczba jest za duza, to twoja {proby} proba.");

            }

            if (guessedNumber < correctNumber)

            {

                Console.WriteLine($"Twoja liczba jest za mala, to twoja {proby} proba.");

            }

        } while (true);

    }

}

