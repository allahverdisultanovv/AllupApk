using AllupApk.DAL;
using AllupApk.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AllupApk.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Slides = _context.Slides.ToList(),
                Products = _context.Product.ToList(),
                Categories = _context.Categories.ToList(),
                Brands = _context.Brands.ToList(),
                ProductImages = _context.ProductImages.ToList()
            };

            return View(homeVM);
        }
    }
}
