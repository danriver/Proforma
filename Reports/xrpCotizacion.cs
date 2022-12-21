using DevExpress.XtraReports.UI;
using Proforma.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Proforma.Modules;

namespace Proforma.Reports
{
    public partial class xrpCotizacion : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpCotizacion()
        {
            InitializeComponent();
        }

        public void SetFilter(decimal idCotizacion, bool bSAC = false)
        {
            BD_ERPEntities contexto = new BD_ERPEntities();
            decimal subtotal, descuento, iva, total;
            DateTime fecha;
            string _moneda = "";
            string _atencionTelefono = "";
            var monedas = contexto.tblMonedas.ToList();
            var detalle = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion);
            tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
            tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
            tblClientesContacto cc = contexto.tblClientesContacto.FirstOrDefault(x => x.decIdContacto == cot.decIdContacto);
            //Mostrar u Ocultar código SAC de los productos
            if (bSAC == true)
            {
                this.SBNORMAL.Visible = false;
                this.SBSNORMALDet.Visible = false;
                this.SBSAC.Visible = true;
                this.SBSACDet.Visible = true;
            }
            else
            {
                this.SBNORMAL.Visible = true;
                this.SBSNORMALDet.Visible = true;
                this.SBSAC.Visible = false;
                this.SBSACDet.Visible = false;
            }
            //Agregar Logo de Empresa
            this.picLogo.ImageUrl = con.strDireccionLogo.ToString();
            //Mostrar u Ocultar Encabezado de página de acuerdo a configuración general
            if (Convert.ToBoolean(con.bitEncabezado))
            {
                this.lblEncabezado.Visible = true;
            }
            else
            {
                this.lblEncabezado.Visible = false;
            }
            //Mostrar u Ocultar Pie de página de acuerdo a configuración general
            if (Convert.ToBoolean(con.bitPieEmpresa))
            {
                this.lblPie.Visible = true;
            }
            else
            {
                this.lblPie.Visible = false;
            }
            //Formato de campo teléfono del contacto
            if (cc.strTelefono.Length>0)
            {
                _atencionTelefono = _atencionTelefono + cc.strTelefono;
                if (cc.strExtension.Length > 0)
                {
                    _atencionTelefono = _atencionTelefono + " ext. " + cc.strExtension;
                }
                if (cc.strCelular.Length > 0)
                {
                    _atencionTelefono = _atencionTelefono + ", " + cc.strCelular;
                }
            }
            else
            {
                if (cc.strCelular.Length > 0)
                {
                    _atencionTelefono = _atencionTelefono + cc.strCelular;
                }
            }
            this.lblAtencionTelefono.Text = _atencionTelefono;
            //Creación de Totales
            if (idCotizacion > 0)
            {
                fecha = cot.datFechaCreacion.Date;
            }
            else
            {
                fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
            }
            tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
            if (detalle.Any())
            {
                if (Convert.ToInt32(con.intMoneda) == 1)
                {
                    if (Convert.ToBoolean(con.bitImprimirFacturaUS))
                    {
                        subtotal = Convert.ToDecimal(cot.decSubtotal) / mn.decTipoCambio;
                        descuento = Convert.ToDecimal(cot.decDescuento) / mn.decTipoCambio;
                        iva = Convert.ToDecimal(cot.decIva) / mn.decTipoCambio;
                    }
                    else
                    {
                        subtotal = Convert.ToDecimal(cot.decSubtotal);
                        descuento = Convert.ToDecimal(cot.decDescuento);
                        iva = Convert.ToDecimal(cot.decIva);
                    }                                        
                }
                else
                {
                    if (Convert.ToBoolean(con.bitImprimirFacturaUS))
                    {
                        subtotal = Convert.ToDecimal(cot.decSubtotal) * mn.decTipoCambio;
                        descuento = Convert.ToDecimal(cot.decDescuento) * mn.decTipoCambio;
                        iva = Convert.ToDecimal(cot.decIva) * mn.decTipoCambio;
                    }
                    else
                    {
                        subtotal = Convert.ToDecimal(cot.decSubtotal);
                        descuento = Convert.ToDecimal(cot.decDescuento);
                        iva = Convert.ToDecimal(cot.decIva);
                    }
                }
                total = subtotal - descuento + iva;
            }
            else
            {
                subtotal = 0;
                descuento = 0;
                iva = 0;
                total = 0;
            }
            if (Convert.ToBoolean(con.bitImprimirFacturaUS))
            {
                _moneda = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strSimbolo).ToUpper();
            }
            else
            {
                _moneda = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strSimbolo).ToUpper();
            }
            string cantidad = CustomFormat.gNum_texto(total);
            this.lblCantidadLetras.Text = "(" + cantidad + ")"; 
            this.lblSubtotal.Text = String.Format("{1} {0:n2}", subtotal, _moneda);
            this.lblDescuento.Text = String.Format("{1} {0:n2}", descuento, _moneda);
            this.lblIVA.Text = String.Format("{1} {0:n2}", iva, _moneda);
            this.lblTotal.Text = String.Format("{1} {0:n2}", total, _moneda);
            //Establecer Marca de Agua
            if (cot.intEstadoCotizacion == 3)
            {
                this.Watermark.Text = "ANULADA";
            }
            this.Parameters["Moneda"].Value = Convert.ToInt32(con.intMoneda);
            this.Parameters["Imprimir"].Value = Convert.ToBoolean(con.bitImprimirFacturaUS);
            this.Parameters["Tasa"].Value = Convert.ToDecimal(mn.decTipoCambio);
            BSDetalleCotizacion.DataSource = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion).ToList();
        }
    }
}
