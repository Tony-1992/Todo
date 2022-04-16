using Microsoft.EntityFrameworkCore;
using Todo.Domain;

namespace Todo.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}