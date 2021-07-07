using System;

namespace Urion1044
{
    class Program
    {
    static void Main(string[] args)
    {
        /// Leia dois valores nteger (A e B). A seguir, o programa deve imprimir a mensagem "Sao Multiplos" (são múltiplos) ou "Nao sao Multiplos" (não são múltiplos), correspondendo aos valores lidos.

        /// Entrada
        /// A entrada possui dois números inteiros.

        ///Resultado
        ///Imprima a mensagem relativa à entrada conforme indicado acima.

        int A, B;
        string[] vet;

        vet = Console.ReadLine().Split(' ');

        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);

        if (A % B == 0 || B % A == 0) {
            Console.WriteLine("Sao Multiplos");
        } else { 
            Console.WriteLine("Nao sao Multiplos");
        }
    }
    }  
}
