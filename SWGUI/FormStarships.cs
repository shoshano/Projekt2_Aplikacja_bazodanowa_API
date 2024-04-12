using StarWars.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SWGUI
{
    public partial class FormStarships : Form
    {
        SWdatabase DB;
        public FormStarships(SWdatabase db)
        {
            InitializeComponent();
            DB = db;
            listBox_plist.DataSource = db.starships.ToList<Starships>();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void listBox_plist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Starships ship = (Starships)listBox_plist.SelectedItem;
            label2.Text = ship.name;
            textBox1.Text = ship.showAll();
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_search.Text;
            listBox_plist.DataSource = DB.starships.Where(s => s.name.Contains(search)).ToList<Starships>();

        }
    }
}
