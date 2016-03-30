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
    public partial class FrmEmpleados : Form
    {
        ProyectoFinalEntities1 conexion = new ProyectoFinalEntities1();
        public FrmEmpleados()
        {
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.AllowUserToAddRows = false;
            cargarEmpleados();
            cargarCombos();

        }

        public void cargarCombos()
        {
            var departamentos = conexion.Departamentos.ToList();
            var departamentosBinding = new BindingList<Departamentos>(departamentos);
            txtDepartameto.DataSource = departamentosBinding;
            txtDepartameto.DisplayMember = "Nombre";
            txtDepartameto.ValueMember = "Id";


            var puestos = conexion.Puestos.ToList();
            var puestosBinding = new BindingList<Puestos>(puestos);
            txtPuesto.DataSource = puestosBinding;
            txtPuesto.DisplayMember = "Nombre";
            txtPuesto.ValueMember = "Id";
        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {

        }
        public void cargarEmpleados()
        {

            var empleadosViewModel = new List<EmpleadosViewModel>();
            var p = conexion.Empleados.ToList();


            foreach (var emp in p)
            {
                EmpleadosViewModel e = new EmpleadosViewModel();
                e.Id = emp.Id;
                e.Departamento = emp.Departamentos.Nombre;
                e.Cedula = emp.Cedula;
                e.Puesto = emp.Puestos.Nombre;
                e.SalarioMensual = emp.SalarioMensual;
                e.Nombre = emp.Nombre;

                empleadosViewModel.Add(e);
            }
            var empleados = new BindingList<EmpleadosViewModel>(empleadosViewModel);
            dgvEmpleados.DataSource = empleados;
        }

        public bool validar(int id = 0)
        {

            var correcto = true;

            if (id != 0)
            {
                if (txtNombre.Text == "" ||
                    txtCedula.Text == "" ||
                    txtDepartameto.Text == "" ||
                    txtSalario.Text == "" ||
                    txtPuesto.Text == "" ||
                    txtId.Text == ""
                    )
                {
                    correcto = false;
                }
            }
            else
            {
                if (txtNombre.Text == "" ||
                    txtCedula.Text == "" ||
                    txtDepartameto.Text == "" ||
                    txtSalario.Text == "" ||
                    txtPuesto.Text == "")
                {
                    correcto = false;
                }
            }
            return correcto;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Empleados empleados = new Empleados();

                empleados.Nombre = txtNombre.Text;
                empleados.SalarioMensual = Convert.ToDouble(txtSalario.Text);
                empleados.Cedula = txtCedula.Text;
                empleados.IdDepartamento = Convert.ToInt32(txtDepartameto.SelectedValue);
                empleados.IdPuesto = Convert.ToInt32(txtPuesto.SelectedValue);

                var idPuesto = Convert.ToInt32(txtPuesto.SelectedValue);
                var salario = conexion.Puestos.FirstOrDefault(u => u.Id ==idPuesto);

                if (salario.SalarioMaximo <= Convert.ToDouble(txtSalario.Text) &&
                    salario.SalarioMinimo >= Convert.ToDouble(txtSalario.Text))
                {

                    empleados.SalarioMensual = Convert.ToDouble(txtSalario.Text);

                    conexion.Empleados.Add(empleados);
                    conexion.SaveChanges();
                    cargarEmpleados();
                }
                else {

                    MessageBox.Show("El salario no esta en el margen de ganacia del cargo seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDepartameto.Text = "";
            txtPuesto.Text = "";
            txtCedula.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvEmpleados.SelectedRows;
            if (seleccion.Count > 0)
            {
                int selectedIndex = seleccion[0].Index;


                int rowID = int.Parse(dgvEmpleados[0, selectedIndex].Value.ToString());

                var existe = conexion.Departamentos.FirstOrDefault(y => y.Responsable == rowID );
                var existeRegistro = conexion.RegistroTransacciones.FirstOrDefault(y => y.IdEmpleado == rowID);
                if (existe == null && existeRegistro == null)
                {

                    Empleados dep = conexion.Empleados.FirstOrDefault(r => r.Id == rowID);

                    conexion.Empleados.Remove(dep);
                    conexion.SaveChanges();
                    dgvEmpleados.Rows.RemoveAt(seleccion[0].Index);
                    cargarEmpleados();
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
                if (validar(Convert.ToInt32(txtId.Text)))
                {

                    int id = Convert.ToInt32(txtId.Text);
                    var empleados = conexion.Empleados.FirstOrDefault(r => r.Id == id);

                    empleados.Nombre = txtNombre.Text;
                    empleados.SalarioMensual = Convert.ToDouble(txtSalario.Text);
                    empleados.Cedula = txtCedula.Text;
                    empleados.IdDepartamento = Convert.ToInt32(txtDepartameto.SelectedValue);
                    empleados.IdPuesto = Convert.ToInt32(txtPuesto.SelectedValue);
                    empleados.SalarioMensual = Convert.ToDouble(txtSalario.Text);

                    conexion.SaveChanges();
                    cargarEmpleados();
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
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvEmpleados.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvEmpleados[0, selectedIndex].Value.ToString());
                // int empeladoid = int.Parse(dgvEmpleados[3, selectedIndex].Value.ToString());

                Empleados empleado = conexion.Empleados.FirstOrDefault(r => r.Id == rowID);

                txtDepartameto.SelectedValue = empleado.IdDepartamento;

                txtPuesto.SelectedValue = empleado.IdPuesto;

                txtId.Text = Convert.ToString(empleado.Id);
                txtNombre.Text = empleado.Nombre;
                txtCedula.Text = empleado.Cedula;
                txtSalario.Text = Convert.ToString(empleado.SalarioMensual);

                //txtDepartameto.Text =Convert.ToString(puesto.SalarioMaximo);
                //txtPuesto.Text =Convert.ToString(puesto.SalarioMinimo);







            }
        }

        private void txtSalarioMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscar.Text))
            {
                cargarEmpleados();
            }
            else
            {
                var resultados = conexion.Empleados.Where(y => y.Nombre.Contains(this.txtBuscar.Text));

                if (resultados != null)
                {
                    var empleadosViewModel = new List<EmpleadosViewModel>();

                    foreach (var emp in resultados)
                    {
                        var p = new EmpleadosViewModel();
                        p.Id = emp.Id;
                        p.Departamento = emp.Departamentos.Nombre;
                        p.Cedula = emp.Cedula;
                        p.Puesto = emp.Puestos.Nombre;
                        p.SalarioMensual = emp.SalarioMensual;
                        p.Nombre = emp.Nombre;

                        empleadosViewModel.Add(p);
                    }
                    var empleados = new BindingList<EmpleadosViewModel>(empleadosViewModel);
                    dgvEmpleados.DataSource = empleados;
                }
            }
        }


    }
}
