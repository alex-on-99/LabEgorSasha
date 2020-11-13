using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisLab4.Models;
using Microsoft.EntityFrameworkCore;

namespace KisLab4
{
    public class MyDbContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id=blog;Password=blog;Data Source=<ip or hostname>:1521/<service name>");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Good)
                .WithMany(g => g.Sales)
                .HasForeignKey(s => s.fk_Good_id);
        }
    }
}
