using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StarWars.Data;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SWGUI")]

namespace Projekt2_Aplikacja_bazodanowa_API
{
    internal class APITest
    {
        public HttpClient Client { get; set; }
        Root root = new Root(0);

        public async Task GetData()
        {
            Client = new HttpClient();
            string call = "https://swapi.dev/api/";
            string response = await Client.GetStringAsync(call);            
            root  = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(response);
            Console.WriteLine(root.ToString());
            
        }

        //////////////
        // GET PEOPLE
        //////////////

        public async Task GetAllPeople()
        {
            Client = new HttpClient();
            string url = root.people;
            for (int i = 1; i <84; i++)
            {
                string url1 = url + $"{i}" + @"/";
                var response1 = await Client.GetAsync(url1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    People human = Newtonsoft.Json.JsonConvert.DeserializeObject<People>(json);
                    human.Id = i;
                    Console.WriteLine(human.showAll());
                }
            }
        }

        public async Task GetPeopleByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.people + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            People human = Newtonsoft.Json.JsonConvert.DeserializeObject<People>(response);
            Console.WriteLine(human.ToString());
        }


        //////////////
        // GET SPECIES
        //////////////

        public async Task GetAllSpecies()
        {
            Client = new HttpClient();
            string url = root.species;
            for (int i = 1; i <38; i++)
            {
                string url1 = url + $"{i}" + @"/";
                var response1 = await Client.GetAsync(url1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    Species species = Newtonsoft.Json.JsonConvert.DeserializeObject<Species>(json);
                    species.Id = i;
                    Console.WriteLine(species.showName());
                }
            }
        }

        public async Task GetSpeciesByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.species + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            Species species = Newtonsoft.Json.JsonConvert.DeserializeObject<Species>(response);
            Console.WriteLine(species.ToString());
        }

        //////////////
        // GET FILMS
        //////////////

        public async Task GetAllFilms()
        {
            Client = new HttpClient();
            string url = root.films;
            var response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                ListOfFilms films = Newtonsoft.Json.JsonConvert.DeserializeObject<ListOfFilms>(json);
                films.addId();
                Console.WriteLine(films.ToString());
            }
        }

        public async Task GetFilmByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.films + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            Films film = Newtonsoft.Json.JsonConvert.DeserializeObject<Films>(response);
            Console.WriteLine(film.ToString());
        }

        //////////////
        // GET STARSHIPS
        //////////////

        public async Task GetAllStarships()
        {
            Client = new HttpClient();
            string url = root.starships;
            for (int i = 1; i <76; i++)
            {
                string url1 = url + $"{i}" + @"/";
                var response1 = await Client.GetAsync(url1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    Starships ship = Newtonsoft.Json.JsonConvert.DeserializeObject<Starships>(json);
                    ship.Id = i;
                    Console.WriteLine(ship.showName());
                }
            }
        }

        public async Task GetStarshipsByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.starships + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            Starships ship = Newtonsoft.Json.JsonConvert.DeserializeObject<Starships>(response);
            Console.WriteLine(ship.ToString());
        }

        //////////////
        // GET VEHICLES
        //////////////

        public async Task GetAllVehicles()
        {
            Client = new HttpClient();
            string url = root.vehicles;
            for (int i = 1; i <77; i++)
            {
                string url1 = url + $"{i}" + @"/";
                var response1 = await Client.GetAsync(url1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    Vehicles vehicle = Newtonsoft.Json.JsonConvert.DeserializeObject<Vehicles>(json);
                    vehicle.Id = i;
                    Console.WriteLine(vehicle.showName());
                }
            }
        }

        public async Task GetVehiclesByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.vehicles + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            Vehicles vehicle = Newtonsoft.Json.JsonConvert.DeserializeObject<Vehicles>(response);
            Console.WriteLine(vehicle.ToString());
        }

        //////////////
        // GET PLANET
        //////////////

        public async Task GetAllPlanets()
        {
            Client = new HttpClient();
            string url = root.planets;
            for (int i = 1; i <61; i++)
            {
                string url1 = url + $"{i}" + @"/";
                var response1 = await Client.GetAsync(url1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    Planets planet = Newtonsoft.Json.JsonConvert.DeserializeObject<Planets>(json);
                    planet.Id = i;
                    Console.WriteLine(planet.showName());
                }
            }
        }

        public async Task GetPlanetByIndex(int id)
        {
            Client = new HttpClient();
            string url = root.planets + $"{id}" + @"/";
            string response = await Client.GetStringAsync(url);
            Planets planet = Newtonsoft.Json.JsonConvert.DeserializeObject<Planets>(response);
            Console.WriteLine(planet.ToString());
        }
    }
}
