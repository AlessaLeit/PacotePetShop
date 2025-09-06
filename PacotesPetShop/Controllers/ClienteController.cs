using Microsoft.AspNetCore.Mvc;
using PacotesPetShop.Data;
using PacotesPetShop.Models;

namespace PacotesPetShop.Controllers
{
    public class ClienteController : Controller
    {
        readonly private ApplicationDbContext _db;
        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ClienteModel> clientes = _db.Clientes;
            return View(clientes);
        }
    }
}
