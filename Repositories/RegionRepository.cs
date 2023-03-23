using System;
using Microsoft.EntityFrameworkCore;
using WebAPIWalkJA.Data;
using WebAPIWalkJA.Models.Domain;

namespace WebAPIWalkJA.Repositories
{
	public class RegionRepository: IRegionRepository
	{
        private readonly WalkDbContext walkDbContext;

        public RegionRepository(WalkDbContext walkDbContext)
		{
            this.walkDbContext = walkDbContext;
		}

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await walkDbContext.Region.ToListAsync();
        }
    }
}

