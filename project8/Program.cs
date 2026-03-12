using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP to demonstrate the use of string in C#

            string str;
            Console.Write("enter a string");
            str = Console.ReadLine();
            Console.WriteLine("entered string : " + str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Length);
            // accessing character of specific index
            Console.WriteLine("characater of 3rd index" + str[3]);
            //Knowing index of specific character/word

            Console.WriteLine("First occurence index of i " + str.IndexOf("is"));
            Console.WriteLine("Last occurence index of  i" + str.LastIndexOf("i"));
        }
    }
}
