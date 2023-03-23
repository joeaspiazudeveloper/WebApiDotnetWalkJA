using System;
using WebAPIWalkJA.Models.Domain;

namespace WebAPIWalkJA.Repositories
{
	public interface IRegionRepository
	{
		Task<IEnumerable<Region>> GetAllAsync();
	}
}

