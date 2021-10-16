using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trackity.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext (DbContextOptions<ExpenseContext> options) : base(options) { }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Type> Types { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Type>().HasData(
                new Type { TypeId = "F", Name = "Fixed" },
                new Type { TypeId = "R", Name = "Recurring" },
                new Type { TypeId = "N", Name = "Non-Recurring" },
                new Type { TypeId = "W", Name = "Whammy" }
                );
            modelBuilder.Entity<Expense>().HasData(
                new Expense
                {
                    ExpenseId = 1,
                    Date = DateTime.Parse("09-24-2021"),
                    Name = "Rent Payment",
                    Cost = 600,
                    TypeId = "F"
                },
                new Expense
                {
                    ExpenseId = 2,
                    Date = DateTime.Parse("09-25-2021"),
                    Name = "Netflix",
                    Cost = 8.99,
                    TypeId = "F"
                },
                new Expense
                {
                    ExpenseId = 3,
                    Date = DateTime.Parse("09-25-2021"),
                    Name = "Gas",
                    Cost = 42.01,
                    TypeId = "R"
                },
                new Expense
                {
                    ExpenseId = 4,
                    Date = DateTime.Parse("09-26-2021"),
                    Name = "Bubba's",
                    Cost = 21.85,
                    TypeId = "R"
                }
                );
        }
    }

    
}
