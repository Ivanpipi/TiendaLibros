using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TiendaLibros.Models
{
    public partial class TiendaLibrosDbContext : DbContext
    {

        public DbSet<Autor> Autores { get; set; }
        public DbSet<AutorCategoria> AutoresCat { get; set; }

        public TiendaLibrosDbContext()
        {
        }

        public TiendaLibrosDbContext(DbContextOptions<TiendaLibrosDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-QNKN04C;user=DESKTOP-QNKN04C\\Ivan;trusted_connection=true;Database=TiendaLibros");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
