using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public sealed class CalculatorContext : DbContext
    {
        public DbSet<Expression>Expressions { get; set; }
        public DbSet<Result>Results { get; set; }

        public CalculatorContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder Options)  
        {
            Options.UseSqlServer("Server=DESKTOP-GFLE9ES\\MYSQLSERVER;Database=CalculatorDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expression>().HasKey(x => x.Id);
            modelBuilder.Entity<Result>().HasKey(x => x.Id);

            modelBuilder.Entity<Result>().HasOne(x => x.Expression)
                .WithOne(y => y.Result).HasForeignKey<Result>(z => z.ExpressionId);
        }
    }
}