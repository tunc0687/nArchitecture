using AutoMapper;
using Core.Persistence.Paging;
using RentACar.Application.Features.Brands.Commands.CreateBrand;
using RentACar.Application.Features.Brands.Commands.DeleteBrand;
using RentACar.Application.Features.Brands.Commands.UpdateBrand;
using RentACar.Application.Features.Brands.Dtos;
using RentACar.Application.Features.Brands.Models;
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

            CreateMap<UpdateBrandCommand, Brand>().ReverseMap();
            CreateMap<UpdatedBrandDto, Brand>().ReverseMap();

            CreateMap<DeleteBrandCommand, Brand>().ReverseMap();
            CreateMap<DeletedBrandDto, Brand>().ReverseMap();

            CreateMap<BrandListModel, IPaginate<Brand>>().ReverseMap();
            CreateMap<BrandListDto, Brand>().ReverseMap();
        }
    }
}
