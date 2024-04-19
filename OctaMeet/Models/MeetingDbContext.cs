using Microsoft.EntityFrameworkCore;

namespace OctaMeet.Models
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext(DbContextOptions<MeetingDbContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
    }
}
