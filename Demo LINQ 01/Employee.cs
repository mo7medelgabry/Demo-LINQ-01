using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LINQ_01
{
    internal class Employee
    {
        public int id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }


        public override string ToString()
        {
            return $"Id  : {id}, Name : {Name} , Salary : {Salary}";
        }



    }
}
