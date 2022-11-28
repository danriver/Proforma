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
    public partial class frmProductosXProveedor : Proforma.Forms.frmServer
    {
        #region Variables
        public decimal IdProveedor;
        public string Operacion, TipoRegistro = "Producto por Proveedor", NumRegistro;
        #endregion

        public frmProductosXProveedor()
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
                this.grdProductosxProveedor.DataSource = contexto.Sp_ProductosXProveedor(IdProveedor).ToList();
                this.vwProductosxProveedor.BestFitColumns();
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

        public void Show(Form frmParent, decimal decIdProveedor)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                IdProveedor = decIdProveedor;
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

        private void frmProductosXProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.repositoryItemLookUpEdit1.DataSource = contexto.tblProductos.ToList();
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

        private void vwProductosxProveedor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (e.Column.FieldName == "Agregado")
                {
                    using (BD_ERPEntities contexto = new BD_ERPEntities())
                    {
                        bool bSeleccionado = Convert.ToBoolean(vwProductosxProveedor.GetRowCellValue(e.RowHandle, "Agregado"));
                        decimal decIdProducto = Convert.ToDecimal(vwProductosxProveedor.GetRowCellValue(e.RowHandle, "Producto"));
                        tblProductosXProveedor PxP;
                        if (bSeleccionado == true)
                        {
                            PxP = new tblProductosXProveedor
                            {
                                decIdProveedor = IdProveedor,
                                decIdProducto = decIdProducto,
                            };
                            contexto.tblProductosXProveedor.Add(PxP);
                            Operacion = TipoOperacion.Creacion;
                        }
                        else
                        {
                            PxP = contexto.tblProductosXProveedor.FirstOrDefault(x => x.decIdProveedor == IdProveedor && x.decIdProducto == decIdProducto);
                            contexto.tblProductosXProveedor.Remove(PxP);
                            Operacion = TipoOperacion.Eliminacion;
                        }
                        contexto.SaveChanges();
                        NumRegistro = Convert.ToString("Proveedor: " + PxP.decIdProveedor + ", Producto: " + PxP.decIdProducto);
                        AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                        CargarGrid();
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
