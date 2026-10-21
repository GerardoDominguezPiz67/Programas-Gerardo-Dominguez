//programa 10.- covertir un numero decimal a binar
//objetivo convertir 

using System;
using System.ComponentModel.Design;
class Program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.Write(n)
                return;
        }
        BinarioA(BinarioA(n / 2);
    }
    static viod BinarioB(int n)
        console.Write(n%2);
    {
        static void Main()

    {
        Console.Write("ingresa un numero entero:");
        int n = int.Parse(Console.ReadLine());

        if(n<0)
        { Console.WriteLine("ingresa un numero no negativo:");
            return;
        }

        Console.Write("Binario");

        if(n==0)
            Console,Write("0");
        élse
            BinarioA(n);
        Console.WriteLine();
    }
    }
