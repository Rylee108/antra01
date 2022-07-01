using OOP.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    internal class PersonRepository : IPersonService<Person>
    {
        public decimal CalSalary()
        {
            throw new NotImplementedException();
        }

        public string getAddress()
        {
            throw new NotImplementedException();
        }

        public int getAge()
        {
            throw new NotImplementedException();
        }
    }
}
