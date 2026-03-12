using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10
{
    internal class Program
    {
        class Employee
        {

            int EmpNo;
            string EmpName, Designation;
            internal double Salary;
            internal void ReadEmpData()
            {
                Console.Write("Enter Employee number/ ID: ");
                EmpNo=int.Parse(Console.ReadLine());
                Console.Write("Enter name of Employee: ");
                EmpName = Console.ReadLine();
                Console.Write("Enter designation of Employee: ");
                Designation = Console.ReadLine();
                Console.Write("Enter salary of employee: ");
                Salary = double.Parse(Console.ReadLine());
            }

            internal void PrintEmpData()
            {
                Console.WriteLine(" employee no. : " + EmpNo);
                Console.WriteLine("name of employee : " + EmpName);
                Console.WriteLine("Designation of employee  : " + Designation);
                Console.WriteLine("Salary of Employee : " + Salary);
            }
        }

        static void Main(string[] args)
        {
            // Accept data of 2 employee and then print name and salary of only that employee who is
            // getting max salary



            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Console.WriteLine("enter record of first employee : ");
            emp1.ReadEmpData();
            Console.WriteLine("enter record of  employee : ");
            emp2.ReadEmpData();
            Console.Clear();
            Console.WriteLine("Record of Employee ( Getting max salary ) : ");
            if (emp1.Salary > emp2.Salary) 
                emp1.PrintEmpData();
            else
                emp2.PrintEmpData();            
        }

    }
}
