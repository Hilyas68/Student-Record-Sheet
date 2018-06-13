using Domain.Entities;
using System.Collections.Generic;

namespace Web.Models
{
    public class DummyData
    {
        //-----------------------Grades----------------------
        public static Grade grade1 = new Grade { Type = "A" };
        public static Grade grade2 = new Grade { Type = "B" };
        public static Grade grade3 = new Grade { Type = "C" };
        public static Grade grade4 = new Grade { Type = "D" };
        public static Grade grade5 = new Grade { Type = "E" };
        public static Grade grade6 = new Grade { Type = "F" };

        //--------------------Depts-------------------------
        public static Department dept1 = new Department { Name = "Avengers" };
        public static Department dept2 = new Department { Name = "Wakanda" };
        public static Department dept3 = new Department { Name = "Incredibles" };

        //-------------------Courses---------------------------------------
        public static Course course1 = new Course { Code = "Mat101", Unit = 3, Title = "Introduction to Algebra" };
        public static Course course2 = new Course { Code = "Mat102", Unit = 2, Title = "Introduction to Statistics" };
        public static Course course3 = new Course { Code = "Mat103", Unit = 4, Title = "Introduction to Algebra II" };
        public static Course course4 = new Course { Code = "Mat104", Unit = 1, Title = "Vector Analysis" };
        public static Course course5 = new Course { Code = "Mat105", Unit = 5, Title = "Compiler Construction" };

        public static IEnumerable<Student> GetStudents()
        {

            var Students = new List<Student>()
            {
                new Student
                {
                    Name = "Mabi Chukwuma",
                    Department = dept1,
                    Grade = grade1,
                    Course = course1,
                },

                new Student
                {
                    Name = "Oriahi Emmanuel",
                    Department = dept2,
                    Grade = grade2,
                    Course = course3,
                },

                new Student
                {
                    Name = "Olowoniwa Gabriel",
                    Department = dept1,
                    Grade = grade2,
                    Course =course1,
                },

                new Student
                {
                    Name = "Aremu Omolola",
                    Department = dept3,
                    Grade = grade1,
                    Course = course5,
                },

                new Student
                {
                    Name = "Ochiaka Okey",
                    Department = dept3,
                    Grade = grade1,
                    Course = course4
                },

                new Student
                {
                    Name = "Osezuah Wnnie",
                    Department = dept1,
                    Grade = grade1,
                    Course = course2
                }
            };

            return Students;
        }

        public static IEnumerable<Grade> GetGrades()
        {
            return new List<Grade> { grade1, grade2, grade3, grade4, grade5, grade6 };

        }

        public static IEnumerable<Course> GetCourses()
        {
            return new List<Course> { course1, course2, course3, course4, course5 };

        }

        public static IEnumerable<Department> GetDept()
        {
            return new List<Department> { dept1, dept2, dept3 };

        }

    }
}