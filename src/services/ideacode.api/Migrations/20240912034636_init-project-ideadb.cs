using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ideacode.api.Migrations
{
    /// <inheritdoc />
    public partial class initprojectideadb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContatosWebSite",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Assunto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lixeira = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatosWebSite", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContatosWebSite");
        }
    }
}
