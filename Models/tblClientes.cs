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
    
    public partial class tblClientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientes()
        {
            this.tblClientesContacto = new HashSet<tblClientesContacto>();
            this.tblCotizaciones = new HashSet<tblCotizaciones>();
        }
    
        public decimal decIdCliente { get; set; }
        public string strNombre { get; set; }
        public string strDireccion { get; set; }
        public string strTelefono { get; set; }
        public Nullable<decimal> decIdVendedor { get; set; }
        public Nullable<bool> bitExonerado { get; set; }
        public Nullable<int> intIdPrecio { get; set; }
        public Nullable<bool> bitActivo { get; set; }
        public string strRUC { get; set; }
        public string strSiglas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientesContacto> tblClientesContacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCotizaciones> tblCotizaciones { get; set; }
        public virtual tblPrecios tblPrecios { get; set; }
        public virtual tblVendedores tblVendedores { get; set; }
    }
}
