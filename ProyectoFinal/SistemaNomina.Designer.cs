namespace ProyectoFinal
{
    partial class SistemaNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mismoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTransaccion = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esoToolStripMenuItem,
            this.mismoToolStripMenuItem,
            this.gestiónDePuestosToolStripMenuItem,
            this.gestionDeIngresosToolStripMenuItem,
            this.gestionDeDeduccionesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // esoToolStripMenuItem
            // 
            this.esoToolStripMenuItem.Name = "esoToolStripMenuItem";
            this.esoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.esoToolStripMenuItem.Text = "Gestión Departamentos";
            this.esoToolStripMenuItem.Click += new System.EventHandler(this.esoToolStripMenuItem_Click);
            // 
            // mismoToolStripMenuItem
            // 
            this.mismoToolStripMenuItem.Name = "mismoToolStripMenuItem";
            this.mismoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mismoToolStripMenuItem.Text = "Gestion Empleados";
            this.mismoToolStripMenuItem.Click += new System.EventHandler(this.mismoToolStripMenuItem_Click);
            // 
            // gestiónDePuestosToolStripMenuItem
            // 
            this.gestiónDePuestosToolStripMenuItem.Name = "gestiónDePuestosToolStripMenuItem";
            this.gestiónDePuestosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestiónDePuestosToolStripMenuItem.Text = "Gestión de Puestos";
            this.gestiónDePuestosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePuestosToolStripMenuItem_Click);
            // 
            // gestionDeIngresosToolStripMenuItem
            // 
            this.gestionDeIngresosToolStripMenuItem.Name = "gestionDeIngresosToolStripMenuItem";
            this.gestionDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestionDeIngresosToolStripMenuItem.Text = "Gestion de Ingresos";
            this.gestionDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeIngresosToolStripMenuItem_Click);
            // 
            // gestionDeDeduccionesToolStripMenuItem
            // 
            this.gestionDeDeduccionesToolStripMenuItem.Name = "gestionDeDeduccionesToolStripMenuItem";
            this.gestionDeDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestionDeDeduccionesToolStripMenuItem.Text = "Gestion de Deducciones";
            this.gestionDeDeduccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDeduccionesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de transacción";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transacción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(224, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Registro de Transacciones";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 10;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(134, 110);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 11;
            // 
            // cmbTipoTransaccion
            // 
            this.cmbTipoTransaccion.FormattingEnabled = true;
            this.cmbTipoTransaccion.Items.AddRange(new object[] {
            "Deduccion",
            "Ingreso"});
            this.cmbTipoTransaccion.Location = new System.Drawing.Point(134, 147);
            this.cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            this.cmbTipoTransaccion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTransaccion.TabIndex = 12;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(134, 184);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 13;
            // 
            // cmbTransaccion
            // 
            this.cmbTransaccion.FormattingEnabled = true;
            this.cmbTransaccion.Location = new System.Drawing.Point(378, 149);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(121, 21);
            this.cmbTransaccion.TabIndex = 14;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(378, 70);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Empleado,
            this.TipoTransaccion,
            this.Estado,
            this.Fecha,
            this.Monto,
            this.Transaccion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 189);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // TipoTransaccion
            // 
            this.TipoTransaccion.HeaderText = "Tipo de transacción";
            this.TipoTransaccion.Name = "TipoTransaccion";
            this.TipoTransaccion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Column1";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Transaccion
            // 
            this.Transaccion.HeaderText = "Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(156, 179);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(230, 20);
            this.txtBuscar.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(603, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(603, 142);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 23);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(603, 179);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 23);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(392, 179);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(241, 23);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar selección";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 211);
            this.panel1.TabIndex = 24;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(590, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SistemaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 470);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbTransaccion);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbTipoTransaccion);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaNomina";
            this.Text = "Tipo de transacción";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mismoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDeduccionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoTransaccion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTransaccion;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
    }
}