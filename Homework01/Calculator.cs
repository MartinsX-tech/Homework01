using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework01
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ievadi skaitli y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ievadi aritmētisko operāciju: ");
            string z = Console.ReadLine();

            if (z == "+")
            {
                Console.WriteLine(Utils.Add(x, y));
            } else if (z == "-")
            {
                Console.WriteLine(Utils.Subtract(x, y));
            } else if (z == "*")
            {
                Console.WriteLine(Utils.Multiply(x, y));
            } else if (z == "/")
            {
                Console.WriteLine(Utils.Divide(x, y));
            }

        }
    }
}
