using AutoMapper;
using RentACar.Application.Features.Brands.Commands.CreateBrand;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<CreatedBrandDto, Brand>().ReverseMap();
        }
    }
}
