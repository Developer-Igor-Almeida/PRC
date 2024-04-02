using System.ComponentModel.DataAnnotations;

namespace Teste2.Models
{
    public class Produtos
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string? Nome { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O preço deve ser maior ou igual a zero.")]
        public decimal Preco { get; set; }
    }
}
