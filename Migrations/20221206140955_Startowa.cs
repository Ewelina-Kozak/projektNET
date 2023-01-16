using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zpnet.Migrations
{
    /// <inheritdoc />
    public partial class Startowa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Indeks = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezyser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datap = table.Column<DateTime>(name: "Data_u", type: "datetime2", nullable: true),
                    Czast = table.Column<string>(type: "nvarchar(max)", nullable: true),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
