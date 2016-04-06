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
    public partial class FrmIngresos : Form
    {
        ProyectoFinalEntities2 _conexion = new ProyectoFinalEntities2();

        public FrmIngresos()
        {
            InitializeComponent();
            cargarIngresos();
            dgvIngresos.AllowUserToAddRows = false;

        }

        public void cargarIngresos()
        {


            var lista = _conexion.TiposIngresos.ToList();
            var listabing = new BindingList<TiposIngresos>(lista);
            dgvIngresos.DataSource = listabing;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtEstado.SelectedIndex = 0;
            txtDepende.SelectedIndex = 0;
            txtTipo.SelectedIndex = 0;
            txtMonto.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                TiposIngresos ingreso = new TiposIngresos();
                ingreso.Nombre = txtNombre.Text;
                ingreso.DependeSalario = txtDepende.Text;
                ingreso.Estado = txtEstado.Text;
                ingreso.Monto = Convert.ToDouble(txtMonto.Text);
                ingreso.Tipo = txtTipo.Text;

                _conexion.TiposIngresos.Add(ingreso);
                _conexion.SaveChanges();
                cargarIngresos();
            }
            else
            {
                MessageBox.Show("Hay campos vacios.");
            }
        }
        public bool validar(int id = 0)
        {

            var correcto = true;

            if (id != 0)
            {
                if (txtNombre.Text == "" ||
                    txtEstado.SelectedText == "" ||
                    txtDepende.SelectedText == "" ||
                    txtTipo.Text == "" ||
                    txtMonto.Text.Trim() == "" ||
                    txtId.Text == ""
                    )
                {
                    correcto = false;
                }
            }
            else
            {
                if (txtNombre.Text == "" ||
                    txtEstado.Text == "" ||
                    txtTipo.Text == "" ||
                    txtMonto.Text.Trim() == "" ||
                    txtDepende.Text == ""
                    )
                {
                    correcto = false;
                }
            }
            return correcto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscar.Text))
            {
                cargarIngresos();
            }
            else
            {
                var resultados = _conexion.TiposIngresos.Where(y => y.Nombre.Contains(this.txtBuscar.Text)).ToList();

                if (resultados != null)
                {
                    var ingresos = new BindingList<TiposIngresos>(resultados);
                    dgvIngresos.DataSource = ingresos;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvIngresos.SelectedRows;
            if (seleccion.Count > 0)
            {
                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvIngresos[0, selectedIndex].Value.ToString());

                var existe = _conexion.RegistroTransacciones.FirstOrDefault(y => y.IdTransaccion == rowID && y.TipoMovimiento == "Ingreso");

                if (existe == null)
                {

                    TiposIngresos dep = _conexion.TiposIngresos.FirstOrDefault(r => r.Id == rowID);

                    _conexion.TiposIngresos.Remove(dep);
                    _conexion.SaveChanges();
                    dgvIngresos.Rows.RemoveAt(seleccion[0].Index);
                    cargarIngresos();
                }
                else
                {
                    MessageBox.Show("Este registro esta siendo utilizado por otra entidad");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (validar())
                {

                    int id = Convert.ToInt32(txtId.Text);
                    var ingresos = _conexion.TiposIngresos.FirstOrDefault(r => r.Id == id);

                    ingresos.Nombre = txtNombre.Text;
                    ingresos.Estado = txtEstado.Text;
                    ingresos.DependeSalario = txtDepende.Text;
                    ingresos.Monto = Convert.ToDouble(txtMonto.Text);
                    ingresos.Tipo = txtTipo.Text;

                    _conexion.SaveChanges();
                    cargarIngresos();
                }
                else
                {
                    MessageBox.Show("Hay campos vacios.");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvIngresos.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvIngresos[0, selectedIndex].Value.ToString());

                TiposIngresos ingreso = _conexion.TiposIngresos.FirstOrDefault(r => r.Id == rowID);

                txtDepende.Text = ingreso.DependeSalario;

                txtEstado.Text = ingreso.Estado;

                txtMonto.Text = Convert.ToString(ingreso.Monto);

                txtTipo.Text = ingreso.Tipo;

                txtId.Text = Convert.ToString(ingreso.Id);
                txtNombre.Text = ingreso.Nombre;


            }
        }
    }
}
