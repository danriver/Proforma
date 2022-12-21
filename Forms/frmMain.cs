using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Proforma.Modules;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.Deployment.Application;
using DevExpress.XtraBars.Alerter;
using Proforma.Models;

namespace Proforma.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables 

        public frmServer frm = new frmServer();
        private ApplicationDeployment appDeployment;
        private UpdateCheckInfo updateInfo;

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region Metodos

        private void AbrirFormulario(Form frmTemp, Form frmParent = null)
        {
            if ((Application.OpenForms[frmTemp.Name]) as Form != null)
            {
                Form frmOpen = Application.OpenForms[frmTemp.Name];
                frmOpen.BringToFront();
                frmOpen.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (frmOpen.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (frmOpen.Size.Height / 2));
            }
            else
            {
                if (frmParent != null)
                {
                    frmTemp.MdiParent = frmParent;
                    frmTemp.Show();
                }
                else
                {
                    frmTemp.Show(this);
                }
            }
        }

        private void BloquearFormularios()
        {
            foreach (Form openFrm in Application.OpenForms)
            {
                openFrm.Enabled = false;
            }
        }

        private void ActualizarSistema(bool timer)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                appDeployment = ApplicationDeployment.CurrentDeployment;
                updateInfo = appDeployment.CheckForDetailedUpdate();
                if (updateInfo.UpdateAvailable)
                {
                    if (timer)
                    {
                        AlertInfo info = new AlertInfo(PublicVar.gstrTitleInfo, PublicVar.gstrUpdateExistMsg);
                        alertControlInfo.Show(this, info);
                    }
                    else
                    {
                        BloquearFormularios();
                        progressBarControlUpdate.Visible = true;
                        if (XtraMessageBox.Show(PublicVar.gstrUpdateWaitMsg, PublicVar.gstrTitleInfo, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            appDeployment.UpdateProgressChanged += ADUpdate_UpdateProgressChanged;
                            appDeployment.UpdateCompleted += ADUpdate_UpdateCompleted;
                            appDeployment.UpdateAsync();
                        }
                    }
                }
                else
                {
                    VerificarTasa();
                }
            }
            else
            {
                VerificarTasa();
            }
        }

        private void VerificarTasa()
        {
            BD_ERPEntities contexto = new BD_ERPEntities();
            DateTime fecha;
            decimal tasa = 0;

            fecha = Convert.ToDateTime(DateTime.Now.GetDateDB()).Date;
            tblCambioMoneda mn = contexto.tblCambioMoneda.FirstOrDefault(x => x.datFecha == fecha);
            if (mn != null)
            {
                tasa = Convert.ToDecimal(mn.decTipoCambio.IsNull(0));
            }

            if (tasa <= 0)
            {
                var resp = XtraMessageBox.Show(PublicVar.gstrTasaNoExistMsg, PublicVar.gstrTitleInfo,
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resp == DialogResult.OK)
                {
                    AbrirFormulario(new frmTasaCambio());
                }
            }
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUsuario.Caption = PublicVar.gstrUsername;
            PermissionObjects.CargarPermisos(this);
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default.ApplicationSkinName;
            UserLookAndFeel.Default.SkinMaskColor = Properties.Settings.Default.SkinMaskColor;
            frm.CargarLogo(this);
        }

        private void RibbonControlAdministracion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            switch (e.Item.Name)
            {
                case "mnuProformas":
                    AbrirFormulario(new frmProforma(), this);
                    break;

                case "mnuUsuarios":
                    AbrirFormulario(new frmUsuarios());
                    break;

                case "mnuRoles":
                    AbrirFormulario(new frmRoles());
                    break;

                case "mnuVendedores":
                    AbrirFormulario(new frmVendedores());
                    break;

                case "mnuProveedores":
                    AbrirFormulario(new frmProveedores());
                    break;

                case "mnuClientes":
                    AbrirFormulario(new frmClientes());
                    break;

                case "mnuTipoProductos":
                    AbrirFormulario(new frmTipoProductos());
                    break;

                case "mnuProductos":
                    AbrirFormulario(new frmProductos());
                    break;

                case "mnuConfiguraciones":
                    AbrirFormulario(new frmConfiguracion());
                    break;

                case "mnuConsultasCotizaciones":
                    AbrirFormulario(new frmConsultasCotizaciones());
                    break;

                case "mnuBitacora":
                    AbrirFormulario(new frmBitacora(), this);
                    break;

                case "mnuReportes":
                    AbrirFormulario(new frmAsistenteReportes());
                    break;

                case "mnuTasaCambio":
                    AbrirFormulario(new frmTasaCambio());
                    break;
            }
            Cursor = Cursors.Default;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ApplicationSkinName = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            Properties.Settings.Default.Save();
        }

        private void ADUpdate_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            try
            {
                progressBarControlUpdate.EditValue = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void ADUpdate_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception(e.Error.Message, e.Error);
                }
                else
                {
                    XtraMessageBox.Show(PublicVar.gstrUpdateCompletedMsg, PublicVar.gstrTitleInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                ActualizarSistema(false);

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void ribbonControlAdministracion_ApplicationButtonClick(object sender, EventArgs e)
        {
            try
            {
                PermissionObjects.CargarPermisos(this);
                ActualizarSistema(false);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }

        private void timerInactivo_Tick(object sender, EventArgs e)
        {
            try
            {
                PublicVar.gintContadorInactivo += 5;
                if (PublicVar.gintContadorInactivo >= 60)
                {
                    timerInactivo.Stop();
                    XtraMessageBox.Show(PublicVar.gstrInactiveTimeMsg, PublicVar.gstrTitleInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Restart();
                }
                else
                {
                    ActualizarSistema(true);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex, this);
            }
        }
    }
}