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
    public partial class FrmDepartamentos : Form
    {
        ProyectoFinalEntities2 conexion = new ProyectoFinalEntities2();
        public FrmDepartamentos()
        {
            InitializeComponent();
            this.dgvDepartamentos.AutoGenerateColumns = false;
            cargarDepartamentos();
            var empleados = conexion.Empleados.ToList();
            var empleadoBinding = new BindingList<Empleados>(empleados);
            comboEncargado.DataSource = empleadoBinding;
            comboEncargado.DisplayMember = "Nombre";
            comboEncargado.ValueMember = "Id";
        }

        public void cargarDepartamentos() {

            var departamentosViewModel = new List<DepartamentoViewModel>();
  
            var p = conexion.Departamentos.ToList();

            foreach (var emp in p)
            {
                DepartamentoViewModel e = new DepartamentoViewModel();
                e.Id = emp.Id;
                e.Nombre = emp.Nombre;
                if (emp.Responsable != 0) { 
                e.Responsable = conexion.Empleados.FirstOrDefault(l=>l.Id == emp.Responsable).Nombre;
                }
                e.Ubicacion = emp.Ubicacion;

                departamentosViewModel.Add(e);
            }
            var depa = new BindingList<DepartamentoViewModel>(departamentosViewModel);
            dgvDepartamentos.DataSource = depa;


        }

        private void btnConsultarDepartamento_Click(object sender, EventArgs e)
        {
         
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDepartamentos.AutoGenerateColumns = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((3 + 3 == 0) && (6+3==0))
            {

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBuscar.Text)) {

                cargarDepartamentos();
            }
            else {
                var resultados = conexion.Departamentos.Where(y => y.Nombre.Contains(this.textBuscar.Text));

                if (resultados != null)
                {
                    var departamentosViewModel = new List<DepartamentoViewModel>();

                    foreach (var emp in resultados)
                    {
                        var l = new DepartamentoViewModel();
                        l.Id = emp.Id;
                        l.Nombre = emp.Nombre;
                        l.Responsable = conexion.Empleados.FirstOrDefault(m => m.Id == emp.Responsable).Nombre;
                        l.Ubicacion = emp.Ubicacion;

                        departamentosViewModel.Add(l);
                    }
                    var depa = new BindingList<DepartamentoViewModel>(departamentosViewModel);
                    dgvDepartamentos.DataSource = depa;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtUbicacion.Text = "";
            this.textBuscar.Text = "";
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var seleccion = dgvDepartamentos.SelectedRows;
            if (seleccion.Count > 0) {
                try
                {
                    int selectedIndex = seleccion[0].Index;



                    int rowID = int.Parse(dgvDepartamentos[0, selectedIndex].Value.ToString());

                    var existe = conexion.Empleados.FirstOrDefault(y => y.IdDepartamento == rowID);

                    if (existe == null)
                    {

                        Departamentos dep = conexion.Departamentos.FirstOrDefault(r => r.Id == rowID);
                        conexion.Departamentos.Remove(dep);
                        conexion.SaveChanges();
                        dgvDepartamentos.Rows.RemoveAt(seleccion[0].Index);
                        cargarDepartamentos();
                    }
                    else {
                        MessageBox.Show("Este registro esta siendo utilizado por otra entidad");
                    }
                }
                catch {
                    MessageBox.Show("Este departarmento no puede ser borrado ya que posee empleados.");
                }
            }
        }

        public bool validar(int id =0) {

            var correcto = true;

            if (id != 0)
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text) ||
                    String.IsNullOrWhiteSpace(txtUbicacion.Text)||
                    String.IsNullOrWhiteSpace(txtId.Text))
                {
                    correcto = false;
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text) ||
                    String.IsNullOrWhiteSpace(txtUbicacion.Text))
                {
                    correcto = false;
                }
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                    Departamentos dep = new Departamentos();
                    dep.Nombre = txtNombre.Text;

                    if (Convert.ToInt32(comboEncargado.SelectedValue) != null) {
                        dep.Responsable = Convert.ToInt32(comboEncargado.SelectedValue);
                    }
                    
                    dep.Ubicacion = txtUbicacion.Text;
                    conexion.Departamentos.Add(dep);
                    conexion.SaveChanges();
                    cargarDepartamentos();

            }
            else {
                MessageBox.Show("Hay campos vacios.");
            }
           


        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (validar(Convert.ToInt32(txtId.Text)))
                {
                    try
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        var dep = conexion.Departamentos.FirstOrDefault(r => r.Id == id);
                        dep.Nombre = txtNombre.Text;
                        dep.Responsable = Convert.ToInt32(comboEncargado.SelectedValue);
                        dep.Ubicacion = txtUbicacion.Text;
                        conexion.SaveChanges();
                        cargarDepartamentos();
                    }
                    catch
                    {
                        MessageBox.Show("campos con datos incorrectos.");
                    }
                }
            }
            else {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seleccion = dgvDepartamentos.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvDepartamentos[0, selectedIndex].Value.ToString());
              
                var idResponsable = conexion.Departamentos.FirstOrDefault(o=>o.Id == rowID).Responsable;
                
                if(idResponsable!=null){
                    comboEncargado.SelectedValue = idResponsable;
                }
                Departamentos dep = conexion.Departamentos.FirstOrDefault(r => r.Id == rowID);


                txtNombre.Text = dep.Nombre;
                txtId.Text = Convert.ToString(dep.Id);
                
                txtUbicacion.Text = dep.Ubicacion;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
