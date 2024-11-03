using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//abstract class and inheritence assignment 3rd question
namespace OopsConcepts
{
    abstract public class Employees
    {
        public abstract void CalculateSalary();
    }

    public class PartTime:Employees
    {
        private int working_hours;
        private int salaryperhours;
        private int totalsal;

        public PartTime(int working_hours, int salaryperhours)
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
            return $"Total Salary of PartTime Employee is {totalsal}";
        }
    }
}
