using System;



namespace WalidacjaPesel

{

    class Program

    {

        static void Main()

        {

            Console.WriteLine("=== Sprawdzanie numeru PESEL ===");

            Console.Write("Podaj numer PESEL: ");

            string pesel = Console.ReadLine();
            string[] pesele = new string[3] { "44051401359", "02231406240", "85082103567" };



            // Najpierw sprawdzamy format, aby uniknąć błędów odwołania do znaków 

            if (!CzyPoprawnyFormat(pesel))

            {

                Console.WriteLine("Błąd: numer PESEL musi składać się dokładnie z 11 cyfr.");

                Console.ReadKey();

                return; // przerywamy program, gdy format jest niepoprawny 

            }



            // Wyznaczenie i wypisanie płci 

            char plec = OkreslPlec(pesel);

            if (plec == 'K')

            {

                Console.WriteLine("Płeć: Kobieta");

            }
            else
            {
                Console.WriteLine("Płeć: Mężczyzna");
            }
            // Sprawdzenie i wypisanie informacji o sumie kontrolnej 
            if (CzyPoprawnaSumaKontrolna(pesel))
            {
                Console.WriteLine("Suma kontrolna: zgodna (numer poprawny).");
            }
            else
            {
                Console.WriteLine("Suma kontrolna: niezgodna (numer błędny).");
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć…");

            LiczbaKobiet(pesele);




            Console.ReadKey();
        }
        /********************************************** 

        * Nazwa funkcji: OkreslPlec 

        * Opis działania: ustala płeć na podstawie dziesiątej cyfry numeru PESEL 

        * Parametry: pesel — napis z jedenastoma cyframi numeru PESEL 

        * Zwracana wartość: 'K' dla kobiety lub 'M' dla mężczyzny (char) 

        * Autor: numer zdającego 

        **********************************************/
        static char OkreslPlec(string pesel)
        {
            int cyfraPlci = pesel[9] - '0';
            return (cyfraPlci % 2 == 0) ? 'K' : 'M';
        }
        static bool CzyPoprawnaSumaKontrolna(string pesel)
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                int cyfra = pesel[i] - '0';
                suma += cyfra * wagi[i];
            }
            int cyfraKontrolnaObliczona = (10 - (suma % 10)) % 10;
            int cyfraKontrolnaZPesel = pesel[10] - '0';
            return cyfraKontrolnaObliczona == cyfraKontrolnaZPesel;
        }
        static bool CzyPoprawnyFormat(string pesel)
        {
            if (pesel == null || pesel.Length != 11)
            {
                return false;
            }
            foreach (char znak in pesel)
            {
                if (!char.IsDigit(znak))
                {
                    return false;
                }
            }
            return true;
        }
        static void LiczbaKobiet(string[] peseleTablica)
        {
            int iloscKobiet = 0;
            for (int i = 0; i < peseleTablica.Length; i++)
            {
                char plec = OkreslPlec(peseleTablica[i]);
                if(plec == 'K')
                {
                iloscKobiet++;
                }
            }
            Console.WriteLine($"Ilosć kobiet: {iloscKobiet}");
        }

    }

}