using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Model
{
    public class Course : BaseEntity
    {
        public Course(bool initialize) : base(initialize)
        {
        }
        public Course()
        {

        }

        [MaxLength(30)]
        public string? Name { get; set; }

        public List<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();
    }
}
