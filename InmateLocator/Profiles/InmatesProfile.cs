using System;
using AutoMapper;
using InmateLocator.Helpers;

namespace InmateLocator.Profiles
{
    public class InmatesProfile : Profile
    {
        public InmatesProfile()
        {
            CreateMap<Entities.Inmate, Models.InmateDto>();
                //.ForMember(
                //    dest => dest.Name,
                //    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                //.ForMember(
                //    dest => dest.Age,
                //    opt => opt.MapFrom(src => $"{src.DateOfBirth.GetCurrentAge()}"));
        }
    }
}
