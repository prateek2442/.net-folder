using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    internal class Program
    {
        //WAP to demonstrate the use of UDF(user defined function)
        //A program to find the area of recetangle by using UDf passing parameter and no return type

        static void area(int len, int wid)
        {
            int res = len * wid;
            Console.WriteLine(" Area of Rectangle :" + res);


        }
        static void Main(string[] args)
        {
            area(10, 20);
        }
    }
}
