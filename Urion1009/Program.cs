using System;
using System.Globalization;

namespace Urion1009
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Make a program that reads a seller's name, his/her fixed salary and the sale's total made by
            /// himself/herself in the month (in money). Considering that this seller receives 15% over all products sold,
            /// rite the final salary (total) of this seller at the end of the month , with two decimal places.
            /// MANGOJATA
            /// 1700,00
            /// 1230,50
            /// TOTAL = R $ 1.884,58

            string nome;
            double salarioFixo, vendas, comissao = 0.15, total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salarioFixo + (vendas * comissao);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
