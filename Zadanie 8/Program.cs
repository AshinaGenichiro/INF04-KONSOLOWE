using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random generator = new Random();

        Console.Write("Ile zestawow chcesz wylosowac:");
        int n = int.Parse(Console.ReadLine());
        int[,] zestawy = new int[n,6];

        for (int w = 0; w < n; w++)
        {
            bool[] uzyte = new bool[50];
            int ile = 0;
            while (ile < 6)
            {
                int kandydat = generator.Next(1, 50); 
                if (!uzyte[kandydat])
                {
                    zestawy[w, ile] = kandydat;
                    uzyte[kandydat] = true;
                    ile++;
                }
            }
        }
        for (int w = 0; w < n; w++)
        {
            Console.Write("Zestaw nr " + (w + 1) + ": ");
            for (int k = 0; k < 6; k++)
            {
                Console.Write(zestawy[w, k] + " ");
            }
            Console.WriteLine();
        }
        int[] licznik = new int[50];
        for (int w = 0; w < zestawy.GetLength(0); w++)
        {
            for (int k = 0; k < zestawy.GetLength(1); k++)
            {
                int liczba = zestawy[w, k];
                licznik[liczba]++; 
            }
        }
        Console.WriteLine("Częstość wystąpień liczb:");
        for (int i = 1; i <= 49; i++)
        {
          if (licznik[i] > 0)
            {
                Console.WriteLine("Liczba " + i + ": " + licznik[i] + " raz(y)");
            }
        }
    }
}