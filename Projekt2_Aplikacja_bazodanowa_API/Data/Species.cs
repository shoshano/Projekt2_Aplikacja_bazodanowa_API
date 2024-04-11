using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class Species : SWEntity
    {
        public int Id { get; set; }
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

        public Species(int id)
        {
            Id = id;
            name = " ";
            classification = " ";
            designation = " ";
            average_height = " ";
            average_lifespan = " "; 
            eye_colors = " ";
            hair_colors = " ";
            skin_colors = " ";
            language = " ";
            
            

        }

        public override string ToString()
        {
            string str = $"Name: {name}" + Environment.NewLine;
            str += $"Classification: {classification}" + Environment.NewLine;
            str += $"Designation: {designation}" +Environment.NewLine;
            str += $"Average hight: {average_height}" + Environment.NewLine;
            str += $"Average lifespan: {average_lifespan}" + Environment.NewLine;
            str += $"Eye colors: {eye_colors}" + Environment.NewLine;
            str += $"Hair colors: {hair_colors}" + Environment.NewLine;
            str += $"Skin colors: {skin_colors}" + Environment.NewLine;
            str += $"Language: {language}" +Environment.NewLine;
            return str;
        }

        public string showName()
        {
            string n = $"{Id}. {name}";
            return n;
        }
    }
}
