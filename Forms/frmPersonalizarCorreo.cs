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
    public partial class frmPersonalizarCorreo : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro, NumRegistro;
        public string strAsunto, strMensaje, strArchivo;



        public decimal decidVendedor, decidContacto;
        #endregion
        public frmPersonalizarCorreo()
        {
            InitializeComponent();
        }

        #region Metodos
        private void Enviar()
        {
            CustomMail mail = new CustomMail();
            string asunto = Convert.ToString(this.txtAsunto.Text.Trim());
            string mensaje = Convert.ToString(this.mmoMensaje.Text.Trim());

            if (asunto.Length > 0)
            {
                strAsunto = asunto;
            }
            if (mensaje.Length > 0)
            {
                strMensaje = mensaje;
            }
            mail.EnviarCorreo(this, decidVendedor, decidContacto, strAsunto, strMensaje, strArchivo);
            Operacion = TipoOperacion.CorreoCotizacion;
            AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
        }
        #endregion

        public void Show(Form frmParent, string strTipoRegistro, string strNumRegistro, decimal idVendedor, decimal idContacto, string asunto, string mensaje, string rutaArchivo)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                TipoRegistro = strTipoRegistro;
                NumRegistro = strNumRegistro;
                decidVendedor = idVendedor;
                decidContacto = idContacto;
                strAsunto = asunto;
                strMensaje = mensaje;
                strArchivo = rutaArchivo;
                this.txtAsunto.Text = asunto;
                this.mmoMensaje.Text = mensaje;
                this.ShowDialog();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Enviar();
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
