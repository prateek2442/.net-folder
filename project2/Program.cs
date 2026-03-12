using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            float radius, area;
            Console.Write("enter the radius :");
            radius = float.Parse(Console.ReadLine());
            area = PI * radius * radius;
            Console.Write("area is :" + area);
        }
        
    }
}
