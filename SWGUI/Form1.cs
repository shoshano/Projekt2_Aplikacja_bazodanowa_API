using StarWars.Data;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography;

namespace SWGUI
{
    public partial class Form1 : Form
    {
        private HttpClient Client;
        Root root = new Root(0);

        public SWdatabase SWdatabase;

        public Form1()
        {
            InitializeComponent();
            Client = new HttpClient();
            SWdatabase = new SWdatabase();
            if (!SWdatabase.root.Any())
            {
                GetData();
            }
            else
            {
                root = SWdatabase.root.Find(1);
            }

        }

        public async Task GetData()
        {
            Client = new HttpClient();
            string call = "https://swapi.dev/api/";
            string response = await Client.GetStringAsync(call);
            root = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(response);
            SWdatabase.root.Add(root);
            SWdatabase.SaveChanges();
        }

        private async void Label_people_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.people.Any())
            {
                Client = new HttpClient();
                string url = root.people;
                for (int i = 1; i < 84; i++)
                {
                    string url1 = url + $"{i}" + @"/";
                    var response1 = await Client.GetAsync(url1);
                    if (response1.IsSuccessStatusCode)
                    {
                        var json = await response1.Content.ReadAsStringAsync();
                        People human = Newtonsoft.Json.JsonConvert.DeserializeObject<People>(json);
                        human.Id = i;
                        SWdatabase.people.Add(human);
                        SWdatabase.SaveChanges();
                    }
                }
            }
            FormPeople form = new FormPeople(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private async void Label_Spieces_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.species.Any())
            {
                Client = new HttpClient();
                string url = root.species;
                for (int i = 1; i < 38; i++)
                {
                    string url1 = url + $"{i}" + @"/";
                    var response1 = await Client.GetAsync(url1);
                    if (response1.IsSuccessStatusCode)
                    {
                        var json = await response1.Content.ReadAsStringAsync();
                        Species species = Newtonsoft.Json.JsonConvert.DeserializeObject<Species>(json);
                        species.Id = i;
                        SWdatabase.species.Add(species);
                        SWdatabase.SaveChanges();
                    }
                }
            }
            FormSpieces form = new FormSpieces(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private async void Label_films_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.films.Any())
            {
                Client = new HttpClient();
                ListOfFilms films = new ListOfFilms();
                string url = root.films;
                var response = await Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    films = Newtonsoft.Json.JsonConvert.DeserializeObject<ListOfFilms>(json);
                    films.addId();
                }

                SWdatabase.films.AddRange(films.results);
                SWdatabase.SaveChanges();
            }
            FormFilms form = new FormFilms(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private async void LAbel_Starships_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.starships.Any())
            {
                Client = new HttpClient();
                string url = root.starships;
                for (int i = 1; i < 76; i++)
                {
                    string url1 = url + $"{i}" + @"/";
                    var response1 = await Client.GetAsync(url1);
                    if (response1.IsSuccessStatusCode)
                    {
                        var json = await response1.Content.ReadAsStringAsync();
                        Starships ship = Newtonsoft.Json.JsonConvert.DeserializeObject<Starships>(json);
                        ship.Id = i;
                        SWdatabase.starships.Add(ship);
                        SWdatabase.SaveChanges();
                    }
                }
            }

            FormStarships form = new FormStarships(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private async void Label_vehicles_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.vehicles.Any())
            {
                Client = new HttpClient();
                string url = root.vehicles;
                for (int i = 1; i < 77; i++)
                {
                    string url1 = url + $"{i}" + @"/";
                    var response1 = await Client.GetAsync(url1);
                    if (response1.IsSuccessStatusCode)
                    {
                        var json = await response1.Content.ReadAsStringAsync();
                        Vehicles vehicle = Newtonsoft.Json.JsonConvert.DeserializeObject<Vehicles>(json);
                        vehicle.Id = i;
                        SWdatabase.vehicles.Add(vehicle);
                        SWdatabase.SaveChanges();
                    }
                }
            }
            FormVehicles form = new FormVehicles(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private async void Label_planets_Click(object sender, EventArgs e)
        {
            if (!SWdatabase.planets.Any())
            {
                Client = new HttpClient();
                string url = root.planets;
                for (int i = 1; i < 61; i++)
                {
                    string url1 = url + $"{i}" + @"/";
                    var response1 = await Client.GetAsync(url1);
                    if (response1.IsSuccessStatusCode)
                    {
                        var json = await response1.Content.ReadAsStringAsync();
                        Planets planet = Newtonsoft.Json.JsonConvert.DeserializeObject<Planets>(json);
                        planet.Id = i;
                        SWdatabase.planets.Add(planet);
                        SWdatabase.SaveChanges();
                    }
                }
            }

            FormPlanets form = new FormPlanets(SWdatabase);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
