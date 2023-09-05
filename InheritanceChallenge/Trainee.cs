using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceChallenge
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, decimal salary, int workingHours, int schoolHours)
            : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} {Name} is working for {WorkingHours} hours.");
        }

        public void Learn()
        {
            Console.WriteLine($"{FirstName} {Name} is learning for {SchoolHours} hours.");
        }
    }
}
