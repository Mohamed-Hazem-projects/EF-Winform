using Microsoft.EntityFrameworkCore;
using createDebi.Entities;

namespace createDebi
{
    public class DepiContext : DbContext
    {
        internal virtual DbSet<Topic> Topics { get; set; }
        internal virtual DbSet<Course> Courses { get; set; }
        internal virtual DbSet<Ins_Course> Ins_courses { get; set; }
        internal virtual DbSet<Instructor> Instructors { get; set; }
        internal virtual DbSet<Stud_Course> Stud_Courses { get; set; }
        internal virtual DbSet<Department> Departments { get; set; }
        internal virtual DbSet<Student> Students { get; set; }
        internal virtual DbSet<Student_audit> student_Audits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //change Data Source
            string connectionString = "Data Source=MOHAMED-HAZEM;Initial Catalog=DepiHazem;" +
                                      "Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.instructors)
                .HasForeignKey(i => i.Dept_Id);
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany(i => i.departments)
                .HasForeignKey(d => d.Dept_Manager);

            base.OnModelCreating(modelBuilder);
        }
        //add-migration [name]
        //update-database
    } 
}
