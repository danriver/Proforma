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
    public partial class frmTasaCambio : Proforma.Forms.frmServer
    {
        #region Variables
        public string Operacion, TipoRegistro = "Tasa de Cambio", NumRegistro;
        #endregion

        public frmTasaCambio()
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
                this.grdTasa.DataSource = contexto.tblCambioMoneda.ToList();
                this.vwTasa.BestFitColumns();
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
                this.dtFecha.EditValue = null;
                this.spDias.EditValue = 1;
                this.txtTasa.EditValue = 0;
                this.rdOpcion.EditValue = 1;
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
            BD_ERPEntities contexto = new BD_ERPEntities();
            DateTime fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
            DateTime datFecha = Convert.ToDateTime(this.dtFecha.EditValue);
            int? dias = Convert.ToInt32(this.spDias.EditValue.IsNull(0));
            decimal? tasaInicial = Convert.ToDecimal(this.txtTasa.EditValue.IsNull(0));
            int? opcion = Convert.ToInt32(this.rdOpcion.EditValue.IsNull(0));
            decimal? deslizamiento = Convert.ToDecimal(this.txtDeslizamiento.EditValue.IsNull(0));

            if (datFecha.Date >= fecha)
            {
                if (datFecha == fecha)
                {
                    tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => Convert.ToDateTime(x.datFechaCreacion).Date == datFecha);

                    if (cot != null)
                    {
                        this.dtFecha.ErrorText = PublicVar.gstrTasaEnRegistrosMsg;
                        result = false;
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                this.dtFecha.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (dias == 0)
            {
                this.spDias.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (tasaInicial == 0)
            {
                this.txtTasa.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            if (opcion == 0)
            {
                this.spDias.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                result = false;
            }
            else if (opcion == 2)
            {
                if (deslizamiento == 0)
                {
                    this.txtDeslizamiento.ErrorText = PublicVar.gstrCampoRequeridoMsg;
                    result = false;
                }                
            }

            return result;
        }

        #endregion

        private void frmTasaCambio_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                BD_ERPEntities contexto = new BD_ERPEntities();
                CargarGrid();
                this.rdOpcion.EditValue = 1;
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

        private void rdOpcion_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.rdOpcion.EditValue) == 1)
            {
                this.txtDeslizamiento.Text = "";
                this.txtDeslizamiento.ReadOnly = true;
            }   
            else if (Convert.ToInt32(this.rdOpcion.EditValue) == 2)
            {
                this.txtDeslizamiento.ReadOnly = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                DateTime fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                DateTime datFecha = Convert.ToDateTime(this.dtFecha.EditValue);
                int? dias = Convert.ToInt32(this.spDias.EditValue);
                decimal? tasaInicial = Convert.ToDecimal(this.txtTasa.EditValue);
                int? opcion = Convert.ToInt32(this.rdOpcion.EditValue);
                decimal? deslizamiento = Convert.ToDecimal(this.txtDeslizamiento.EditValue.IsNull(0));

                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    for (int i = 1; i <= dias; i++)
                    {
                        tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == datFecha);
                        if (mn != null)
                        {
                            mn.decTipoCambio = Convert.ToDecimal(tasaInicial);
                            Operacion = TipoOperacion.Modificacion;
                        }
                        else
                        {
                            mn = new tblCambioMoneda
                            {
                                datFecha = datFecha,
                                decTipoCambio = Convert.ToDecimal(tasaInicial),
                                decIdConfiguracion = 1,
                            };
                            contexto.tblCambioMoneda.Add(mn);
                            Operacion = TipoOperacion.Creacion;
                        }
                        contexto.SaveChanges();
                        NumRegistro = Convert.ToString(mn.datFecha);
                        AgregarBitacora(Operacion, TipoRegistro, NumRegistro);
                        
                        if (opcion == 1)
                        {

                        }
                        else if (opcion == 2)
                        {
                            tasaInicial = tasaInicial + deslizamiento;
                        }
                        datFecha = datFecha.AddDays(1);
                    }
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

        private void vwTasa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.btnAgregar.Enabled)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        BD_ERPEntities contexto = new BD_ERPEntities();
                        DateTime fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
                        DateTime datFecha = Convert.ToDateTime(this.vwTasa.GetFocusedRowCellValue("datFecha"));
                        if (datFecha >= fecha)
                        {
                            bool bAplica = false;
                            if (datFecha == fecha)
                            {
                                tblCotizaciones cot = contexto.tblCotizaciones.FirstOrDefault(x => Convert.ToDateTime(x.datFechaCreacion).Date == datFecha);

                                if (cot != null)
                                {
                                    bAplica = false;
                                }
                                else
                                {
                                    bAplica = true;
                                }
                            }
                            else
                            {
                                bAplica = true;
                            }
                            if (bAplica)
                            {
                                tblCambioMoneda det = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == datFecha);
                                if (XtraMessageBox.Show(PublicVar.gstrDeleteDataMsg, PublicVar.gstrTitleWarning,
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    contexto.tblCambioMoneda.Remove(det);
                                    contexto.SaveChanges();
                                    CargarGrid();
                                }
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
    }
}
