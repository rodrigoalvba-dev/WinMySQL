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
            FrmMaestro maestro = new FrmMaestro();
            maestro.ShowDialog();
        }

        private void ActForm(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Maestros");
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

        private void DobleClickMAestros(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombre = "";
                string correo = DGVMaestros.Rows[e.RowIndex].Cells[5].Value + "";

                for (int i = 1; i < DGVMaestros.Rows[e.RowIndex].Cells.Count - 2; i++)
                {
                    if (DGVMaestros.Rows[e.RowIndex].Cells[i].Value != null)
                        nombre += DGVMaestros.Rows[e.RowIndex].Cells[i].Value.ToString() + " ";
                }

                FrmMaestro maestro = new FrmMaestro(
                    nombre,
                    Convert.ToInt32(DGVMaestros.Rows[e.RowIndex].Cells[0].Value),
                    correo
                );

                maestro.ShowDialog();
            }
        }

        private void DGVMaestros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

