using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proforma.Models;
using static System.Windows.Forms.Control;

namespace Proforma.Modules
{
    public static class PermissionObjects
    {
        public static void CargarPermisos(Form frmObjects)
        {
            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                var formulario = context.tblFormularios.Where(x => x.strNombreFormulario == frmObjects.Name).FirstOrDefault();
                if (formulario != null)
                {
                    var lstPermisos = context.spRolPermisos(PublicVar.gdecIdRol, formulario.decIdFormulario);
                    if (lstPermisos != null)
                    {
                        foreach (var permiso in lstPermisos)
                        {
                            BuscadorControl(frmObjects.Controls, permiso.strNombreObjeto, permiso.bitActivo);
                        }
                    }
                }
            }
        }

        public static void CargarEventoControles(Form frm, bool tiempo = false)
        {
            if (tiempo)
            {
                frm.MouseMove += Control_MouseMove;
                frm.KeyDown += Control_KeyDown;
                BuscadorControl(frm.Controls, timer: tiempo);
            }
        }

        private static void BuscadorControl(ControlCollection controls, string nombre = "", bool activo = false, bool timer = false)
        {
            foreach (Control control in controls)
            {
                if (timer == false)
                {
                    if (control.Name == nombre)
                    {
                        control.Enabled = activo;
                    }
                    else if (control is DevExpress.XtraEditors.PanelControl || control is DevExpress.XtraEditors.GroupControl ||
                            control is DevExpress.XtraEditors.XtraScrollableControl || control is DevExpress.XtraTab.XtraTabPage ||
                            control is DevExpress.XtraLayout.LayoutControl || control is DevExpress.XtraTab.XtraTabControl ||
                            control is DevExpress.XtraBars.Navigation.TabPane || control is DevExpress.XtraBars.Navigation.NavigationPane ||
                            control is DevExpress.XtraBars.Navigation.NavigationPage || control is DevExpress.XtraBars.Navigation.TabNavigationPage ||
                            control is DevExpress.XtraBars.Docking.DockPanel || control is DevExpress.XtraBars.Docking.AutoHideContainer ||
                            control is DevExpress.XtraBars.Docking.ControlContainer)
                    {
                        if (control.Name == nombre)
                        {
                            control.Enabled = activo;
                        }
                        BuscadorRecursivo(control, nombre, activo);
                    }
                    else if (control is DevExpress.XtraBars.Ribbon.RibbonControl)
                    {
                        BuscadorRibbon(control as DevExpress.XtraBars.Ribbon.RibbonControl, nombre, activo);
                    }
                    else if (control is DevExpress.XtraGrid.GridControl)
                    {
                        BuscadorControlGrid(control as DevExpress.XtraGrid.GridControl, nombre, activo);
                    }
                }
                else
                {
                    control.MouseClick += Control_MouseClick;
                    control.MouseMove += Control_MouseMove;
                    control.KeyDown += Control_KeyDown;

                    if (control is DevExpress.XtraEditors.PanelControl || control is DevExpress.XtraEditors.GroupControl ||
                            control is DevExpress.XtraEditors.XtraScrollableControl || control is DevExpress.XtraTab.XtraTabPage ||
                            control is DevExpress.XtraLayout.LayoutControl || control is DevExpress.XtraTab.XtraTabControl ||
                            control is DevExpress.XtraBars.Navigation.TabPane || control is DevExpress.XtraBars.Navigation.NavigationPane ||
                            control is DevExpress.XtraBars.Navigation.NavigationPage || control is DevExpress.XtraBars.Navigation.TabNavigationPage ||
                            control is DevExpress.XtraBars.Docking.DockPanel || control is DevExpress.XtraBars.Docking.AutoHideContainer ||
                            control is DevExpress.XtraBars.Docking.ControlContainer)
                    {
                        BuscadorRecursivo(control, timer: timer);
                    }
                }

            }
        }



        private static void BuscadorRecursivo(Control ctrl, string nombre = "", bool activo = false, bool timer = false)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (timer == false)
                {
                    if (control.Name == nombre)
                    {
                        control.Enabled = activo;
                    }
                    else if (control is DevExpress.XtraEditors.PanelControl || control is DevExpress.XtraEditors.GroupControl ||
                            control is DevExpress.XtraEditors.XtraScrollableControl || control is DevExpress.XtraTab.XtraTabPage ||
                            control is DevExpress.XtraLayout.LayoutControl || control is DevExpress.XtraTab.XtraTabControl ||
                            control is DevExpress.XtraBars.Navigation.TabPane || control is DevExpress.XtraBars.Navigation.NavigationPane ||
                            control is DevExpress.XtraBars.Navigation.NavigationPage || control is DevExpress.XtraBars.Navigation.TabNavigationPage ||
                            control is DevExpress.XtraBars.Docking.DockPanel || control is DevExpress.XtraBars.Docking.AutoHideContainer ||
                            control is DevExpress.XtraBars.Docking.ControlContainer)
                    {
                        if (control.Name == nombre)
                        {
                            control.Enabled = activo;
                        }
                        BuscadorRecursivo(control, nombre, activo);
                    }
                    else if (control is DevExpress.XtraBars.Ribbon.RibbonControl)
                    {
                        BuscadorRibbon(control as DevExpress.XtraBars.Ribbon.RibbonControl, nombre, activo);
                    }
                    else if (control is DevExpress.XtraGrid.GridControl)
                    {
                        BuscadorControlGrid(control as DevExpress.XtraGrid.GridControl, nombre, activo);
                    }
                }
                else
                {
                    control.MouseClick += Control_MouseClick;
                    control.MouseMove += Control_MouseMove;
                    control.KeyDown += Control_KeyDown;

                    if (control is DevExpress.XtraEditors.PanelControl || control is DevExpress.XtraEditors.GroupControl ||
                            control is DevExpress.XtraEditors.XtraScrollableControl || control is DevExpress.XtraTab.XtraTabPage ||
                            control is DevExpress.XtraLayout.LayoutControl || control is DevExpress.XtraTab.XtraTabControl ||
                            control is DevExpress.XtraBars.Navigation.TabPane || control is DevExpress.XtraBars.Navigation.NavigationPane ||
                            control is DevExpress.XtraBars.Navigation.NavigationPage || control is DevExpress.XtraBars.Navigation.TabNavigationPage ||
                            control is DevExpress.XtraBars.Docking.DockPanel || control is DevExpress.XtraBars.Docking.AutoHideContainer ||
                            control is DevExpress.XtraBars.Docking.ControlContainer)
                    {
                        BuscadorRecursivo(control, timer: timer);
                    }
                }

            }
        }

        private static void BuscadorRibbon(DevExpress.XtraBars.Ribbon.RibbonControl ctrl, string nombre = "", bool activo = false)
        {
            foreach (DevExpress.XtraBars.BarItem item in ctrl.Items)
            {
                if (item.Name == nombre)
                {
                    item.Enabled = activo;
                }
            }
        }

        private static void BuscadorControlGrid(DevExpress.XtraGrid.GridControl ctrl, string nombre, bool activo)
        {
            foreach (DevExpress.XtraGrid.Views.Grid.GridView view in ctrl.Views)
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                {
                    if (col.ColumnEdit != null)
                    {
                        if (col.ColumnEdit.Name == nombre)
                        {
                            if (col.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)
                            {
                                (col.ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit).Buttons[0].Enabled = activo;
                            }
                        }
                    }
                }
            }
        }

        private static void Control_MouseClick(object sender, MouseEventArgs e)
        {
            PublicVar.gintContadorInactivo = 0;
        }

        private static void Control_MouseMove(object sender, MouseEventArgs e)
        {
            PublicVar.gintContadorInactivo = 0;
        }

        private static void Control_KeyDown(object sender, KeyEventArgs e)
        {
            PublicVar.gintContadorInactivo = 0;
        }
    }
}
