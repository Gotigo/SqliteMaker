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
    public partial class TableForm : Form
    {

        public Table Tabla
        {
            get { return Tables.ListTable.Where(x => x.Id == this.Id).First(); }
        }

        public String Name
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }


        DataGridViewCell cell;
        DataGridViewRow row;
        DataGridViewRow primary;

        public TableForm()
        {
            InitializeComponent();
            if (Tables.ListTable.Count == 0)
                Id = 0;
            else
                Id = Tables.ListTable.Last().Id + 1;

            this.Name = "table_" + Id;

            Tables.ListTable.Add(new Table(this.Id, this.Name));
            Tables.ListTable.Where(x => x.Id == this.Id).First().ListColumn.Add(new Column(0, "", ""));
            dgvTabla.Rows[0].Cells["id"].Value = 0;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.txtTableName.Text = Tabla.Name;

            this.tbsTypes.DataSource = Types.ListTypes();
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
           string nombre = ((TextBox)sender).Text;
           Tabla.Name = nombre;
           if (Tables.ListTable.Any(x => x.Name.Equals(nombre) && !x.Id.Equals(Tabla.Id)))
           {
               txtTableName.ForeColor = Color.Red;
           }
           else
           {

               txtTableName.ForeColor = Color.Black;
           }
        }

        private void dgvTabla_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int id = 0;
            id = (Tabla.ListColumn.Count == 0) ? 0 : Tabla.ListColumn.Last().Id + 1;
            Column col = new Column(id, "", "");
            dgvTabla.Rows[e.RowIndex].Cells["id"].Value = id.ToString();
            Tabla.ListColumn.Add(col);
        
        }

        private Column getColumn(int RowIndex)
        {
            object name = dgvTabla.Rows[RowIndex].Cells["name"].Value ?? "";
            object type = dgvTabla.Rows[RowIndex].Cells["type"].Value ?? "";
            object id = dgvTabla.Rows[RowIndex].Cells["id"].Value ?? "0";
            object isrowid = dgvTabla.Rows[RowIndex].Cells["isrowid"].Value ?? "false";
            object ispk = dgvTabla.Rows[RowIndex].Cells["ispk"].Value ?? "false";
            object isunique = dgvTabla.Rows[RowIndex].Cells["isunique"].Value ?? "false";

            if (bool.Parse(isrowid.ToString()))
            {
                type = "integer";
                ispk = "true";
                dgvTabla.Rows[RowIndex].Cells["type"].Value = "integer";
                dgvTabla.Rows[RowIndex].Cells["ispk"].Value = "true";
            }
            Column col = new Column(int.Parse(id.ToString())
                                    , name.ToString()
                                    , type.ToString()
                                    , bool.Parse(isrowid.ToString())
                                    , bool.Parse(ispk.ToString())
                                    , bool.Parse(isunique.ToString()));

            return col;
        }

        private void dgvTabla_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Column col = this.getColumn(e.Row.Index);
            Tables.ListTable.Where(x => x.Id == this.Id).First().ListColumn.Remove(col);
        }

        private void dgvTabla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= Tables.ListTable.Where(x => x.Id == this.Id).First().ListColumn.Count)
                return;

            Column col = this.getColumn(e.RowIndex);
            Column lcol = Tabla.ListColumn.First(x => x.Id == col.Id);
            lcol.Name = col.Name;
            lcol.Type = col.Type;
            lcol.IsRowId = col.IsRowId;

            if (Tabla.ListColumn.Any(x => x.Name.Equals(name) && !x.Id.Equals(col.Id)))
                dgvTabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            else
                dgvTabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tables.ListTable.Remove(Tabla);
            this.Close();
        }

        private void TableForm_Activated(object sender, EventArgs e)
        {

        }

        private void TableForm_Enter(object sender, EventArgs e)
        {
        }

        private void dgvTabla_MouseDown(object sender, MouseEventArgs e)
        {
            cell = null;
            row = null;
            if (e.Button == MouseButtons.Right)
            {
                var ht = dgvTabla.HitTest(e.X, e.Y);
                if (ht.RowIndex >= 0)
                {
                    row = dgvTabla.Rows[ht.RowIndex];
                    if (ht.ColumnIndex >= 0)
                        cell = dgvTabla.Rows[ht.RowIndex].Cells[ht.ColumnIndex];
                }
            }
        }

        private void cmsTable_Opening(object sender, CancelEventArgs e)
        {

            var ht = dgvTabla.HitTest(MousePosition.X, MousePosition.Y);
            if (row == null)
                e.Cancel = true;

        }

        private void primeryKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
