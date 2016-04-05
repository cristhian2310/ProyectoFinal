using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels
{
    class CalculoViewModel
    {
        public string tipo { get; set; }

        public string descripcion { get; set;}

        public double? monto { get; set; }

        public DateTime? fecha { get; set; }
    }
}
