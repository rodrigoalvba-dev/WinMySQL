namespace WinMySQL.Views
{
    partial class FrmAlumno
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
            label1 = new Label();
            TxtNmbAlu = new TextBox();
            TxtNumCont = new TextBox();
            label2 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            buttAcep = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Alumno";
            label1.Click += label1_Click;
            // 
            // TxtNmbAlu
            // 
            TxtNmbAlu.Location = new Point(12, 58);
            TxtNmbAlu.Name = "TxtNmbAlu";
            TxtNmbAlu.Size = new Size(145, 27);
            TxtNmbAlu.TabIndex = 1;
            // 
            // TxtNumCont
            // 
            TxtNumCont.Location = new Point(189, 58);
            TxtNumCont.Name = "TxtNumCont";
            TxtNumCont.Size = new Size(145, 27);
            TxtNumCont.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 24);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "NO.Control";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // buttAcep
            // 
            buttAcep.Location = new Point(131, 128);
            buttAcep.Name = "buttAcep";
            buttAcep.Size = new Size(94, 29);
            buttAcep.TabIndex = 6;
            buttAcep.Text = "Aceptar";
            buttAcep.UseVisualStyleBackColor = true;
            buttAcep.Click += buttAcep_Click;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 184);
            Controls.Add(buttAcep);
            Controls.Add(TxtNumCont);
            Controls.Add(label2);
            Controls.Add(TxtNmbAlu);
            Controls.Add(label1);
            Name = "FrmAlumno";
            Text = "FrmAlumnos";
            Load += FrmAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNmbAlu;
        private TextBox TxtNumCont;
        private Label label2;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Button buttAcep;
    }
}