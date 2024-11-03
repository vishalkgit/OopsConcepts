using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface question 4th one
namespace OopsConcepts
{
    public interface IFlyable
    {
        void FlyObj();
    }

    public class Spacecraft:IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft is Flying");
        }
    }
}
