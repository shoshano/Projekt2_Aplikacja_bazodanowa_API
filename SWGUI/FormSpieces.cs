﻿using StarWars.Data;
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
    public partial class FormSpieces : Form
    {
        SWdatabase DB;
        public FormSpieces(SWdatabase db)
        {
            InitializeComponent();
            DB = db;
            listBox_plist.DataSource = db.species.ToList<Species>();
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
            Species spec = (Species)listBox_plist.SelectedItem;
            label2.Text = spec.name;
            textBox1.Text = spec.showAll();
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void FormSpieces_Load(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_search.Text;
            listBox_plist.DataSource = DB.species.Where(s => s.name.Contains(search)).ToList<Species>();

        }

        private void listBox_plist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
