//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaPaz.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcion
    {
        public Funcion()
        {
            this.OperadoresFunciones = new HashSet<OperadoresFuncione>();
            this.Roles = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string kccodfunc { get; set; }
        public string Comentario { get; set; }
        public string DefinicionTecnica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual ICollection<OperadoresFuncione> OperadoresFunciones { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
