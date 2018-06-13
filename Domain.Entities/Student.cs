using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Department Department { get; set; }

        public int DepartmentId { get; set; }
        [Required]
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public virtual Grade Grade { get; set; }
        public int Gradeid { get; set; }
    }
}
