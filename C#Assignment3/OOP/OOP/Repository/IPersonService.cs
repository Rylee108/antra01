using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    internal interface IPersonService<T> where T : class
    {
        int getAge();
        decimal CalSalary();
        String getAddress();
    }
}
