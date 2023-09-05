using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string name, string firstName, decimal salary, string companyCar)
            : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"{FirstName} {Name} is leading.");
        }
    }
}
