using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11
{
    class student
    {
        int RollNo;
        string Name, Course;
        int Age;
        internal void SetStudentDetails()
        {
            Console.Write("Enter roll no. of students : ");
            RollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of student : ");
            Name = Console.ReadLine();
            Console.Write("enter the age of students : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter course name of student : ");
            Course = Console.ReadLine();
        }

        internal void PrintStudentDetail()
        {
            Console.WriteLine("RollNo. : " + RollNo);
            Console.WriteLine("Name is : " + Name);
            Console.WriteLine("Age is  : " + Age);
            Console.WriteLine("course is : " + Course);
        }
    }

    class Fees: student   //inheritence
    {
        float FeeAmount;
        string FeeSem;

        internal void SetFessData()
        {
            SetStudentDetails();    // Base class Function
            Console.Write("Enter fees Amount : ");
            FeeAmount = float.Parse(Console.ReadLine());
            Console.Write("Enter semester name for fees: ");
            FeeSem = Console.ReadLine();
        }

        internal void PrintFessData()
        {
            PrintStudentDetail();  // Base class Function
            Console.WriteLine("Amount of Fees : " + FeeAmount);
            Console.WriteLine("Semester name for fees : " + FeeSem);
        }
    }     

    internal class Program
    {
        static void Main(string[] args)
        {
            Fees f = new Fees();
            f.SetFessData();
            f.PrintFessData();
        }
    }
}
