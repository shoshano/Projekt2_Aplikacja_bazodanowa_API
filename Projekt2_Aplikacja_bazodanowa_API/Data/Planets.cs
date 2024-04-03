using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
