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
using Proforma.Models;
using System.IO;
using System.Windows;

namespace Proforma.Forms
{
    public partial class frmServer : DevExpress.XtraEditors.XtraForm
    {

        #region Variables

        public string gstrUsername = "";
        public decimal gdecIdUser = 0;
        public decimal gdecIdRol = 0;
        private bool? inDesignMode;
        public BD_ERPEntities BDContext = new BD_ERPEntities();

        #endregion

        public frmServer()
        {
            InitializeComponent();
        }

        #region Metodos

        public bool IsDesignMode
        {
            get
            {
                if (inDesignMode == null)
                {
                    var prop = DesignerProperties.IsInDesignModeProperty;

                    inDesignMode = (bool)DependencyPropertyDescriptor
                        .FromProperty(prop, typeof(FrameworkElement))
                        .Metadata.DefaultValue;

                    if (!inDesignMode.GetValueOrDefault(false) && System.Diagnostics.Process.GetCurrentProcess().ProcessName.StartsWith("devenv", StringComparison.Ordinal))
                        inDesignMode = true;
                }

                return inDesignMode.GetValueOrDefault(false);
            }
        }

        public void AgregarBitacora(string Operacion, string TipoRegistro, string NumRegistro)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblBitacoras b = new tblBitacoras
                    {
                        decIdUsuario = gdecIdUser,
                        datFechaOperacion = DateTime.Now.GetDateDB(),
                        strOperacion = Operacion,
                        strTipoRegistro = TipoRegistro,
                        decNumRegistro = NumRegistro,
                    };
                    contexto.tblBitacoras.Add(b);
                    contexto.SaveChanges();
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

        public void CargarLogo(Form frmParent = null)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblConfiguracion b = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                    if (b != null)
                    {
                        string direccionLogo = b.strDireccionLogo ?? "";

                        if (direccionLogo.Length > 0)
                        {
                            using (NetworkShareAccesser.Access(PublicVar.gstrServername, PublicVar.gstrServeruser, PublicVar.gstrServerpassword))
                            {
                                if (File.Exists(direccionLogo))
                                {
                                    Bitmap myBitmap = new Bitmap(direccionLogo);
                                    Bitmap copia = new Bitmap(myBitmap);
                                    IntPtr Hicon = copia.GetHicon();
                                    Icon newIcon = Icon.FromHandle(Hicon);
                                    myBitmap.Dispose();
                                    if (frmParent != null)
                                    {
                                        frmParent.Icon = newIcon;
                                    }
                                    else
                                    {
                                        this.Icon = newIcon;
                                    }
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

        #endregion 

        private void FrmServer_Load(object sender, EventArgs e)
        {
            if (!IsDesignMode)
            {
                try
                {
                    gstrUsername = PublicVar.gstrUsername;
                    gdecIdUser = PublicVar.gdecIdUser;
                    gdecIdRol = PublicVar.gdecIdRol;
                    PermissionObjects.CargarPermisos(this);
                    PermissionObjects.CargarEventoControles(this, true);
                    CargarLogo();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex, this);
                }
            }
        }
    }
}