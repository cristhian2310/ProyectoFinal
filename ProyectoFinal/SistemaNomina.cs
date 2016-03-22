using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class SistemaNomina : Form
    {
        public SistemaNomina()
        {
            InitializeComponent();
        }

        private void esoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos o = new FrmDepartamentos();
            o.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados o= new FrmEmpleados();
            o.Show();
        }

        private void gestiónDePuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPuestos o = new FrmPuestos();
            o.Show();
        }

        private void gestiónDeTiposDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos o = new FrmIngresos();
            o.Show();
        }

        private void gestionDeDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeducciones o = new FrmDeducciones();
            o.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
