using System;
using System.Globalization;

namespace Urion1079
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
            Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
            Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o 
            primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

            Entrada
            O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir 
            contém um caso de teste com três valores com uma casa decimal cada valor.

            Saída
            Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo 
            abaixo. */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){

            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}