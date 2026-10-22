//Determinar si el numero es par o impar: recursividad indirecta, determinando si un numero negativo es par o impar cumpliendo las siguientes funciones 1. Es Par() llama a EsImpar(). 2. EsImpar() llama a EsPar(). 3. El proceso termina cuando el numero llega a cero.﻿
using System;

class Program
{
    static void CuentaA(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("A: " + n);
        CuentaB(n - 1);
    }

    static void CuentaB(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("B: " + n);
        CuentaA(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Ingresa el numero inicial:  ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 1000");
            return;
        }

        CuentaA(n);
    }
}
