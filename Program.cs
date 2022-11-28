using DevExpress.XtraLayout;
using DevExpress.UserSkins;
using Proforma.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proforma
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cursor.Current = Cursors.WaitCursor;
            BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LayoutControl.AllowCustomizationDefaultValue = false;
            Application.Run(new frmLogin());
            Cursor.Current = Cursors.Default;
        }
    }
}
