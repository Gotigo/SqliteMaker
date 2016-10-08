namespace SqliteMaker
{
    partial class MainForm
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.dataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.addTable = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBase});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(865, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // dataBase
            // 
            this.dataBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTable});
            this.dataBase.Name = "dataBase";
            this.dataBase.Size = new System.Drawing.Size(67, 20);
            this.dataBase.Text = "DataBase";
            // 
            // addTable
            // 
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(152, 22);
            this.addTable.Text = "Add Table";
            this.addTable.Click += new System.EventHandler(this.addTable_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Location = new System.Drawing.Point(647, 24);
            this.txtPreview.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(218, 363);
            this.txtPreview.TabIndex = 3;
            this.txtPreview.Click += new System.EventHandler(this.txtPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "asd";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem dataBase;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.ToolStripMenuItem addTable;
    }
}

