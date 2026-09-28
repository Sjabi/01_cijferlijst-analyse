using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[] cijfers = LeesCijfers("cijfers.csv");

        Console.WriteLine($"Gemiddelde: {Gemiddelde(cijfers):F2}");
        Console.WriteLine($"Hoogste: {Hoogste(cijfers)}");
        Console.WriteLine($"Laagste: {Laagste(cijfers)}");
        Console.WriteLine($"Aantal geslaagd: {AantalGeslaagd(cijfers, 10)}");
    }

    static int[] LeesCijfers(string pad)
    {
        // TODO: lees cijfers.csv in (formaat: naam,cijfer per lijn) en geef een int[] terug
        throw new NotImplementedException();
    }

    static double Gemiddelde(int[] cijfers)
    {
        // TODO
        throw new NotImplementedException();
    }

    static int Hoogste(int[] cijfers)
    {
        // TODO
        throw new NotImplementedException();
    }

    static int Laagste(int[] cijfers)
    {
        // TODO
        throw new NotImplementedException();
    }

    static int AantalGeslaagd(int[] cijfers, int grens)
    {
        // TODO
        throw new NotImplementedException();
    }
}