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
        ProyectoFinalEntities2 _conexion = new ProyectoFinalEntities2();

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

            var deduccionesMensuales = _conexion.TiposDeducciones.Where(p => p.DependeSalario == "Si");

            if (deduccionesMensuales != null)
            {
                foreach (var mensual in deduccionesMensuales)
                {
                    var cal = new CalculoViewModel();
                    cal.tipo = "Deduccion";
                    cal.descripcion = mensual.Nombre;

                    if (mensual.Tipo == "Fijo")
                    {
                        cal.monto = mensual.Monto;
                    }
                    else
                    {
                        var p = mensual.Monto / 100;
                        cal.monto = p * empleado.SalarioMensual;
                    }
                    cal.fecha = DateTime.Today;

                    deducciones.Add(cal);
                }
            }
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < DgvCalculo.Rows.Count; i++)
                {
                    for (int j = 0; j < DgvCalculo.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DgvCalculo.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DgvCalculo.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
}
