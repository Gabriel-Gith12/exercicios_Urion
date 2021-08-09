using System;

namespace Urion1036
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente 
            “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

            Entrada
            Leia três valores de ponto flutuante (double) A, B e C.

            Saída
            Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o 
            ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.        
            */

            String[] vet = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(vet[0]);
            double B = Convert.ToDouble(vet[1]);
            double C = Convert.ToDouble(vet[2]);

            if ((B * B - 4 * A * C) >= 0 && (2 * A) != 0)
            {
                double x1 = (-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);

                double x2 = (-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);

                Console.WriteLine("R1 = {0:0.00000}", x1);

                Console.WriteLine("R2 = {0:0.00000}", x2);
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}