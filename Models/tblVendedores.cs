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
    
    public partial class tblVendedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVendedores()
        {
            this.tblClientes = new HashSet<tblClientes>();
            this.tblUsuarios = new HashSet<tblUsuarios>();
            this.tblCotizaciones = new HashSet<tblCotizaciones>();
        }
    
        public decimal decIdVendedor { get; set; }
        public string strNombreVendedor { get; set; }
        public string strTelefono { get; set; }
        public string strCorreo { get; set; }
        public string strContrasena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientes> tblClientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsuarios> tblUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCotizaciones> tblCotizaciones { get; set; }
    }
}
