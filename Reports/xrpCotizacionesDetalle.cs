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

            var config = _context.tblConfiguracion.FirstOrDefault();

            this.Parameters["MonedaConfiguracion"].Value = config.intMoneda;
            this.Parameters["MonedaImpresion"].Value = idMoneda;

            //Formato de montos
            string formatoMonto = "{0:C$ #,0.00}";
            if (idMoneda == 2)
            {
                formatoMonto = "{0:U$ #,0.00}";
            }

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
                        && (x.tblCotizaciones.decIdCliente == idCliente && idCliente > 0 || x.tblCotizaciones.decIdCliente > 0 && idCliente == 0))
                .ToList();

            cotizacionesBindingSource.DataSource = cotizaciones;

        }

        private void lblNumCotizacion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Parameters["Cambio"].Value = 0;
            var cotizacion = _context.tblCotizaciones.Where(x => x.strNumCotizacion == lblNumCotizacion.Text).FirstOrDefault();
            if (cotizacion != null)
            {
                var cambioMoneda = _context.tblCambioMoneda.Where(x => x.datFecha == cotizacion.datFechaCreacion.Date).FirstOrDefault();
                if (cambioMoneda != null)
                {
                    this.Parameters["Cambio"].Value = Convert.ToString(cambioMoneda.decTipoCambio.IsNull(0));
                }
            }
        }
    }
}
