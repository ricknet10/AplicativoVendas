using AplicativoVendas.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoVendas.Controllers
{
    public class SellerController : Controller
    {

        private readonly SellerService _sellerService;

        public SellerController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
