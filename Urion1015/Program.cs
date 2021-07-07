using System;
using System.Globalization;

namespace Urion1015
{
    class Program
    {
        static void Main(string[] args)
        
        { 
        /// Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them,
        /// showing four decimal places after the comma, according to the formula:

        /// Distance = 

        /// Input.
        /// The input file contains two lines of data. The first one contains two double values: x1 y1 and the second one also contains two double values with one
        /// digit after the decimal point: x2 y2.

        /// Output.
        /// Calculate and print the distance value using the provided formula, with 4 digits after the decimal point.
        
        
        /// Variaveis

        double x1,x2,y1,y2,distancia;
        string[] vetor;

        /// Entrada de Dados
        /// Primeira leitura

        vetor = Console.ReadLine().Split(' ');
        x1 = double.Parse(vetor[0],CultureInfo.InvariantCulture);
        y1 = double.Parse(vetor[1],CultureInfo.InvariantCulture);

        /// Segunda Leitura

        vetor = Console.ReadLine().Split(' ');
        x2 = double.Parse(vetor[0],CultureInfo.InvariantCulture);
        y2 = double.Parse(vetor[1],CultureInfo.InvariantCulture);

        /// Processamento

        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

        /// Saida

        Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));

        
        }
    }
}
