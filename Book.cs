using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Book
    {
        private int bid;
        private string bname;
        private double bprice;
        private string author;


        public Book(int id,string nm, double pr, string aut)
        {
            bid = id;
            bname = nm;
            bprice = pr;
            author = aut;
        }

        public void Display()
        {
            Console.WriteLine($"Book id is {bid}, BookName is {bname}, Book price is {bprice}, Book Author is {author}");
        }
    }
}
