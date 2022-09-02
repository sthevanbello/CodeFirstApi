using CodeFirstApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApi.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;
        [Required]
        public EStatusPedido Status { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
