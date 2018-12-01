using System;

class Задача220абв
{
    static double Suma(int st, int br)
    {
        double s = 0;
        for (int i = 1; i <= br; i++)
        {
            s += 1.0 / Math.Pow(i, st);
        }
        return s;
    }
    static void Main()
    {
        double S = ((Suma(1, 15) + Suma(2, 10)) / Suma(3, 20));
        double SS = ((Suma(1, 10) + Suma(2, 10)) / Suma(3, 10));
        double SSS = ((Suma(1, 15) + Suma(1, 10)) / Suma(1, 20));
        Console.WriteLine("а) Сума= " + SSS);
        Console.WriteLine("б) Сума= " + SS); Console.WriteLine("в) Сума= " + S);
    }
}