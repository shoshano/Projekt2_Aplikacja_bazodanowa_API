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
    public partial class FormSpieces : Form
    {

        public FormSpieces(SWdatabase db)
        {
            InitializeComponent();
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
        }

        private void FormSpieces_Load(object sender, EventArgs e)
        {

        }
    }
}
