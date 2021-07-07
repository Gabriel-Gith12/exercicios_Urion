using System;

namespace Urion_1113
{
    class Program
    {
        static void Main(string[] args)
        {
        /// Leia um número indeterminado de pares de valores inteiros. Escreva uma mensagem para cada par indicando se esses dois números estão em ordem crescente ou decrescente.

        /// Entrada
        /// O arquivo de entrada contém vários casos de teste. Cada caso de teste contém dois números inteiros X e Y. A entrada terminará quando X = Y.

        /// Resultado
        /// Para cada caso de teste imprima “Crescente”, se os valores X e Y estão em ordem crescente, caso contrário imprima “Decrescente”.

        /// Variaveis
        string[] vet;
        int X, Y;

        /// Entrada
        vet = Console.ReadLine().Split(' ');
        X = int.Parse(vet[0]);
        Y = int.Parse(vet[1]);

            while(X != Y)
            {
                if(X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
