using System;
using AutoMapper;

namespace WebAPIWalkJA.Profiles
{
	public class RegionProfile: Profile
	{
		public RegionProfile()
		{
			CreateMap<Models.Domain.Region, Models.DTO.Region>()
				.ReverseMap();
		}
	}
}

