using System;

namespace Urion_1035
{
    class Program
    {
        static void Main(string[] args)
        {
        /// Leia 4 valores inteiros A, B, C e D. Então, se B for maior do que C e D for maior do que A e se a soma de C e D for maior do que a soma de A e B e se C e D forem valores positivos e se A for par, escreva a mensagem “Valores aceitos” (Valores aceitos). Caso contrário, escreva a mensagem “Valores nao aceitos” (Valores não aceites).

        /// Entrada
        /// Quatro números inteiros A, B, C e D.

        /// Resultado
        /// Mostra a mensagem correspondente após a validação dos valores.

        int A, B, C, D;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);
        D = int.Parse(vet[3]);

            if(B > C && D > A && D+C > A+B && C > 0 && D > 0 && A %2 ==0)
            {
            Console.WriteLine("Valores aceitos");
            }
            else
            {
            Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
