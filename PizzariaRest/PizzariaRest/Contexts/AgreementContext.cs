using System;
using Microsoft.EntityFrameworkCore;
using PizzariaRest.Models;

namespace PizzariaRest.Contexts
{
    public class AgreementContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DbAgreement");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Agreement> Agreements { get; set; }
    }
}
