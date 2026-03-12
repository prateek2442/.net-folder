using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (string arg in args)
            //{
            //    statement
            //}
            // WAP to demonstrate the use of foreach in C#
            int[] dev = new int[10];

            for (int i = 0; i < dev.Length; i++)
            {
                dev[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("after sorting");
            foreach (int a in dev) 
            {
                Console.WriteLine(a);
            }
        }
    }
}
