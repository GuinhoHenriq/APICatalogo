using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int produtoId { get; set; }
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }
        [Required]
        
        public decimal Preco { get; set; }
        [Required]
        [StringLength(300)]
        public string ImagemUrl { get; set; }

        public float Estoque { get; set; }


        public DateTime DataCadastro { get; set; }

        public Categoria Categoria { get; set; }

        public int CategoriaID { get; set; }
    }
}
