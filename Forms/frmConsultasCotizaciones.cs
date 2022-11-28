using Proforma.Models;
using Proforma.Modules;
using Proforma.Reports;
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
    public partial class frmConsultasCotizaciones : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro = "Listado de Cotizaciones", NumRegistro;
        #endregion               

        public frmConsultasCotizaciones()
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
                this.grdCotizacionEnc.DataSource = contexto.tblCotizaciones.ToList();
                this.vwCotizacionEnc.BestFitColumns();
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

        private void CargarDatos(decimal idCotizacion)
        {
            try
            {
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.grdCotizacionDet.DataSource = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion).ToList();
                this.vwCotizacionDet.BestFitColumns();
                ActualizarTotales(idCotizacion);
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

        private void ActualizarTotales(decimal numCotizacion)
        {
            decimal idCotizacion = numCotizacion;
            decimal subtotal, iva, total, equiv;
            DateTime fecha;
            string simbprinc = "", simbsecun = "";
            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                var detalle = contexto.tblDetalleCotizaciones.Where(x => x.decIdCotizacion == idCotizacion);
                var monedas = contexto.tblMonedas.ToList();
                tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                if (idCotizacion > 0)
                {
                    tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                    fecha = cot.datFechaCreacion.Date;
                }
                else
                {
                    fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                }
                tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
                if (detalle.Any())
                {
                    subtotal = (decimal)detalle.Sum(x => x.decPrecio * x.decCantidad);
                    iva = subtotal * (Convert.ToDecimal(con.decPorcentajeIVA) / 100);
                    total = subtotal + iva;
                    if (Convert.ToInt32(con.intMoneda) == 1)
                    {
                        equiv = total / mn.decTipoCambio;
                        simbprinc = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strSimbolo);
                        simbsecun = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strSimbolo);
                    }
                    else
                    {
                        equiv = total * mn.decTipoCambio;
                        simbprinc = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strSimbolo);
                        simbsecun = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strSimbolo);
                    }
                }
                else
                {
                    subtotal = 0;
                    iva = 0;
                    total = 0;
                    equiv = 0;
                }
            }
            this.txtSubtotal.Text = String.Format("{1} {0:n2}", subtotal, simbprinc);
            this.txtIVA.Text = String.Format("{1} {0:n2}", iva, simbprinc);
            this.txtTotal.Text = String.Format("{1} {0:n2}", total, simbprinc);
            this.txtTotalEquiv.Text = String.Format("{1} {0:n2}", equiv, simbsecun);
        }

        private void Imprimir(decimal idCotizacion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                xrpCotizacion report = new xrpCotizacion();
                bool bSAC = Convert.ToBoolean(this.chkSAC.Checked);
                report.SetFilter(idCotizacion, bSAC);
                report.DisplayName = "Cotización " + Convert.ToString(cot.strNumCotizacion);
                frmReport window = new frmReport();
                window.documentViewer1.DocumentSource = report;
                window.Text = "Cotización " + Convert.ToString(cot.strNumCotizacion);
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                window.Show(this.Owner, TipoRegistro, NumRegistro);
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

        private void Enviar(decimal idCotizacion)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);
                xrpCotizacion report = new xrpCotizacion();
                bool bSAC = Convert.ToBoolean(this.chkSAC.Checked);
                report.SetFilter(idCotizacion, bSAC);
                report.DisplayName = "Cotización " + Convert.ToString(cot.strNumCotizacion);
                NumRegistro = Convert.ToString(cot.strNumCotizacion);
                string ruta = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + report.DisplayName + ".pdf");
                report.ExportToPdf(ruta);
                CustomMail mail = new CustomMail();
                mail.EnviarCorreo((decimal)cot.decIdVendedor, (decimal)cot.decIdContacto, rutaArchivo: ruta);
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

        private void frmConsultasCotizaciones_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                this.cmbClientes.Properties.DataSource = contexto.tblClientes.ToList();
                this.dtInicio.DateTime = DateTime.Now;
                this.dtFin.DateTime = DateTime.Now;
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

        private void vwCotizacionEnc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                decimal idCotizacion = Convert.ToDecimal(vwCotizacionEnc.GetRowCellValue(e.RowHandle, "decIdCotizacion"));
                CargarDatos(idCotizacion);
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

        private void vwCotizacionEnc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                decimal idCotizacion = Convert.ToDecimal(vwCotizacionEnc.GetFocusedRowCellValue("decIdCotizacion"));
                CargarDatos(idCotizacion);
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

        private void chkSAC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.chkSAC.Checked)
                {
                    this.vwCotizacionDet.Columns["tblProductos.strReferencia"].VisibleIndex = 3;
                    this.vwCotizacionDet.Columns["tblProductos.strReferencia"].Visible = true;
                }
                else
                {
                    this.vwCotizacionDet.Columns["tblProductos.strReferencia"].Visible = false;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(vwCotizacionEnc.GetFocusedRowCellValue("decIdCotizacion"));
                frmProforma frmTemp = new frmProforma();
                if (idCotizacion > 0)
                {
                    frmTemp.Show(this.Owner, idCotizacion);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    decimal idCotizacion = Convert.ToDecimal(vwCotizacionEnc.GetFocusedRowCellValue("decIdCotizacion"));
                    if (idCotizacion <= 0)
                    {

                    }
                    else
                    {
                        tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => x.decIdCotizacion == idCotizacion);

                        if (cot.intEstadoCotizacion == 2 || cot.intEstadoCotizacion == 3)
                        {
                            Imprimir(idCotizacion);
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal idCotizacion = Convert.ToDecimal(vwCotizacionEnc.GetFocusedRowCellValue("decIdCotizacion"));
                Enviar(idCotizacion);
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
