using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number :");
            a = int.Parse(Console.ReadLine());

            if (a < 0) Console.WriteLine("a is negative");

            else Console.WriteLine("a is positive");

        }
    }
}
