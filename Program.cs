using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student(101,"Vishal",89,85,92);
            //s1.Calculate(); 
            //s1.Display();
            //Student s2 = new Student(102, "Shivani", 95, 90, 89);
            //s2.Calculate();
            //s2.Display();

            //Bank b1 = new Bank();
            //b1.Deposit();
            //b1.Withdraw();
            //b1.GetBalance();

            //Product p1 = new Product(101, "Mouse", 1800);
            //p1.Percentage();

            //Book b1 = new Book(101, "Harry Potter and the Half-Blood Prince", 1500, "J.K.Rowling");
            //b1.Display();

            //// option1
            //Date d1 = new Date(1, "Jan", 2025);

            //Employee emp1 = new Employee("Amol", 45600, d1);
            //emp1.CalculateSalary();
            //Console.WriteLine(emp1);

            //// option2

            //Employee emp2 = new Employee("Raj", 34000, new Date(1, "Nov", 2024));
            //emp2.CalculateSalary();
            //Console.WriteLine(emp2);


            //SalesManager sm1 = new SalesManager("Rohan", 34000, d1, 5000, 6700);
            //sm1.CalculateSalary();
            //Console.WriteLine(sm1);// want to print sm1 object information -> ToString()

            //Employee emp3 = new SalesManager("Suraj", 33000, d1, 4500, 5500);
            //emp3.CalculateSalary(); // compile time , it call Employee method
            //// late binding , runtime polymorphism / dynamic binding
            //Console.WriteLine(emp3);

            //Date d1 = new Date(1, "Jan", 2025);

            //Date d1 = new Date(5, "FEB", 2024);
            //Ceo c1 = new Ceo("Vishal",350000,d1,10,"ABC");
            //c1.CalculateSalary();
            //Console.WriteLine(c1);


            //Rectangle r1 = new Rectangle(5, 8);
            //r1.CalculateArea();
            //r1.CalculatePerimeter();
            //Console.WriteLine(r1);

            //Circle c1 = new Circle(5);
            //c1.CalculateArea();
            //c1.CalculatePerimeter();
            //Console.WriteLine(c1);

            //Triangle t1 = new Triangle(5.5, 8.8, 6, 8, 9);
            //t1.CalculateArea();
            //t1.CalculatePerimeter();
            //Console.WriteLine(t1);



            //SavingsAccount sa = new SavingsAccount(75000,25000);
            //sa.Deposit();
            //sa.Withdraw();

            //CurrentAccount ca = new CurrentAccount(89000, 18000);
            //ca.Deposit();
            //ca.Withdraw();


            //PartTime p1 = new PartTime(11, 200);
            //p1.CalculateSalary();
            //Console.WriteLine(p1);

            //FullTime f1 = new FullTime(10,500);
            //f1.CalculateSalary();
            //Console.WriteLine(f1);


            Spacecraft sp = new Spacecraft();
            sp.FlyObj();

            Airplane ap = new Airplane();
            ap.FlyObj();

            Helicopter h = new Helicopter();
            h.FlyObj();

        }
    }
}
