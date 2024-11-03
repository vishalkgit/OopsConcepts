using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3rd question of inheritence
namespace OopsConcepts
{
    public class FullTime:Employees
    {
        private int working_hours;
        private int salaryperhours;
        private int totalsal;

        public FullTime(int working_hours, int salaryperhours)
        {
            this.working_hours = working_hours;
            this.salaryperhours = salaryperhours;
        }

        public override void CalculateSalary()
        {
            totalsal = salaryperhours * working_hours;
        }

        public override string ToString()
        {
            return $"Total Salary of FullTime Employee is {totalsal}";
                 
        }
    }
}
