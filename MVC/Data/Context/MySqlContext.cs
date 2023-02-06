
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<AuditLog> Logs { get; set; }

    }
}
