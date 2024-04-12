using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Vehicles : SWEntity
    {
        public int Id { get; set; }
        public required string name { get; set; }   //Search Fields
        public string model { get; set; }           //Search Fields
        public string vehicle_class { get; set; }
        public string manufacturer { get; set; }
        public string cost_in_credits { get; set; }
        public string length { get; set; }
        public string crew { get; set; }
        public string passengers { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string cargo_capacity { get; set; }
        public List<string> films { get; set; }
        public List<string> pilots { get; set; }
        public required string url { get; set; }
        public required DateTime created { get; set; }
        public required DateTime edited { get; set; }

        public Vehicles(int id)
        {
            Id = id;
            name = " ";
            model = " ";
            vehicle_class = " ";
            manufacturer = " ";
            cost_in_credits = " ";
            length = " ";
            crew = " ";
            passengers = " ";
            max_atmosphering_speed = " ";
            cargo_capacity = " ";

        }

        public string showAll()
        {
            string str = $"Model: {model}" + Environment.NewLine;
            str += $"Vehicle class: {vehicle_class}" + Environment.NewLine;
            str += $"Manufacturer: {manufacturer}" +Environment.NewLine;
            str += $"Cost in credits: {cost_in_credits}" + Environment.NewLine;
            str += $"Length: {length}" + Environment.NewLine;
            str += $"Crew: {crew}" +Environment.NewLine;
            str += $"Number of passengers: {passengers}" + Environment.NewLine;
            str += $"Max atmosphering speed: {max_atmosphering_speed}" + Environment.NewLine;
            str += $"Cargo capacity: {cargo_capacity}" + Environment.NewLine;
            return str;
        }
        
        public override string ToString()
    {
            string n = $"{Id}. {name}";
            return n;
        }
    }
}
