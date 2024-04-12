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
    public partial class FormFilms : Form
    {
        public FormFilms(SWdatabase db)
        {
            InitializeComponent();
            listBox_plist.DataSource = db.films.ToList<Films>();
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
            Films film = (Films)listBox_plist.SelectedItem;
            label2.Text = film.title;
            textBox1.Text = film.showAll();
        }
    }

}
