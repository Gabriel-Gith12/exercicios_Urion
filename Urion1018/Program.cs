using System;

namespace Urion1018
{
    class Program
    {
        static void Main(string[] args)
        {
        //// In this problem you have to read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed. The possible
        /// banknotes are 100, 50, 20, 10, 5, 2 e 1. Print the read value and the list of banknotes.
        /// Input.
        /// The input file contains an integer value N (0 < N < 1000000).

        /// Output.
        /// Print the read number and the minimum quantity of each necessary banknotes in Portuguese language, as the given example. Do not forget to print the end of 
        /// line after each line, otherwise you will receive “Presentation Error”.

            //troco
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number);
            Console.WriteLine("{0} nota(s) de R$ 100,00",number/100);
            number = number % 100;
            Console.WriteLine("{0} nota(s) de R$ 50,00", number/50);
            number = number % 50;
            Console.WriteLine("{0} nota(s) de R$ 20,00",number/20);
            number = number % 20;
            Console.WriteLine("{0} nota(s) de R$ 10,00",number/10);
            number = number % 10;
            Console.WriteLine("{0} nota(s) de R$ 5,00",number/5);
            number = number % 5;
            Console.WriteLine("{0} nota(s) de R$ 2,00",number/2);
            number = number % 2;
            Console.WriteLine("{0} nota(s) de R$ 1,00",number/1);
    }

}
}
