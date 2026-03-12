using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("enter the number");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) Console.WriteLine("a is an even number");

            else Console.WriteLine("b is an odd number");
        }
    }
}
