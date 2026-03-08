using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmMateria : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }

        public frmMateria(int id, string materia, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materia;
            txtCVE.Text = cve;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Materias (materias,CVE) " +
                    $"values ('{txtMateria.Text}','{txtCVE.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Materias set Materia='{txtMateria.Text}', CVE='{txtCVE.Text}' " +
                    $"where idMateria={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
