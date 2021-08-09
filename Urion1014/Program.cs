using System;
using System.Globalization;

namespace Urion_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
            Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

            Entrada
            O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

            Saída
            Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
            */
            double kml;

            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml = X / Y;

            Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}