using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tables.ListTable = new List<Table>();

        }
        private void txtPreview_Click(object sender, EventArgs e)
        {
            txtPreview.Text = new Tables().ToString();
        }

        private void addTable_Click(object sender, EventArgs e)
        {
            new TableForm() { MdiParent = this }.Show();

            /*
            MenuStrip msMenu = (MenuStrip)this.Controls["msMenu"];
            ToolStripMenuItem table = new ToolStripMenuItem();
            msMenu.Items.Add(table);
            table.Text = "Table";
            */

        }

    }
}
