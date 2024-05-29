using Microsoft.EntityFrameworkCore;

namespace JitTeam_Rekrutacja.Models
{
    public class VisitContext : DbContext
    {
        public VisitContext(DbContextOptions<VisitContext> options)
        : base(options)
        {
        }

        public DbSet<Visit> Visits { get; set; } = null!;

    }
}
