using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Product
    {
        private int pcode;
        private string pname;
        private double price;
        private double discount;

        public Product(int code,string nm,double pr)
        {
            pcode = code;
            pname = nm;
            price = pr;
        }

        public void Percentage()
        {
            if(price>1000)
            {
                discount= price*0.10;
                Console.WriteLine($"Total discount is {discount}");
            }
            else
            {
                Console.WriteLine("No Discount applicable for this product, because product price is not greater than 1000 ");
            }

            
        }
    }
}
