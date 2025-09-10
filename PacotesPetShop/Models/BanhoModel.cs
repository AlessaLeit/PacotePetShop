using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PacotesPetShop.Models
{
    public class BanhoModel
    {
        [Key]
        public int IdBanho { get; set; }

        [Required]
        public DateTime DataVisita { get; set; }

        public string Observacoes { get; set; }

        [Required]
        public int IdCliente { get; set; }  // FK

        [ForeignKey("IdCliente")]
        public ClienteModel Cliente { get; set; } // Navegação
    }
}
