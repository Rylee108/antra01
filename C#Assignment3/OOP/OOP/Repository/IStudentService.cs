using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    public interface IStudentService<T> where T : class
    {
        List<T> getClass();
        decimal CalGPA();
        char getGrade();


    }
}
