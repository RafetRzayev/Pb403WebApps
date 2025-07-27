namespace MvcDemo.Models
{
    public class HomeViewModel
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public HomeViewModel()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public HomeViewModel(List<Student> students, List<Teacher> teachers)
        {
            Students = students ?? new List<Student>();
            Teachers = teachers ?? new List<Teacher>();
        }
    }
}
