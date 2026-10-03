using EStoreAdminModel.Models.Brands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreAdminModel.Services
{
    public interface IBrandService
    {
        List<BrandModel> GetAllBrands();

        void DeleteBrand(Guid Id);
    }
}
