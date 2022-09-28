using Microsoft.EntityFrameworkCore;
using _3PEntidades.Models;

namespace _3PRepository
{
    public class DBCoreModelContext : DbContext
    {
        public DBCoreModelContext(DbContextOptions<DBCoreModelContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}