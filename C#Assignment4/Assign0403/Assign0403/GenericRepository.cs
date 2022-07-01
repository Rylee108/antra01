using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign0403
{
    public class GenericRepository : IRepository<CRUD>
    {
        public void Add(CRUD item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CRUD> GetAll()
        {
            throw new NotImplementedException();
        }

        public CRUD GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CRUD item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
