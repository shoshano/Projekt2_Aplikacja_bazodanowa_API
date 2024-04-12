using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Planets : SWEntity
    {
        public int Id { get; set; }
        public string name { get; set; }            //Search Fields
        public string diameter { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period {  get; set; }
        public string gravity { get; set; }
        public string population {  get; set; }
        public string climate { get; set; }
        public string terrain { get; set; }
        public string surface_water {  get; set; }
        public List<string> residents { get; set; }
        public List<string> films { get; set; }
        public required string url { get; set; }
        public required DateTime created { get; set; }
        public required DateTime edited { get; set; }

        public Planets(int id)
        {
            Id = id;
            name = " ";
            diameter = " ";
            rotation_period = " ";
            orbital_period = " ";
            gravity = " ";
            population = " ";
            climate = " ";
            terrain = " ";
            surface_water = " ";

        }

        
        public string showAll()
        {
            string str = $"Diameter: {diameter}" + Environment.NewLine;
            str += $"Rotation period: {rotation_period}" + Environment.NewLine;
            str += $"Orbital period: {orbital_period}" +Environment.NewLine;
            str += $"Gravity: {gravity}" + Environment.NewLine;
            str += $"Population: {population}" + Environment.NewLine;
            str += $"Climate: {climate}" + Environment.NewLine;
            str += $"Terrain: {terrain}"+ Environment.NewLine;
            str += $"Surface water: {surface_water}" + Environment.NewLine;
            return str;
        }

        public override string ToString()
        {
            string n = $"{Id}. {name}";
            return n;
        }
    }
}
