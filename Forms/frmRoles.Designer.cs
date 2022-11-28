
namespace Proforma.Forms
{
    partial class frmRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tlstPermisos = new DevExpress.XtraTreeList.TreeList();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombreRol = new DevExpress.XtraEditors.TextEdit();
            this.txtIdRol = new DevExpress.XtraEditors.TextEdit();
            this.grdRoles = new DevExpress.XtraGrid.GridControl();
            this.tblRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdVwRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlstPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tlstPermisos);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnNuevo);
            this.layoutControl1.Controls.Add(this.txtNombreRol);
            this.layoutControl1.Controls.Add(this.txtIdRol);
            this.layoutControl1.Controls.Add(this.grdRoles);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(923, 204, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(849, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tlstPermisos
            // 
            this.tlstPermisos.Location = new System.Drawing.Point(491, 12);
            this.tlstPermisos.Name = "tlstPermisos";
            this.tlstPermisos.OptionsView.AutoWidth = false;
            this.tlstPermisos.Size = new System.Drawing.Size(346, 444);
            this.tlstPermisos.TabIndex = 0;
            this.tlstPermisos.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tlstPermisos_BeforeCheckNode);
            this.tlstPermisos.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlstPermisos_AfterCheckNode);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.ImageUri.Uri = "Delete;Size16x16";
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(332, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 22);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.ToolTip = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(178, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 22);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.ToolTip = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNuevo.Location = new System.Drawing.Point(24, 69);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 22);
            this.btnNuevo.StyleController = this.layoutControl1;
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.ToolTip = "Agregar Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(220, 45);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(255, 20);
            this.txtNombreRol.StyleController = this.layoutControl1;
            this.txtNombreRol.TabIndex = 6;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(65, 45);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Properties.ReadOnly = true;
            this.txtIdRol.Size = new System.Drawing.Size(69, 20);
            this.txtIdRol.StyleController = this.layoutControl1;
            this.txtIdRol.TabIndex = 5;
            this.txtIdRol.EditValueChanged += new System.EventHandler(this.txtIdRol_EditValueChanged);
            // 
            // grdRoles
            // 
            this.grdRoles.DataSource = this.tblRolesBindingSource;
            this.grdRoles.Location = new System.Drawing.Point(12, 107);
            this.grdRoles.MainView = this.grdVwRoles;
            this.grdRoles.Name = "grdRoles";
            this.grdRoles.Size = new System.Drawing.Size(475, 349);
            this.grdRoles.TabIndex = 4;
            this.grdRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwRoles});
            // 
            // tblRolesBindingSource
            // 
            this.tblRolesBindingSource.DataSource = typeof(Proforma.Models.tblRoles);
            // 
            // grdVwRoles
            // 
            this.grdVwRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdRol,
            this.colstrNombreRol});
            this.grdVwRoles.GridControl = this.grdRoles;
            this.grdVwRoles.Name = "grdVwRoles";
            this.grdVwRoles.OptionsBehavior.Editable = false;
            this.grdVwRoles.OptionsView.ShowGroupPanel = false;
            this.grdVwRoles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwRoles_RowClick);
            // 
            // coldecIdRol
            // 
            this.coldecIdRol.Caption = "ID Rol";
            this.coldecIdRol.FieldName = "decIdRol";
            this.coldecIdRol.Name = "coldecIdRol";
            this.coldecIdRol.Visible = true;
            this.coldecIdRol.VisibleIndex = 0;
            // 
            // colstrNombreRol
            // 
            this.colstrNombreRol.Caption = "Nombre de Rol";
            this.colstrNombreRol.FieldName = "strNombreRol";
            this.colstrNombreRol.Name = "colstrNombreRol";
            this.colstrNombreRol.Visible = true;
            this.colstrNombreRol.VisibleIndex = 1;
            this.colstrNombreRol.Width = 410;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup1,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(849, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdRoles;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(479, 353);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(479, 95);
            this.layoutControlGroup1.Text = "Datos";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txtIdRol;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem2.Text = "ID Rol :";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.txtNombreRol;
            this.layoutControlItem3.Location = new System.Drawing.Point(114, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem3.Text = "Nombre de Rol :";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNuevo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(154, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(154, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "btnGuardar";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnGuardar;
            this.layoutControlItem6.Location = new System.Drawing.Point(154, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(154, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(154, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "btnGuardar";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnEliminar;
            this.layoutControlItem7.Location = new System.Drawing.Point(308, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(147, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(147, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(147, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "btnEliminar";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tlstPermisos;
            this.layoutControlItem8.Location = new System.Drawing.Point(479, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(350, 448);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 468);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRoles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlstPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtNombreRol;
        private DevExpress.XtraEditors.TextEdit txtIdRol;
        private DevExpress.XtraGrid.GridControl grdRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwRoles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource tblRolesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdRol;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreRol;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraTreeList.TreeList tlstPermisos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
