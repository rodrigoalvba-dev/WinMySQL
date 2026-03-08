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
    public partial class FrmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar(
   "SELECT NumCont,Prim_Nom, Seg_Nom, Ap_Pat, Ap_Mat ,Telefono" +
   "FROM Alumnos");
                DGValumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                if (ds != null)
                {
                    DGValumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void CCDoublClicl(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string nombre=null;

                for (int i = 1; i < 4; i++)
                {
                    if (DGValumnos.Rows[e.RowIndex].Cells[1].Value != null)
                        nombre += DGValumnos.Rows[e.RowIndex].Cells[i].Value.ToString() + " ";
                    else
                        nombre += " ";
                }
                FrmAlumno alumno = new FrmAlumno(nombre,
                    Convert.ToInt32(DGValumnos.Rows[e.RowIndex].Cells[0].Value)
                );

                alumno.ShowDialog();
            }
        }

        private void DGValumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();
            alumno.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numControl = Convert.ToInt32(DGValumnos.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Deseas eliminar el alumno: " +
                DGValumnos.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                datos.ejecutarComando($"DELETE FROM Alumno_Materia WHERE idAlumno={numControl}");

                bool f = datos.ejecutarComando($"DELETE FROM Alumnos WHERE NumCont={numControl}");

                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema");
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema");
                }
            }
        }
    }
}

