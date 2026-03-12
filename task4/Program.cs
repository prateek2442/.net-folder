using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("enter the marks of all 3 students : ");
            marks = int.Parse(Console.ReadLine());
            if (marks >= 90) Console.WriteLine("A grade");

            else if (marks >= 70 && marks <= 89) Console.WriteLine("B grade");

            else if (marks >= 50 && marks <= 69) Console.WriteLine("C grade");

            else Console.WriteLine("D grade");


        }
    }
}
