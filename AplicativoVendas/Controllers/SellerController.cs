using Microsoft.AspNetCore.Mvc;

namespace AplicativoVendas.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
