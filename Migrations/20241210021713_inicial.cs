using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P2.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Datan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RG = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Estado_civil = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome_pai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nome_mae = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
