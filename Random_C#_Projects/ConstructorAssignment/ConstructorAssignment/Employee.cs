using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Employee
    {
        public int Id;
        public string name;

        public Employee(int Id) : this(Id, "Steve")
        {

        }

        public Employee(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
    }
}
