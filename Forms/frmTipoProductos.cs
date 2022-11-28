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
    public partial class frmTipoProductos : Proforma.Forms.frmServer
    {

        #region Variables
        public string Operacion, TipoRegistro = "Tipo de Producto", NumRegistro;
        #endregion

        public frmTipoProductos()
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
                this.grdTipoProductos.DataSource = contexto.tblTipoProductos.ToList();
                this.vwTipoProductos.BestFitColumns();
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
                this.txtIdTipoProducto.Text = "";
                this.txtTipoProducto.Text = "";
                this.txtIncrementoPrecio1.Text = "";
                this.txtIncrementoPrecio2.Text = "";
                this.txtIncrementoPrecio3.Text = "";
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

            string idTipoProducto = Convert.ToString(this.txtIdTipoProducto.Text.Trim());
            string TipoProducto = Convert.ToString(this.txtTipoProducto.Text.Trim());
            decimal? incrementoprecio1 = Convert.ToDecimal(this.txtIncrementoPrecio1.EditValue.IsNull(0));
            decimal? incrementoprecio2 = Convert.ToDecimal(this.txtIncrementoPrecio2.EditValue.IsNull(0));
            decimal? incrementoprecio3 = Convert.ToDecimal(this.txtIncrementoPrecio3.EditValue.IsNull(0));

            if (idTipoProducto.Length == 0)
            {
                this.txtIdTipoProducto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (TipoProducto.Length == 0)
            {
                this.txtTipoProducto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (incrementoprecio1 == 0)
            {
                this.txtIncrementoPrecio1.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (incrementoprecio2 == 0)
            {
                this.txtIncrementoPrecio2.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (incrementoprecio3 == 0)
            {
                this.txtIncrementoPrecio3.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }

            return result;
        }

        private void CargarDatos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idTipoProducto = Convert.ToDecimal(this.vwTipoProductos.GetFocusedRowCellValue("decIdTipoProducto").IsNull(0));
                if (idTipoProducto > 0)
                {
                    this.txtIdTipoProducto.Text = Convert.ToString(idTipoProducto);
                    this.txtTipoProducto.Text = Convert.ToString(this.vwTipoProductos.GetFocusedRowCellValue("strTipoProducto"));
                    this.txtIncrementoPrecio1.Text = Convert.ToString(this.vwTipoProductos.GetFocusedRowCellValue("decIncrementoPrecio1"));
                    this.txtIncrementoPrecio2.Text = Convert.ToString(this.vwTipoProductos.GetFocusedRowCellValue("decIncrementoPrecio2"));
                    this.txtIncrementoPrecio3.Text = Convert.ToString(this.vwTipoProductos.GetFocusedRowCellValue("decIncrementoPrecio3"));
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

        private void frmTipoProductos_Load(object sender, EventArgs e)
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
                this.txtIdTipoProducto.Text = "-1";
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

                string TipoProducto = Convert.ToString(this.txtTipoProducto.Text.Trim());
                decimal? incrementoprecio1 = Convert.ToDecimal(this.txtIncrementoPrecio1.EditValue);
                decimal? incrementoprecio2 = Convert.ToDecimal(this.txtIncrementoPrecio2.EditValue);
                decimal? incrementoprecio3 = Convert.ToDecimal(this.txtIncrementoPrecio3.EditValue);

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idTipoProducto = Convert.ToDecimal(this.txtIdTipoProducto.Text);
                    tblTipoProductos tp;

                    if (idTipoProducto > 0)
                    {
                        tp = contexto.tblTipoProductos.FirstOrDefault(x => x.decIdTipoProducto == idTipoProducto);
                        tp.strTipoProducto = TipoProducto;
                        tp.decIncrementoPrecio1 = incrementoprecio1;
                        tp.decIncrementoPrecio2 = incrementoprecio2;
                        tp.decIncrementoPrecio3 = incrementoprecio3;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        tp = new tblTipoProductos
                        {
                            strTipoProducto = TipoProducto,
                            decIncrementoPrecio1 = incrementoprecio1,
                            decIncrementoPrecio2 = incrementoprecio2,
                            decIncrementoPrecio3 = incrementoprecio3,
                        };
                        contexto.tblTipoProductos.Add(tp);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(tp.decIdTipoProducto);
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
                decimal idTipoProducto = Convert.ToDecimal(this.txtIdTipoProducto.EditValue);
                if (idTipoProducto > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {

                            tblTipoProductos tp = contexto.tblTipoProductos.FirstOrDefault(x => x.decIdTipoProducto == idTipoProducto);
                            var refProducto = tp.tblProductos.Count;
                            if (refProducto > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblTipoProductos.Remove(tp);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(tp.decIdTipoProducto);
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

        private void vwTipoProductos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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
