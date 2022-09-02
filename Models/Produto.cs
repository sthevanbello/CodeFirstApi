using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApi.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informar o título do produto")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Informar o preço do produto")]
        public double Preco { get; set; }
        public bool Ativo { get; set; } = true;

        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
