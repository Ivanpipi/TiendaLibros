using System.Collections.Generic;

namespace TiendaLibros.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public virtual List<Categoria> Categorias { get; set; }

    }
}