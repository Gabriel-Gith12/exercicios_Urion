using System;

namespace Urion1002
{
    class Program
    {
        static void Main(string[] args)
        {

        double n = 3.14159, r;
        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A=" + (n*r*r).ToString("0.0000"));
        
        }
    }
}
