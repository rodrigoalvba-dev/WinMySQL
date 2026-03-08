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
    public partial class FrmMaestros : Form
    {
        public FrmMaestros()
        {
            InitializeComponent();
        }
        Datos datos = new Datos();
        DataSet ds;

        private void butAgreMae_Click(object sender, EventArgs e)
        {

        }

        private void ActForm(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar(
   "SELECT NumCont,Prim_Nom, Seg_Nom, Ap_Pat, Ap_Mat ,Correo_Ins" +
   "FROM Alumnos");
                DGVMaestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                if (ds != null)
                {
                    DGVMaestros.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int numControl = Convert.ToInt32(DGVMaestros.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Deseas eliminar el alumno: " +
                DGVMaestros.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {

                bool f = datos.ejecutarComando($"DELETE FROM Maestros WHERE NumCont={numControl}");

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

