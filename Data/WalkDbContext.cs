using Microsoft.EntityFrameworkCore;
using WebAPIWalkJA.Models.Domain;

namespace WebAPIWalkJA.Data
{
	public class WalkDbContext: DbContext
    {
		public WalkDbContext(DbContextOptions<WalkDbContext> options): base(options)
		{
		}

		public DbSet<Region> Region { get; set; }

        public DbSet<Walk> Walk { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }


    }
}

