namespace WinMySQL.Views
{
    partial class frmMateria
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
            txtMateria = new TextBox();
            label2 = new Label();
            txtCVE = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(12, 37);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(424, 31);
            txtMateria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "CVE Oficial";
            // 
            // txtCVE
            // 
            txtCVE.Location = new Point(12, 113);
            txtCVE.Name = "txtCVE";
            txtCVE.Size = new Size(150, 31);
            txtCVE.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(324, 111);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 167);
            Controls.Add(btnAceptar);
            Controls.Add(txtCVE);
            Controls.Add(label2);
            Controls.Add(txtMateria);
            Controls.Add(label1);
            Name = "frmMateria";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMateria;
        private Label label2;
        private TextBox txtCVE;
        private Button btnAceptar;
    }
}