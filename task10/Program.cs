using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Student
    {
        int RollNo;
        string Name;

        internal void GetStuDetails()
        {
            Console.WriteLine("enter the Rollno of the Student : ");
            RollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name of the student : ");
            Name = Console.ReadLine(); 
        }

        internal void PrintStuDetails()
        {
            Console.WriteLine("Roll no. of Student : " + RollNo);
            Console.WriteLine("Name of the Student : " + Name);
        }

    }

    class Marks : Student
    {
        int Sub1, Sub2;

        internal void GetMarks()
        {
            GetStuDetails();

            Console.WriteLine("enter the marks of the sub1 and sub2 : ");
            Sub1 = int.Parse(Console.ReadLine());
            Sub2 = int.Parse(Console.ReadLine());
        }

        internal void PrintMarks()
        {
            PrintStuDetails();
            int a =Sub1 + Sub2;
            Console.WriteLine("total marks of the two subs are : " + a);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Marks mk = new Marks();
            mk.GetMarks();
            mk.PrintMarks();
        }
    }
}
