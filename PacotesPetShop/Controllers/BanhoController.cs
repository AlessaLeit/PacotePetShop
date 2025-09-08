using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PacotesPetShop.Data;
using PacotesPetShop.Models;

namespace PacotesPetShop.Controllers
{
    public class BanhoController : Controller
    {
        readonly private ApplicationDbContext _db;
        public BanhoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BanhoModel> banhos = _db.Banhos
                .Include(b => b.Cliente) 
                .ToList();
            return View(banhos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
