using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Model
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() 
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=RegionalBank;Trusted_Connection=True;");
            }
        }

        public DbSet<SalesAssociate> SalesAssociate { get; set; }
         
        public DbSet<Subsidiary> Subsidiary { get; set; }   



    }
    
}
