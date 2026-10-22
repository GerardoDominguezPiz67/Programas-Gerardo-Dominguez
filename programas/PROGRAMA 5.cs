//Invertir el orden de los digitos de un numero entero positivo mediante llamadas recursivas
using System;

class program
{
    static int SumarDigitos(int n)
    {
        if (n == 0)
            return 0;
        return n % 10 + SumarDigitos(n / 10);

    }
    static void Main ()
    {
        Console.Write("Ingresar un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("ingresa un numero positivo");
            return
        }
        Console.WriteLine("Sumar de digitos: " +
            SumarDigitos(n));


    }
}
