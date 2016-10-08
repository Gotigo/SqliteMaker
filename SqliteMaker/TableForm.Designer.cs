namespace SqliteMaker
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.primeryKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsType = new System.Data.DataSet();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.tbsTypes = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isrowid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ispk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isunique = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTableName
            // 
            resources.ApplyResources(this.txtTableName, "txtTableName");
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.TextChanged += new System.EventHandler(this.txtTableName_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmsTable
            // 
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeryKeyToolStripMenuItem});
            this.cmsTable.Name = "cmsTable";
            resources.ApplyResources(this.cmsTable, "cmsTable");
            this.cmsTable.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTable_Opening);
            // 
            // primeryKeyToolStripMenuItem
            // 
            this.primeryKeyToolStripMenuItem.Name = "primeryKeyToolStripMenuItem";
            resources.ApplyResources(this.primeryKeyToolStripMenuItem, "primeryKeyToolStripMenuItem");
            this.primeryKeyToolStripMenuItem.Click += new System.EventHandler(this.primeryKeyToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.btnEliminar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dsType
            // 
            this.dsType.DataSetName = "dtType";
            // 
            // dgvTabla
            // 
            resources.ApplyResources(this.dgvTabla, "dgvTabla");
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.isrowid,
            this.ispk,
            this.isunique});
            this.dgvTabla.ContextMenuStrip = this.cmsTable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.Name = "dgvTabla";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellValueChanged);
            this.dgvTabla.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTabla_RowsAdded);
            this.dgvTabla.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTabla_UserDeletingRow);
            this.dgvTabla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTabla_MouseDown);
            // 
            // tbsTypes
            // 
            this.tbsTypes.DataSource = typeof(SqliteMaker.Types);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.DataSource = this.tbsTypes;
            this.type.DisplayMember = "name";
            resources.ApplyResources(this.type, "type");
            this.type.Name = "type";
            this.type.ValueMember = "value";
            // 
            // isrowid
            // 
            this.isrowid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.isrowid, "isrowid");
            this.isrowid.Name = "isrowid";
            // 
            // ispk
            // 
            this.ispk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.ispk, "ispk");
            this.ispk.Name = "ispk";
            // 
            // isunique
            // 
            this.isunique.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.isunique, "isunique");
            this.isunique.Name = "isunique";
            // 
            // TableForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TableForm";
            this.Activated += new System.EventHandler(this.TableForm_Activated);
            this.Enter += new System.EventHandler(this.TableForm_Enter);
            this.cmsTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem primeryKeyToolStripMenuItem;
        private System.Windows.Forms.BindingSource tbsTypes;
        private System.Data.DataSet dsType;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isrowid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ispk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isunique;
    }
}