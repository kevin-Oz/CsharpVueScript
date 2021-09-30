
using csharpVue.Models;
using Microsoft.EntityFrameworkCore;

namespace csharpVue.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        
        public DbSet<Task> Tasks { get; set; }
    }
}