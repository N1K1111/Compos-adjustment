using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        /*
        public AppContext()
        {
            Database.EnsureCreated();
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=pgdb; POSTGRES_USER=postgres; POSTGRES_PASSWORD=123123;");
        }


    }
}
