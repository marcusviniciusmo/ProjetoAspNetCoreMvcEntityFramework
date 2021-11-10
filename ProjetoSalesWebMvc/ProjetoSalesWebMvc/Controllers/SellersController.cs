using Microsoft.AspNetCore.Mvc;

namespace ProjetoSalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
