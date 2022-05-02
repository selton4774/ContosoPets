using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Models
{
    public class Cliente
    {
       
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        #nullable enable
        public string? Endereço { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        #nullable disable
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
