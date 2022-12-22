using Proforma.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proforma.Models;
using System.Linq;
using DevExpress.XtraEditors;
using System.Globalization;
using Proforma.Reports;

namespace Proforma.Forms
{
    public partial class frmProforma : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro = "Cotización", NumRegistro;
        public bool bCargar=false, bConsultas=false;
        #endregion
        public frmProforma()
        {
            InitializeComponent();
        }

        #region Metodos
        private void CargarCliente()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue.IsNull(0));
                decimal idContacto = Convert.ToDecimal(this.cmbContactos.EditValue.IsNull(0));
                if (idContacto > 0)
                {
                    using (BD_ERPEntities contexto = new BD_ERPEntities())
                    {
                        tblClientesContacto cc;
                        tblUsuarios user;
                        cc = contexto.tblClientesContacto.FirstOrDefault(x => x.decIdContacto == idContacto);
                        user = contexto.tblUsuarios.FirstOrDefault(x => x.decIdUsuario == gdecIdUser);
                        this.txtTelefono.Text = cc.strTelefono;
                        this.txtExtension.Text = cc.strExtension;
                        this.txtCelular.Text = cc.strCelular;
                        this.txtCorreo.Text = cc.strCorreo;
                        this.cmbClientes.EditValue = cc.tblClientes.decIdCliente;
                        this.txtDireccion.Text = cc.tblClientes.strDireccion;
                        this.txtRUC.Text = cc.tblClientes.strRUC;
                        this.chkExonerado.Checked = Convert.ToBoolean(cc.tblClientes.bitExonerado);

                        if (idCotizacion <= 0)
                        {
                            if (Convert.ToDecimal(user.decIdVendedor) == 0)
                            {
                                this.cmbVendedor.EditValue = cc.tblClientes.decIdVendedor;
                            }
                        }
                    }
                }
                else
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarProductos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue.IsNull(0));
                BD_ERPEntities contexto = new BD_ERPEntities();
                var prodagregados = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion).Select(x => x.decIdProducto).ToList();
                this.cmbProductos.Properties.DataSource = contexto.tblProductos.Where(x => x.bitActivo == true && !prodagregados.Contains(x.decIdProducto)).ToList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarHistorial(decimal idCliente, decimal idProducto, decimal numCotizacion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (idCliente > 0 && idProducto > 0)
                {
                    BD_ERPEntities contexto = new BD_ERPEntities();
                    this.grdProductoHist.DataSource = contexto.tblDetalleCotizaciones.Where(x => x.tblCotizaciones.decIdCliente == idCliente && x.decIdProducto == idProducto && x.decIdCotizacion != numCotizacion).ToList();
                    this.vwProductoHist.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarGrid(decimal numCotizacion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.grdDetalleCotizacion.DataSource = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == numCotizacion).ToList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarCotizacion(decimal numCotizacion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == numCotizacion);
                    if (cot is null)
                    {

                    }
                    else
                    {
                        tblConfiguracion con;
                        tblCambioMoneda mn;
                        DateTime fecha = cot.datFechaCreacion.Date;
                        con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                        mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
                        this.txtIdCotizacion.Text = Convert.ToString(cot.decIdCotizacion);
                        this.txtStrProforma.Text = Convert.ToString(cot.strNumCotizacion);
                        this.cmbContactos.EditValue = Convert.ToDecimal(cot.decIdContacto);
                        this.txtFecha.Text = String.Format("{0:d} {0:t}", cot.datFechaCreacion);
                        this.cmbMoneda.EditValue = Convert.ToInt32(con.intMoneda);
                        this.txtTasa.Text = Convert.ToString(mn.decTipoCambio);
                        this.cmbVendedor.EditValue = Convert.ToDecimal(cot.decIdVendedor);
                        this.chkFactura.Checked = Convert.ToBoolean(cot.bitFactura);
                        this.cmbEstados.EditValue = Convert.ToInt32(cot.intEstadoCotizacion);
                        this.mmoInfAdicional.Text = Convert.ToString(cot.strInfAdicional);
                        this.mmoObservaciones.Text = Convert.ToString(cot.strObservaciones);                        
                        CargarGrid(numCotizacion);
                        CargarProductos();
                        bCargar = true;
                        this.txtSubtotal.Text = Convert.ToString(cot.decSubtotal);
                        this.txtDescuento.Text = Convert.ToString(cot.decDescuento);
                        this.txtIVA.Text = Convert.ToString(cot.decIva);
                        if (Convert.ToDecimal(cot.decSubtotal)>0)
                        {
                            this.spDescuento.EditValue = Convert.ToString(Convert.ToDecimal(cot.decDescuento) / Convert.ToDecimal(cot.decSubtotal) * 100);
                        }
                        else
                        {
                            this.spDescuento.EditValue = 0;
                        }
                        bCargar = true;
                        ActualizarTotales();
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.txtTelefono.Text = "";
                this.txtExtension.Text = "";
                this.txtCelular.Text = "";
                this.txtCorreo.Text = "";
                this.cmbClientes.EditValue = null;
                this.txtDireccion.Text = "";
                this.txtRUC.Text = "";
                this.chkExonerado.Checked = false;
                this.cmbEstados.EditValue = null;
                this.cmbProductos.EditValue = null;
                this.grdDetalleCotizacion.DataSource = null;
                this.mmoInfAdicional.Text = "";
                this.mmoObservaciones.Text = "";
                this.txtSubtotal.Text = "";
                this.txtDescuento.Text = "";
                this.txtIVA.Text = "";
                this.txtTotal.Text = "";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LimpiarProducto()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.cmbProductos.EditValue = null;
                this.txtExistencia.Text = "";
                this.txtCosto.Text = "";
                this.spMargen.Text = "";
                this.txtPrecio.Text = "";
                this.txtCantidad.Text = "";
                this.cmbProveedores.Properties.DataSource = null;
                this.cmbProveedores.EditValue = null;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool CamposValidosEncabezado()
        {
            bool result = true;

            string strIdCotizacion = Convert.ToString(this.txtIdCotizacion.Text.Trim());
            decimal? idContacto = Convert.ToDecimal(this.cmbContactos.EditValue.IsNull(0));
            decimal? idCliente = Convert.ToDecimal(this.cmbClientes.EditValue.IsNull(0));
            decimal? idVendedor = Convert.ToDecimal(this.cmbVendedor.EditValue.IsNull(0));
            decimal? idMoneda = Convert.ToDecimal(this.cmbMoneda.EditValue.IsNull(0));
            decimal? tasa = Convert.ToDecimal(this.txtTasa.EditValue.IsNull(0));

            if (strIdCotizacion.Length == 0)
            {
                this.txtIdCotizacion.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idContacto == 0)
            {
                this.cmbContactos.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idCliente == 0)
            {
                this.cmbClientes.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idVendedor == 0)
            {
                this.cmbVendedor.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idMoneda == 0)
            {
                this.cmbMoneda.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (tasa == 0)
            {
                this.txtTasa.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private bool CamposValidosDetalle()
        {
            bool result = true;

            decimal? idProducto = Convert.ToDecimal(this.cmbProductos.EditValue.IsNull(0));
            int? existencia = Convert.ToInt32(this.txtExistencia.EditValue.IsNull(0));
            int? cantidad = Convert.ToInt32(this.txtCantidad.EditValue.IsNull(0));
            decimal? costo = Convert.ToDecimal(this.txtCosto.EditValue.IsNull(0));
            decimal? precio = Convert.ToDecimal(this.txtPrecio.EditValue.IsNull(0));
            decimal? idProveedor = Convert.ToDecimal(this.cmbProveedores.EditValue.IsNull(0));

            if (idProducto == 0)
            {
                this.cmbProductos.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            else
            {
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblProductos prod = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);

                    if (prod is null)
                    {

                    }
                    else
                    {
                        bool sinExistencia = Convert.ToBoolean(prod.bitNoExistencia.IsNull(false));

                        if (sinExistencia == true)
                        {
                            if (cantidad <= 0)
                            {
                                this.txtCantidad.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                                result = false;
                            }
                        }
                        else
                        {
                            if (cantidad <= 0)
                            {
                                this.txtCantidad.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                                result = false;
                            }
                            else
                            {
                                if (cantidad > existencia)
                                {
                                    this.txtCantidad.ErrorText = PublicVar.gstrExistenciaInsuficienteMsg;
                                    result = false;
                                }
                            }
                        }
                        if (costo <= 0)
                        {
                            this.txtCosto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                            result = false;
                        }
                        else if (precio <= 0)
                        {
                            this.txtPrecio.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                            result = false;
                        }
                        else
                        {
                            if (precio < costo)
                            {
                                this.txtPrecio.ErrorText = PublicVar.gstrPrecioInvalidoMSg;
                                result = false;
                            }
                        }
                        if (idProveedor == 0)
                        {
                            this.cmbProveedores.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                            result = false;
                        }
                    }
                }
            }

            return result;
        }

        private void GuardarEnc()
        {
            DateTime fecha = DateTime.Now.GetDateDB();
            decimal? idCliente = Convert.ToDecimal(this.cmbClientes.EditValue);
            decimal? idContacto = Convert.ToDecimal(this.cmbContactos.EditValue);
            decimal? idVendedor = Convert.ToDecimal(this.cmbVendedor.EditValue);
            decimal? subtotal;
            decimal? porcDescuento;
            decimal? descuento;
            decimal? iva;
            string infAdicional = Convert.ToString(this.mmoInfAdicional.Text.Trim());
            string observaciones = Convert.ToString(this.mmoObservaciones.Text.Trim());
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);

                tblClientes c = contexto.tblClientes.FirstOrDefault(x => x.decIdCliente == idCliente);
                tblCotizaciones cot;

                if (idCotizacion > 0)
                {
                    cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                    var detalle = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion);
                    tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                    porcDescuento = Convert.ToDecimal(this.spDescuento.EditValue);                    
                    if (detalle.Any())
                    {
                        subtotal = (decimal)detalle.Sum(x => x.decPrecio * x.decCantidad);
                        if (porcDescuento > 0)
                        {
                            descuento = subtotal * (porcDescuento/100);
                        }
                        else
                        {
                            descuento = 0;
                        }
                        iva = (subtotal-descuento) * (Convert.ToDecimal(con.decPorcentajeIVA) / 100);
                    }
                    else
                    {
                        subtotal = 0;
                        descuento = 0;
                        iva = 0;
                    }                    
                    cot.decSubtotal = subtotal;
                    cot.decDescuento = descuento;
                    cot.decIva = iva;
                    cot.strInfAdicional = infAdicional;
                    cot.strObservaciones = observaciones;
                    Operacion = TipoOperacion.Modificacion;
                }
                else
                {
                    string NumCotizacion = c.strSiglas + "-" + String.Format("{0:ddMMyyyy}", fecha) + "-" + Convert.ToString(Convert.ToInt32(c.tblCotizaciones.Where(x => x.datFechaCreacion.Year == fecha.Year).Count().IsNull(0)) + 1);
                    cot = new tblCotizaciones
                    {
                        strNumCotizacion = NumCotizacion,
                        decIdCliente = idCliente,
                        decIdContacto = idContacto,
                        decIdVendedor = idVendedor,
                        decIdUsuario = gdecIdUser,
                        datFechaCreacion = DateTime.Now.GetDateDB(),
                        intEstadoCotizacion = 1,
                        bitFactura = false,
                        decSubtotal = 0,
                        decDescuento = 0,
                        decIva = 0,
                        strInfAdicional = infAdicional,
                        strObservaciones = observaciones,
                    };
                    contexto.tblCotizaciones.Add(cot);
                    Operacion = TipoOperacion.Creacion;
                }
                contexto.SaveChanges();
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                CargarCotizacion(cot.decIdCotizacion);
            }
        }

        private void Aprobar()
        {
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);

                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                cot.intEstadoCotizacion = 2;
                Operacion = TipoOperacion.Aprobacion;
                contexto.SaveChanges();
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                CargarCotizacion(cot.decIdCotizacion);
            }

        }

        private void Anular()
        {
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);

                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                cot.intEstadoCotizacion = 3;
                Operacion = TipoOperacion.Anulacion;
                contexto.SaveChanges();
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                CargarCotizacion(cot.decIdCotizacion);
            }

        }

        private void GuardarDet()
        {
            decimal? idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
            decimal? cantidad = Convert.ToDecimal(this.txtCantidad.EditValue);
            decimal? costo = Convert.ToDecimal(this.txtCosto.EditValue);
            decimal? margen = Convert.ToDecimal(this.spMargen.EditValue);
            decimal? precio = Convert.ToDecimal(this.txtPrecio.EditValue);
            decimal? idProveedor = Convert.ToDecimal(this.cmbProveedores.EditValue);
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                decimal idProducto = Convert.ToDecimal(this.cmbProductos.EditValue);
                tblProductos prod = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                tblDetalleCotizaciones det = new tblDetalleCotizaciones
                {
                    decIdCotizacion = (decimal)idCotizacion,
                    decIdProducto = idProducto,
                    decCantidad = cantidad,
                    decCosto = costo,
                    decMargen = margen,
                    decPrecio = precio,
                    decIdProveedor = idProveedor,
                    bitExonerado = prod.bitExonerado,
                    decIdUsuario = gdecIdUser,
                    FechaMovimiento = DateTime.Now.GetDateDB(),
                };
                contexto.tblDetalleCotizaciones.Add(det);
                contexto.SaveChanges();
                ActualizarTotales();
            }
        }

        private void ActualizarTotales()
        {
            decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
            decimal subtotal, descuento, iva, total, equiv;
            decimal porcDescuento;
            DateTime fecha;
            string simbprinc = "", simbsecun = "";
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                var detalle = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion);
                var monedas = contexto.tblMonedas.ToList();
                tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                if (idCotizacion > 0)
                {                    
                    fecha = cot.datFechaCreacion.Date;
                }
                else
                {
                    fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                }
                tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
                porcDescuento = Convert.ToDecimal(this.spDescuento.EditValue);
                if (detalle.Any())
                {
                    if (bCargar)
                    {
                        subtotal  = Convert.ToDecimal(cot.decSubtotal);
                        descuento = Convert.ToDecimal(cot.decDescuento);
                        iva = Convert.ToDecimal(cot.decIva);
                        total = subtotal - descuento + iva;
                        bCargar = false;
                    }
                    else
                    {
                        subtotal = (decimal)detalle.Sum(x => x.decPrecio * x.decCantidad);
                        if (porcDescuento > 0)
                        {
                            descuento = subtotal * (porcDescuento / 100);
                        }
                        else
                        {
                            descuento = 0;
                        }
                        iva = (subtotal - descuento) * (Convert.ToDecimal(con.decPorcentajeIVA) / 100);
                        total = subtotal - descuento + iva;
                    }                
                }
                else
                {
                    subtotal = 0;
                    descuento = 0;
                    iva = 0;
                    total = 0;
                }
                if (Convert.ToInt32(con.intMoneda) == 1)
                {
                    equiv = total / mn.decTipoCambio;
                    simbprinc = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strSimbolo);
                    simbsecun = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strSimbolo);
                }
                else
                {
                    equiv = total * mn.decTipoCambio;
                    simbprinc = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strSimbolo);
                    simbsecun = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strSimbolo);
                }
            }
            this.txtSubtotal.Text = String.Format("{1} {0:n2}", subtotal, simbprinc);
            this.txtDescuento.Text = String.Format("{1} {0:n2}", descuento, simbprinc);
            this.txtIVA.Text = String.Format("{1} {0:n2}", iva, simbprinc);
            this.txtTotal.Text = String.Format("{1} {0:n2}", total, simbprinc);
            this.txtTotalEquiv.Text = String.Format("{1} {0:n2}", equiv, simbsecun);
        }

        private void HabilitarInhabilitarGroupControl(int intOpcion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (intOpcion == 1)
                {
                    this.layoutControlGroup1.Enabled = false;
                    this.layoutControlGroup2.Enabled = false;
                    this.layoutControlGroup3.Enabled = false;
                    this.mmoObservaciones.ReadOnly = true;
                    this.mmoInfAdicional.ReadOnly = true;
                    this.spDescuento.ReadOnly = true;
                    this.vwDetalleCotizacion.OptionsBehavior.ReadOnly = true;
                }
                else if (intOpcion == 2)
                {
                    this.layoutControlGroup1.Enabled = true;
                    this.layoutControlGroup2.Enabled = true;
                    this.layoutControlGroup3.Enabled = true;
                    this.mmoObservaciones.ReadOnly = false;
                    this.mmoInfAdicional.ReadOnly = false;
                    this.spDescuento.ReadOnly = false;
                    this.vwDetalleCotizacion.OptionsBehavior.ReadOnly = false;
                }
                else if (intOpcion == 3)
                {
                    this.layoutControlGroup1.Enabled = false;
                    this.layoutControlGroup2.Enabled = false;
                    this.layoutControlGroup3.Enabled = true;
                    this.mmoObservaciones.ReadOnly = false;
                    this.mmoInfAdicional.ReadOnly = false;
                    this.spDescuento.ReadOnly = false;
                    this.vwDetalleCotizacion.OptionsBehavior.ReadOnly = false;
                }

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Imprimir()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                BD_ERPEntities contexto = new BD_ERPEntities();
                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                xrpCotizacion report = new xrpCotizacion();
                bool bSAC = Convert.ToBoolean(this.chkMostrarSAC.Checked);
                report.SetFilter(idCotizacion, bSAC);
                report.DisplayName = "Cotización " + Convert.ToString(cot.strNumCotizacion);
                frmReport window = new frmReport();
                window.documentViewer1.DocumentSource = report;
                window.Text = "Cotización " + Convert.ToString(cot.strNumCotizacion);
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                window.Show(this.MdiParent, TipoRegistro, NumRegistro);                
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Enviar(bool bEditar)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                BD_ERPEntities contexto = new BD_ERPEntities();
                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                xrpCotizacion report = new xrpCotizacion();
                bool bSAC = Convert.ToBoolean(this.chkMostrarSAC.Checked);
                report.SetFilter(idCotizacion, bSAC);
                report.DisplayName = "Cotización " + Convert.ToString(cot.strNumCotizacion);               
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                string ruta = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + report.DisplayName + ".pdf");
                report.ExportToPdf(ruta);
                CustomMail mail = new CustomMail();
                frmPersonalizarCorreo correo = new frmPersonalizarCorreo();
                if (bEditar)
                {
                    correo.Show(this, TipoRegistro, NumRegistro, (decimal)cot.decIdVendedor, (decimal)cot.decIdContacto, Convert.ToString(report.DisplayName), "Estimado cliente. Se adjunta cotización correspondiente a solicitud realizada.", ruta);
                }
                else
                {
                    mail.EnviarCorreo(this, (decimal)cot.decIdVendedor, (decimal)cot.decIdContacto, Convert.ToString(report.DisplayName), "Estimado cliente. Se adjunta cotización correspondiente a solicitud realizada.", ruta);
                    Operacion = TipoOperacion.CorreoCotizacion;
                    AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                }                
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        public void Show(Form frmParent, decimal decIdCotizacion = 0)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (decIdCotizacion > 0)
                {
                    CargarCotizacion(decIdCotizacion);
                }
                else
                {
                    HabilitarInhabilitarGroupControl(1);
                }
                bConsultas = true;
                this.MdiParent = frmParent;
                this.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void frmProforma_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbVendedor.Properties.DataSource = contexto.tblVendedores.ToList();
                this.cmbContactos.Properties.DataSource = contexto.tblClientesContacto.Where(x => x.tblClientes.bitActivo == true).ToList();
                this.cmbClientes.Properties.DataSource = contexto.tblClientes.ToList();
                this.cmbMoneda.Properties.DataSource = contexto.tblMonedas.ToList();
                this.cmbEstados.Properties.DataSource = contexto.tblEstados.ToList();
                if (bConsultas==false)
                {
                    HabilitarInhabilitarGroupControl(1);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void cmbContactos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CargarCliente();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void cmbEstados_EditValueChanged(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(this.cmbEstados.EditValue.IsNull(0));

            if (idEstado == 1)
            {
                HabilitarInhabilitarGroupControl(3);
            }
            else if (idEstado == 0)
            {
                HabilitarInhabilitarGroupControl(2);
            }
            else
            {
                HabilitarInhabilitarGroupControl(1);
            }
        }

        private void cmbProductos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue.IsNull(0));
                decimal idCliente = Convert.ToDecimal(this.cmbClientes.EditValue.IsNull(0));
                decimal idProducto = Convert.ToDecimal(this.cmbProductos.EditValue.IsNull(0));
                DateTime fecha;
                if (idProducto > 0)
                {
                    if (idCliente > 0)
                    {
                        if (idCotizacion > 0)
                        {
                            tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                            fecha = cot.datFechaCreacion.Date;
                        }
                        else
                        {
                            fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                        }
                        tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
                        tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                        tblClientes c = contexto.tblClientes.FirstOrDefault(x => x.decIdCliente == idCliente);
                        tblProductos prod = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                        if (prod is null)
                        {

                        }
                        else
                        {
                            this.txtExistencia.EditValue = Convert.ToDecimal(prod.decExistencia);
                            decimal precio = 0, costo = 0;
                            if (Convert.ToInt32(c.intIdPrecio.IsNull(0)) != 0)
                            {
                                if (Convert.ToInt32(c.intIdPrecio.IsNull(0)) == 1)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio1);
                                }
                                else if (Convert.ToInt32(c.intIdPrecio.IsNull(0)) == 2)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio2);
                                }
                                else if (Convert.ToInt32(c.intIdPrecio.IsNull(0)) == 3)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio3);
                                }
                            }
                            else if (Convert.ToInt32(prod.intIdPrecio.IsNull(0)) != 0)
                            {
                                if (Convert.ToInt32(prod.intIdPrecio.IsNull(0)) == 1)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio1);
                                }
                                else if (Convert.ToInt32(prod.intIdPrecio.IsNull(0)) == 2)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio2);
                                }
                                else if (Convert.ToInt32(prod.intIdPrecio.IsNull(0)) == 3)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio3);
                                }
                            }
                            else if (Convert.ToInt32(con.intIdPrecio.IsNull(0)) != 0)
                            {
                                if (Convert.ToInt32(con.intIdPrecio.IsNull(0)) == 1)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio1);
                                }
                                else if (Convert.ToInt32(con.intIdPrecio.IsNull(0)) == 2)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio2);
                                }
                                else if (Convert.ToInt32(con.intIdPrecio.IsNull(0)) == 3)
                                {
                                    precio = Convert.ToDecimal(prod.decPrecio3);
                                }
                            }
                            if (prod.intMoneda != con.intMoneda)
                            {
                                if (Convert.ToInt32(prod.intMoneda) == 1)
                                {
                                    precio = precio / mn.decTipoCambio;
                                    costo = (decimal)prod.decCosto / mn.decTipoCambio;
                                }
                                else
                                {
                                    precio = precio * mn.decTipoCambio;
                                    costo = (decimal)prod.decCosto * mn.decTipoCambio;
                                }
                                this.txtCosto.EditValue = Convert.ToDecimal(costo);
                                this.txtPrecio.EditValue = Convert.ToDecimal(precio);
                            }
                            else
                            {
                                this.txtCosto.EditValue = Convert.ToDecimal(prod.decCosto);
                                this.txtPrecio.EditValue = Convert.ToDecimal(precio);
                            }
                            var prodXprov = contexto.tblProductosXProveedor.Where(x => x.decIdProducto == idProducto).Select(x => x.decIdProveedor).ToList();
                            this.cmbProveedores.Properties.DataSource = contexto.tblProveedores.Where(x => prodXprov.Contains(x.decIdProveedor)).ToList();
                            this.cmbProveedores.EditValue = null;
                            CargarHistorial(idCliente, idProducto, idCotizacion);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(PublicVar.gstrClienteInvalidoMsg, PublicVar.gstrTitleInfo,
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.cmbProductos.EditValue = null;
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                tblConfiguracion con;
                tblCambioMoneda mn;
                tblUsuarios user;
                con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                this.cmbMoneda.EditValue = Convert.ToInt32(con.intMoneda);
                DateTime fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
                if (mn is null)
                {
                    XtraMessageBox.Show(PublicVar.gstrTasaCambioFaltanteMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.txtTasa.Text = Convert.ToString(mn.decTipoCambio);
                }

                user = contexto.tblUsuarios.FirstOrDefault(x => x.decIdUsuario == gdecIdUser);
                this.cmbVendedor.EditValue = Convert.ToDecimal(user.decIdVendedor);
                this.mmoInfAdicional.Text = Convert.ToString(con.strInfAdicional);
                this.txtFecha.Text = String.Format("{0:d} {0:t}", DateTime.Now.GetDateDB());
                HabilitarInhabilitarGroupControl(2);
                this.cmbContactos.EditValue = null;
                this.txtIdCotizacion.Text = "-1";
                this.txtStrProforma.Text = "";
                CargarProductos();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                if (CamposValidosEncabezado() == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);

                if (idCotizacion <= 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrCotizacionSinDetalleMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        GuardarEnc();
                        XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                    if (cot.intEstadoCotizacion == 1)
                    {
                        GuardarEnc();
                        XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (CamposValidosEncabezado() == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CamposValidosDetalle() == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);

                    if (idCotizacion <= 0)
                    {
                        GuardarEnc();
                    }

                    idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                    tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                    if (cot.intEstadoCotizacion == 1)
                    {
                        GuardarDet();
                        GuardarEnc();
                    }

                    LimpiarProducto();
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                    if (idCotizacion <= 0)
                    {

                    }
                    else
                    {
                        tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                        if (cot.intEstadoCotizacion == 1)
                        {
                            if (XtraMessageBox.Show(PublicVar.gstrAprobacionMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                Aprobar();
                                XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                    if (idCotizacion <= 0)
                    {

                    }
                    else
                    {
                        tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                        if (cot.intEstadoCotizacion == 1 || cot.intEstadoCotizacion == 2)
                        {
                            if (XtraMessageBox.Show(PublicVar.gstrAnulacionMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                Anular();
                                XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                    if (idCotizacion <= 0)
                    {

                    }
                    else
                    {
                        tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                        if (cot.intEstadoCotizacion == 2 || cot.intEstadoCotizacion == 3)
                        {
                            Imprimir();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue);
                    if (idCotizacion <= 0)
                    {

                    }
                    else
                    {
                        tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                        if (cot.intEstadoCotizacion == 2)
                        {
                            var resp = XtraMessageBox.Show(PublicVar.gstrPersonalizarCorreoMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                            if (resp == DialogResult.Yes)
                            {
                                Enviar(true);
                            }
                            else if (resp == DialogResult.No)
                            {
                                Enviar(false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal costo = Convert.ToDecimal(this.txtCosto.EditValue.IsNull(0));
                decimal margen = Convert.ToDecimal(this.spMargen.EditValue.IsNull(0));
                decimal precio = Convert.ToDecimal(this.txtPrecio.EditValue.IsNull(0));
                if (costo > 0 && margen > 0)
                {
                    precio = costo + (costo * (margen / 100));
                    this.txtPrecio.EditValue = precio;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtPrecio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal costo = Convert.ToDecimal(this.txtCosto.EditValue.IsNull(0));
                decimal margen = Convert.ToDecimal(this.spMargen.EditValue.IsNull(0));
                decimal precio = Convert.ToDecimal(this.txtPrecio.EditValue.IsNull(0));
                if (costo > 0 && precio > 0)
                {
                    margen = (precio - costo) / costo * 100;
                    this.spMargen.EditValue = margen;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void spMargen_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal costo = Convert.ToDecimal(this.txtCosto.EditValue.IsNull(0));
                decimal margen = Convert.ToDecimal(this.spMargen.EditValue.IsNull(0));
                decimal precio = Convert.ToDecimal(this.txtPrecio.EditValue.IsNull(0));
                if (costo > 0 && margen > 0)
                {
                    precio = costo + (costo * (margen / 100));
                    this.txtPrecio.EditValue = precio;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void spDescuento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal porcDesc = Convert.ToDecimal(this.spDescuento.EditValue.IsNull(0));
                if (bCargar)
                {
                    bCargar = false;
                }
                else
                {
                    if (porcDesc > 0 && porcDesc < 100)
                    {
                        GuardarEnc();
                    }
                }                
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void chkMostrarSAC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.chkMostrarSAC.Checked)
                {
                    this.vwDetalleCotizacion.Columns["tblProductos.strReferencia"].VisibleIndex = 3;
                    this.vwDetalleCotizacion.Columns["tblProductos.strReferencia"].Visible = true;
                    this.vwProductoHist.Columns["tblProductos.strReferencia"].VisibleIndex = 5;
                    this.vwProductoHist.Columns["tblProductos.strReferencia"].Visible = true;
                }
                else
                {
                    this.vwDetalleCotizacion.Columns["tblProductos.strReferencia"].Visible = false;
                    this.vwProductoHist.Columns["tblProductos.strReferencia"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void vwDetalleCotizacion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(this.txtIdCotizacion.EditValue.IsNull(0));
                decimal idCliente = Convert.ToDecimal(this.cmbClientes.EditValue.IsNull(0));
                decimal idProducto = Convert.ToDecimal(this.vwDetalleCotizacion.GetFocusedRowCellValue("decIdProducto"));
                CargarHistorial(idCliente, idProducto, idCotizacion);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }        

        private void vwDetalleCotizacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (vwDetalleCotizacion.OptionsBehavior.ReadOnly == false)
                {
                    BD_ERPEntities contexto = new BD_ERPEntities();
                    decimal idDetalle = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decIdDetalle"));
                    decimal idProducto = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decIdProducto"));
                    tblProductos prod = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                    tblDetalleCotizaciones det = contexto.tblDetalleCotizaciones.FirstOrDefault(x => x.decIdDetalle == idDetalle);
                    if (e.Column.FieldName == "decCantidad")
                    {
                        int cantidad = Convert.ToInt32(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decCantidad"));
                        if (Convert.ToBoolean(prod.bitNoExistencia) == true)
                        {
                            if (cantidad <= 0)
                            {
                                vwDetalleCotizacion.CancelUpdateCurrentRow();
                                GuardarEnc();
                            }
                            else
                            {
                                det.decCantidad = cantidad;
                                contexto.SaveChanges();
                                ActualizarTotales();
                                GuardarEnc();
                            }
                        }
                        else
                        {
                            if (cantidad <= 0)
                            {
                                vwDetalleCotizacion.CancelUpdateCurrentRow();
                                GuardarEnc();
                            }
                            else if (cantidad > Convert.ToInt32(prod.decExistencia))
                            {
                                vwDetalleCotizacion.CancelUpdateCurrentRow();
                                GuardarEnc();
                            }
                            else
                            {
                                det.decCantidad = cantidad;
                                contexto.SaveChanges();
                                ActualizarTotales();
                                GuardarEnc();
                            }
                        }

                    }
                    else if (e.Column.FieldName == "decCosto")
                    {
                        decimal costo = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decCosto"));
                        decimal margen = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decMargen"));
                        decimal precio = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decPrecio"));

                        if (costo <= 0)
                        {
                            vwDetalleCotizacion.CancelUpdateCurrentRow();
                            GuardarEnc();
                        }
                        else
                        {
                            if (precio < costo)
                            {
                                vwDetalleCotizacion.CancelUpdateCurrentRow();
                                GuardarEnc();
                            }
                            else
                            {
                                precio = costo + (costo * (margen / 100));
                                det.decCosto = costo;
                                det.decPrecio = precio;
                                contexto.SaveChanges();
                                ActualizarTotales();
                                GuardarEnc();
                            }
                        }
                    }
                    else if (e.Column.FieldName == "decMargen")
                    {
                        decimal costo = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decCosto"));
                        decimal margen = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decMargen"));
                        decimal precio = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decPrecio"));

                        if (margen <= 0)
                        {
                            vwDetalleCotizacion.CancelUpdateCurrentRow();
                            GuardarEnc();
                        }
                        else
                        {
                            precio = costo + (costo * (margen / 100));
                            det.decMargen = margen;
                            det.decPrecio = precio;
                            contexto.SaveChanges();
                            ActualizarTotales();
                            GuardarEnc();
                        }
                    }
                    else if (e.Column.FieldName == "decPrecio")
                    {
                        decimal costo = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decCosto"));
                        decimal margen = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decMargen"));
                        decimal precio = Convert.ToDecimal(vwDetalleCotizacion.GetRowCellValue(e.RowHandle, "decPrecio"));

                        if (precio <= 0)
                        {
                            vwDetalleCotizacion.CancelUpdateCurrentRow();
                            GuardarEnc();
                        }
                        else
                        {
                            if (precio < costo)
                            {
                                vwDetalleCotizacion.CancelUpdateCurrentRow();
                                GuardarEnc();
                            }
                            else
                            {
                                margen = (precio - costo) / costo * 100;
                                det.decMargen = margen;
                                det.decPrecio = precio;
                                contexto.SaveChanges();
                                ActualizarTotales();
                                GuardarEnc();
                            }
                        }
                    }
                    else
                    {
                        vwDetalleCotizacion.CancelUpdateCurrentRow();
                        GuardarEnc();
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void vwDetalleCotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.vwDetalleCotizacion.OptionsBehavior.ReadOnly == false)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        BD_ERPEntities contexto = new BD_ERPEntities();
                        decimal idDetalle = Convert.ToDecimal(this.vwDetalleCotizacion.GetFocusedRowCellValue("decIdDetalle"));
                        tblDetalleCotizaciones det = contexto.tblDetalleCotizaciones.FirstOrDefault(x => x.decIdDetalle == idDetalle);
                        if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            contexto.tblDetalleCotizaciones.Remove(det);
                            contexto.SaveChanges();
                            ActualizarTotales();
                            GuardarEnc();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
