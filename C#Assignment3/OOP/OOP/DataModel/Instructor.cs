using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataModel
{
    public class Instructor : Person
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public DateTime WorkingDate { get; set; }
        public decimal salary { get; set; }
    }
}
