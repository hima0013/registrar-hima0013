using Microsoft.EntityFrameworkCore;
using registrar_hima0013.Models;

namespace registrar_hima0013.Data
{
    public class RegistrarContext : DbContext
    {
        public RegistrarContext(DbContextOptions<RegistrarContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define composite primary key for the Registration table
            modelBuilder.Entity<Registration>()
                .HasKey(r => new { r.StudentId, r.CourseId });

            // Optional: Set up navigation relationships (if you want)
            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Student)
                .WithMany()
                .HasForeignKey(r => r.StudentId);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Course)
                .WithMany()
                .HasForeignKey(r => r.CourseId);
        }
    }
}
