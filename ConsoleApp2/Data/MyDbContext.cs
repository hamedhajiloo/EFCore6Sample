using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=TestZ;Integrated Security=True;App=Tralus");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentCourse>().HasKey(e => new { e.CourseId, e.StudentId });
            modelBuilder.Entity<StudentCourse>().Property(e => e.JoinDate).HasComputedColumnSql("CAST(JoinDateTime as date)");
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
