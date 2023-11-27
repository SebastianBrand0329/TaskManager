using Microsoft.EntityFrameworkCore;
using TaskManager.Shared.Entities;

namespace TaskManager.Backend.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
                
        }

        public DbSet<MyTask> MyTasks { get; set; }  
    }
}
