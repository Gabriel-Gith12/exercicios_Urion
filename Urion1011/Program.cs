using System;
using System.Globalization;

namespace Urion1011
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A
            /// fórmula para calcular o volume é: (4/3) * pi * R 3 . Considere (atribua) para pi o valor 3,14159.

            ///Dica: Use (4 / 3.0) ou (4.0 / 3) em sua fórmula, porque algumas linguagens (incluindo C ++) assumem que o
            ///resultado da divisão entre dois inteiros é outro inteiro. :)

            
            /// declarar as variaveis
            double raio, pi = 3.14159, volume;

            
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ///VOLUME = 113.097
            volume = (4.0 / 3) * pi * raio * raio * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
