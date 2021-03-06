using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    internal interface ICourseService<T> where T : class
    {
        int getStudentID();
        String getCourseName();
    }
}
