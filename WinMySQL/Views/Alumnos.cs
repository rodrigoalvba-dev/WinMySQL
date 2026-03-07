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
    public partial class Alumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar(
       "SELECT Alumnos.Prim_Nom, Alumnos.Ap_Pat, Materias.NombreMateria " +
       "FROM Alumno_Materia " +
       "INNER JOIN Alumnos ON Alumno_Materia.idAlumno = Alumnos.idAlumnos " +
       "INNER JOIN Materias ON Alumno_Materia.idMateria = Materias.idMaterias");

                if (ds != null)
                {
                    DGValumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void CCDoublClicl(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {
                FrmAlumno alumno = new FrmAlumno(
                    Convert.ToInt32(DGValumnos.Rows[e.RowIndex].Cells[0].Value),
                    DGValumnos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    DGValumnos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    DGValumnos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    DGValumnos.Rows[e.RowIndex].Cells[4].Value.ToString()
                );

                alumno.ShowDialog();
            }*/
        }

        private void DGValumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

