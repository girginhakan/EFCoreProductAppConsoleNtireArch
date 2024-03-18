using Ank16ProductApplication.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.DAL.Context
{
    public class ProductDbContext:DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HakanPC;Initial Catalog=Ank16ProductDb;Integrated Security=true;Encrypt=False");
        }
    }
}
