using Todo.Services.TodoServices;

namespace Todo.Services.UnitOfWork
{
    public interface IUnitOfWork
    {
        // Add services below
        public ITodoService TodoService { get; }
        public void Save();
    }
}
