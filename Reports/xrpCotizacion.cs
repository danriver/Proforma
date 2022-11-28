using DevExpress.XtraReports.UI;
using Proforma.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

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
            tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
            BSDetalleCotizacion.DataSource = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion).ToList();
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
            this.picLogo.ImageUrl = con.strDireccionLogo.ToString();
        }

    }
}
