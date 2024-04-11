using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarWars.Data;

namespace SWGUI
{
    public class SWdatabase : DbContext
    {
        public DbSet<Films> films { get; set; }
        public DbSet<People> people { get; set; }
        public DbSet<Planets> planets { get; set; }
        public DbSet<Root> root { get; set; }
        public DbSet<Species> species { get; set; }
        public DbSet<Starships> starships { get; set; }
        public DbSet<Vehicles> vehicles { get; set; }

        public SWdatabase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=starwarsDB.db");
        }
    }
}
