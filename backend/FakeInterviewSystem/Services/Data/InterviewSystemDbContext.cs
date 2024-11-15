using FakeInterviewSystem.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace FakeInterviewSystem.Services.Data
{
    public class InterviewSystemDbContext : DbContext
    {
        public DbSet<CenterOfExcellence> COES { get; set; }
        public InterviewSystemDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
