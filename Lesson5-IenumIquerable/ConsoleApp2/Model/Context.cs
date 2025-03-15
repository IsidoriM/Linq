using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Model
{
    public  class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-KD5PU46V;Initial Catalog=MenuDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
