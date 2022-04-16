using Todo.DataAccess.Generics.Interfaces;
using Todo.Domain;

namespace Todo.Services.TodoServices
{
    public interface ITodoService : IBaseRepository<TodoItem>
    {
        public TodoItem GetTodoById(Guid id);
        public void Update(TodoItem item);
    }
}
