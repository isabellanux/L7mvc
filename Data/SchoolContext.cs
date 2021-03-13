//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Date                  Developer                  Description
// 2021-03-03            bellatn                    --followed alongside video 22 and 23 and added components to the website
// 2021-03-12            bellatn                    --added comments to added elements, took screenshots, and submitted L7mvc

using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-03-bellatn-dykstra1] - creates a DbSet property for each entity class. This allows each entity
        // to be linked / corresponded to a database table where large amounts of information can easily be inputted, edited
        // and removed. 
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }


        //tinfo200:[2021-03-03-bellatn-dykstra1] - overrides the automatic naming of each table with the property name
        // by setting the name to the singularized version of each word. ex. Courses --> Course.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
