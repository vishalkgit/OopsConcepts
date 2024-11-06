using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code for ref keyword
namespace OopsConcepts
{
    public class RefKey
    {
        static void SwapValue(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b=temp;
        }

        //static void Main(string[] args)
        //{
        //    int a = 10; int b = 20;
        //    Console.WriteLine($"Before Swapping a={a}, b={b}");
        //    SwapValue(ref a, ref b);
        //    Console.WriteLine($"After Swapping a={a}, b={b}");
        //}



    }


}
