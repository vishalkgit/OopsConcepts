using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//abstract class 2nd question
namespace OopsConcepts
{
   abstract public class Shape
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }


    public class Rectangle : Shape
    {

        private int length;
        private int width;
        private int area;
        private int perimeter;
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
            
        }

        public override void CalculateArea()
        {
            area=length*width;  
        }

        public override void CalculatePerimeter()
        {
            perimeter=2*(length*width);
        }

        public override string ToString()
        {
            return $"Area of Rectangle is {area} and Perimeter of Rectangle is {perimeter}";
        }
    }


}
