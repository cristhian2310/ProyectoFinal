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
    public partial class Form1 : Form
    {
        ProyectoFinalEntities1 conexion = new ProyectoFinalEntities1();
        public Form1()
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
            var yourList = conexion.Departamentos.ToList();
            List<String> lista;
            //foreach(var e in yourList){
            //    conexion.Empleados.Where(t=>t.Id)
            //    lista.Add();
            //}

            var listBinding = new BindingList<Departamentos>(yourList);
            dgvDepartamentos.DataSource = listBinding;
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
                dgvDepartamentos.DataSource = conexion.Departamentos.ToList();
            }

            var depatamentos = conexion.Departamentos.Where(y => y.Nombre.Contains(this.textBuscar.Text));
            //var depatamentos = conexion.Departamentos.Where(y => y.Nombre == this.textBuscar.Text);
            if(depatamentos!=null){
                dgvDepartamentos.DataSource = depatamentos.ToList();
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
                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvDepartamentos[0, selectedIndex].Value.ToString());

                Departamentos dep = conexion.Departamentos.FirstOrDefault(r => r.Id == rowID);

                conexion.Departamentos.Remove(dep);
                conexion.SaveChanges();
                dgvDepartamentos.Rows.RemoveAt(seleccion[0].Index);
                cargarDepartamentos();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtUbicacion.Text != "")
            {
                Departamentos dep = new Departamentos();
                dep.Nombre = txtNombre.Text;
                dep.Responsable =Convert.ToInt32(comboEncargado.SelectedValue);
                dep.Ubicacion = txtUbicacion.Text;
                conexion.Departamentos.Add(dep);
                conexion.SaveChanges();
                cargarDepartamentos();
            }
           


        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text !="" && this.txtNombre.Text != "" && this.txtUbicacion.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                var dep = conexion.Departamentos.FirstOrDefault(r => r.Id == id);
                dep.Nombre = txtNombre.Text;
                dep.Responsable = Convert.ToInt32(comboEncargado.SelectedValue);
                dep.Ubicacion = txtUbicacion.Text;
                conexion.SaveChanges();
                cargarDepartamentos();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seleccion = dgvDepartamentos.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvDepartamentos[0, selectedIndex].Value.ToString());
                int empeladoid = int.Parse(dgvDepartamentos[3, selectedIndex].Value.ToString());


                comboEncargado.SelectedValue = empeladoid;
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
