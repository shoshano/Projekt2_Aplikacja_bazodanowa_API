using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarWars.Data;

public class SWDatabase : DbContext
{
    public DbSet<Films> films { get; set; }
    public DbSet<People> people { get; set; }
    public DbSet<Planets> planets { get; set; }
    public DbSet<Root> root { get; set; }
    public DbSet<Species> species { get; set; }
    public DbSet<Starships> starships { get; set; }
    public DbSet<Vehicles> vehicles { get; set; }


    public string DbPath { get; }

    public SWDatabase()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "Database\\starwars.db");
    }

    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source = {DbPath}");
}

