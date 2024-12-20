using Microsoft.AspNetCore.Mvc;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Services;

namespace Shop.Controllers
{
    public class CategoryController : Controller
    {
        readonly ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        public IActionResult Index()
        {
            var resualt = _categoryService.GetAllCategories();
            return View(resualt);
        }
        
    }
}
