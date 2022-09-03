﻿using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Brands.Rules
{
    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Brand name exists.");
        }

        public async Task BrandIdIsThere(int id)
        {
            Brand? result = await _brandRepository.GetAsync(b => b.Id == id);
            if (result == null) throw new BusinessException("Brand id is null.");
        }
    }
}
