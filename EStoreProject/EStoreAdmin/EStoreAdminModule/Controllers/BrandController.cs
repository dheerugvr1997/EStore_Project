using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Services;
using EStoreAdminService;
using Microsoft.AspNetCore.Mvc;

namespace EStoreAdminModule.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        // Constructor Injection of IBrandService into BrandController
        // This is called Dependency Injection (DI)
        // i.e. Object is created outside of the class via IOC which injected into the class via constructor.
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet]
        [Route("/")]
        public ActionResult<List<BrandModel>> Index()
        {
            // But this is not a good practice to create service instance directly in the controller.
            // Instead, we should use Dependency Injection to inject the service into the controller.
            // Or else it will tightly couple the controller with the service implementation and make it difficult to test and maintain.
            //BrandService brandService = new BrandService();
            //IBrandService brandService = new BrandService();
            //brandService. => Shows only the methods defined in the IBrandService interface. But we want to access the methods defined in the BrandService class as well


            List<BrandModel> brandModels = _brandService.GetAllBrands();

            return View(brandModels);
        }

        #region Learning Angular + ASP.NET Core Integration
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
        #endregion
    }
}
