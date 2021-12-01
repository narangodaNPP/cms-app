using cms_app.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Database
{
    class DatabaseRepository: DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Payment> Payment { get; set; }
       
    }
}
