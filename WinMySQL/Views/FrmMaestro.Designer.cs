namespace WinMySQL.Views
{
    partial class FrmMaestro
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
            button2 = new Button();
            label1 = new Label();
            textBNomProf = new TextBox();
            textBCorreoInst = new TextBox();
            label2 = new Label();
            textBNoCont = new TextBox();
            labelNoCont = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(214, 96);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Profesor";
            // 
            // textBNomProf
            // 
            textBNomProf.Location = new Point(12, 39);
            textBNomProf.Name = "textBNomProf";
            textBNomProf.Size = new Size(148, 27);
            textBNomProf.TabIndex = 3;
            // 
            // textBCorreoInst
            // 
            textBCorreoInst.Location = new Point(12, 107);
            textBCorreoInst.Name = "textBCorreoInst";
            textBCorreoInst.Size = new Size(148, 27);
            textBCorreoInst.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 4;
            label2.Text = "Correo Institucional";
            // 
            // textBNoCont
            // 
            textBNoCont.Location = new Point(200, 39);
            textBNoCont.Name = "textBNoCont";
            textBNoCont.Size = new Size(125, 27);
            textBNoCont.TabIndex = 7;
            // 
            // labelNoCont
            // 
            labelNoCont.AutoSize = true;
            labelNoCont.Location = new Point(214, 9);
            labelNoCont.Name = "labelNoCont";
            labelNoCont.Size = new Size(81, 20);
            labelNoCont.TabIndex = 6;
            labelNoCont.Text = "No.Control";
            labelNoCont.Click += label3_Click;
            // 
            // FrmMaestro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 195);
            Controls.Add(textBNoCont);
            Controls.Add(labelNoCont);
            Controls.Add(textBCorreoInst);
            Controls.Add(label2);
            Controls.Add(textBNomProf);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "FrmMaestro";
            Text = "FrmMaestro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private TextBox textBNomProf;
        private TextBox textBCorreoInst;
        private Label label2;
        private TextBox textBNoCont;
        private Label labelNoCont;
    }
}