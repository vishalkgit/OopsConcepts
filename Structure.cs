﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code for Structure
namespace OopsConcepts
{
    public struct Dept
    {
        private int id;
        private string name;

        public Dept(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Print()
        {
            return $"{id}, name = {name}";
        }
    }

}
