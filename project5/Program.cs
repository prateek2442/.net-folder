using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write a program to print a table of an entered number by using c#
            int num;
            Console.WriteLine("enter the number to print the table \n");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i<= 10; i++)
            {
                int b = num * i;
                Console.WriteLine(num + "*" + i + "=" + b );
            }
        }
    }
}
