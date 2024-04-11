using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Root : SWEntity
    {
        public int Id { get; set; }
        public string films { get; set; }
        public string people { get; set; }
        public string planets { get; set; }
        public string species { get; set; }
        public string starships { get; set; }
        public string vehicles { get; set; }
        public Root(int id) 
        {
            Id = id;
            films = " ";
            people = " ";
            planets = " ";
            species = " ";
            starships = " ";
            vehicles = " ";
        }

        public override string ToString()
        {
            return $"Films: {films}, People: {people}, Planets: {planets}, Speciec: {species}, Starships: {starships}, Vehicles: {vehicles}" + Environment.NewLine;
        }
    }
}
