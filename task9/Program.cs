using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Student
    {
        int Studentid;
        string Name, Course;

        internal void Getstudetails()
        {
            Console.WriteLine("enter the ID of student : ");
            Studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name of student : ");
            Name = Console.ReadLine();  
            Console.WriteLine("enter the course the student is in : ");
            Course = Console.ReadLine();
        }

        internal void Printstudetails()
        {
            Console.WriteLine("the ID of the student is : " + Studentid);
            Console.WriteLine("the name of the student is : " + Name);
            Console.WriteLine("the course student is in is : " + Course);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            std.Getstudetails();
            std.Printstudetails();
        }
    }
}
