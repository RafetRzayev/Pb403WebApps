using PodCast.DataContext.Entities;

namespace PodCast.Models
{
    public class FooterViewModel
    {
        public List<Social> Socials { get; set; } = [];
        public Bio? Bio { get; set; }
    }
}
