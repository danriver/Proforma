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
using System.IO;
using System.Diagnostics;

namespace Proforma.Forms
{
    public partial class frmBitacora : Proforma.Forms.frmServer
    {

        #region Variables

        DateTime? _fechaIni = null, _fechaFin = null;
        decimal _idUsuario = 0;

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
            if (fechaIni != null && fechaFin != null)
            {
                if (fechaIni > fechaFin)
                {
                    datFechaIni.ErrorText = PublicVar.gstrFechaIniMayorFechaFinMsg;
                    result = false;
                }
            }            

            return result;
        }

        #endregion

        public frmBitacora()
        {
            InitializeComponent();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                datFechaIni.EditValue = DateTime.Today;
                datFechaFin.EditValue = DateTime.Today;
                cboUsuario.Properties.DataSource = BDContext.tblUsuarios.ToList();
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string nombreArchivo = this.Text;
                string extension = ".xlsx";                      
                string directorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string rutaArchivo = directorio + "\\" + nombreArchivo + extension;
                grdVwDetalleBitacora.ExportToXlsx(rutaArchivo);
                ProcessStartInfo startInfo = new ProcessStartInfo(rutaArchivo);
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start(startInfo);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (CamposValidos() == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _fechaIni = Convert.ToDateTime(datFechaIni.EditValue).StartDate();
                _fechaFin = Convert.ToDateTime(datFechaFin.EditValue).EndDate();
                _idUsuario = Convert.ToDecimal(cboUsuario.EditValue.IsNull(0));

                var bitacora = BDContext.tblBitacoras.Where(x => (x.tblUsuarios.decIdUsuario == _idUsuario || (x.tblUsuarios.decIdUsuario > 0 && _idUsuario == 0))
                                                                && x.datFechaOperacion >= _fechaIni && x.datFechaOperacion <= _fechaFin).ToList();
                grdDetalleBitacora.DataSource = bitacora;
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
