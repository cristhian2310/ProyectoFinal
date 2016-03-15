namespace ProyectoFinal
{
    partial class FrmPuestos
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNivelRiesgo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.txtSalarioMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(97, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(188, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNivelRiesgo
            // 
            this.txtNivelRiesgo.Location = new System.Drawing.Point(97, 86);
            this.txtNivelRiesgo.Name = "txtNivelRiesgo";
            this.txtNivelRiesgo.Size = new System.Drawing.Size(188, 20);
            this.txtNivelRiesgo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Location = new System.Drawing.Point(97, 160);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(188, 20);
            this.txtSalarioMin.TabIndex = 3;
            // 
            // txtSalarioMax
            // 
            this.txtSalarioMax.Location = new System.Drawing.Point(97, 123);
            this.txtSalarioMax.Name = "txtSalarioMax";
            this.txtSalarioMax.Size = new System.Drawing.Size(188, 20);
            this.txtSalarioMax.TabIndex = 4;
            this.txtSalarioMax.TextChanged += new System.EventHandler(this.txtSalarioMax_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nivel de riesgo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salario maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salario minimo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNivelRiesgo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSalarioMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSalarioMax);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 190);
            this.panel1.TabIndex = 10;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(305, 157);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(125, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrr registro";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(305, 121);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(305, 83);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 23);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(305, 45);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 247);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(303, 245);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar selección";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.NivelRiesgo,
            this.SalarioMaximo,
            this.SalarioMinimo});
            this.dgvPuestos.Location = new System.Drawing.Point(13, 273);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.Size = new System.Drawing.Size(429, 150);
            this.dgvPuestos.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NivelRiesgo
            // 
            this.NivelRiesgo.DataPropertyName = "NivelRiesgo";
            this.NivelRiesgo.HeaderText = "Nivel de Riesgo";
            this.NivelRiesgo.Name = "NivelRiesgo";
            this.NivelRiesgo.ReadOnly = true;
            // 
            // SalarioMaximo
            // 
            this.SalarioMaximo.DataPropertyName = "SalarioMaximo";
            this.SalarioMaximo.HeaderText = "Salario Maximo";
            this.SalarioMaximo.Name = "SalarioMaximo";
            this.SalarioMaximo.ReadOnly = true;
            // 
            // SalarioMinimo
            // 
            this.SalarioMinimo.DataPropertyName = "SalarioMinimo";
            this.SalarioMinimo.HeaderText = "Salario Minimo";
            this.SalarioMinimo.Name = "SalarioMinimo";
            this.SalarioMinimo.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(117, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gestión de Puestos";
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPuestos";
            this.Text = "FrmPuestos";
            this.Load += new System.EventHandler(this.FrmPuestos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNivelRiesgo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.TextBox txtSalarioMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMinimo;
    }
}