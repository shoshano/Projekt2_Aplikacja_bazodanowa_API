using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt2_Aplikacja_bazodanowa_API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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

            migrationBuilder.CreateTable(
                name: "planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    diameter = table.Column<string>(type: "TEXT", nullable: false),
                    rotation_period = table.Column<string>(type: "TEXT", nullable: false),
                    orbital_period = table.Column<string>(type: "TEXT", nullable: false),
                    gravity = table.Column<string>(type: "TEXT", nullable: false),
                    population = table.Column<string>(type: "TEXT", nullable: false),
                    climate = table.Column<string>(type: "TEXT", nullable: false),
                    terrain = table.Column<string>(type: "TEXT", nullable: false),
                    surface_water = table.Column<string>(type: "TEXT", nullable: false),
                    residents = table.Column<string>(type: "TEXT", nullable: false),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "root",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    people = table.Column<string>(type: "TEXT", nullable: false),
                    planets = table.Column<string>(type: "TEXT", nullable: false),
                    species = table.Column<string>(type: "TEXT", nullable: false),
                    starships = table.Column<string>(type: "TEXT", nullable: false),
                    vehicles = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_root", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    classification = table.Column<string>(type: "TEXT", nullable: false),
                    designation = table.Column<string>(type: "TEXT", nullable: false),
                    average_height = table.Column<string>(type: "TEXT", nullable: false),
                    average_lifespan = table.Column<string>(type: "TEXT", nullable: false),
                    eye_colors = table.Column<string>(type: "TEXT", nullable: false),
                    hair_colors = table.Column<string>(type: "TEXT", nullable: false),
                    skin_colors = table.Column<string>(type: "TEXT", nullable: false),
                    language = table.Column<string>(type: "TEXT", nullable: false),
                    homeworld = table.Column<string>(type: "TEXT", nullable: false),
                    people = table.Column<string>(type: "TEXT", nullable: false),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: false),
                    starship_class = table.Column<string>(type: "TEXT", nullable: false),
                    manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    cost_in_credits = table.Column<string>(type: "TEXT", nullable: false),
                    length = table.Column<string>(type: "TEXT", nullable: false),
                    crew = table.Column<string>(type: "TEXT", nullable: false),
                    passengers = table.Column<string>(type: "TEXT", nullable: false),
                    max_atmosphering_speed = table.Column<string>(type: "TEXT", nullable: false),
                    hyperdrive_rating = table.Column<string>(type: "TEXT", nullable: false),
                    MGLT = table.Column<string>(type: "TEXT", nullable: false),
                    cargo_capacity = table.Column<string>(type: "TEXT", nullable: false),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    pilots = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: false),
                    vehicle_class = table.Column<string>(type: "TEXT", nullable: false),
                    manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    cost_in_credits = table.Column<string>(type: "TEXT", nullable: false),
                    length = table.Column<string>(type: "TEXT", nullable: false),
                    crew = table.Column<string>(type: "TEXT", nullable: false),
                    passengers = table.Column<string>(type: "TEXT", nullable: false),
                    max_atmosphering_speed = table.Column<string>(type: "TEXT", nullable: false),
                    cargo_capacity = table.Column<string>(type: "TEXT", nullable: false),
                    films = table.Column<string>(type: "TEXT", nullable: false),
                    pilots = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    edited = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "people");

            migrationBuilder.DropTable(
                name: "planets");

            migrationBuilder.DropTable(
                name: "root");

            migrationBuilder.DropTable(
                name: "species");

            migrationBuilder.DropTable(
                name: "starships");

            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
