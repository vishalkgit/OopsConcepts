using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Student
    {
        private int sid;
        private string sname;
        private int science;
        private int maths;
        private int english;
        private int percentage;
        private int totalmarks;

        public Student(int id,string nm,int sc,int mat,int eng)
        {
            sid = id;
            sname = nm;
            science = sc;
            maths = mat;
            english = eng;
        }

        public void Calculate()
        {
            totalmarks = english + maths + science;
            percentage = totalmarks / 3;
        }

        public void Display()
        {
            Console.WriteLine($" Student id is {sid}, Student name is {sname}, Student total marks is {totalmarks}, Student got percentage {percentage}%");
        }
    }
}
