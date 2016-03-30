using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels
{
    class RegistroTransaccionViewModel
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public string Transaccion { get; set; }
        public string TipoMovimiento { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
    }
}
