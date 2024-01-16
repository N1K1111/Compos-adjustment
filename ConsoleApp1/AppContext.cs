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


        public AppContext() { }
        /*
        public AppContext()
        {
            Database.EnsureCreated();
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=npgsql; Port=5432; Database=pgdb; Username=postgres; Password=123123;");
        }


    }
}
