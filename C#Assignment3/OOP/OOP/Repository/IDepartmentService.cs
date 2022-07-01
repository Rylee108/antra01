using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    internal interface IDepartmentService<T> where T : class
    {
        int getHeadID();
        decimal getBudget();
        List<T> ClassName();
    }
}
