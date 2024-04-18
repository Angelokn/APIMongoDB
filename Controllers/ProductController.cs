using Microsoft.AspNetCore.Mvc;

namespace APIMongoDB.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
