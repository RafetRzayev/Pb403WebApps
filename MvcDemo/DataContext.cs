using MvcDemo.Models;

namespace MvcDemo
{
    public static class DataContext
    {
        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student(1, "Alice"),
            new Student(2, "Bob"),
            new Student(3, "Charlie")
        };

        public static List<Teacher> Teachers { get; set; } = new List<Teacher>
        {
            new Teacher(1, "Mr. Smith"),
            new Teacher(2, "Ms. Johnson")
        };
    }
}
