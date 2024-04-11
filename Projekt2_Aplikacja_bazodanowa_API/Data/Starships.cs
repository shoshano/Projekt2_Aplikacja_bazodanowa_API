using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Starships : SWEntity
    {
        public int Id { get; set; }
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

        public Starships(int id)
        {
            Id = id;
            name = " ";
            model = " ";
            starship_class = " ";
            manufacturer = " ";
            cost_in_credits = " ";
            length = " ";
            crew = " ";
            passengers = " ";
            max_atmosphering_speed = " ";
            hyperdrive_rating = " ";
            MGLT = " ";
            cargo_capacity = " ";

        }

        public override string ToString()
        {
            string str = $"Name: {name}" + Environment.NewLine;
            str += $"Model: {model}" + Environment.NewLine;
            str += $"Starship class: {starship_class}" + Environment.NewLine;
            str += $"Manufacturer: {manufacturer}" +Environment.NewLine;
            str += $"Cost in credits: {cost_in_credits}" + Environment.NewLine;
            str += $"Length: {length}" + Environment.NewLine;
            str += $"Crew: {crew}" +Environment.NewLine;
            str += $"Number of passengers: {passengers}" + Environment.NewLine;
            str += $"Max atmosphering speed: {max_atmosphering_speed}" + Environment.NewLine;
            str += $"Hyperdrive rating: {hyperdrive_rating}" + Environment.NewLine;
            str += $"MGLT: {MGLT}" + Environment.NewLine;
            str += $"Cargo capacity: {cargo_capacity}" + Environment.NewLine;
            return str;
        }

        public string showName()
        {
            string n = $"{Id}. {name}";
            return n;
        }

    }
}
