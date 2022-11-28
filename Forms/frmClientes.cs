using Proforma.Models;
using Proforma.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proforma.Forms
{
    public partial class frmClientes : Proforma.Forms.frmServer
    {

        #region Variables
        public string Operacion, TipoRegistro = "Cliente", NumRegistro;
        #endregion

        public frmClientes()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CargarGrid()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.grdClientes.DataSource = contexto.tblClientes.ToList();
                this.vwClientes.BestFitColumns();
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

        private void LimpiarCampos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.txtIdCliente.Text = "";
                this.txtNombre.Text = "";
                this.txtSiglas.Text = "";
                this.txtDireccion.Text = "";
                this.txtTelefono.Text = "";
                this.txtRUC.Text = "";
                this.cmbPrecioXDefecto.EditValue = null;
                this.cmbVendedor.EditValue = null;
                this.chkActivo.Checked = false;
                this.chkExonerado.Checked = false;
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

        private bool CamposValidos()
        {
            bool result = true;
            string idCliente = Convert.ToString(this.txtIdCliente.Text.Trim());
            string nombre = Convert.ToString(this.txtNombre.Text.Trim());
            string siglas = Convert.ToString(this.txtSiglas.Text.Trim());
            string direccion = Convert.ToString(this.txtDireccion.Text.Trim());
            string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
            string RUC = Convert.ToString(this.txtRUC.Text.Trim());
            int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue.IsNull(0));
            decimal? idVendedor = Convert.ToDecimal(this.cmbVendedor.EditValue.IsNull(0));

            if (idCliente.Length == 0)
            {
                this.txtIdCliente.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (nombre.Length == 0)
            {
                this.txtNombre.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (siglas.Length == 0)
            {
                this.txtSiglas.ErrorText = PublicVar.gstrCampoRequeridoMsg;
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
            if (precioxdefecto == 0)
            {
                this.cmbPrecioXDefecto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idVendedor == 0)
            {
                this.cmbVendedor.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCliente = Convert.ToDecimal(this.vwClientes.GetFocusedRowCellValue("decIdCliente").IsNull(0));
                if (idCliente > 0)
                {
                    this.txtIdCliente.Text = Convert.ToString(idCliente);
                    this.txtNombre.Text = Convert.ToString(this.vwClientes.GetFocusedRowCellValue("strNombre"));
                    this.txtSiglas.Text = Convert.ToString(this.vwClientes.GetFocusedRowCellValue("strSiglas"));
                    this.txtDireccion.Text = Convert.ToString(this.vwClientes.GetFocusedRowCellValue("strDireccion"));
                    this.txtTelefono.Text = Convert.ToString(this.vwClientes.GetFocusedRowCellValue("strTelefono"));
                    this.txtRUC.Text = Convert.ToString(this.vwClientes.GetFocusedRowCellValue("strRUC"));
                    this.cmbPrecioXDefecto.EditValue = Convert.ToInt32(this.vwClientes.GetFocusedRowCellValue("intIdPrecio"));
                    this.cmbVendedor.EditValue = Convert.ToDecimal(this.vwClientes.GetFocusedRowCellValue("decIdVendedor"));
                    this.chkActivo.Checked = Convert.ToBoolean(this.vwClientes.GetFocusedRowCellValue("bitActivo"));
                    this.chkExonerado.Checked = Convert.ToBoolean(this.vwClientes.GetFocusedRowCellValue("bitExonerado"));
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

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbVendedor.Properties.DataSource = contexto.tblVendedores.ToList();                
                this.repVendedores.DataSource = contexto.tblVendedores.ToList();
                this.cmbPrecioXDefecto.Properties.DataSource = contexto.tblPrecios.ToList();
                this.repPrecios.DataSource = contexto.tblPrecios.ToList();
                CargarGrid();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LimpiarCampos();
                this.txtIdCliente.Text = "-1";
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
                string siglas = Convert.ToString(this.txtSiglas.Text.Trim());
                string direccion = Convert.ToString(this.txtDireccion.Text.Trim());
                string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
                string RUC = Convert.ToString(this.txtRUC.Text.Trim());
                int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue);
                decimal? idVendedor = Convert.ToDecimal(this.cmbVendedor.EditValue);
                bool activo = Convert.ToBoolean(this.chkActivo.Checked);
                bool exonerado = Convert.ToBoolean(this.chkExonerado.Checked);

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCliente = Convert.ToDecimal(this.txtIdCliente.Text);
                    tblClientes c;

                    if (idCliente > 0)
                    {
                        c = contexto.tblClientes.FirstOrDefault(x => x.decIdCliente == idCliente);
                        c.strNombre = nombre;
                        c.strSiglas = siglas;
                        c.strDireccion = direccion;
                        c.strTelefono = telefono;
                        c.strRUC = RUC;
                        c.intIdPrecio = precioxdefecto;
                        c.decIdVendedor = idVendedor;
                        c.bitActivo = activo;
                        c.bitExonerado = exonerado;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        c = new tblClientes
                        {
                            strNombre = nombre,
                            strSiglas = siglas,
                            strDireccion = direccion,
                            strTelefono = telefono,
                            strRUC = RUC,
                            intIdPrecio = precioxdefecto,
                            decIdVendedor = idVendedor,
                            bitActivo = activo,
                            bitExonerado = exonerado,
                        };
                        contexto.tblClientes.Add(c);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(c.decIdCliente);
                    AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                    XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();

                    LimpiarCampos();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCliente = Convert.ToDecimal(this.txtIdCliente.EditValue);
                if (idCliente > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {

                            tblClientes c = contexto.tblClientes.FirstOrDefault(x => x.decIdCliente == idCliente);
                            var refContactos = c.tblClientesContacto.Count;
                            var refCotizaciones = c.tblCotizaciones.Count;
                            if (refContactos > 0 || refCotizaciones > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblClientes.Remove(c);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(c.decIdCliente);
                                AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                                CargarGrid();

                                LimpiarCampos();
                            }                            
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

        private void vwClientes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
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

        private void repContactos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                frmClientesContacto frmCC = new frmClientesContacto();
                frmCC.Show(this, Convert.ToDecimal(vwClientes.GetFocusedRowCellValue("decIdCliente")));
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
