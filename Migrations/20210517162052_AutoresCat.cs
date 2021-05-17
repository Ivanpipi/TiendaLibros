using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaLibros.Migrations
{
    public partial class AutoresCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_AutorCategoria",
                columns: table => new
                {
                    AutorCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "ntext", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AutorCategoria", x => x.AutorCatId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_AutorCategoria");
        }
    }
}
