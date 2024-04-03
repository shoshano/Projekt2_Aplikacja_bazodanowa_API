using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    internal class Starships : SWEntity
    {
        public required string name { get; set; }   //Search Fields
        public string model { get; set; }           //Search Fields
        public string starship_class { get; set; }
        public string manufacturer { get; set; }
        public string cost_in_credits { get; set; }
        public string length { get; set; }
        public string crew {  get; set; }
        public string passengers { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        public string cargo_capacity { get; set; }
        public List<string> films { get; set; }
        public List<string> pilots { get; set; }
        public required string url { get; set; }
        public required DateTime created { get; set; }
        public required DateTime edited { get; set; }

    }
}
