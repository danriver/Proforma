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
    public partial class frmProveedores : Proforma.Forms.frmServer
    {

        #region Variables
        public string Operacion, TipoRegistro = "Proveedor", NumRegistro;
        #endregion

        public frmProveedores()
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
                this.grdProveedores.DataSource = contexto.tblProveedores.ToList();
                this.vwProveedores.BestFitColumns();
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
                this.txtIdProveedor.Text = "";
                this.txtNombre.Text = "";
                this.txtDireccion.Text = "";
                this.txtTelefono.Text = "";
                this.txtRUC.Text = "";
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

            string idProveedor = Convert.ToString(this.txtIdProveedor.Text.Trim());
            string nombre = Convert.ToString(this.txtNombre.Text.Trim());
            string direccion = Convert.ToString(this.txtDireccion.Text.Trim());
            string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
            string RUC = Convert.ToString(this.txtRUC.Text.Trim());

            if (idProveedor.Length == 0)
            {
                this.txtIdProveedor.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
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

            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idProveedor = Convert.ToDecimal(this.vwProveedores.GetFocusedRowCellValue("decIdProveedor").IsNull(0));
                if (idProveedor>0)
                {
                    this.txtIdProveedor.Text = Convert.ToString(idProveedor);
                    this.txtNombre.Text = Convert.ToString(this.vwProveedores.GetFocusedRowCellValue("strNombre"));
                    this.txtDireccion.Text = Convert.ToString(this.vwProveedores.GetFocusedRowCellValue("strDireccion"));
                    this.txtTelefono.Text = Convert.ToString(this.vwProveedores.GetFocusedRowCellValue("strTelefono"));
                    this.txtRUC.Text = Convert.ToString(this.vwProveedores.GetFocusedRowCellValue("strRUC"));
                    this.chkExonerado.Checked = Convert.ToBoolean(this.vwProveedores.GetFocusedRowCellValue("bitExonerado"));
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
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
                this.txtIdProveedor.Text = "-1";
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
                bool exonerado = Convert.ToBoolean(this.chkExonerado.Checked);

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idProveedor = Convert.ToDecimal(this.txtIdProveedor.Text);
                    tblProveedores p;

                    if (idProveedor > 0)
                    {
                        p = contexto.tblProveedores.FirstOrDefault(x => x.decIdProveedor == idProveedor);
                        p.strNombre = nombre;
                        p.strDireccion = direccion;
                        p.strTelefono = telefono;
                        p.strRUC = RUC;
                        p.bitExonerado = exonerado;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        p = new tblProveedores
                        {
                            strNombre = nombre,
                            strDireccion = direccion,
                            strTelefono = telefono,
                            strRUC = RUC,
                            bitExonerado = exonerado,
                        };
                        contexto.tblProveedores.Add(p);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(p.decIdProveedor);
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
                decimal idProveedor = Convert.ToDecimal(this.txtIdProveedor.EditValue);
                if (idProveedor > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {

                            tblProveedores p = contexto.tblProveedores.FirstOrDefault(x => x.decIdProveedor == idProveedor);
                            var refProductos = p.tblProductosXProveedor.Count;
                            var refDetalleCotizacion = p.tblDetalleCotizaciones.Count;
                            if (refProductos > 0 || refDetalleCotizacion > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblProveedores.Remove(p);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(p.decIdProveedor);
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

        private void vwProveedores_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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
        
        private void btnAgregarProductos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                frmProductosXProveedor frmProdProv = new frmProductosXProveedor();
                frmProdProv.Show(this, Convert.ToDecimal(vwProveedores.GetFocusedRowCellValue("decIdProveedor")));
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
