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
            // wap a program to read and print name, age and salary of an employee
            string name;
            int age;
            float salary;

            Console.Write("enter the name:");
            name = Console.ReadLine();
            Console.Write("enter the age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("enter the salary :");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine("name : " + name + " age :" + age + " salary :" +  salary);
        }
    }
}
