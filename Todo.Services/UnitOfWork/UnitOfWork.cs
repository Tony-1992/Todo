using Todo.DataAccess;
using Todo.Services.TodoServices;

namespace Todo.Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ITodoService TodoService { get; private set; }
        
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            TodoService = new TodoService(_db);
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
