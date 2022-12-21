using DevExpress.XtraEditors;
using Proforma.Models;
using Proforma.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proforma.Forms
{
    public partial class frmConfiguracion : Proforma.Forms.frmServer
    {

        #region Variables
        public string Operacion, TipoRegistro = "Configuración", NumRegistro;
        #endregion

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        #region Metodos
        private bool CamposValidos()
        {
            bool result = true;
            string nombre = Convert.ToString(this.txtNombre.Text.Trim());
            string direccion = Convert.ToString(this.txtDireccion.Text.Trim());
            string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
            string RUC = Convert.ToString(this.txtRUC.Text.Trim());
            string nombreCheque = Convert.ToString(this.txtNombreCheque.Text.Trim());
            int? moneda = Convert.ToInt32(this.cmbMoneda.EditValue.IsNull(0));
            decimal? IVA = Convert.ToDecimal(this.txtIVA.EditValue.IsNull(0));
            int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue.IsNull(0));

            if (nombre.Length == 0)
            {
                this.txtNombre.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (direccion.Length == 0)
            {
                this.txtDireccion.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (telefono.Length == 0)
            {
                this.txtTelefono.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (RUC.Length == 0)
            {
                this.txtRUC.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (nombreCheque.Length == 0)
            {
                this.txtNombreCheque.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (moneda == 0)
            {
                this.cmbMoneda.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (IVA == 0)
            {
                this.txtIVA.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (precioxdefecto == 0)
            {
                this.cmbPrecioXDefecto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                    this.xtraTabControl1.SelectedTabPageIndex = 1;
                    this.cmbMoneda.EditValue = Convert.ToInt32(con.intMoneda);
                    this.txtIVA.Text = Convert.ToString(con.decPorcentajeIVA);
                    this.chkImprimirUS.Checked = Convert.ToBoolean(con.bitImprimirFacturaUS);
                    this.cmbPrecioXDefecto.EditValue = Convert.ToInt32(con.intIdPrecio);

                    int cont = Convert.ToInt32(contexto.tblCotizaciones.Count().IsNull(0));

                    if (cont > 0)
                    {
                        this.cmbMoneda.ReadOnly = true;
                    }
                    else
                    {
                        this.cmbMoneda.ReadOnly = false;
                    }

                    this.xtraTabControl1.SelectedTabPageIndex = 0;
                    this.txtNombre.Text = Convert.ToString(con.strNombreEmpresa);
                    this.txtDireccion.Text = Convert.ToString(con.strDireccionEmpresa);
                    this.txtTelefono.Text = Convert.ToString(con.strTelefono);
                    this.txtRUC.Text = Convert.ToString(con.strRUCEmpresa);
                    this.txtEncabezado.Text = Convert.ToString(con.strEncabezado);
                    this.chkMostrarEncabezado.Checked = Convert.ToBoolean(con.bitEncabezado);
                    this.txtInfAdicional.Text = Convert.ToString(con.strInfAdicional);
                    this.txtPiePagina.Text = Convert.ToString(con.strPieEmpresa);
                    this.chkMostrarPiePagina.Checked = Convert.ToBoolean(con.bitPieEmpresa);
                    this.txtEslogan.Text = Convert.ToString(con.strEsloganEmpresa);
                    this.txtNombreCheque.Text = Convert.ToString(con.strChequeNombreDe);
                    this.txtLogo.Text = Convert.ToString(con.strDireccionLogo);
                    this.txtFoto.Text = Convert.ToString(con.strRutaFoto);
                }

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
        #endregion

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbMoneda.Properties.DataSource = contexto.tblMonedas.ToList();
                this.cmbPrecioXDefecto.Properties.DataSource = contexto.tblPrecios.ToList();
                CargarDatos();
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

        private void cmbMoneda_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                var monedas = contexto.tblMonedas.ToList();
                int intmoneda = Convert.ToInt32(this.cmbMoneda.EditValue);
                this.chkImprimirUS.Text = "Imprimir en " + Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != intmoneda).strSimbolo);
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

        private void btnGuardar_Click(object sender, EventArgs e)
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
                string nombre = Convert.ToString(this.txtNombre.Text.Trim());
                string direccion = Convert.ToString(this.txtDireccion.Text.Trim());
                string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
                string RUC = Convert.ToString(this.txtRUC.Text.Trim());
                string encabezado = Convert.ToString(this.txtEncabezado.Text.Trim());
                bool mostrarEncabezado = Convert.ToBoolean(this.chkMostrarEncabezado.Checked);
                string infAdicional = Convert.ToString(this.txtInfAdicional.Text.Trim());
                string piePagina = Convert.ToString(this.txtPiePagina.Text.Trim());
                bool mostrarPiePagina = Convert.ToBoolean(this.chkMostrarPiePagina.Checked);
                string eslogan = Convert.ToString(this.txtEslogan.Text.Trim());
                string nombreCheque = Convert.ToString(this.txtNombreCheque.Text.Trim());
                string logo = Convert.ToString(this.txtLogo.Text.Trim());
                string foto = Convert.ToString(this.txtFoto.Text.Trim());
                int? moneda = Convert.ToInt32(this.cmbMoneda.EditValue);
                decimal? IVA = Convert.ToDecimal(this.txtIVA.EditValue);
                bool imprimirUS = Convert.ToBoolean(this.chkImprimirUS.Checked);
                int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue);

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                    con.strNombreEmpresa = nombre;
                    con.strDireccionEmpresa = direccion;
                    con.strTelefono = telefono;
                    con.strRUCEmpresa = RUC;
                    con.strEncabezado = encabezado;
                    con.bitEncabezado = mostrarEncabezado;
                    con.strInfAdicional = infAdicional;
                    con.strPieEmpresa = piePagina;
                    con.bitPieEmpresa = mostrarPiePagina;
                    con.strEsloganEmpresa = eslogan;
                    con.strChequeNombreDe = nombreCheque;
                    con.strDireccionLogo = logo;
                    con.strRutaFoto = foto;
                    con.intMoneda = moneda;
                    con.decPorcentajeIVA = IVA;
                    con.bitImprimirFacturaUS = imprimirUS;
                    con.intIdPrecio = precioxdefecto;
                    Operacion = TipoOperacion.Modificacion;
                    contexto.SaveChanges();
                    NumRegistro = "Parámetros";
                    AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                    XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                OpenFileImagen.InitialDirectory = "c:\\";
                OpenFileImagen.Filter = "Imágenes|*.jpg;*.png";

                if (OpenFileImagen.ShowDialog() == DialogResult.OK)
                {
                    string origen = OpenFileImagen.FileName;
                    string extension = Path.GetExtension(origen);
                    string destino = PublicVar.gstrServerArchivos;
                    using (NetworkShareAccesser.Access(PublicVar.gstrServername, PublicVar.gstrServeruser, PublicVar.gstrServerpassword))
                    {
                        string[] files = System.IO.Directory.GetFiles(destino, "Foto.*");
                        foreach (string f in files)
                        {
                            File.Delete(f);
                        }
                        destino = PublicVar.gstrServerArchivos + "Foto" + extension;
                        File.Copy(origen, destino);
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {
                            tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                            con.strRutaFoto = destino;
                            this.txtFoto.Text = destino;
                            Operacion = TipoOperacion.Modificacion;
                            contexto.SaveChanges();
                            NumRegistro = "Foto";
                            AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                            XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
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

        private void btnLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                OpenFileImagen.InitialDirectory = "c:\\";
                OpenFileImagen.Filter = "Imágenes|*.jpg;*.ico;*.png";

                if (OpenFileImagen.ShowDialog() == DialogResult.OK)
                {
                    string origen = OpenFileImagen.FileName;
                    string extension = Path.GetExtension(origen);
                    string destino = PublicVar.gstrServerArchivos;
                    using (NetworkShareAccesser.Access(PublicVar.gstrServername, PublicVar.gstrServeruser, PublicVar.gstrServerpassword))
                    {
                        string[] files = System.IO.Directory.GetFiles(destino, "Logo.*");
                        foreach (string f in files)
                        {
                            File.Delete(f);
                        }
                        destino = PublicVar.gstrServerArchivos + "Logo" + extension;
                        File.Copy(origen, destino);
                    }
                    using (BD_ERPEntities contexto = new BD_ERPEntities())
                    {
                        tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                        con.strDireccionLogo = destino;
                        this.txtLogo.Text = destino;
                        Operacion = TipoOperacion.Modificacion;
                        contexto.SaveChanges();
                        NumRegistro = "Logo";
                        AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                        XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarLogo();
                    if ((Application.OpenForms["frmMain"]) as Form != null)
                    {
                        CargarLogo(Application.OpenForms["frmMain"]);
                    }
                }
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
