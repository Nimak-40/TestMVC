using Microsoft.AspNetCore.Mvc;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Services;

namespace Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _service;

        public UserController()
        {
            _service = new UserService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registering(string username, string email, string password)
        {
            if (_service.RegisterUser(username, email, password))
                return RedirectToAction("Login");

            ViewBag.Error = "ایمیل از قبل ثبت شده است.";
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(string email, string password)
        {
            if (_service.LoginUser(email, password))
                return RedirectToAction("Index", "Category");

            ViewBag.Error = "ایمیل یا رمز عبور اشتباه است.";
            return View();
        }
    }
}
