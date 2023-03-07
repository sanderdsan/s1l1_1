using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        double[] I = new double[10];
        for (int i = 0; i<10; i++)
        {
            double number = rnd.Next(0, 4) + Math.Round(rnd.NextDouble(), 1);
            I [i]  = number;
        }
        Console.WriteLine("Сила струму:");
        Console.WriteLine(string.Join("  ", I));

        double[] U = new double[10];
        for (int i = 0; i < 10; i++)
        {
            double number = rnd.Next(3, 10) + Math.Round(rnd.NextDouble(), 1);
            U[i] = number;
        }
        Console.WriteLine("Напруга:");
        Console.WriteLine(string.Join("  ", U));

        double[] R = new double[10];
        for (int i = 0; i < 10; i++)
        {            
            R[i] = U[i] / I[i];
        }

        double avgR = R.Average();
        double avgI = I.Average();
        double avgU = U.Average();

        double CalcR = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(avgR,2) - Math.Pow(avgU/avgI, 2))), 2);

        Console.WriteLine($"Опір R = {avgR} +- {CalcR}");
    }
}
