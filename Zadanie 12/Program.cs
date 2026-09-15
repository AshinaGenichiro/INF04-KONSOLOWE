using System;
using System.Transactions;
using System.Xml.Linq;
public class dziedziczenie
{
    abstract class Pracownik
    {
        public string name { get; }
        public Pracownik(string name)
        {
            this.name = name;
        }
        public abstract double ObliczWynagrodzenie();
    }
     class PracownikEtatowy : Pracownik
    {
        public double pensjaMiesieczna { get; private set; }
        public PracownikEtatowy(double pensjaMiesieczna, string name) : base(name)
        {
            this.pensjaMiesieczna = pensjaMiesieczna;
        }
        public override double ObliczWynagrodzenie()
        {
            return pensjaMiesieczna;
        }
    }
     class ZlecenioBiorca : Pracownik
    {
        public double stawkaGodzinowa { get; private set; }
        public double liczbaGodzin { get; private set; }
        public ZlecenioBiorca(double stawkaGodzinowa, double liczbaGodzin,string name) : base(name)
        {
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzin = liczbaGodzin;

        }
        public override double ObliczWynagrodzenie()
        {
            return stawkaGodzinowa * liczbaGodzin;
        }
    }
    public static void Main(string[] args)
    {
     List<Pracownik>pracownicy = new List<Pracownik>(); 
        pracownicy.Add(new PracownikEtatowy(3600, "Jacek sparrow"));
        pracownicy.Add(new ZlecenioBiorca(31.5, 140, "Harry pantofel"));
        pracownicy.Add(new PracownikEtatowy(1200, "Artur melex"));
        pracownicy.Add(new ZlecenioBiorca(53,160, "magazyniarz"));
        foreach (var pracownik in pracownicy)
        {
            Console.WriteLine($"{pracownik.name} zarabia: {pracownik.ObliczWynagrodzenie()}");
        }
        //foreach zrobiony za pomoca ai, gdyż nie wiedziałem jak sie odwołac do listy obietków
    }
}