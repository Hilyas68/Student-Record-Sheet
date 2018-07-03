using Domain.Entities;
using System.Data.Entity;

namespace Infrastructure
{
    class RecordSheetDBContext : DbContext
    {
        public RecordSheetDBContext() : base("RecordSheet")
        {

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
