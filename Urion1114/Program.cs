﻿using System;

namespace Urion1114
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 

            Entrada
            A entrada é composta por vários casos de testes contendo valores inteiros.

            Saída
            Para cada valor lido mostre a mensagem correspondente à descrição do problema.*/
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}