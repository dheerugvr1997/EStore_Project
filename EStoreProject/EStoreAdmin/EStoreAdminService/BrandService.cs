using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Services;
using EStoreAdminRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreAdminService
{
    public class BrandService : IBrandService
    {
        private readonly BrandRepository _brandRepository;

        // Constructor Injection of BrandRepository into BrandService to get the data from the database. This is called Dependency Injection (DI)
        public BrandService(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public List<BrandModel> GetAllBrands()
        {
            // Pass List of Brand Models Manually
            //List<BrandModel> brandModels1 = new List<BrandModel>
            //{
            //    new BrandModel { Id = Guid.NewGuid(), Name = "Brand A" },
            //    new BrandModel { Id = Guid.NewGuid(), Name = "Brand B" },
            //    new BrandModel { Id = Guid.NewGuid(), Name = "Brand C" }
            //};

            // Get List of Brand Models from the Database using BrandRepository(This is the right way)
            List<BrandModel> brandModels = _brandRepository.Brands.ToList();


            return brandModels;
        }

        public void DeleteBrand(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new ArgumentException("Invalid brand Id.");
            }

            BrandModel? brandToDelete = _brandRepository.Brands.Where(b => b.Id == Id).FirstOrDefault();

            if (brandToDelete != null)
            {
                _brandRepository.Brands.Remove(brandToDelete);
                _brandRepository.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Brand not found.");
            }
        }
    }
}
