using Proforma.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Proforma.Modules;
using DevExpress.XtraEditors;

namespace Proforma.Forms
{
    public partial class frmVendedores : Proforma.Forms.frmServer
    {

        #region Variables
        public string Operacion, TipoRegistro = "Vendedor", NumRegistro;
        #endregion

        public frmVendedores()
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
                this.grdVendedores.DataSource = contexto.tblVendedores.ToList();
                this.vwVendedores.BestFitColumns();
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
                this.txtIdVendedor.Text = "";
                this.txtNombre.Text = "";
                this.txtTelefono.Text = "";
                this.txtCorreo.Text = "";
                this.txtContrasena.Text = "";
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
            string idVendedor = Convert.ToString(this.txtIdVendedor.Text.Trim());
            string nombre = Convert.ToString(this.txtNombre.Text.Trim());
            string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
            string correo = Convert.ToString(this.txtCorreo.Text.Trim());
            string contrasena = Convert.ToString(this.txtContrasena.Text.Trim());

            if (idVendedor.Length == 0)
            {
                this.txtIdVendedor.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (nombre.Length == 0)
            {
                this.txtNombre.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (telefono.Length == 0)
            {
                this.txtTelefono.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (correo.Length == 0)
            {
                this.txtCorreo.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (contrasena.Length == 0)
            {
                this.txtContrasena.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idVendedor = Convert.ToDecimal(this.vwVendedores.GetFocusedRowCellValue("decIdVendedor").IsNull(0));
                if (idVendedor > 0)
                {
                    this.txtIdVendedor.Text = Convert.ToString(idVendedor);
                    this.txtNombre.Text = Convert.ToString(this.vwVendedores.GetFocusedRowCellValue("strNombreVendedor"));
                    this.txtTelefono.Text = Convert.ToString(this.vwVendedores.GetFocusedRowCellValue("strTelefono"));
                    this.txtCorreo.Text = Convert.ToString(this.vwVendedores.GetFocusedRowCellValue("strCorreo"));
                    this.txtContrasena.Text = SystemProtected.DesEncriptarCadena(Convert.ToString(this.vwVendedores.GetFocusedRowCellValue("strContrasena").IsNull("")));
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

        private void frmVendedores_Load(object sender, EventArgs e)
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
                this.txtIdVendedor.Text = "-1";
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
                string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
                string correo = Convert.ToString(this.txtCorreo.Text.Trim());
                string contrasena = SystemProtected.EncriptarCadena(Convert.ToString(this.txtContrasena.Text.Trim()));

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idVendedor = Convert.ToDecimal(this.txtIdVendedor.Text.Trim());
                    tblVendedores v;

                    if (idVendedor > 0)
                    {
                        v = contexto.tblVendedores.FirstOrDefault(x => x.decIdVendedor == idVendedor);
                        v.strNombreVendedor = nombre;
                        v.strTelefono = telefono;
                        v.strCorreo = correo;
                        v.strContrasena = contrasena;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        v = new tblVendedores
                        {
                            strNombreVendedor = nombre,
                            strTelefono = telefono,
                            strCorreo = correo,
                            strContrasena = contrasena
                        };
                        contexto.tblVendedores.Add(v);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(v.decIdVendedor);
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
                decimal idVendedor = Convert.ToDecimal(this.txtIdVendedor.EditValue);
                if (idVendedor > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {
                            tblVendedores v = contexto.tblVendedores.FirstOrDefault(x => x.decIdVendedor == idVendedor);
                            var refClientes = v.tblClientes.Count;
                            var refCotizaciones = v.tblCotizaciones.Count;
                            var refUsuarios = v.tblUsuarios.Count;
                            if (refClientes > 0 || refCotizaciones > 0 || refUsuarios > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblVendedores.Remove(v);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(v.decIdVendedor);
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

        private void vwVendedores_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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
    }
}
