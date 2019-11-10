using Microsoft.EntityFrameworkCore;
using TodoApp.Entities;

namespace TodoApp.DataAccess
{
    public class TodoAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionStringContainer.SQLiteConnectionString);
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
