namespace WinMySQL.Views
{
    partial class FrmAlumnos
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
            DGValumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGValumnos).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DGValumnos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 130;
            splitContainer1.TabIndex = 0;
            // 
            // DGValumnos
            // 
            DGValumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGValumnos.Location = new Point(0, 3);
            DGValumnos.Name = "DGValumnos";
            DGValumnos.RowHeadersWidth = 51;
            DGValumnos.Size = new Size(800, 310);
            DGValumnos.TabIndex = 0;
            DGValumnos.CellContentClick += DGValumnos_CellContentClick;
            DGValumnos.CellContentDoubleClick += CCDoublClicl;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmAlumnos";
            Text = "Alumnos";
            Activated += Alumnos_Activated;
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGValumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView DGValumnos;
    }
}