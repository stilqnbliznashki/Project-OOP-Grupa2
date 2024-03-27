using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    internal class Department
    {

        public static List <Employee> employees = new List <Employee> ();

        

        public static void AddMember(string name, int age)
        {
            employees.Add(new Employee(name,age));
        }

        public static void GetOldest()
        {
            int ageOfOldest = 0;
            string nameOfOldest = "";
            foreach(Employee emp in employees)
            {
               if(emp.age > ageOfOldest)
                {
                    ageOfOldest = emp.age;
                    nameOfOldest = emp.name;
                }
            }
            Console.WriteLine($"Oldest employee is:\n {nameOfOldest} {ageOfOldest}");
        }

    }
}
