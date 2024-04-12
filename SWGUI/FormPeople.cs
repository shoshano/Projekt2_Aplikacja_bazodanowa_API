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
using System.Text.RegularExpressions;


namespace SWGUI
{
    public partial class FormPeople : Form
    {
        SWdatabase DB;
        public FormPeople(SWdatabase db)
        {
            InitializeComponent();
            DB = db;
            listBox_plist.DataSource = db.people.ToList<People>();
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
            People peop = (People)listBox_plist.SelectedItem;
            label2.Text = peop.name;
            textBox1.Text = peop.showAll();
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_search.Text;
            listBox_plist.DataSource = DB.people.Where(s => s.name.Contains(search)).ToList<People>();
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            
        }
    }
}
