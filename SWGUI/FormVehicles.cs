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
    public partial class FormVehicles : Form
    {
        SWdatabase DB;
        public FormVehicles(SWdatabase db)
        {
            InitializeComponent();
            DB = db;
            listBox_plist.DataSource = db.vehicles.ToList<Vehicles>();
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
            Vehicles veh = (Vehicles)listBox_plist.SelectedItem;
            label2.Text = veh.name;
            textBox1.Text = veh.showAll();
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_search.Text;
            listBox_plist.DataSource = DB.vehicles.Where(s => s.name.Contains(search)).ToList<Vehicles>();

        }
    }
}
