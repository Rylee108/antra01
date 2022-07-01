using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataModel
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Address { get; set; }
        public virtual decimal Salary { get; set; }

    }
}
