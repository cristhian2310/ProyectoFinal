//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistroTransacciones
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdDeduccion { get; set; }
        public int IdTrasaccion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
    
        public virtual TiposDeducciones TiposDeducciones { get; set; }
        public virtual Empleados Empleados { get; set; }
    }
}
