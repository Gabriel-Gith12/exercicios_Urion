using System;

namespace Urion1050
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
            Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, em inglês, com a primeira 
            letra maiúscula.

            Entrada
            A entrada contém um único valor inteiro.

            Saída
            Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.
            */

            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.WriteLine("January");
            }
            else if (m == 2)
            {
                Console.WriteLine("February");
            }
            else if (m == 3)
            {
                Console.WriteLine("March");
            }
            else if (m == 4)
            {
                Console.WriteLine("April");
            }
            else if (m == 5)
            {
                Console.WriteLine("May");
            }
            else if (m == 6)
            {
                Console.WriteLine("June");
            }
            else if (m == 7)
            {
                Console.WriteLine("July");
            }
            else if (m == 8)
            {
                Console.WriteLine("August");
            }
            else if (m == 9)
            {
                Console.WriteLine("September");
            }
            else if (m == 10)
            {
                Console.WriteLine("October");
            }
            else if (m == 11)
            {
                Console.WriteLine("November");
            }
            else
            {
                Console.WriteLine("December");
            }
        }
    }
}