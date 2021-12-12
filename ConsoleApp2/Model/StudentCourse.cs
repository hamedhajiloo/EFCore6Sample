using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Model
{
    [Index(nameof(JoinDate))]
    public class StudentCourse
    {

        [ForeignKey(nameof(Student))]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        [ForeignKey(nameof(Course))]
        public Guid? CourseId { get; set; }
        public Course? Course { get; set; }

        public DateTimeOffset JoinDateTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime JoinDate { get; set; }
    }
}
