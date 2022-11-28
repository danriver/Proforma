using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proforma.Models;
using Proforma.Modules;
using System.Linq;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;

namespace Proforma.Forms
{
    public partial class frmLogin : Proforma.Forms.frmServer
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CargarFoto();
        }

        private void TxtContrasena_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '\0';
        }

        private void TxtContrasena_MouseMove(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '•';
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = SystemProtected.EncriptarCadena(txtContrasena.Text);

                var tblUsuario = context.tblUsuarios.Where(x => x.strUsuario == usuario && x.strContrasena == contrasena).FirstOrDefault();
                if (tblUsuario == null)
                {
                    XtraMessageBox.Show(PublicVar.gstrUserPassIncorrectMsg, PublicVar.gstrTitleWarning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cursor = Cursors.Default;
                    return;
                }

                if (tblUsuario.bitActivo == false)
                {
                    XtraMessageBox.Show(PublicVar.gstrUserInactiveMsg, PublicVar.gstrTitleWarning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cursor = Cursors.Default;
                    return;
                }

                PublicVar.gstrUsername = tblUsuario.strUsuario;
                PublicVar.gdecIdUser = tblUsuario.decIdUsuario;
                PublicVar.gdecIdRol = tblUsuario.decIdRol ?? 0;

                frmMain frmMainTemp = new frmMain();
                this.Hide();
                frmMainTemp.Show(this);
            }
            Cursor = Cursors.Default;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarFoto()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (BD_ERPEntities contexto = new BD_ERPEntities())
                {
                    tblConfiguracion b = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);
                    if (b != null)
                    {
                        string direccionFoto = b.strRutaFoto ?? "";

                        if (direccionFoto.Length > 0)
                        {                            
                            using (NetworkShareAccesser.Access(PublicVar.gstrServername, PublicVar.gstrServeruser, PublicVar.gstrServerpassword))
                            {
                                if (File.Exists(direccionFoto))
                                {
                                    Image myImage = Image.FromFile(direccionFoto);
                                    Image copia = new Bitmap(myImage);
                                    this.picLogo.Image = copia;
                                    this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                                    myImage.Dispose();
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
