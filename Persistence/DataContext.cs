using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        //Create "DBSets" to represent tables (using: Domain)- quick fix:
        public DbSet<Activity> Activities { get; set; } //"Activities" is the table name.






    }
}