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
    public partial class frmProductos : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro = "Producto", NumRegistro;
        #endregion

        public frmProductos()
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
                this.grdProductos.DataSource = contexto.tblProductos.ToList();
                this.vwProductos.BestFitColumns();
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
                this.txtIdProducto.Text = "";
                this.txtProducto.Text = "";
                this.txtReferencia.Text = "";
                this.txtCosto.Text = "";
                this.txtPrecio1.Text = "";
                this.txtPrecio2.Text = "";
                this.txtPrecio3.Text = "";
                this.cmbMoneda.EditValue = null;
                this.txtExistencia.Text = "";
                this.chkNoExistencia.Checked = false;
                this.chkActivo.Checked = false;
                this.chkExonerado.Checked = false;
                this.cmbTipoProducto.EditValue = null;
                this.cmbPrecioXDefecto.EditValue = null;
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

            string idProducto = Convert.ToString(this.txtIdProducto.Text.Trim());
            string producto = Convert.ToString(this.txtProducto.Text.Trim());
            decimal? costo = Convert.ToDecimal(this.txtCosto.EditValue.IsNull(0));
            int? moneda = Convert.ToInt32(this.cmbMoneda.EditValue.IsNull(0));
            decimal? idTipoProducto = Convert.ToDecimal(this.cmbTipoProducto.EditValue.IsNull(0));
            int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue.IsNull(0));

            if (idProducto.Length == 0)
            {
                this.txtIdProducto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (producto.Length == 0)
            {
                this.txtProducto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (costo <= 0)
            {
                this.txtCosto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (idTipoProducto == 0)
            {
                this.cmbTipoProducto.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            else
            {
                CalcularPrecio();
            }
            decimal? precio1 = Convert.ToDecimal(this.txtPrecio1.EditValue.IsNull(0));
            decimal? precio2 = Convert.ToDecimal(this.txtPrecio2.EditValue.IsNull(0));
            decimal? precio3 = Convert.ToDecimal(this.txtPrecio3.EditValue.IsNull(0));
            if (precio1 <= 0)
            {
                this.txtPrecio1.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (precio2 <= 0)
            {
                this.txtPrecio2.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (precio3 <= 0)
            {
                this.txtPrecio3.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (moneda == 0)
            {
                this.cmbMoneda.ErrorText = PublicVar.gstrCampoRequeridoMsg;
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
                decimal idProducto = Convert.ToDecimal(this.vwProductos.GetFocusedRowCellValue("decIdProducto").IsNull(0));
                if (idProducto > 0)
                {
                    this.txtIdProducto.Text = Convert.ToString(idProducto);
                    this.txtProducto.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("strProducto"));
                    this.txtReferencia.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("strReferencia"));
                    this.txtCosto.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("decCosto"));
                    this.txtPrecio1.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("decPrecio1"));
                    this.txtPrecio2.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("decPrecio2"));
                    this.txtPrecio3.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("decPrecio3"));
                    this.cmbMoneda.EditValue = Convert.ToInt32(this.vwProductos.GetFocusedRowCellValue("intMoneda"));
                    using (BD_ERPEntities contexto = new BD_ERPEntities())
                    {
                        tblProductos p = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                        var refDetCotizacion = p.tblDetalleCotizaciones.Count;

                        if (refDetCotizacion > 0)
                        {
                            this.cmbMoneda.ReadOnly = true;
                        }
                        else
                        {
                            this.cmbMoneda.ReadOnly = false;
                        }
                    }
                        this.txtExistencia.Text = Convert.ToString(this.vwProductos.GetFocusedRowCellValue("decExistencia"));
                    this.chkNoExistencia.Checked = Convert.ToBoolean(this.vwProductos.GetFocusedRowCellValue("bitNoExistencia"));
                    this.chkActivo.Checked = Convert.ToBoolean(this.vwProductos.GetFocusedRowCellValue("bitActivo"));
                    this.chkExonerado.Checked = Convert.ToBoolean(this.vwProductos.GetFocusedRowCellValue("bitExonerado"));
                    this.cmbTipoProducto.EditValue = Convert.ToDecimal(this.vwProductos.GetFocusedRowCellValue("decIdTipoProducto"));
                    this.cmbPrecioXDefecto.EditValue = Convert.ToInt32(this.vwProductos.GetFocusedRowCellValue("intIdPrecio"));
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

        private void CalcularPrecio()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal? idTipoProducto = Convert.ToDecimal(this.cmbTipoProducto.EditValue.IsNull(0));
                if (idTipoProducto != 0)
                {
                    using (BD_ERPEntities contexto = new BD_ERPEntities())
                    {

                        tblTipoProductos p = contexto.tblTipoProductos.FirstOrDefault(x => x.decIdTipoProducto == idTipoProducto);
                        this.txtPrecio1.Text = Convert.ToString(Convert.ToDecimal(this.txtCosto.Text) + (Convert.ToDecimal(this.txtCosto.Text) * (p.decIncrementoPrecio1 / 100)));
                        this.txtPrecio2.Text = Convert.ToString(Convert.ToDecimal(this.txtCosto.Text) + (Convert.ToDecimal(this.txtCosto.Text) * (p.decIncrementoPrecio2 / 100)));
                        this.txtPrecio3.Text = Convert.ToString(Convert.ToDecimal(this.txtCosto.Text) + (Convert.ToDecimal(this.txtCosto.Text) * (p.decIncrementoPrecio3 / 100)));
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

        #endregion

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbTipoProducto.Properties.DataSource = contexto.tblTipoProductos.ToList();
                this.repTipoProducto.DataSource = contexto.tblTipoProductos.ToList();
                this.cmbMoneda.Properties.DataSource = contexto.tblMonedas.ToList();                
                this.repMonedas.DataSource = contexto.tblMonedas.ToList();
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
                this.txtIdProducto.Text = "-1";
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


                string producto = Convert.ToString(this.txtProducto.Text.Trim());
                string referencia = Convert.ToString(this.txtReferencia.Text.Trim());
                decimal? costo = Convert.ToDecimal(this.txtCosto.EditValue);
                decimal? precio1 = Convert.ToDecimal(this.txtPrecio1.EditValue);
                decimal? precio2 = Convert.ToDecimal(this.txtPrecio2.EditValue);
                decimal? precio3 = Convert.ToDecimal(this.txtPrecio3.EditValue);
                int? moneda = Convert.ToInt32(this.cmbMoneda.EditValue);
                decimal? existencia = Convert.ToDecimal(this.txtExistencia.EditValue.IsNull(0));
                bool noExistencia = Convert.ToBoolean(this.chkNoExistencia.Checked);
                bool activo = Convert.ToBoolean(this.chkActivo.Checked);
                bool exonerado = Convert.ToBoolean(this.chkExonerado.Checked);
                decimal? idTipoProducto = Convert.ToDecimal(this.cmbTipoProducto.EditValue);
                int? precioxdefecto = Convert.ToInt32(this.cmbPrecioXDefecto.EditValue);

                if (precio1 < costo || precio2 < costo || precio3 < costo)
                {
                    XtraMessageBox.Show(PublicVar.gstrPrecioInvalidoMSg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idProducto = Convert.ToDecimal(this.txtIdProducto.Text);
                    tblProductos p;

                    if (idProducto > 0)
                    {
                        p = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                        p.strProducto = producto;
                        p.strReferencia = referencia;
                        p.decCosto = costo;
                        p.decPrecio1 = precio1;
                        p.decPrecio2 = precio2;
                        p.decPrecio3 = precio3;
                        p.intMoneda = moneda;
                        p.decExistencia = existencia;
                        p.bitNoExistencia = noExistencia;
                        p.bitActivo = activo;
                        p.bitExonerado = exonerado;
                        p.decIdTipoProducto = idTipoProducto;
                        p.intIdPrecio = precioxdefecto;
                        Operacion = TipoOperacion.Modificacion;
                    }
                    else
                    {
                        p = new tblProductos
                        {
                            strProducto = producto,
                            strReferencia = referencia,
                            decCosto = costo,
                            decPrecio1 = precio1,
                            decPrecio2 = precio2,
                            decPrecio3 = precio3,
                            intMoneda = moneda,
                            decExistencia = existencia,
                            bitNoExistencia = noExistencia,
                            bitActivo = activo,
                            bitExonerado = exonerado,
                            decIdTipoProducto = idTipoProducto,
                            intIdPrecio = precioxdefecto,
                        };
                        contexto.tblProductos.Add(p);
                        Operacion = TipoOperacion.Creacion;
                    }
                    contexto.SaveChanges();
                    NumRegistro = Convert.ToString(p.decIdProducto);
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
                decimal idProducto = Convert.ToDecimal(this.txtIdProducto.EditValue);
                if (idProducto > 0)
                {
                    if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (BD_ERPEntities contexto = new BD_ERPEntities())
                        {

                            tblProductos p = contexto.tblProductos.FirstOrDefault(x => x.decIdProducto == idProducto);
                            var refDetCotizacion = p.tblDetalleCotizaciones.Count;
                            var refProdXProveedor = p.tblProductosXProveedor.Count;
                            if (refDetCotizacion > 0 || refProdXProveedor > 0)
                            {
                                XtraMessageBox.Show(PublicVar.gstrErrorLlaveForaneaMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                contexto.tblProductos.Remove(p);
                                Operacion = TipoOperacion.Eliminacion;
                                contexto.SaveChanges();
                                NumRegistro = Convert.ToString(p.decIdProducto);
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

        private void vwProductos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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
