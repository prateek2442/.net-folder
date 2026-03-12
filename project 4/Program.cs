using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional statement in c#
            // wap to find max number from 3 number by using ladder if or nested if 

            int a , b, c;

            Console.WriteLine("enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a is largest number");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is larget");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c is largest");
            }
        }
    }
}
