using Microsoft.EntityFrameworkCore;
using PacotesPetShop.Models;

namespace PacotesPetShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<BanhoModel> Banhos { get; set; }
    }
}
