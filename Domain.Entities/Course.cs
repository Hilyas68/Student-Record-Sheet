namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Unit { get; set; }
        //public virtual Student Student { get; set; }
        //public int StudentId { get; set; }
        //public virtual Grade Grade { get; set; }
        //public int GradeId { get; set; }
    }
}
