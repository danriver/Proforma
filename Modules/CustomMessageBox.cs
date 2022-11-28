using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proforma.Models;
using Proforma.Modules;

namespace Proforma.Modules
{
    public static class CustomMessageBox
    {
        public static void Show(Exception exception, Form frm)
        {
            try
            {
                using (var context = new BD_ERPEntities())
                {
                    var formulario = context.tblFormularios.Where(x => x.strNombreFormulario == frm.Name).FirstOrDefault();
                    if (formulario != null)
                    {
                        var error = new tblErrores
                        {
                            strError = exception.Message,
                            decIdFormulario = formulario.decIdFormulario,
                            strStackTrace = exception.StackTrace,
                            decIdUsuario = PublicVar.gdecIdUser,
                            datFecha=DateTime.Now.GetDateDB()
                        };
                        context.tblErrores.Add(error);
                        context.SaveChanges();
                    }
                }
                XtraMessageBox.Show(exception.Message, PublicVar.gstrTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, PublicVar.gstrTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
