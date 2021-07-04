using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//EF

namespace AdminkaMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tovar> TableTovar { get; set; }
        public DbSet<Order> TableOrder { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

    }
}
