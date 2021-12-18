using System;
using System.Globalization;

namespace Urion1021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

            Saída
            Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

            Obs: Utilize ponto (.) para separar a parte decimal.*/

            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor);

            Console.WriteLine("NOTAS:");

            Console.WriteLine($"{(int)(valor / 100)} nota(s) de R$ 100.00");
            valor %= 100;
            Console.WriteLine($"{(int)(valor / 50)} nota(s) de R$ 50.00");
            valor %= 50;
            Console.WriteLine($"{(int)(valor / 20)} nota(s) de R$ 20.00");
            valor %= 20;
            Console.WriteLine($"{(int)(valor / 10)} nota(s) de R$ 10.00");
            valor %= 10;
            Console.WriteLine($"{(int)(valor / 5)} nota(s) de R$ 5.00");
            valor %= 5;
            Console.WriteLine($"{(int)(valor / 2)} nota(s) de R$ 2.00");
            valor %= 2;

            Console.WriteLine("MOEDAS:");

            Console.WriteLine($"{(int)valor} moeda(s) de R$ 1.00");
            valor = valor % 1 * 100;
            Console.WriteLine($"{(int)(valor / 50)} moeda(s) de R$ 0.50");
            valor %= 50;
            Console.WriteLine($"{(int)(valor / 25)} moeda(s) de R$ 0.25");
            valor %= 25;
            Console.WriteLine($"{(int)(valor / 10)} moeda(s) de R$ 0.10");
            valor %= 10;
            Console.WriteLine($"{(int)(valor / 5)} moeda(s) de R$ 0.05");
            valor %= 5;
            Console.WriteLine($"{(int)valor} moeda(s) de R$ 0.01");
        }
    }
}