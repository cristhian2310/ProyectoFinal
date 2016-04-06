using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.ViewModels;
namespace ProyectoFinal
{
    public partial class Login : Form
    {
        ProyectoFinalEntities2 _conexion = new ProyectoFinalEntities2();
        public Login()
        {
            InitializeComponent();
            lblError.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = _conexion.Usuarios.FirstOrDefault(o => o.Usuario == txtUsuario.Text &&
                o.Clave == txtPass.Text);
            if (usuario !=null)
            {
                Seguridad.Rol = usuario.Rol;
                new SistemaNomina().Show();
                this.Hide();
            }
            else {
                lblError.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
