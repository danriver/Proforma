﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_ERPEntities : DbContext
    {
        public BD_ERPEntities()
            : base("name=BD_ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCambioMoneda> tblCambioMoneda { get; set; }
        public virtual DbSet<tblCotizaciones> tblCotizaciones { get; set; }
        public virtual DbSet<tblFormularios> tblFormularios { get; set; }
        public virtual DbSet<tblPermisos> tblPermisos { get; set; }
        public virtual DbSet<tblRolPermisos> tblRolPermisos { get; set; }
        public virtual DbSet<tblProductosXProveedor> tblProductosXProveedor { get; set; }
        public virtual DbSet<tblRoles> tblRoles { get; set; }
        public virtual DbSet<tblUsuarios> tblUsuarios { get; set; }
        public virtual DbSet<tblBitacoras> tblBitacoras { get; set; }
        public virtual DbSet<tblErrores> tblErrores { get; set; }
        public virtual DbSet<tblMonedas> tblMonedas { get; set; }
        public virtual DbSet<tblPrecios> tblPrecios { get; set; }
        public virtual DbSet<tblTipoProductos> tblTipoProductos { get; set; }
        public virtual DbSet<tblProductos> tblProductos { get; set; }
        public virtual DbSet<tblProveedores> tblProveedores { get; set; }
        public virtual DbSet<tblClientesContacto> tblClientesContacto { get; set; }
        public virtual DbSet<tblClientes> tblClientes { get; set; }
        public virtual DbSet<tblEstados> tblEstados { get; set; }
        public virtual DbSet<tblDetalleCotizaciones> tblDetalleCotizaciones { get; set; }
        public virtual DbSet<tblVendedores> tblVendedores { get; set; }
        public virtual DbSet<tblConfiguracion> tblConfiguracion { get; set; }
    
        public virtual ObjectResult<Sp_ProductosXProveedor_Result> Sp_ProductosXProveedor(Nullable<decimal> decIdProveedor)
        {
            var decIdProveedorParameter = decIdProveedor.HasValue ?
                new ObjectParameter("decIdProveedor", decIdProveedor) :
                new ObjectParameter("decIdProveedor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_ProductosXProveedor_Result>("Sp_ProductosXProveedor", decIdProveedorParameter);
        }
    
        public virtual ObjectResult<spRolPermisos_Result> spRolPermisos(Nullable<decimal> idRol, Nullable<decimal> idFormulario)
        {
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(decimal));
    
            var idFormularioParameter = idFormulario.HasValue ?
                new ObjectParameter("IdFormulario", idFormulario) :
                new ObjectParameter("IdFormulario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRolPermisos_Result>("spRolPermisos", idRolParameter, idFormularioParameter);
        }
    }
}
