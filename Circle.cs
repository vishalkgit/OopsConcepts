using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2nd question of assesment 
namespace OopsConcepts
{
    public class Circle:Shape
    {
        private double r;
        private double area;
        private double perimeter;


        public Circle( double r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }

        public override void CalculatePerimeter()
        {
            perimeter = 2 * 3.14 * r;
        }


        public override string ToString()
        {
            return $"Area of circle is {area} and perimeter of circle id {perimeter}";
        }
    }
}
