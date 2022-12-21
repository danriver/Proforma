using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Proforma.Reports
{
    public partial class xrpCotizacionesDetalle : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpCotizacionesDetalle()
        {
            InitializeComponent();
        }

        public void SetFilter(DateTime? fechaIni, DateTime? fechaFin, decimal idCliente, int idMoneda)
        {

        }

    }
}
