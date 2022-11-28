using Proforma.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proforma.Forms
{
    public partial class frmReport : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro, NumRegistro;
        #endregion
        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operacion = TipoOperacion.Impresion;
            AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
        }

        private void bbiPrintDirect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operacion = TipoOperacion.Impresion;
            AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
        }

        private void bbiExportFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operacion = TipoOperacion.Exportacion;
            AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
        }

        public frmReport()
        {
            InitializeComponent();
        }

        public void Show(Form frmParent, string strTipoRegistro, string strNumRegistro)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.MdiParent = frmParent;
                TipoRegistro = strTipoRegistro;
                NumRegistro = strNumRegistro;
                this.Show();
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
