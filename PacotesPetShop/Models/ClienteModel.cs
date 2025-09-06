using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PacotesPetShop.Models
{
    public class ClienteModel
    {
        [Key] public int IdCliente { get; set; }
        public string Nome { get; set; }
        [Required] public string Cachorro { get; set; }
        [Column(TypeName = "decimal(10,2)")] public decimal Valor { get; set; }
        public List<BanhoModel> Banhos { get; set; } // Relacionamento 1:Nel
    }
}
