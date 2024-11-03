using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsConcepts
{
    public class Ceo:Employee
    {
        private int experience;
        private string cname;
        // base keyword will call the base class constructor
        public Ceo(string nm, double basic, Date date, int experience,string cname) : base(nm, basic, date)
        {
            this.experience = experience;
            this.cname = cname;
            
        }

        // polymorphism - method overrding
        public override void CalculateSalary()
        {
            hra = basic * 0.30;
            da = basic * 0.25;
            pf = basic * 0.12;
            gross = (basic + hra + da ) - pf;
        }
        // ToString() - is used to represent object in string format
        public override string ToString() // overriding method from base class (object)
        {
            return $"Ceo experience is {experience}years, ceo cname is {cname}";
        }
    }
}
