using System;
using System.Globalization;

namespace Urion1048
{
    class Program
    {
        static void Main(string[] args)
        {
        /// A empresa ABC decidiu dar um aumento salarial aos seus funcionários, de acordo com a seguinte tabela:

        /// Salário	                Taxa de reajuste
        /// 0 - 400,00              15%
        /// 400,01 - 800,00         12%
        /// 800,01 - 1200,00        10%
        /// 1200,01 - 2000,00       7%
        /// Acima de 2.000,00       4%

        /// Leia o salário do funcionário, calcule e imprima o salário do novo funcionário, bem como o dinheiro ganho e o aumento percentual obtido pelo funcionário, com as respectivas mensagens em português, conforme exemplo abaixo.
        /// Entrada
        /// A entrada contém apenas um número de vírgula flutuante, com 2 dígitos após a vírgula decimal.

        /// Resultado
        /// Imprima 3 mensagens seguidas dos números correspondentes (ver exemplo) informando o novo salário, a proporção do dinheiro ganho e o percentual obtido pelo funcionário. Nota:
        /// Novo salario:  significa "Novo Salário "
        /// Reajuste ganho: significa "Dinheiro ganho"
        /// Em percentual: significa "Em percentagem"/
             double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;
            ///                Novo salario:       460.00
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
