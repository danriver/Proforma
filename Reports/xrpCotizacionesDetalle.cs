using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Proforma.Models;
using Proforma.Modules;

namespace Proforma.Reports
{
    public partial class xrpCotizacionesDetalle : DevExpress.XtraReports.UI.XtraReport
    {

        BD_ERPEntities _context = new BD_ERPEntities();

        public xrpCotizacionesDetalle()
        {
            InitializeComponent();
        }

        public void SetFilter(DateTime? fechaIni, DateTime? fechaFin, decimal idCliente, int idMoneda)
        {
            lblRangoFechas.Text = string.Format(" Del {0:" + PublicVar.gstrFormatFecha + "} Al {1:" + PublicVar.gstrFormatFecha + "}", fechaIni, fechaFin);
            lblUsuario.Text = PublicVar.gstrUsername;
            lblFechaHoraImpresion.Text = string.Format("{0:dd/MM/yyyy hh:mm tt}", DateTime.Now.GetDateDB());

            var config = _context.tblConfiguracion.FirstOrDefault();

            this.Parameters["MonedaConfiguracion"].Value = config.intMoneda;
            this.Parameters["MonedaImpresion"].Value = idMoneda;

            //Formato de montos
            string monedaSimbolo = "";
            string formatoMonto = "";
            var moneda = _context.tblMonedas.Where(x => x.intIdMoneda == idMoneda).FirstOrDefault();
            if (moneda != null)
            {
                monedaSimbolo = moneda.strSimbolo;
            }
            formatoMonto = "{0:" + monedaSimbolo + " #,0.00}";

            //SubTotal
            lblSubTotalEnc.TextFormatString = formatoMonto;
            lblPrecioDet.TextFormatString = formatoMonto;
            lblSubTotalDet.TextFormatString = formatoMonto;
            lblSubTotalContacto.TextFormatString = formatoMonto;
            lblSubTotalCliente.TextFormatString = formatoMonto;
            lblSubTotalGeneral.TextFormatString = formatoMonto;

            //Descuento
            lblDescuentoEnc.TextFormatString = formatoMonto;
            lblDescuentoContacto.TextFormatString = formatoMonto;
            lblDescuentoCliente.TextFormatString = formatoMonto;
            lblDescuentoGeneral.TextFormatString = formatoMonto;

            //IVA
            lblIvaEnc.TextFormatString = formatoMonto;
            lblIvaContacto.TextFormatString = formatoMonto;
            lblIvaCliente.TextFormatString = formatoMonto;
            lblIvaGeneral.TextFormatString = formatoMonto;

            //Total
            lblTotalEnc.TextFormatString = formatoMonto;
            lblTotalContacto.TextFormatString = formatoMonto;
            lblTotalCliente.TextFormatString = formatoMonto;
            lblTotalGeneral.TextFormatString = formatoMonto;

            var cotizaciones = _context.tblDetalleCotizaciones
                .Where(x => x.tblCotizaciones.datFechaCreacion >= fechaIni && x.tblCotizaciones.datFechaCreacion <= fechaFin
                        && (x.tblCotizaciones.decIdCliente == idCliente || (x.tblCotizaciones.decIdCliente > 0 && idCliente == 0)))
                .Select(x => new
                {
                    x.bitExonerado,
                    x.decCantidad,
                    x.decCosto,
                    x.decDescuento,
                    x.decIdCotizacion,
                    x.decIdDetalle,
                    x.decIdProducto,
                    x.decIdProveedor,
                    x.decIdUsuario,
                    x.decMargen,
                    x.decPrecio,
                    x.FechaMovimiento,
                    x.tblCotizaciones,
                    x.tblProductos,
                    x.tblProveedores,
                    x.tblUsuarios,
                    TipoCambio = _context.tblCambioMoneda.FirstOrDefault(y => y.datFecha.Year == x.tblCotizaciones.datFechaCreacion.Year
                                                                                 && y.datFecha.Month == x.tblCotizaciones.datFechaCreacion.Month
                                                                                 && y.datFecha.Day == x.tblCotizaciones.datFechaCreacion.Day).decTipoCambio
                })
                .ToList();

            cotizacionesBindingSource.DataSource = cotizaciones;
        }
    }
}
