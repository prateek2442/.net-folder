using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WAP to read any 10 numbers in an array and print them in sorted order 

            int[] dev = new int[10];
            Console.WriteLine("enter any 10 numbers");
            for (int i = 0; i < dev.Length; i++)
            {
                dev[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(dev);
            Console.WriteLine("sorted items are : ");
            for (int i = 0;i < dev.Length;i++)
            {
                Console.WriteLine(dev[i]);
            }
        }
    }
}
