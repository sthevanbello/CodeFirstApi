using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApi.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Informar o Id do produto")]
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        [Required(ErrorMessage = "Informar o Id do pedido")]
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
    }
}
