using Microsoft.AspNetCore.Mvc;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Services;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index()
        {
            var resualt = _productService.GetAllProcuts();
            return View(resualt);
        }
    }
}
