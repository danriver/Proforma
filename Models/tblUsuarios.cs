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
    
    public partial class tblUsuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuarios()
        {
            this.tblCotizaciones = new HashSet<tblCotizaciones>();
            this.tblBitacoras = new HashSet<tblBitacoras>();
            this.tblErrores = new HashSet<tblErrores>();
            this.tblDetalleCotizaciones = new HashSet<tblDetalleCotizaciones>();
        }
    
        public decimal decIdUsuario { get; set; }
        public string strUsuario { get; set; }
        public string strNombreUsuario { get; set; }
        public string strContrasena { get; set; }
        public Nullable<decimal> decIdRol { get; set; }
        public Nullable<decimal> decIdVendedor { get; set; }
        public bool bitActivo { get; set; }
        public Nullable<bool> bitEnllavado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCotizaciones> tblCotizaciones { get; set; }
        public virtual tblRoles tblRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBitacoras> tblBitacoras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblErrores> tblErrores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDetalleCotizaciones> tblDetalleCotizaciones { get; set; }
        public virtual tblVendedores tblVendedores { get; set; }
    }
}
