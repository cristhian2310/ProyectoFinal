using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SistemaNomina());
            //Application.Run(new FrmCalculo());

            //Application.Run(new FrmEmpleados());
            //Application.Run(new FrmPuestos());
            //Application.Run(new Login());
            //Application.Run(new FrmDepartamentos());
            //Application.Run(new FrmDeducciones());
            //Application.Run(new FrmIngresos());
        
        }
    }
}
