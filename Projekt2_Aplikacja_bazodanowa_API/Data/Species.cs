using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    internal class Species : SWEntity
    {
        public string name {  get; set; }           //Search Fields
        public string classification { get; set; }
        public string designation { get; set; }
        public string average_height { get; set; }
        public string average_lifespan { get; set; }    
        public string eye_colors { get; set;}
        public string hair_colors { get; set;}
        public string skin_colors { get; set;}
        public string language { get; set; }
        public string homeworld {  get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }
        public required string url { get; set; }
        public required DateTime created { get; set; }
        public required DateTime edited { get; set; }

    }
}
