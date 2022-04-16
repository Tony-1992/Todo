using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DataAccess.Generics.Interfaces;
using Todo.Domain;

namespace Todo.DataAccess.Generics
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _db;
        public DbSet<T> table;
        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
            table = _db.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Remove(T entity)
        {
           table.Remove(entity);
        }
    }
}
