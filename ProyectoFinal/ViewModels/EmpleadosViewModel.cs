﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels
{
    public class EmpleadosViewModel 
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public Nullable<double> SalarioMensual { get; set; }
    }
}
