using BooksOnion.Domain.Repositories;
using BooksOnion.Infrastructure.Context;
using BooksOnion.Presantation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BooksOnion.Presantation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly IAuthorRepo _iauthorRepo;

        public HomeController(ILogger<HomeController> logger, IAuthorRepo iauthorRepo)
        {
            _logger = logger;
            _iauthorRepo = iauthorRepo;



        }

        public IActionResult Index()
        {
            return View(_iauthorRepo.GetAllAsync());
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