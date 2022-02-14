using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        { 
        }
        public DbSet<Produto> ToDoProducts { get; set; }
    }
}
