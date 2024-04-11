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
        public required string height { get; set;  }
        public required string mass { get; set; }
        public required string skin_color {get; set;}


        

        public People(int id)
        {
            Id = id;
            name = " ";
            birth_year = " ";
            eye_color = " ";
            gender = " ";
            hair_color = " ";
            height = " ";
            mass = " ";
            skin_color = " ";
            
        }
        public People()
        {
            Id = 0;
            name = " ";
            birth_year = " ";
            eye_color = " ";
            gender = " ";
            hair_color = " ";
            height = " ";
            mass = " ";
            skin_color = " ";

        }

        public string showAll()
        {
            //string str = $"Name: {name}" + Environment.NewLine;
            string str = $"Birth year: {birth_year}" + Environment.NewLine;
            str += $"Eye color: {eye_color}" + Environment.NewLine;
            str += $"Gender: {gender}" +Environment.NewLine;
            str += $"Hair color: {hair_color}" + Environment.NewLine;
            str += $"Hight: {height}" + Environment.NewLine;
            str += $"Mass: {mass}" +Environment.NewLine;
            str += $"Skin color: {skin_color}" + Environment.NewLine;
            return str;
        }

        
        public override string ToString()
        {
            string n = $"{Id}. {name}" + Environment.NewLine;
            return n;
        }
    }

    public class ListOfPeople
    {
        public List<People> results { get; set; }

        public override string ToString()
        {
            string n = "";
            foreach (People human in results)
            {
                n += human.showAll() + Environment.NewLine;
            }
            return n;
        }

        public void addId()
        {
            int i = 1;
            foreach (People human in results)
            {
                human.Id = i;
                i++;
            }
        }
    }
}
