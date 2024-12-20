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
        [HttpGet]
        public IActionResult Index()
        {
            var resualt = _categoryService.GetAllCategories();
            return View(resualt);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(string name , string description)
        {
            _categoryService.SetCategory(name, description);
            return RedirectToAction("Index");
        }

    }
}
