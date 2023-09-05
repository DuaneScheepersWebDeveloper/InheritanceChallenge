using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string firstName, decimal salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{FirstName} {Name} is working.");
        }

        public void Pause()
        {
            Console.WriteLine($"{FirstName} {Name} is taking a break.");
        }
    }
}
