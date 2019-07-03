using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Data.Models;

namespace WebAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ToDo Configure sql server in config
            optionsBuilder.UseSqlServer(
                @"Server=davis-pc\sqlexpress;Database=WebApi2;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasOne(p => p.Person)
                .WithMany(t => t.Loans)
                .HasForeignKey(m => m.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Loan>()
                .HasOne(p => p.OwingToPerson)
                .WithMany(t => t.LoansOwing)
                .HasForeignKey(m => m.OwingToId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
