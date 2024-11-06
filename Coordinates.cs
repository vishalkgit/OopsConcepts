using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//another code for structure
namespace OopsConcepts
{
    public struct Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x + " " + y);
        }
    }

}
