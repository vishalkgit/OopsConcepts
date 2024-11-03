using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//abtract class 2nd question
namespace OopsConcepts
{
    public class Triangle:Shape
    {
        private double bs;
        private double h;
        private double a;
        private double b;
        private double c;
        private double area;
        private double perimeter;

        public Triangle(double bs,double h, double a,double b,double c)
        {
            this.bs = bs;
            this.h = h; 
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void CalculateArea()
        {
            area = 0.5 * bs * h;
        }

        public override void CalculatePerimeter()
        {
            perimeter = a + b + c;
        }

        public override string ToString()
        {
            return $"Area of Triangle is {area} and Perimeter of triangle is {perimeter}";
        }
    }
}
