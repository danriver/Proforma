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

            if (idMoneda == 1)
            {
                SubBandCotizacionDolaresEnc.Visible = false;
                SubBandDetalleDolares.Visible = false;
                SubBandSubTotalContactoDolares.Visible = false;
                SubBandSubTotalClienteDolares.Visible = false;
                SubBandTotalDolares.Visible = false;
            }
            else
            {
                SubBandCotizacionCordobasEnc.Visible = false;
                SubBandDetalleCordobas.Visible = false;
                SubBandSubTotalContactoCordobas.Visible = false;
                SubBandSubTotalClienteCordobas.Visible = false;
                SubBandTotalCordobas.Visible = false;
            }

            var config = _context.tblConfiguracion.FirstOrDefault();

            this.Parameters["MonedaConfiguracion"].Value = config.intMoneda;
            this.Parameters["MonedaImpresion"].Value = idMoneda;

            var cotizaciones = _context.tblDetalleCotizaciones.ToList();
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
