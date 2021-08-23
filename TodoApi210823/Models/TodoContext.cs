using Microsoft.EntityFrameworkCore;

namespace TodoApi210823.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}