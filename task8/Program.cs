using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void findvowel()
        {
            string str;
            int count = 0;
            Console.WriteLine("enter a string");
            str = Console.ReadLine();
            str = str.ToLower ();
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count = count + 1;  
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            findvowel();
        }
    }
}
