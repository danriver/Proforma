using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proforma.Models;
using Proforma.Modules;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.Data.Entity.Infrastructure;

namespace Proforma.Forms
{
    public partial class frmRoles : Proforma.Forms.frmServer
    {
        #region Variables

        decimal _idRol = 0;
        bool _enllavado = false;
        bool _bolBtnNuevo = false;
        bool _bolBtnGuardar = false;
        bool _bolBtnEliminar = false;
        string _tipoRegistro = "Rol";

        #endregion

        public frmRoles()
        {
            InitializeComponent();
        }

        #region Metodos

        private void LimpiarCampos()
        {
            txtIdRol.EditValue = "";
            txtNombreRol.EditValue = "";
        }

        private bool CamposValidos()
        {
            bool result = false;
            string nombreRol = txtNombreRol.Text.Trim();
            if (nombreRol.Length == 0)
            {
                txtNombreRol.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            return result;
        }

        private void HabilitarCampos()
        {
            btnNuevo.Enabled = _bolBtnNuevo;
            if (_idRol != 0)
            {
                if (_idRol > 0)
                {
                    if (_enllavado == false)
                    {
                        txtNombreRol.ReadOnly = false;
                        btnGuardar.Enabled = _bolBtnGuardar;
                        btnEliminar.Enabled = _bolBtnEliminar;
                    }
                    else
                    {
                        txtNombreRol.ReadOnly = true;
                        btnGuardar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                }
                else
                {
                    txtNombreRol.ReadOnly = false;
                    btnGuardar.Enabled = _bolBtnGuardar;
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                txtNombreRol.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void CargarRoles()
        {
            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                var roles = context.tblRoles.ToList();
                grdRoles.DataSource = roles;
            }
        }

        private void CargarArbolPermisos()
        {
            tlstPermisos.Appearance.Row.BackColor = Color.Transparent;
            tlstPermisos.Appearance.Empty.BackColor = Color.Transparent;
            tlstPermisos.BackColor = Color.Transparent;
            tlstPermisos.CheckBoxFieldName = "Checked";
            tlstPermisos.TreeViewFieldName = "Name";
            tlstPermisos.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
            tlstPermisos.OptionsView.CheckBoxStyle = DefaultNodeCheckBoxStyle.Check;
            tlstPermisos.OptionsBehavior.Editable = false;
            tlstPermisos.OptionsBehavior.ReadOnly = true;
            tlstPermisos.OptionsBehavior.AllowRecursiveNodeChecking = true;
            tlstPermisos.NodeCellStyle += OnNodeCellStyle;
            tlstPermisos.BeforeFocusNode += OnBeforeFocusNode;
            CargarPermisosRol();
        }

        private void CargarPermisosRol()
        {
            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                var rolPermisos = context.spRolPermisos(_idRol, 0).ToList();
                if (rolPermisos != null)
                {
                    DataTable dt = new DataTable();
                    var contRolPermisos = rolPermisos.Where(x => x.bitActivo == true).Count();
                    var contPermisos = rolPermisos.Count();
                    bool? checkParent = false;
                    if (contRolPermisos == contPermisos)
                    {
                        checkParent = true;
                    }
                    dt.Columns.Add("ID", typeof(decimal));
                    dt.Columns.Add("ParentID", typeof(decimal));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Checked", typeof(bool));
                    dt.Columns.Add("strNombreObjeto", typeof(string));
                    dt.Rows.Add(new object[] { 0, -1, "Permisos del Sistema", checkParent, "" });
                    foreach (var permiso in rolPermisos)
                    {
                        dt.Rows.Add(new object[] { permiso.decIdPermiso, permiso.decIdPermisoPrincipal, permiso.strDescripcionObjeto, permiso.bitActivo, permiso.strNombreObjeto });
                    }
                    tlstPermisos.DataSource = dt;
                    tlstPermisos.ForceInitialize();
                    tlstPermisos.ExpandAll();
                    tlstPermisos.BestFitColumns();
                }
            }
        }

        private void ActualizarPermisosNodo(TreeListNode nodo, BD_ERPEntities context)
        {
            var rolPermisos = context.tblRolPermisos.Where(x => x.decIdPermiso == nodo.Id && x.decIdRol == _idRol).FirstOrDefault();
            if (rolPermisos != null)
            {
                if (nodo.Checked != rolPermisos.bitActivo)
                {
                    rolPermisos.bitActivo = nodo.Checked;
                    context.SaveChanges();
                }
            }
            else
            {
                if (nodo.Level > 0)
                {
                    rolPermisos = new tblRolPermisos
                    {
                        decIdPermiso = nodo.Id,
                        decIdRol = _idRol,
                        bitActivo = nodo.Checked
                    };
                    context.tblRolPermisos.Add(rolPermisos);
                    context.SaveChanges();
                }
            }
            if (nodo.Nodes.Count > 0)
            {
                foreach (TreeListNode n in nodo.Nodes)
                {
                    ActualizarPermisosNodo(n, context);
                }
            }
            if (nodo.ParentNode != null)
            {
                var contPermisosAplicados = context.spRolPermisos(_idRol, 0).Where(x => x.decIdPermisoPrincipal == nodo.ParentNode.Id && x.bitActivo == true).Count();
                var rolPermisoNodo = context.spRolPermisos(_idRol, 0).Where(x => x.decIdPermiso == nodo.ParentNode.Id).FirstOrDefault();
                if (rolPermisoNodo != null)
                {
                    bool checkParent = rolPermisoNodo.bitActivo;
                    if (contPermisosAplicados > 0)
                    {
                        if (checkParent == false)
                        {
                            rolPermisoNodo.bitActivo = true;
                            context.SaveChanges();
                            nodo.ParentNode.Checked = rolPermisoNodo.bitActivo;
                            ActualizarPermisosNodo(nodo.ParentNode, context);
                        }
                    }
                    else
                    {
                        if (checkParent == true)
                        {
                            rolPermisoNodo.bitActivo = false;
                            context.SaveChanges();
                            nodo.ParentNode.Checked = rolPermisoNodo.bitActivo;
                            ActualizarPermisosNodo(nodo.ParentNode, context);
                        }
                    }
                }
            }
        }

        #endregion

        private void frmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                _bolBtnNuevo = btnNuevo.Enabled;
                _bolBtnGuardar = btnGuardar.Enabled;
                _bolBtnEliminar = btnEliminar.Enabled;

                HabilitarCampos();
                CargarRoles();
                CargarArbolPermisos();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LimpiarCampos();
                txtIdRol.EditValue = -1;
                _enllavado = false;
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
                if (CamposValidos())
                {
                    XtraMessageBox.Show(PublicVar.gstrCamposRequeridosMsg, PublicVar.gstrTitleWarning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (BD_ERPEntities context = new BD_ERPEntities())
                {
                    tblRoles r;
                    string nombreRol = txtNombreRol.Text.Trim();
                    string operacion = "";

                    if (_idRol <= 0)
                    {
                        r = new tblRoles
                        {
                            strNombreRol = nombreRol
                        };
                        context.tblRoles.Add(r);
                        operacion = TipoOperacion.Creacion;
                    }
                    else
                    {
                        r = context.tblRoles.Where(x => x.decIdRol == _idRol).FirstOrDefault();
                        if (r != null)
                        {
                            r.strNombreRol = nombreRol;
                            operacion = TipoOperacion.Modificacion;
                        }
                    }

                    context.SaveChanges();
                    AgregarBitacora(operacion, _tipoRegistro, r.decIdRol.ToString());
                    XtraMessageBox.Show(PublicVar.gstrSaveDataMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_idRol <= 0)
                    {
                        LimpiarCampos();
                    }
                    CargarRoles();
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
                if (_idRol > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities context = new BD_ERPEntities())
                        {
                            Cursor = Cursors.WaitCursor;
                            var r = context.tblRoles.Where(x => x.decIdRol == _idRol).FirstOrDefault();
                            if (r != null)
                            {
                                context.tblRoles.Remove(r);
                                context.SaveChanges();
                                AgregarBitacora(TipoOperacion.Eliminacion, _tipoRegistro, r.decIdRol.ToString());
                                CargarRoles();
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

        private void grdVwRoles_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idUsuario = Convert.ToDecimal(grdVwRoles.GetRowCellValue(e.RowHandle, coldecIdRol).IsNull(0));
                if (idUsuario > 0)
                {
                    _enllavado = Convert.ToBoolean(grdVwRoles.GetRowCellValue(e.RowHandle, "bitEnllavado"));
                    txtIdRol.EditValue = idUsuario;
                    txtNombreRol.EditValue = grdVwRoles.GetRowCellValue(e.RowHandle, colstrNombreRol);
                    CargarPermisosRol();
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

        private void txtIdRol_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _idRol = Convert.ToDecimal(txtIdRol.EditValue.IsNull(0));
                CargarPermisosRol();
                HabilitarCampos();
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

        private void OnBeforeFocusNode(object sender, BeforeFocusNodeEventArgs e)
        {
            e.CanFocus = false;
        }

        private void OnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                e.Appearance.FontSizeDelta += 1;
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            if (e.Node.Level == 1 && e.Node.Nodes.Count > 0)
            {
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
        }

        private void tlstPermisos_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            try
            {
                if (_idRol > 0 && _enllavado == false)
                {
                    e.CanCheck = true;
                }
                else
                {
                    e.CanCheck = false;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void tlstPermisos_AfterCheckNode(object sender, NodeEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities context = new BD_ERPEntities())
                {
                    ActualizarPermisosNodo(e.Node, context);
                    AgregarBitacora(TipoOperacion.Modificacion, _tipoRegistro, _idRol.ToString());
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
