using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project12                 // demonstrating function overloading
{
    class Addition
    {
        internal void Add(int num1, int num2)
        {
            int r = num1 + num2;
            Console.WriteLine("Addition is : " + r);
        }   

        internal void Add(int num1, int num2 , int num3)
        {
            int r = num1 + num2 + num3;
            Console.WriteLine("Additon is : " + r);
        }

        internal void Add(float num1, float num2)
        {
            float f = num1 + num2;
            Console.WriteLine("Addition is : "  + f);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();
            a.Add(4, 5);
            a.Add(4.5f, 7.2f);
            a.Add(2, 3, 5);
        }
    }
}
