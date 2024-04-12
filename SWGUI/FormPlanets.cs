using StarWars.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWGUI
{
    public partial class FormPlanets : Form
    {
        public FormPlanets(SWdatabase db)
        {
            InitializeComponent();
            listBox_plist.DataSource = db.planets.ToList<Planets>();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void listBox_plist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Planets planet = (Planets)listBox_plist.SelectedItem;
            label2.Text = planet.name;
            textBox1.Text = planet.showAll();
        }
    }
}
