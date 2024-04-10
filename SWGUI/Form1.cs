using System.Threading;

namespace SWGUI
{
    public partial class Form1 : Form
    {
        Thread newForm;

        public Form1()
        {
            InitializeComponent();
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

        private void Label_people_Click(object sender, EventArgs e)
        {
            //is.Close();   
            //wForm 
            FormPeople f = new FormPeople();
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
