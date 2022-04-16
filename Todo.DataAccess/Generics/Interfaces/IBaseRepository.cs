using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain;

namespace Todo.DataAccess.Generics.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public void Add(T entity);
        public void Remove(T entity);

    }
}
