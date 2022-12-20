using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proforma.Models;
using Proforma.Modules;
using System.Linq;
using DevExpress.XtraEditors;
using Proforma.Reports;

namespace Proforma.Forms
{
    public partial class frmAsistenteReportes : Proforma.Forms.frmServer
    {
        public frmAsistenteReportes()
        {
            InitializeComponent();
        }

        #region Variables

        DateTime? _fechaIni = null;
        DateTime? _fechaFin = null;

        #endregion

        #region Metodos

        private bool CamposValidos()
        {
            bool result = true;

            datFechaIni.ErrorText = "";
            datFechaFin.ErrorText = "";

            DateTime? fechaIni = Convert.ToDateTime(datFechaIni.EditValue.IsNull(null));
            DateTime? fechaFin = Convert.ToDateTime(datFechaFin.EditValue.IsNull(null));

            if (fechaIni == null)
            {
                datFechaIni.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            if (fechaFin == null)
            {
                datFechaFin.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            if (fechaIni > fechaFin)
            {
                datFechaIni.ErrorText = PublicVar.gstrFechaIniMayorFechaFinMsg;
                result = false;
            }

            return result;
        }

        #endregion

        private void frmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                datFechaIni.EditValue = DateTime.Today;
                datFechaFin.EditValue = DateTime.Today;
                var clientes = BDContext.tblClientes.ToList();
                cboClienteCotizacion.Properties.DataSource = clientes;
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

                if (CamposValidos() == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _fechaIni = Convert.ToDateTime(datFechaIni.EditValue).StartDate();
                _fechaFin = Convert.ToDateTime(datFechaFin.EditValue).EndDate();

                frmReport viewer = new frmReport();
                xrpCotizacionesDetalle reportDetalle = new xrpCotizacionesDetalle();
                decimal idCliente = Convert.ToDecimal(cboClienteCotizacion.EditValue.IsNull(0));                
                string tipoRegistro = "Reporte " + tabPageCotizaciones.Text;
                string tipoReporte = "";
                string nombreCliente = "";

                if (idCliente > 0)
                {
                    var cliente = BDContext.tblClientes.Where(x => x.decIdCliente == idCliente).FirstOrDefault();
                    if (cliente != null)
                    {
                        nombreCliente = cliente.strNombre;
                    }
                }
                else
                {
                    nombreCliente = "Todos los clientes";
                }

                if (radioGroupFiltroCotizacion.SelectedIndex == 0)
                {
                    tipoReporte = "Detalle";
                    reportDetalle.SetFilter(_fechaIni, _fechaFin, idCliente);
                    viewer.documentViewer1.DocumentSource = reportDetalle;
                }
                else
                {
                    tipoReporte = "Consolidado";
                }                               
                
                viewer.Text = PublicVar.gstrPrintPreviewTitle;
                viewer.Show(this.Owner, tipoRegistro, "Fecha Inicio: " + string.Format("{0:" + PublicVar.gstrFormatFecha + "}", _fechaIni) +
                                                      " Fecha Final: " + string.Format("{0:" + PublicVar.gstrFormatFecha + "}", _fechaFin) +
                                                      " Cliente: " + nombreCliente + " - " + tipoReporte);

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
