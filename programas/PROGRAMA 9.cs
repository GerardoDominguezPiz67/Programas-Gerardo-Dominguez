
using System;

class Program
{
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaB(n - 1);
    }

    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        return SumaA(n - 1);
    }

    static void Main()
    {
        Console.Write("ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("La suma es: " + SumaA(n));
        }
    }
}
