using ProyectoFinal.ViewModels;
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
        private readonly ProyectoFinalEntities1 _conexion = new ProyectoFinalEntities1();

        public SistemaNomina()
        {
            InitializeComponent();
            cargarCombos();
            cargarDGV();

        }

        public void cargarDGV() {

            var registrosViewModel = new List<RegistroTransaccionViewModel>();
            var r = _conexion.RegistroTransacciones.ToList();

            foreach (var l in r) {
                RegistroTransaccionViewModel e = new RegistroTransaccionViewModel();
                e.Empleado = l.Empleados.Nombre;
                e.Estado = l.Estado;
                e.Fecha = l.Fecha;
                e.Monto = l.Monto;
                e.Id = l.Id;
                e.TipoMovimiento = l.TipoMovimiento;
                var tr="";
                if(l.TipoMovimiento == "Deduccion")
                {
                     tr = _conexion.TiposDeducciones.FirstOrDefault(o => o.Id == l.IdTransaccion).Nombre;
                
                }
                else{
                     tr = _conexion.TiposIngresos.FirstOrDefault(o => o.Id == l.IdTransaccion).Nombre;
                }
                e.Transaccion = tr;
                registrosViewModel.Add(e);
            }


            dgvRegristroTransaccion.DataSource = registrosViewModel;
        }

        public void cargarCombos(){

            var empleados = _conexion.Empleados.ToList();
            var empleadosBinding = new BindingList<Empleados>(empleados);
            cmbEmpleado.DataSource = empleadosBinding;
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "Id";


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

        public bool validar() {

            bool correcto = true;
        
            if(
                cmbEmpleado.Text =="" ||
                cmbTipoTransaccion.Text == "" ||
                cmbEstado.Text == "" ||
                txtFecha.Value == null ||
                txtMonto.Text == "" ||
                cmbTransaccion.Text == ""
                ){
                    correcto = false;
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           
            if (validar()) {

                var registro = new RegistroTransacciones();

                registro.IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue); 
                registro.IdTransaccion = Convert.ToInt32(cmbTransaccion.SelectedValue);
                registro.Estado = cmbEstado.Text;
                registro.Fecha = txtFecha.Value;
                registro.Monto = Convert.ToDouble(txtMonto.Text);
                registro.TipoMovimiento = cmbTipoTransaccion.Text;
                _conexion.RegistroTransacciones.Add(registro);
                _conexion.SaveChanges();
            }
            cargarDGV();
        }

        private void cmbTipoTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTransaccion.Text == "Deduccion") {
                cmbTransaccion.DataSource = null;
                var deducciones = _conexion.TiposDeducciones.ToList();
                var deduccionesBinding = new BindingList<TiposDeducciones>(deducciones);
                cmbTransaccion.DataSource = deduccionesBinding;
                cmbTransaccion.DisplayMember = "Nombre";
                cmbTransaccion.ValueMember = "Id";
            }
            else if (cmbTipoTransaccion.Text == "Ingreso")
            {
                cmbTransaccion.DataSource = null;
                var ingresos = _conexion.TiposIngresos.ToList();
                var ingresosBinding = new BindingList<TiposIngresos>(ingresos);
                cmbTransaccion.DataSource = ingresosBinding;
                cmbTransaccion.DisplayMember = "Nombre";
                cmbTransaccion.ValueMember = "Id";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEmpleado.Text ="";
            cmbTipoTransaccion.Text = "";
            cmbEstado.Text ="";
            txtId.Text = "";
            txtMonto.Text = "";
            cmbTransaccion.DataSource = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvRegristroTransaccion.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvRegristroTransaccion[0, selectedIndex].Value.ToString());
                
                RegistroTransacciones registro = _conexion.RegistroTransacciones.FirstOrDefault(r => r.Id == rowID);
                Empleados empleados = _conexion.Empleados.FirstOrDefault(r => r.Id == registro.IdEmpleado);

                cmbEmpleado.Text = empleados.Nombre;
                cmbTipoTransaccion.Text = registro.TipoMovimiento;
                cmbEstado.Text = registro.Estado;
                txtId.Text = Convert.ToString(registro.Id);
                txtMonto.Text = Convert.ToString(registro.Monto);

                var tr = "";
                if (registro.TipoMovimiento == "Deduccion")
                {
                    tr = _conexion.TiposDeducciones.FirstOrDefault(o => o.Id == registro.IdTransaccion).Nombre;

                }
                else
                {
                    tr = _conexion.TiposIngresos.FirstOrDefault(o => o.Id == registro.IdTransaccion).Nombre;
                }

                cmbTransaccion.Text = tr;
                txtFecha.Value = Convert.ToDateTime(registro.Fecha);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvRegristroTransaccion.SelectedRows;
            if (seleccion.Count > 0)
            {
                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvRegristroTransaccion[0, selectedIndex].Value.ToString());

                RegistroTransacciones dep = _conexion.RegistroTransacciones.FirstOrDefault(r => r.Id == rowID);

                _conexion.RegistroTransacciones.Remove(dep);
                _conexion.SaveChanges();
                //dgvRegristroTransaccion.Rows.RemoveAt(seleccion[0].Index);
                cargarDGV();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (validar()) {
                int id = Convert.ToInt32(txtId.Text);
                RegistroTransacciones registro = _conexion.RegistroTransacciones.FirstOrDefault(o => o.Id ==id); ;

                registro.IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue); 
                registro.IdTransaccion = Convert.ToInt32(cmbTransaccion.SelectedValue);
                registro.Estado = cmbEstado.Text;
                registro.Fecha = txtFecha.Value;
                registro.Monto = Convert.ToDouble(txtMonto.Text);
                registro.TipoMovimiento = cmbTipoTransaccion.Text;
                _conexion.SaveChanges();
            }
                else
                {
                    MessageBox.Show("Hay campos vacios.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninún puesto.");
            }

            cargarDGV();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscar.Text))
            {
                cargarDGV();
            }
        }
    }
}
