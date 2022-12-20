using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

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

        }
    }
}
