using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Jak sie nazywasz ?");
        string name = Console.ReadLine();
        Console.WriteLine("Jaki jest twoj ulubiony kolor:");
        string color = Console.ReadLine();
        Console.WriteLine("Jakie jest twoje ulubione zwierze");
        string favAnimal = Console.ReadLine();
        Console.WriteLine($"Czesc {name}! Twoj ulubiony kolor to {color}, a ulubione zwierze to {favAnimal}");

    }
}