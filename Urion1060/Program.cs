using System;
using System.Globalization;

namespace Urion1060
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 6 valores. Estes valores serão somente negativos ou 
            positivos (desconsidere os valores nulos). A seguir, mostre a quantidade de valores 
            positivos digitados.

            Entrada
            Seis valores, negativos e/ou positivos.

            Saída
            Imprima uma mensagem dizendo quantos valores positivos foram lidos.*/

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int valorPositivo = 0;

            if (a > 0.0)
            {
                valorPositivo += 1;
            }

            if (b > 0.0)
            {
                valorPositivo += 1;
            }

            if (c > 0.0)
            {
                valorPositivo += 1;
            }

            if (d > 0.0)
            {
                valorPositivo += 1;
            }

            if (e > 0.0)
            {
                valorPositivo += 1;
            }

            if (f > 0.0)
            {
                valorPositivo += 1;
            }

            Console.WriteLine(valorPositivo + " valores positivos");
        }
    }
}