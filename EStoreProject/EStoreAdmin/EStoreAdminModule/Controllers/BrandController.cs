using EStoreAdminModel.Models.Brands;
using Microsoft.AspNetCore.Mvc;

namespace EStoreAdminModule.Controllers
{
    public class BrandController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ActionResult<List<BrandModel>> Index()
        {
            // Pass List of Brand Models
            List<BrandModel> brandModels = new List<BrandModel>
            {
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand A" },
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand B" },
                new BrandModel { Id = Guid.NewGuid(), Name = "Brand C" }
            };

            return View(brandModels);
        }


        // This returns a JSON response with the list of Brand Models instead of rendering a view.
        // Added for learning purpose. This data is provided to Angular front-end application.
        // The Angular application will consume this API to display the list of brands.
        //[HttpGet]
        //[Route("/")]
        //public ActionResult<List<BrandModel>> Index()
        //{
        //    // Pass List of Brand Models
        //    List<BrandModel> brandModels = new List<BrandModel>
        //    {
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Vivo" },
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Samsung" },
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Apple" }
        //    };

        //    return Ok(brandModels);
        //}
    }
}
