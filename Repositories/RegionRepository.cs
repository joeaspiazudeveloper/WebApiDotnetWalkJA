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

        public async Task<Region> GetAsync(Guid id)
        {
            return await walkDbContext.Region.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region> AddAsync(Region region)
        {
            region.Id = Guid.NewGuid();
            await walkDbContext.AddAsync(region);
            await walkDbContext.SaveChangesAsync();
            return region;
            
        }

        public async Task<Region> DeleteAsync(Guid id)
        {
            var region = await walkDbContext.Region.FirstOrDefaultAsync(x => x.Id == id);

            if(region == null)
            {
                return region;
            }

            // Delete the region
            walkDbContext.Region.Remove(region);
            await walkDbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await walkDbContext.Region.FirstOrDefaultAsync(x => x.Id == id);

            if(existingRegion == null)
            {
                return existingRegion;
            }

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.Area = region.Area;
            existingRegion.Lat = region.Lat;
            existingRegion.Long = region.Long;
            existingRegion.Population = region.Population;


            await walkDbContext.SaveChangesAsync();
            return region;
        }
    }
}

