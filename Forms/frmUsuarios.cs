using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Proforma.Models;
using Proforma.Modules;
using DevExpress.XtraEditors;

namespace Proforma.Forms
{
    public partial class frmUsuarios : Proforma.Forms.frmServer
    {
        #region Variables

        decimal _idUsuario = 0;
        bool _enllavado = false;
        bool _bolBtnNuevo = false;
        bool _bolBtnGuardar = false;
        bool _bolBtnEliminar = false;
        string _tipoRegistro = "Usuario";

        #endregion

        public frmUsuarios()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CargarUsuarios(BD_ERPEntities context)
        {
            var usuarios = context.tblUsuarios.ToList();
            grdUsuarios.DataSource = usuarios;
        }

        private void LimpiarCampos()
        {
            txtIdUsuario.EditValue = "";
            txtNombreUsuario.EditValue = "";
            txtUsuario.EditValue = "";
            txtContrasena.EditValue = "";
            cboRol.EditValue = null;
            cboVendedor.EditValue = null;
            chkActivo.Checked = false;
        }

        private bool CamposValidos()
        {
            bool result = true;
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            decimal? idRol = Convert.ToDecimal(cboRol.EditValue.IsNull(0));

            if (nombreUsuario.Length == 0)
            {
                txtNombreUsuario.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (usuario.Length == 0)
            {
                txtUsuario.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (contrasena.Length == 0)
            {
                txtContrasena.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idRol == 0)
            {
                cboRol.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private void HabilitarCampos()
        {
            btnNuevo.Enabled = _bolBtnNuevo;
            if (_idUsuario != 0)
            {
                if (_idUsuario > 0)
                {
                    txtUsuario.ReadOnly = true;
                    if (_idUsuario == gdecIdUser || _enllavado == true)
                    {
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        btnEliminar.Enabled = _bolBtnEliminar;
                    }
                    if (_enllavado == false)
                    {
                        txtNombreUsuario.ReadOnly = false;
                        cboRol.ReadOnly = false;
                        cboVendedor.ReadOnly = false;
                        chkActivo.ReadOnly = false;
                    }
                    else
                    {
                        txtNombreUsuario.ReadOnly = true;
                        cboRol.ReadOnly = true;
                        cboVendedor.ReadOnly = true;
                        chkActivo.ReadOnly = true;
                    }
                }
                else
                {
                    txtNombreUsuario.ReadOnly = false;
                    cboRol.ReadOnly = false;
                    cboVendedor.ReadOnly = false;
                    chkActivo.ReadOnly = false;
                    txtUsuario.ReadOnly = false;
                    btnEliminar.Enabled = false;
                }
                txtContrasena.ReadOnly = false;
                btnGuardar.Enabled = _bolBtnGuardar;
            }
            else
            {
                txtNombreUsuario.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtContrasena.ReadOnly = true;
                cboRol.ReadOnly = true;
                cboVendedor.ReadOnly = true;
                chkActivo.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        #endregion

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PermissionObjects.CargarPermisos(this);

                _bolBtnNuevo = btnNuevo.Enabled;
                _bolBtnGuardar = btnGuardar.Enabled;
                _bolBtnEliminar = btnEliminar.Enabled;

                HabilitarCampos();
                using (BD_ERPEntities context = new BD_ERPEntities())
                {
                    var roles = context.tblRoles.ToList();
                    var vendedores = context.tblVendedores.ToList();
                    var usuarios = context.tblUsuarios.ToList();

                    cboRol.Properties.DataSource = roles;
                    rpCboRol.DataSource = roles;
                    cboVendedor.Properties.DataSource = vendedores;
                    rpCboVendedore.DataSource = vendedores;
                    CargarUsuarios(context);
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                txtIdUsuario.EditValue = -1;
                chkActivo.Checked = true;
                _enllavado = false;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
                using (BD_ERPEntities context = new BD_ERPEntities())
                {
                    tblUsuarios u;
                    string nombreUsuario = txtNombreUsuario.Text.Trim();
                    string usuario = txtUsuario.Text.Trim().ToLower();
                    string contrasena = SystemProtected.EncriptarCadena(txtContrasena.Text.Trim());
                    decimal? idRol = (decimal?)cboRol.EditValue;
                    decimal? idVendedor = (decimal?)cboVendedor.EditValue;
                    bool activo = chkActivo.Checked;
                    string operacion = "";

                    if (_idUsuario <= 0)
                    {
                        u = new tblUsuarios
                        {
                            strNombreUsuario = nombreUsuario,
                            strUsuario = usuario,
                            strContrasena = contrasena,
                            decIdRol = idRol,
                            decIdVendedor = idVendedor,
                            bitActivo = activo
                        };
                        context.tblUsuarios.Add(u);
                        operacion = TipoOperacion.Creacion;
                    }
                    else
                    {
                        u = context.tblUsuarios.Where(x => x.decIdUsuario == _idUsuario).FirstOrDefault();
                        if (u != null)
                        {
                            u.strNombreUsuario = nombreUsuario;
                            u.strContrasena = contrasena;
                            u.decIdRol = idRol;
                            u.decIdVendedor = idVendedor;
                            u.bitActivo = activo;
                        }
                        operacion = TipoOperacion.Modificacion;
                    }

                    context.SaveChanges();
                    AgregarBitacora(operacion, _tipoRegistro, u.decIdUsuario.ToString());
                    XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_idUsuario <= 0)
                    {
                        LimpiarCampos();
                    }
                    CargarUsuarios(context);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (_idUsuario > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities context = new BD_ERPEntities())
                        {
                            Cursor = Cursors.WaitCursor;
                            var u = context.tblUsuarios.Where(x => x.decIdUsuario == _idUsuario).FirstOrDefault();
                            if (u != null)
                            {
                                context.tblUsuarios.Remove(u);
                                context.SaveChanges();
                                AgregarBitacora(TipoOperacion.Eliminacion, _tipoRegistro, u.decIdUsuario.ToString());
                                CargarUsuarios(context);
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

        private void GrdVwUsuarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idUsuario = Convert.ToDecimal(grdVwUsuarios.GetRowCellValue(e.RowHandle, coldecIdUsuario).IsNull(0));
                if (idUsuario > 0)
                {
                    _enllavado = Convert.ToBoolean(grdVwUsuarios.GetRowCellValue(e.RowHandle, "bitEnllavado").IsNull(false));
                    txtIdUsuario.EditValue = idUsuario;
                    txtNombreUsuario.EditValue = grdVwUsuarios.GetRowCellValue(e.RowHandle, colstrNombreUsuario);
                    txtUsuario.EditValue = grdVwUsuarios.GetRowCellValue(e.RowHandle, colstrUsuario);
                    txtContrasena.EditValue = SystemProtected.DesEncriptarCadena(grdVwUsuarios.GetRowCellValue(e.RowHandle, "strContrasena").IsNull("").ToString());
                    cboRol.EditValue = grdVwUsuarios.GetRowCellValue(e.RowHandle, coldecIdRol);
                    cboVendedor.EditValue = grdVwUsuarios.GetRowCellValue(e.RowHandle, coldecIdVendedor);
                    chkActivo.Checked = Convert.ToBoolean(grdVwUsuarios.GetRowCellValue(e.RowHandle, colbitActivo).IsNull(false));
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

        private void TxtIdUsuario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _idUsuario = Convert.ToDecimal(txtIdUsuario.EditValue.IsNull(0));
                HabilitarCampos();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }
    }
}
