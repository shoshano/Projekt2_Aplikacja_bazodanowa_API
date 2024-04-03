using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt2_Aplikacja_bazodanowa_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    opening_crawl = table.Column<string>(type: "TEXT", nullable: false),
                    director = table.Column<string>(type: "TEXT", nullable: false),
                    producer = table.Column<string>(type: "TEXT", nullable: false),
                    release_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    species = table.Column<string>(type: "TEXT", nullable: false),
                    starships = table.Column<string>(type: "TEXT", nullable: false),
                    vehicles = table.Column<string>(type: "TEXT", nullable: false),
                    characters = table.Column<string>(type: "TEXT", nullable: false),
                    planets = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    birth_year = table.Column<string>(type: "TEXT", nullable: false),
                    eye_color = table.Column<string>(type: "TEXT", nullable: false),
                    gender = table.Column<string>(type: "TEXT", nullable: false),
                    hair_color = table.Column<string>(type: "TEXT", nullable: false),
                    hight = table.Column<string>(type: "TEXT", nullable: false),
                    mass = table.Column<string>(type: "TEXT", nullable: false),
                    skin_color = table.Column<string>(type: "TEXT", nullable: false),
                    homeworld = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    species = table.Column<string>(type: "TEXT", nullable: false),
                    starships = table.Column<string>(type: "TEXT", nullable: false),
                    vehicles = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "people");
        }
    }
}
