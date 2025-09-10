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

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Clientes = _db.Clientes
                .Select(c => new { c.IdCliente, NomeCachorro = c.Nome + " - " + c.Cachorro })
                .ToList();
            if (!ViewBag.Clientes.Any())
            {
                Console.WriteLine("Nenhum cliente encontrado!");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(BanhoModel banho)
        {
            if (ModelState.IsValid && banho.IdCliente != 0)
            {
                _db.Banhos.Add(banho);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Se deu erro, recarrega o dropdown
            ViewBag.Clientes = _db.Clientes
                .Select(c => new { c.IdCliente, NomeCachorro = c.Nome + " - " + c.Cachorro })
                .ToList();

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                // Log ou exiba os erros para depuração
                Console.WriteLine(string.Join(", ", errors));
                ViewBag.Clientes = _db.Clientes
                    .Select(c => new { c.IdCliente, NomeCachorro = c.Nome + " - " + c.Cachorro })
                    .ToList();
                return View(banho);
            }

            return View(banho);
        }








    }
}
