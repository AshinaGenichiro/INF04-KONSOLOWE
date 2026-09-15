using System;

public class klasyobiekty
{ 
    public class KontoBankowe
    {
        public double saldo { get; private set;}
        public KontoBankowe(double saldo)
        {
            this.saldo = saldo;
        }
        public KontoBankowe()
        {
            saldo = 0;
        }
        public double Wplac ( double kwota)
        {
            saldo = saldo + kwota;
            return saldo;
        }
        public double Wyplac(double kwota)
        {
            if(kwota > 0)
            {

            if (kwota > saldo )
            {
                Console.WriteLine("Twoje saldo na koncie jest za male zeby tyle wyplacic");
            }
            else
            {
                saldo = saldo - kwota;
            }
            }
            else
            {
                Console.WriteLine("Prosze podać poprawna wartosc");
            }
            return saldo;
        }
        public void PokazSaldo()
        {
            Console.WriteLine($"Twoje saldo wynosi: {saldo}");
        }
    }
    public static void Main(string[] args)
    {
        KontoBankowe konto = new KontoBankowe();
        konto.PokazSaldo();
        konto.Wplac(300);
        konto.PokazSaldo();
        konto.Wyplac(301);
        konto.Wyplac(-123);
        konto.Wyplac(250);
        konto.PokazSaldo();
    }
}