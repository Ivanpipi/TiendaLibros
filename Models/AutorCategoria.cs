using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaLibros.Models
{

    [Table("tbl_AutorCategoria")]
    public class AutorCategoria
    {

        [Key]
        public int AutorCatId { get; set; }
        [Column("Categoria", TypeName = "ntext")]
        [MaxLength(20)]
        public string TipoCategoria { get; set; }

        public virtual Autor Autor { get; set; }
    }
}