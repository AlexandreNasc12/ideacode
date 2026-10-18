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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Empresa = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Assunto = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Mensagem = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Lixeira = table.Column<bool>(type: "boolean", nullable: false)
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
