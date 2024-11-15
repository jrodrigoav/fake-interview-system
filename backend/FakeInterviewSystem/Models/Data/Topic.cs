using System.ComponentModel.DataAnnotations;

namespace FakeInterviewSystem.Models.Data
{
    public class Topic
    {
        public Guid Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; } = null!;
        public int CenterOfExcellenceId { get; set; }

        public CenterOfExcellence CenterOfExcellence { get; set; } = null!;

        public List<Section> Sections { get; set; } = new List<Section>();  
    }
}
