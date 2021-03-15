using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        // Quando se tem uma definiçao de coleçao deve-se 
        // definir a inicializaçao desta coleçao.
        // Como descrito abaixo
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(300)]

        public string ImagemUrl { get; set; }

        // Propriedade de navegaçao - Relacionamento entre as tabelas - EF
        // Uma categoria possui muitos produtos - 1-N
        public ICollection<Produto> Produtos { get; set; }
    }
}
