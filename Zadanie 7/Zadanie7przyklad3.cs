using System;
public class tablice
{
    public static void Main(string[] args)
    {
     List<int> liczby = new List<int>();
        int liczba = 0;
        int suma = 0;
        do
        {
            Console.Write("Podaj liczbe:");
            liczba = int.Parse(Console.ReadLine());
            if(liczba == 0)
            {
             break;
            }else
            {
                liczby.Add(liczba);
            }
        } while (true);
        for (int i = liczby.Count - 1; i >= 0; i--)
        {
            if (liczby[i] < 0)
            {
                liczby.RemoveAt(i); 
            }
        }
        foreach (int i in liczby)
        {
            if(i > 0){
             Console.WriteLine(i);
                suma = suma + i;
            }
        }
        Console.WriteLine($"Suma: {suma}");
    }
}