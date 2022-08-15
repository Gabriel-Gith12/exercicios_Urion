using System;

namespace Urion1080
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 
            100 valores lidos.

            Entrada
            O arquivo de entrada contém 100 números inteiros, positivos e distintos.

            Saída
            Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo. */

            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for(int i = 2; i <= 100; i++) {
                int x = int.Parse(Console.ReadLine());
                if(x > maior){
                    maior = x;
                    posicao = i;
                }
            }   

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}