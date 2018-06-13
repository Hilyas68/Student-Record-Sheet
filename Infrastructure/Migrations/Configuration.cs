namespace Infrastructure.Migrations
{
    using Domain.Entities;
    using System.Data.Entity.Migrations;
    using Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.RecordSheetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infrastructure.RecordSheetDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var students = DummyData.GetStudents();
            var courses = DummyData.GetCourses();
            var grades = DummyData.GetGrades();
            var depts = DummyData.GetDepartments();


            context.Set<Student>().AddRange(students);
            context.Set<Course>().AddRange(courses);
            context.Set<Grade>().AddRange(grades);
            context.Set<Department>().AddRange(depts);
        }
    }
}
