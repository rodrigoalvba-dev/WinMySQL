namespace WinMySQL.Views
{
    partial class FrmMaestros
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
            splitContainer1 = new SplitContainer();
            butAgreMae = new Button();
            menuStrip1 = new MenuStrip();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            DGVMaestros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaestros).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(butAgreMae);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DGVMaestros);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 92;
            splitContainer1.TabIndex = 1;
            // 
            // butAgreMae
            // 
            butAgreMae.Location = new Point(561, 42);
            butAgreMae.Name = "butAgreMae";
            butAgreMae.Size = new Size(159, 32);
            butAgreMae.TabIndex = 0;
            butAgreMae.Text = "Agregar Maestro";
            butAgreMae.UseVisualStyleBackColor = true;
            butAgreMae.Click += butAgreMae_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // DGVMaestros
            // 
            DGVMaestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMaestros.Location = new Point(3, 3);
            DGVMaestros.Name = "DGVMaestros";
            DGVMaestros.RowHeadersWidth = 51;
            DGVMaestros.Size = new Size(800, 351);
            DGVMaestros.TabIndex = 0;
            DGVMaestros.CellContentClick += DGVMaestros_CellContentClick;
            DGVMaestros.CellContentDoubleClick += DobleClickMAestros;
            // 
            // FrmMaestros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmMaestros";
            Text = "FrmMaestros";
            Activated += ActForm;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaestros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button butAgreMae;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridView DGVMaestros;
    }
}