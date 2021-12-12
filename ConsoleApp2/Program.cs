// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Data;
using ConsoleApp2.Model;

Console.WriteLine("Enter course name");
var courseName = Console.ReadLine();
Console.WriteLine("Enter student name");
var studentName = Console.ReadLine();

var course = new Course(true)
{
    Name = courseName,
};

var student = new Student(true)
{
    Name = studentName
};

await using var db = new MyDbContext();

db.Add(student);
db.Add(course);

var studentCouse = new StudentCourse
{
    CourseId = course.Id,
    StudentId = student.Id,
    JoinDateTime = DateTimeOffset.Now.AddDays(-1),
};

db.Add(studentCouse);

await db.SaveChangesAsync();
