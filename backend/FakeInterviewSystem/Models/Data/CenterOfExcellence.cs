using System.ComponentModel.DataAnnotations;

namespace FakeInterviewSystem.Models.Data
{
    public class CenterOfExcellence
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; } = null!;
        public List<Topic> Topics { get; set; } =new List<Topic>();
    }
}
