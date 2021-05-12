using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace TiendaLibros.Models
{
    public class Libro
    {


        public int idLibro { get; set; }

        [Required]
        [MaxLength(35, ErrorMessage = "El titulo solo puede contener 35 caracteres!")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El autor solo puede contener 20 caracteres!")]
        public string Autor { get; set; }

        [Required]
        public string Categoria { get; set; }

        [Range(1, 2021, ErrorMessage = "El año tiene que ser mayor que 1 y menor que 2021!")]
        public int AñoLanzamiento { get; set; }

        [Required]
        [Range(1, 9999, ErrorMessage = "El precio tiene que ser menor que 9999$!")]
        public double Precio { get; set; }

        public int FotoId { get; set; }

        public string FotoRuta { get; set; }

        [NotMapped()]
        public IFormFile Foto { get; set; }


    }
}