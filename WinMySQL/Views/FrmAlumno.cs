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
    public partial class FrmAlumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmAlumno()
        {
            InitializeComponent();

        }
        public FrmAlumno(int id, string materia, string Nombre, string numCont)
        {
            InitializeComponent();
            this.id = id;
            TxtNmbAlu.Text = Nombre;
            TxtNumCont.Text = numCont;
            updating = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void buttAcep_Click(object sender, EventArgs e)
        {
            string[] nombreCompleto = TxtNmbAlu.Text.Split(' ');
            if (nombreCompleto.Length <= 3) { 
            
            }
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (Prim_Nom,Seg_Nom,Ap_Pat,Ap_Mat) " +
                    $"values ('{nombreCompleto[0]}','{nombreCompleto[1]}','{nombreCompleto[2]}','{nombreCompleto[3]}')");

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
}
