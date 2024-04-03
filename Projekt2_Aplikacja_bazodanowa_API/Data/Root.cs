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
        public Root() { }

        public override string ToString()
        {
            return $"Films, People, Planets, Speciec, Starships, Vehicles" + Environment.NewLine;
        }
    }
}
