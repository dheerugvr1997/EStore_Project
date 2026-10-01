using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreAdminService
{
    public class BrandService : IBrandService
    {
        public List<BrandModel> GetAllBrands()
        {
            // Pass List of Brand Models
            List<BrandModel> brandModels = new List<BrandModel>
            {
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand A" },
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand B" },
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand C" }
            };

            return brandModels;
        }

        public void GetBrand()
        {

        }
    }
}
