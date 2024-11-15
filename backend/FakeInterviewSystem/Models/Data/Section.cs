using System.ComponentModel.DataAnnotations;

namespace FakeInterviewSystem.Models.Data
{
    public class Section
    {
        public Guid Id { get; set; }
        
        [StringLength(150)]
        public string Name { get; set; } = null!;

        public Guid TopicId { get; set; }
        public Topic Topic { get; set; } = null!;

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
