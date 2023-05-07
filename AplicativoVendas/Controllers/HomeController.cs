using AplicativoVendas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AplicativoVendas.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppSettingsDbContext _context;
        private readonly ILogger<HomeController> _logger;
       /* public HomeController(AppSettingsDbContext context)
        {
            _context = context;
           // _logger = logger;
        } */

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

      /*  public async Task<Authentication> Index()
        {
            return await _context.Authentication.FirstAsync(s => s.Id == 1);
        } */

        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}