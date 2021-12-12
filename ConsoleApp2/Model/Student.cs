using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Model
{
    public class Student : BaseEntity
    {
        public Student()
        {

        }
        public Student(bool initialize) : base(initialize)
        {
        }

        [MaxLength(50)]
        public string? Name { get; set; }

        public List<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();

    }
}
