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
    
    public partial class Empleados
    {
        public Empleados()
        {
            this.RegistroTransacciones = new HashSet<RegistroTransacciones>();
        }
    
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public int IdPuesto { get; set; }
        public Nullable<double> SalarioMensual { get; set; }
    
        public virtual Departamentos Departamentos { get; set; }
        public virtual Puestos Puestos { get; set; }
        public virtual ICollection<RegistroTransacciones> RegistroTransacciones { get; set; }
    }
}
