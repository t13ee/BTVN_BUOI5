using BTVN5.Models;
using BTVN5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BTVN5.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.Include(b => b.Category).ToListAsync();
            var categories = await _context.Categories
                .Select(c => new CategoryCountViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Count = c.Books.Count
                })
                .ToListAsync();

            var viewModel = new HomeViewModel
            {
                Books = books,
                Categories = categories
            };

            return View(viewModel);
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
