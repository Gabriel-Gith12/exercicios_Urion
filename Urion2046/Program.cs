using System;

namespace Urion_2046
{
    class Program
    {
        static void Main(string[] args)
        {
        /// Leia a hora de início e de término de um jogo, em horas. Em seguida, calcule a duração do jogo, sabendo que o jogo pode começar em um dia e terminar
        /// em outro, com duração máxima de 24 horas. A mensagem deve ser impressa em português “O JOGO DUROU X HORA (S)” que significa “O JOGO DURADO X HORA (S)”

        /// Entrada
        /// Dois números inteiros que representam a hora de início e de término de um jogo.

        /// Resultado
        /// Imprima a duração do jogo como na saída de amostra.

        int início , término;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        início = int.Parse(vet[0]);
        término = int.Parse(vet[1]);




        }
    }
}