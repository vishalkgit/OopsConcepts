using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code for partial 
namespace OopsConcepts
{
    public partial class Calc
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }
        partial void Divide(int a, int b);
    }

}
