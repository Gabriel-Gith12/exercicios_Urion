﻿using System;

namespace Urion1050
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
            Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

            Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
            DDD nao cadastrado

            Entrada
            A entrada consiste de um único valor inteiro.

            Saída
            Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.
            */

            int ddd = int.Parse(Console.ReadLine());

            if (ddd == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (ddd == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (ddd == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (ddd == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (ddd == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (ddd == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (ddd == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (ddd == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}