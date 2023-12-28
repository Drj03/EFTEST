using Microsoft.EntityFrameworkCore;

namespace EFTest.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.CurrentGradeId);
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
      public DbSet<Employee> Employees { get; set; }
      public DbSet<Department> Departments { get; set; }

        public DbSet<Artists> artists { get; set; }
        public DbSet<Albums> albums { get; set; }
        public DbSet<Singles> singles { get; set; }

    }
}
