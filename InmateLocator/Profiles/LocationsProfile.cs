using System;
using AutoMapper;

namespace InmateLocator.Profiles
{
    public class LocationsProfile : Profile
    {
        public LocationsProfile()
        {
            CreateMap<Entities.Location, Models.LocationDto>();
        }
    }
}
