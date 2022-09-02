using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informar o nome do cliente")]
        [MaxLength(150)]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
