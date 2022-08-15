using System;

namespace Urion1046
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
        sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração 
        mínima de 1 hora e máxima de 24 horas.

        Entrada
        A entrada contém dois valores inteiros representando a hora de início e a hora de fim 
        do jogo.

        Saída
        Apresente a duração do jogo conforme exemplo abaixo.*/

        int horaInícial , horaFinal, duracao;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        horaInícial = int.Parse(vet[0]);
        horaFinal = int.Parse(vet[1]);

        if(horaInícial  < horaFinal) {
            duracao = horaFinal - horaInícial;
            }
        else {
            duracao = 24 - horaInícial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}