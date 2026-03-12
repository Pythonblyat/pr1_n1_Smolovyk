using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_n1_Smolovyk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smolovyk");
            int a;
            double x, y;
            Console.WriteLine("a");
            a = int.Parse(Console.ReadLine());
            x = 8.5 * a;
            y = 2.5 * x + ((5 + 4 * a) / (3 * a + 1));
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            double sqrt_y = Math.Sqrt(y);
            double sqrt_a_y = Math.Pow(x, a);
            Console.WriteLine($"sqrt_root Y = {sqrt_y}");
            Console.WriteLine($"X A = {sqrt_a_y}");

        }
    }
}
