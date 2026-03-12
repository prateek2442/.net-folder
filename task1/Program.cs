using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the value of a & b :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int sub = a - b;
            int mult = a * b;
            int div = a / b;

            Console.WriteLine("the sum is :" + sum);
            Console.WriteLine("the sub is :" + sub);
            Console.WriteLine("the multiplication is :" + mult);
            Console.WriteLine("the division is :" + div);
        }
    }
}
