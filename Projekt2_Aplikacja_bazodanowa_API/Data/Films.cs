using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Films : SWEntity
    {
        public int Id {  get; set; }
        public string title { get; set; }           //Search Fields
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer {  get; set; }
        public DateTime release_date { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> characters { get; set; }
        public List<string> planets { get; set; }
        public required string url { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
    }
}
