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
    public partial class FrmPuestos : Form
    {
        ProyectoFinalEntities1 conexion = new ProyectoFinalEntities1();
        public FrmPuestos()
        {
            InitializeComponent();
            dgvPuestos.AutoGenerateColumns = false;
            cargarPuestos();
        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {

        }
        public void cargarPuestos(){

            var p = conexion.Puestos.ToList();
            var puestosbing = new BindingList<Puestos>(p);
            dgvPuestos.DataSource = puestosbing;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Puestos puesto = new Puestos();
            puesto.Nombre = txtNombre.Text;
            puesto.SalarioMaximo =  Convert.ToDouble (txtSalarioMax.Text);
            puesto.SalarioMinimo = Convert.ToDouble (txtSalarioMax.Text);
            puesto.NivelRiesgo = txtNivelRiesgo.Text;
            conexion.Puestos.Add(puesto);
            conexion.SaveChanges();
            cargarPuestos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtSalarioMax.Text = "";
            txtSalarioMin.Text = "";
            txtNivelRiesgo.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvPuestos.SelectedRows;
            if (seleccion.Count > 0)
            {
                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvPuestos[0, selectedIndex].Value.ToString());

                Puestos dep = conexion.Puestos.FirstOrDefault(r => r.Id == rowID);

                conexion.Puestos.Remove(dep);
                conexion.SaveChanges();
                dgvPuestos.Rows.RemoveAt(seleccion[0].Index);
                cargarPuestos();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

                int id = Convert.ToInt32(txtId.Text);
                var puesto = conexion.Puestos.FirstOrDefault(r => r.Id == id);
                puesto.Nombre = txtNombre.Text;
                puesto.SalarioMaximo = Convert.ToDouble(txtSalarioMax.Text);
                puesto.SalarioMinimo = Convert.ToDouble(txtSalarioMax.Text);
                puesto.NivelRiesgo = txtNivelRiesgo.Text;
                conexion.SaveChanges();
                cargarPuestos();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvPuestos.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvPuestos[0, selectedIndex].Value.ToString());
                int empeladoid = int.Parse(dgvPuestos[3, selectedIndex].Value.ToString());
                
                Puestos puesto = conexion.Puestos.FirstOrDefault(r => r.Id == rowID);


                txtId.Text = Convert.ToString(puesto.Id);
                txtNombre.Text = puesto.Nombre;
                txtSalarioMax.Text =Convert.ToString(puesto.SalarioMaximo);
                txtSalarioMin.Text =Convert.ToString(puesto.SalarioMinimo);
                txtNivelRiesgo.Text = puesto.NivelRiesgo;

                

            }
        }


    }
}
