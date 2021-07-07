using System;
using System.Globalization;

namespace Urion1012
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Faça um programa que leia três valores de ponto flutuante: A, B e C. Em seguida, calcule e mostre:
            /// a) a área do triângulo retângulo que tem base A e altura C.
            /// b) a área do círculo do raio C. (pi = 3,14159)
            /// c) a área do trapézio que tem A e B por base e C por altura.
            /// d) a área do quadrado que tem o lado B.
            /// e) a área do retângulo que tem os lados A e B.
            
            /// 3.0 4.0 5.2

            double A, B, C, Triangulo, Circulo, Trapezio, Quadrado, Retangulo, pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            /// formula do Triangulo = A * C / 2.0
            Triangulo = A * C / 2.0;
            /// formula do Circulo = 3.14159 * C * C
            Circulo = pi = 3.14159 * C * C;
            /// Formula do Trapezio = (A + B) / 2.0 * C
            Trapezio = (A + B) / 2.0 * C;
            /// formula do Quadrado = B * B
            Quadrado = B * B;
            /// formula do Retangulo = A * B
            Retangulo = A * B;

            /// TRIANGULO: 7.800;
            Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            /// CIRCULO: 84.949;
            Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            /// TRAPEZIO: 18.200;
            Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            /// QUADRADO: 16.000;
            Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            /// RETANGULO: 12.000;
             Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
 

        }
    }
}
