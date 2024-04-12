using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StarWars.Data
{
    public class Films : SWEntity
    {
        public int Id {  get; set; }
        public string title { get; set; } //Search Fields
        public int episode_id { get; set; }
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

        public Films()
        {
            Id = 0;
            episode_id = 0;
            title = " ";
            opening_crawl = " ";
            director = " ";
            producer = " ";
            release_date = DateTime.Now;
        }

        public string showAll()
        {
            string str = $"Episode: {episode_id}" + Environment.NewLine;
            str += $"Director: {director}" +Environment.NewLine;
            str += $"Producer: {producer}" + Environment.NewLine;
            str += $"Release date: {release_date}" + Environment.NewLine;
            str += $"Opening crawl: {opening_crawl}" + Environment.NewLine;

            return str;
        }

        
        public override string ToString()
    {
            string n = $"{Id}. {title}";
            return n;
        }
    }

    public class ListOfFilms
    {
        public List<Films> results { get; set; }

        public override string ToString()
        {
            string n = "";
            foreach (Films film in results) 
            { 
                n += film.showAll() + Environment.NewLine;
            }
            return n;
        }

        public void addId()
        {
            int i = 1;
            foreach (Films film in results)
            {
                film.Id = i;
                i++;
            }
        }
    }
    
}
