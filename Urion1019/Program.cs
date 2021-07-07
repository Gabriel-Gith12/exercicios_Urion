using System;

namespace Urion1019
{
    class Program
    {
        static void Main(string[] args)
        {

        ///Read an integer value, which is the duration in seconds of a certain event in a factory, and inform it expressed in hours:minutes:seconds.

        ///Input
        ///The input file contains an integer N.

        ///Output
        ///Print the read time in the input file (seconds) converted in hours:minutes:seconds like the following example.

        int valor, horas, minutos, segundos, resto;

        valor = int .Parse(Console.ReadLine());
        /// hora 60 minutos, 3600 segundos
        horas = valor / 3600;
        resto = valor % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);


        }
    }
}
