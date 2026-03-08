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
        int NOCNT = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmAlumno()
        {
            InitializeComponent();

        }
        public FrmAlumno(string Nombre, int numCont)
        {
            InitializeComponent();
            TxtNmbAlu.Text = Nombre;
            TxtNumCont.Text = numCont+"";
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

            string primerNombre = "";
            string segundoNombre = "";
            string apPat = "";
            string apMat = "";

            if (nombreCompleto.Length >= 1)
                primerNombre = nombreCompleto[0];

            if (nombreCompleto.Length >= 2)
                apPat = nombreCompleto[1];

            if (nombreCompleto.Length >= 3)
            {
                segundoNombre = "";
                apPat = nombreCompleto[1];
                apMat = nombreCompleto[2];
            }

            if (nombreCompleto.Length > 4)
            {
                apPat = nombreCompleto[2];
                apMat = nombreCompleto[3];
            }
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"INSERT INTO Alumnos (Prim_Nom,Seg_Nom,Ap_Pat,Ap_Mat) " +
                    $"VALUES ('{primerNombre}','{segundoNombre}','{apPat}','{apMat}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"UPDATE Alumnos SET " +
                    $"Prim_Nom='{primerNombre}', " +
                    $"Seg_Nom='{segundoNombre}', " +
                    $"Ap_Pat='{apPat}', " +
                    $"Ap_Mat='{apMat}' " +
                    $"WHERE NumCont={NOCNT}");

                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el alumno");
                }
            }
        }
    }
}

