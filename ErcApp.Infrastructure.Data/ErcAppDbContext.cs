using ErcApp.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Infrastructure.Data
{
    public class ErcAppDbContext : DbContext
    {
        public ErcAppDbContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<Indication> Indications { get; set; } = null!;
    }
}
