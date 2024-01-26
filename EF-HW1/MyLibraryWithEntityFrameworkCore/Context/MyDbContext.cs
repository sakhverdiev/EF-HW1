using Microsoft.EntityFrameworkCore;
using MyLibraryWithEntityFrameworkCore.Models;


namespace MyLibraryWithEntityFrameworkCore.Context 
{
    public class MyDbContext : DbContext
    {
        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<BookType>? BookTypes { get; set; }
        public DbSet<Operation>? Operations { get; set; }
        public DbSet<Student>? Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-KOTE4M2\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>().Ignore("Id");
            modelBuilder.Entity<Operation>().HasKey("StudentId", "BookId");
            base.OnModelCreating(modelBuilder);
        }
    }
}