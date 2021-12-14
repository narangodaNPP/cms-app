using cms_app.Models;
using Microsoft.EntityFrameworkCore;

namespace cms_app.Database
{
    class DatabaseRepository: DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<Classes> classess { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-QJ5QQA4H;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
