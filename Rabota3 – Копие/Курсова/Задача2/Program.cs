using System;

class Задача2096
{
    static void Main()
    {
        int value = 2096;
        string bynary1 = Convert.ToString(value, 2);
        string bynary2 = Convert.ToString(value, 8);
        string bynary3 = Convert.ToString(value, 16);
        Console.WriteLine(bynary1);
        Console.WriteLine(bynary2);
        Console.WriteLine(bynary3);
    }
}