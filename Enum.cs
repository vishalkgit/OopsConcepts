using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code for enumeration
namespace OopsConcepts
{
    public enum Department { HR=1,Sales,Dev,Testing,Admin}

    public enum Roles {Employee=100,Manager=200, Ceo=300, HRManager=400 }
    public class Emp
        {
        private int id;
        private string name;
        private Department dept;
        private Roles roles;

        public Emp(int id,string name,Department dept, Roles roles)
        {
            this.id = id;   
            this.name = name;
            this.dept = dept;
            this.roles = roles;
        }

        public override string ToString()
        {
            return $"{id},{name},{dept},{roles}";
        }

    }
}
