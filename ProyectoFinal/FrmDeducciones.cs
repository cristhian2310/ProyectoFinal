﻿using System;
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
    public partial class FrmDeducciones : Form
    {
        ProyectoFinalEntities2 _conexion = new ProyectoFinalEntities2();

        public FrmDeducciones()
        {
            InitializeComponent();
            cargarDeducciones();
            dgvDeducciones.AllowUserToAddRows = false;

        }

        public void cargarDeducciones()
        {


            var lista = _conexion.TiposDeducciones.ToList();
            var listabing = new BindingList<TiposDeducciones>(lista);
            dgvDeducciones.DataSource = listabing;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
            txtDepende.Text = "";
            txtTipo.Text = "";
            txtMonto.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                TiposDeducciones deduccion = new TiposDeducciones();

                deduccion.Nombre = txtNombre.Text;
                deduccion.DependeSalario = txtDepende.Text;
                deduccion.Estado = txtEstado.Text;
                deduccion.Monto = Convert.ToDouble(txtMonto.Text);
                deduccion.Tipo = txtTipo.Text;

                _conexion.TiposDeducciones.Add(deduccion);
                _conexion.SaveChanges();
                cargarDeducciones();
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
                    txtTipo.Text == ""||
                    txtMonto.Text.Trim() == ""||
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
                    txtDepende.Text == ""||
                    txtTipo.Text == ""||
                    txtMonto.Text.Trim() == ""
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
                cargarDeducciones();
            }
            else
            {
                var resultados = _conexion.TiposDeducciones.Where(y => y.Nombre.Contains(this.txtBuscar.Text)).ToList();

                if (resultados != null)
                {
                    var deducciones = new BindingList<TiposDeducciones>(resultados);
                    dgvDeducciones.DataSource = deducciones;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvDeducciones.SelectedRows;
            if (seleccion.Count > 0)
            {
                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvDeducciones[0, selectedIndex].Value.ToString());

                var existe = _conexion.RegistroTransacciones.FirstOrDefault(y => y.IdTransaccion == rowID && y.TipoMovimiento=="Deduccion");

                if (existe == null)
                {

                    TiposDeducciones dep = _conexion.TiposDeducciones.FirstOrDefault(r => r.Id == rowID);

                    _conexion.TiposDeducciones.Remove(dep);
                    _conexion.SaveChanges();
                    dgvDeducciones.Rows.RemoveAt(seleccion[0].Index);
                    cargarDeducciones();
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
                    var deducciones = _conexion.TiposDeducciones.FirstOrDefault(r => r.Id == id);

                    deducciones.Nombre = txtNombre.Text;
                    deducciones.Estado = txtEstado.Text;
                    deducciones.DependeSalario = txtDepende.Text;
                    deducciones.Monto = Convert.ToDouble(txtMonto.Text);
                    deducciones.Tipo = txtTipo.Text;

                    _conexion.SaveChanges();
                    cargarDeducciones();
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
            var seleccion = dgvDeducciones.SelectedRows;
            if (seleccion.Count > 0)
            {

                int selectedIndex = seleccion[0].Index;

                int rowID = int.Parse(dgvDeducciones[0, selectedIndex].Value.ToString());

                TiposDeducciones deduccion = _conexion.TiposDeducciones.FirstOrDefault(r => r.Id == rowID);

                txtDepende.Text = deduccion.DependeSalario;

                txtEstado.Text = deduccion.Estado;

                txtMonto.Text = Convert.ToString(deduccion.Monto);

                txtTipo.Text = deduccion.Tipo;

                txtId.Text = Convert.ToString(deduccion.Id);
                txtNombre.Text = deduccion.Nombre;


            }
        }
    }
}
