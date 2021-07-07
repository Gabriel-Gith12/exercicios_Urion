using System;

namespace Urion1013
{
    class Program
    {
        static void Main(string[] args)
        {

		/// Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:

        /// Input.
        /// The input file contains 3 integer values.
		
		///Output.
		/// Print the greatest of these three values followed by a space and the message “eh o maior”.

		/// Variaveis.
		int a, b, c, maiorAB, maior;
		string[] vetor;

        /// Entrada de Dados.
		vetor = Console.ReadLine().Split(' ');

		a = int.Parse(vetor[0]);
		b = int.Parse(vetor[1]);
		c = int.Parse(vetor[2]);

		/// Processamento
        maiorAB = (a + b + Math.Abs(a - b)) / 2;
		maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

		/// Saida de Dados
		Console.WriteLine(maior + " eh o maior");

		}
    }
}
