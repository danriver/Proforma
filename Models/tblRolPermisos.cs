//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proforma.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRolPermisos
    {
        public decimal decIdRol { get; set; }
        public decimal decIdPermiso { get; set; }
        public Nullable<bool> bitActivo { get; set; }
    
        public virtual tblPermisos tblPermisos { get; set; }
        public virtual tblRoles tblRoles { get; set; }
    }
}