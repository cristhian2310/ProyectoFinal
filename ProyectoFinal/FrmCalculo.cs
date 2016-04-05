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
    public partial class FrmCalculo : Form
    {
        ProyectoFinalEntities1 _conexion = new ProyectoFinalEntities1();

        public FrmCalculo()
        {
            InitializeComponent();
            cargarEmpleados();
        }

        public void cargarEmpleados()
        {
            var empleados = _conexion.Empleados.ToList();
            var empleadosBinding = new BindingList<Empleados>(empleados);
            cmbEmpleados.DataSource = empleadosBinding;
            cmbEmpleados.DisplayMember = "Nombre";
            cmbEmpleados.ValueMember = "Id";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(cmbEmpleados.SelectedValue);

            var empleado = _conexion.Empleados.FirstOrDefault(o => o.Id == idUsuario);

            var transacciones = _conexion.RegistroTransacciones.Where(u => u.IdEmpleado == idUsuario);

            List<CalculoViewModel> deducciones = new List<CalculoViewModel>();
            List<CalculoViewModel> ingresos = new List<CalculoViewModel>();

            

            foreach (var trans in transacciones)
            {
                var cal = new CalculoViewModel();
                if (trans.TipoMovimiento == "Deduccion") {
                    var de = _conexion.TiposDeducciones.FirstOrDefault(p => p.Id == trans.IdTransaccion);
                    cal.tipo = "Deduccion";
                    cal.descripcion = de.Nombre;

                    if (de.Tipo == "Fijo")
                    {
                        cal.monto = de.Monto;
                    }
                    else {
                        var p = de.Monto / 100;
                        cal.monto = p * empleado.SalarioMensual;
                    }
                    cal.fecha = trans.Fecha;

                    deducciones.Add(cal);
                }
                else if (trans.TipoMovimiento == "Ingreso")
                {
                    var de = _conexion.TiposIngresos.FirstOrDefault(p => p.Id == trans.IdTransaccion);
                    cal.tipo = "Ingreso";
                    cal.descripcion = de.Nombre;

                    if (de.Tipo == "Fijo")
                    {
                        cal.monto = de.Monto;
                    }
                    else
                    {
                        var p = de.Monto / 100;
                        cal.monto = p * empleado.SalarioMensual;
                    }
                    cal.fecha = trans.Fecha;

                    deducciones.Add(cal);
                }

            }
            DgvCalculo.DataSource = deducciones.ToList();


        }
    }
}
