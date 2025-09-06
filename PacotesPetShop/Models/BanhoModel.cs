using System.ComponentModel.DataAnnotations;

namespace PacotesPetShop.Models
{
    public class BanhoModel
    {
        [Key] public int IdBanho { get; set; }
        [Required] public DateTime DataVisita { get; set; }
        public string Observacoes { get; set; } // Novo campo para observações
        public int IdCliente { get; set; } // Chave estrangeira
        public ClienteModel Cliente { get; set; } // Navegação
    }
}
