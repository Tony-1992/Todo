using Todo.DataAccess;
using Todo.DataAccess.Generics;
using Todo.Domain;

namespace Todo.Services.TodoServices
{
    public class TodoService : BaseRepository<TodoItem>, ITodoService
    {
        private readonly ApplicationDbContext _db;
        public TodoService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public TodoItem GetTodoById(Guid id)
        {
            return _db.Todos.FirstOrDefault(t => t.Id == id);
        }

        public void Update(TodoItem item)
        {
            _db.Todos.Update(item);
        }
    }
}
