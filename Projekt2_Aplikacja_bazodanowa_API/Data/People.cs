using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class People : SWEntity
    {
        public int Id { get; set; }
        public required string name {  get; set; }       //Search Fields
        public required string birth_year { get; set; }
        public required string eye_color { get; set; }
        public required string gender {  get; set; }
        public required string hair_color { get; set;  }
        public required string hight { get; set;  }
        public required string mass { get; set; }
        public required string skin_color {get; set;}
        public required string homeworld { get; set;}
        public required string url { get; set;  }
        public required DateTime created {  get; set; }
        public required DateTime edited { get; set; }
        public List<string> films { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set;  }
        public List<string> vehicles { get;set; }
    }
}
