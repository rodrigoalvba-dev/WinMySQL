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
    public partial class FrmMaestro : Form
    {
        int NOCNT = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmMaestro()
        {
            InitializeComponent();
        }
        public FrmMaestro(string Nombre, int numCont, string correo)
        {
            InitializeComponent();
            this.NOCNT = numCont;
            textBNomProf.Text = Nombre;
            textBNoCont.Text = numCont + "";
            textBCorreoInst.Text = correo;
            updating = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] nombreCompleto = textBNomProf.Text.Split(' ');

            string primerNombre = "";
            string segundoNombre = "";
            string apPat = "";
            string apMat = "";

            if (nombreCompleto.Length == 3)
            {
                primerNombre = nombreCompleto[0];
                segundoNombre = "";
                apPat = nombreCompleto[2];
                apMat = nombreCompleto[3];
            }

            if (nombreCompleto.Length ==4)
            {
                primerNombre = nombreCompleto[0];
                segundoNombre = nombreCompleto[1];
               apPat = nombreCompleto[2];
                apMat = nombreCompleto[3];
            }
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"INSERT INTO Maestros (Prim_Nom,Seg_Nom,Ap_Pat,Ap_Mat,Correo_Ins,NoCont) " +
                    $"VALUES ('{primerNombre}','{segundoNombre}','{apPat}','{apMat}','{textBCorreoInst.Text}','{textBNoCont.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Maestro agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Maestro");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                   $"UPDATE Maestros SET " +
                   $"Prim_Nom='{primerNombre}', " +
                   $"Seg_Nom='{segundoNombre}', " +
                   $"Ap_Pat='{apPat}', " +
                   $"Ap_Mat='{apMat}', " +
                   $"Correo_Ins='{textBCorreoInst.Text}' " +
                   $"WHERE NoCont={NOCNT}");

                if (resultado)
                {
                    MessageBox.Show("Maestro actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el maestro");
                }
            }
        }

        private void FrmMaestro_Load(object sender, EventArgs e)
        {

        }
    }
}

