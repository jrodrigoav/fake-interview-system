using System.ComponentModel.DataAnnotations;

namespace FakeInterviewSystem.Models.Data
{
    public class Question
    {
        public Guid Id { get; set; }

        [StringLength(600)]
        public string Text { get; set; } = null!;

        [StringLength(600)]
        public string? ExpectedAnswer { get; set; }

        public Guid SectionId { get; set; }
        public Section Section { get; set; } = null!;
    }
}
