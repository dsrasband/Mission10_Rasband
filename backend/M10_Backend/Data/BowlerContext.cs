using Microsoft.EntityFrameworkCore;

namespace M10_Backend.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<BowlerInfo> Bowlers { get; set; }
    }
}
