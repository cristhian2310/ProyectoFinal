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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mismoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeTiposDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esoToolStripMenuItem,
            this.mismoToolStripMenuItem,
            this.gestiónDePuestosToolStripMenuItem,
            this.gestiónDeTiposDeIngresosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // esoToolStripMenuItem
            // 
            this.esoToolStripMenuItem.Name = "esoToolStripMenuItem";
            this.esoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.esoToolStripMenuItem.Text = "Gestión Departamentos";
            this.esoToolStripMenuItem.Click += new System.EventHandler(this.esoToolStripMenuItem_Click);
            // 
            // mismoToolStripMenuItem
            // 
            this.mismoToolStripMenuItem.Name = "mismoToolStripMenuItem";
            this.mismoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.mismoToolStripMenuItem.Text = "Gestion Empleados";
            // 
            // gestiónDePuestosToolStripMenuItem
            // 
            this.gestiónDePuestosToolStripMenuItem.Name = "gestiónDePuestosToolStripMenuItem";
            this.gestiónDePuestosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gestiónDePuestosToolStripMenuItem.Text = "Gestión de Puestos";
            // 
            // gestiónDeTiposDeIngresosToolStripMenuItem
            // 
            this.gestiónDeTiposDeIngresosToolStripMenuItem.Name = "gestiónDeTiposDeIngresosToolStripMenuItem";
            this.gestiónDeTiposDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gestiónDeTiposDeIngresosToolStripMenuItem.Text = "Gestión de Tipos de Ingresos";
            // 
            // SistemaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 484);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaNomina";
            this.Text = "SistemaNomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem gestiónDeTiposDeIngresosToolStripMenuItem;
    }
}