using DevExpress.XtraReports.UI;
using Proforma.Models;
using Proforma.Modules;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Proforma.Reports
{
    public partial class xrpCotizacionesConsolidado : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpCotizacionesConsolidado()
        {
            InitializeComponent();
        }

        public void SetFilter(DateTime? fechaIni, DateTime? fechaFin, decimal idCliente, int idMoneda)
        {
            BD_ERPEntities contexto = new BD_ERPEntities();
            string _moneda = "";
            var monedas = contexto.tblMonedas.ToList();
            tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
            this.Parameters["Moneda"].Value = Convert.ToInt32(con.intMoneda);
            this.Parameters["Imprimir"].Value = Convert.ToInt32(idMoneda);
            this.lblFechaReporte.Text = "Del: " + Convert.ToString(fechaIni) + " Al: " + Convert.ToString(fechaFin);
            _moneda = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == idMoneda).strSimbolo).ToUpper();
            BSCotizacion.DataSource = contexto.tblCotizaciones.Where(x => (x.decIdCliente == idCliente || (x.decIdCliente > 0 && idCliente == 0))
            && x.datFechaCreacion >= fechaIni && x.datFechaCreacion <= fechaFin).ToList();
            this.lblSubtotalCot.TextFormatString = _moneda + " {0:n2}";
            this.lblDescuentoCot.TextFormatString = _moneda + " {0:n2}";
            this.lblIVACot.TextFormatString = _moneda + " {0:n2}";
            this.lblTotalCot.TextFormatString = _moneda + " {0:n2}";
            this.lblSubtotalCliente.TextFormatString = _moneda + " {0:n2}";
            this.lblDescuentoCliente.TextFormatString = _moneda + " {0:n2}";
            this.lblIVACliente.TextFormatString = _moneda + " {0:n2}";
            this.lblTotalCliente.TextFormatString = _moneda + " {0:n2}";
            this.lblSubtotalReporte.TextFormatString = _moneda + " {0:n2}";
            this.lblDescuentoReporte.TextFormatString = _moneda + " {0:n2}";
            this.lblIVAReporte.TextFormatString = _moneda + " {0:n2}";
            this.lblTotalReporte.TextFormatString = _moneda + " {0:n2}";
            this.lblUsuario.Text = String.Format("{0:g}    Imprimió: {1}", Convert.ToDateTime(DateTime.Now.GetDateDB()), PublicVar.gstrUsername);
        }

        private void lblIdCotizacion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BD_ERPEntities contexto = new BD_ERPEntities();
            DateTime fecha;
            decimal idCotizacion = Convert.ToDecimal(this.lblIdCotizacion.Text);
            tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
            fecha = cot.datFechaCreacion.Date;
            tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
            this.Parameters["Tasa"].Value = Convert.ToDecimal(mn.decTipoCambio);
        }
    }
}
