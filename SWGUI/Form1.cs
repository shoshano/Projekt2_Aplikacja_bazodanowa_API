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
            if( SWdatabase.root == null ) 
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
            root  = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(response);
            SWdatabase.root.Add(root);
            SWdatabase.SaveChanges();
        }

        public void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private async void Label_people_Click(object sender, EventArgs e)
        {
            if (SWdatabase.people == null)
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
                        SWdatabase.people.Add(human);
                        SWdatabase.SaveChanges();
                    }
                }
            }
            FormPeople f = new FormPeople(SWdatabase);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        //ivate void

        private void textBox_title1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Spieces_Click(object sender, EventArgs e)
        {
            FormSpieces f = new FormSpieces();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Label_films_Click(object sender, EventArgs e)
        {
            FormFilms f = new FormFilms();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void LAbel_Starships_Click(object sender, EventArgs e)
        {
            FormStarships f = new FormStarships();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Label_vehicles_Click(object sender, EventArgs e)
        {
            FormVehicles f = new FormVehicles();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Label_planets_Click(object sender, EventArgs e)
        {
            FormPlanets f = new FormPlanets();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
