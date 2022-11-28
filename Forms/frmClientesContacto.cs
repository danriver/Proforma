using DevExpress.XtraEditors;
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

namespace Proforma.Forms
{
    public partial class frmClientesContacto : Proforma.Forms.frmServer
    {
        #region Variables
        public decimal IdCliente;
        public string Operacion, TipoRegistro = "Contacto de Cliente", NumRegistro;
        #endregion

        public frmClientesContacto()
        {
            InitializeComponent();
        }

        #region Metodos
        private void CargarGrid()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PermissionObjects.CargarPermisos(this);
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.grdContactos.DataSource = contexto.tblClientesContacto.Where(x => x.decIdCliente == IdCliente).ToList();
                this.vwContactos.BestFitColumns();
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
                this.txtIdContacto.Text = "";
                this.cmbClientes.EditValue = IdCliente;
                this.txtNombre.Text = "";
                this.txtTelefono.Text = "";
                this.txtExtension.Text = "";
                this.txtCelular.Text = "";
                this.txtCorreo.Text = "";
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

            string idContacto = Convert.ToString(this.txtIdContacto.Text.Trim());
            decimal idCliente = Convert.ToDecimal(this.cmbClientes.EditValue);
            string nombre = Convert.ToString(this.txtNombre.Text.Trim());
            string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
            string correo = Convert.ToString(this.txtCorreo.Text.Trim());

            if (idContacto.Length == 0)
            {
                this.txtIdContacto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idCliente == 0)
            {
                this.cmbClientes.ErrorText = PublicVar.gstrCampoRequeridoMsg;
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
            
            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idContacto = Convert.ToDecimal(this.vwContactos.GetFocusedRowCellValue("decIdContacto").IsNull(0));
                if (idContacto > 0)
                {
                    this.txtIdContacto.Text = Convert.ToString(idContacto);
                    this.cmbClientes.EditValue = Convert.ToDecimal(this.vwContactos.GetFocusedRowCellValue("decIdCliente"));
                    this.txtNombre.Text = Convert.ToString(this.vwContactos.GetFocusedRowCellValue("strNombreContacto"));                    
                    this.txtTelefono.Text = Convert.ToString(this.vwContactos.GetFocusedRowCellValue("strTelefono"));
                    this.txtExtension.Text = Convert.ToString(this.vwContactos.GetFocusedRowCellValue("strExtension"));
                    this.txtCelular.Text = Convert.ToString(this.vwContactos.GetFocusedRowCellValue("strCelular"));
                    this.txtCorreo.Text = Convert.ToString(this.vwContactos.GetFocusedRowCellValue("strCorreo"));
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

        public void Show(Form frmParent, decimal decIdCliente)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                IdCliente = decIdCliente;
                this.cmbClientes.EditValue = IdCliente;
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

        private void frmClientesContacto_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbClientes.Properties.DataSource = contexto.tblClientes.ToList();
                this.repClientes.DataSource = contexto.tblClientes.ToList();
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
                this.txtIdContacto.Text = "-1";
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
                decimal idCliente = Convert.ToDecimal(this.cmbClientes.EditValue);
                string telefono = Convert.ToString(this.txtTelefono.Text.Trim());
                string extension = Convert.ToString(this.txtExtension.Text.Trim());
                string celular = Convert.ToString(this.txtCelular.Text.Trim());
                string correo = Convert.ToString(this.txtCorreo.Text.Trim());

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idContacto = Convert.ToDecimal(this.txtIdContacto.Text);
                    tblClientesContacto cc;

                    if (idContacto > 0)
                    {
                        cc = contexto.tblClientesContacto.FirstOrDefault(x => x.decIdContacto == idContacto);
                        cc.strNombreContacto = nombre;
                        cc.strTelefono = telefono;
                        cc.strExtension = extension;
                        cc.strCelular = celular;
                        cc.strCorreo = correo;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        cc = new tblClientesContacto
                        {
                            strNombreContacto = nombre,
                            decIdCliente = idCliente,
                            strTelefono = telefono,
                            strExtension = extension,
                            strCelular= celular,
                            strCorreo = correo,
                        };
                        contexto.tblClientesContacto.Add(cc);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(cc.decIdContacto);
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
                decimal idContacto = Convert.ToDecimal(this.txtIdContacto.EditValue);
                if (idContacto > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {

                            tblClientesContacto cc = contexto.tblClientesContacto.FirstOrDefault(x => x.decIdContacto == idContacto);
                            var refCotizacion = cc.tblCotizaciones.Count;
                            if (refCotizacion > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblClientesContacto.Remove(cc);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(cc.decIdContacto);
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

        private void vwContactos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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
