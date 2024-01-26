using ConsoleApp5.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp5.Contexts
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KOTE4M2\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite; Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Curator>? Curators{ get; set; }
        public DbSet<Deparment>? Deparments{ get; set; }
        public DbSet<Faculity>? Faculities{ get; set; }
        public DbSet<Group>? Groups{ get; set; }
        public DbSet<GroupAndCurator>? GroupAndCurators{ get; set; }
        public DbSet<GroupAndLecture>? GroupAndLectures{ get; set; }
        public DbSet<GroupAndStudent>? GroupAndStudents{ get; set; }
        public DbSet<Lecture>? Lectures{ get; set; }
        public DbSet<Student>? Students{ get; set; }
        public DbSet<Subject>? Subjects{ get; set; }
        public DbSet<Teacher>? Teachers{ get; set; }
    }
}
