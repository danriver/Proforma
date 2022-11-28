
namespace Proforma.Forms
{
    partial class frmUsuarios
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
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cboVendedor = new DevExpress.XtraEditors.LookUpEdit();
            this.tblVendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdUsuarios = new DevExpress.XtraGrid.GridControl();
            this.tblUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdVwUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpCboRol = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tblRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coldecIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpCboVendedore = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colbitActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboRol = new DevExpress.XtraEditors.LookUpEdit();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCboRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCboVendedore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkActivo);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnNuevo);
            this.layoutControl1.Controls.Add(this.cboVendedor);
            this.layoutControl1.Controls.Add(this.grdUsuarios);
            this.layoutControl1.Controls.Add(this.cboRol);
            this.layoutControl1.Controls.Add(this.txtContrasena);
            this.layoutControl1.Controls.Add(this.txtNombreUsuario);
            this.layoutControl1.Controls.Add(this.txtUsuario);
            this.layoutControl1.Controls.Add(this.txtIdUsuario);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(690, 148, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(598, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(521, 45);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkActivo.Size = new System.Drawing.Size(53, 20);
            this.chkActivo.StyleController = this.layoutControl1;
            this.chkActivo.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.ImageUri.Uri = "Delete;Size16x16";
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(392, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 22);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.ToolTip = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(208, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 22);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.ToolTip = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNuevo.Location = new System.Drawing.Point(24, 117);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(180, 22);
            this.btnNuevo.StyleController = this.layoutControl1;
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.ToolTip = "Agregar Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // cboVendedor
            // 
            this.cboVendedor.Location = new System.Drawing.Point(372, 93);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVendedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strNombreVendedor", "Vendedores")});
            this.cboVendedor.Properties.DataSource = this.tblVendedoresBindingSource;
            this.cboVendedor.Properties.DisplayMember = "strNombreVendedor";
            this.cboVendedor.Properties.NullText = "";
            this.cboVendedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboVendedor.Properties.ValueMember = "decIdVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(202, 20);
            this.cboVendedor.StyleController = this.layoutControl1;
            this.cboVendedor.TabIndex = 10;
            // 
            // tblVendedoresBindingSource
            // 
            this.tblVendedoresBindingSource.DataSource = typeof(Proforma.Models.tblVendedores);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.DataSource = this.tblUsuariosBindingSource;
            this.grdUsuarios.Location = new System.Drawing.Point(12, 155);
            this.grdUsuarios.MainView = this.grdVwUsuarios;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpCboRol,
            this.rpCboVendedore});
            this.grdUsuarios.Size = new System.Drawing.Size(574, 301);
            this.grdUsuarios.TabIndex = 9;
            this.grdUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwUsuarios});
            // 
            // tblUsuariosBindingSource
            // 
            this.tblUsuariosBindingSource.DataSource = typeof(Proforma.Models.tblUsuarios);
            // 
            // grdVwUsuarios
            // 
            this.grdVwUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdUsuario,
            this.colstrUsuario,
            this.colstrNombreUsuario,
            this.coldecIdRol,
            this.coldecIdVendedor,
            this.colbitActivo});
            this.grdVwUsuarios.GridControl = this.grdUsuarios;
            this.grdVwUsuarios.Name = "grdVwUsuarios";
            this.grdVwUsuarios.OptionsBehavior.Editable = false;
            this.grdVwUsuarios.OptionsFind.AlwaysVisible = true;
            this.grdVwUsuarios.OptionsView.ColumnAutoWidth = false;
            this.grdVwUsuarios.OptionsView.ShowAutoFilterRow = true;
            this.grdVwUsuarios.OptionsView.ShowGroupPanel = false;
            this.grdVwUsuarios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrdVwUsuarios_RowClick);
            // 
            // coldecIdUsuario
            // 
            this.coldecIdUsuario.Caption = "ID Usuario";
            this.coldecIdUsuario.FieldName = "decIdUsuario";
            this.coldecIdUsuario.Name = "coldecIdUsuario";
            this.coldecIdUsuario.Visible = true;
            this.coldecIdUsuario.VisibleIndex = 0;
            // 
            // colstrUsuario
            // 
            this.colstrUsuario.Caption = "Usuario";
            this.colstrUsuario.FieldName = "strUsuario";
            this.colstrUsuario.Name = "colstrUsuario";
            this.colstrUsuario.Visible = true;
            this.colstrUsuario.VisibleIndex = 1;
            // 
            // colstrNombreUsuario
            // 
            this.colstrNombreUsuario.Caption = "Nombre de Usuario";
            this.colstrNombreUsuario.FieldName = "strNombreUsuario";
            this.colstrNombreUsuario.Name = "colstrNombreUsuario";
            this.colstrNombreUsuario.Visible = true;
            this.colstrNombreUsuario.VisibleIndex = 2;
            this.colstrNombreUsuario.Width = 150;
            // 
            // coldecIdRol
            // 
            this.coldecIdRol.Caption = "Rol";
            this.coldecIdRol.ColumnEdit = this.rpCboRol;
            this.coldecIdRol.FieldName = "decIdRol";
            this.coldecIdRol.Name = "coldecIdRol";
            this.coldecIdRol.Visible = true;
            this.coldecIdRol.VisibleIndex = 3;
            this.coldecIdRol.Width = 150;
            // 
            // rpCboRol
            // 
            this.rpCboRol.AutoHeight = false;
            this.rpCboRol.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpCboRol.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strNombreRol", "Roles")});
            this.rpCboRol.DataSource = this.tblRolesBindingSource;
            this.rpCboRol.DisplayMember = "strNombreRol";
            this.rpCboRol.Name = "rpCboRol";
            this.rpCboRol.NullText = "";
            this.rpCboRol.ValueMember = "decIdRol";
            // 
            // tblRolesBindingSource
            // 
            this.tblRolesBindingSource.DataSource = typeof(Proforma.Models.tblRoles);
            // 
            // coldecIdVendedor
            // 
            this.coldecIdVendedor.Caption = "Vendedor";
            this.coldecIdVendedor.ColumnEdit = this.rpCboVendedore;
            this.coldecIdVendedor.FieldName = "decIdVendedor";
            this.coldecIdVendedor.Name = "coldecIdVendedor";
            this.coldecIdVendedor.Visible = true;
            this.coldecIdVendedor.VisibleIndex = 4;
            this.coldecIdVendedor.Width = 150;
            // 
            // rpCboVendedore
            // 
            this.rpCboVendedore.AutoHeight = false;
            this.rpCboVendedore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpCboVendedore.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strNombreVendedor", "Vendedores")});
            this.rpCboVendedore.DataSource = this.tblVendedoresBindingSource;
            this.rpCboVendedore.DisplayMember = "strNombreVendedor";
            this.rpCboVendedore.Name = "rpCboVendedore";
            this.rpCboVendedore.NullText = "";
            this.rpCboVendedore.ValueMember = "decIdVendedor";
            // 
            // colbitActivo
            // 
            this.colbitActivo.Caption = "Activo";
            this.colbitActivo.FieldName = "bitActivo";
            this.colbitActivo.Name = "colbitActivo";
            this.colbitActivo.Visible = true;
            this.colbitActivo.VisibleIndex = 5;
            // 
            // cboRol
            // 
            this.cboRol.Location = new System.Drawing.Point(96, 93);
            this.cboRol.Name = "cboRol";
            this.cboRol.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRol.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strNombreRol", "Roles")});
            this.cboRol.Properties.DataSource = this.tblRolesBindingSource;
            this.cboRol.Properties.DisplayMember = "strNombreRol";
            this.cboRol.Properties.NullText = "";
            this.cboRol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboRol.Properties.ValueMember = "decIdRol";
            this.cboRol.Size = new System.Drawing.Size(200, 20);
            this.cboRol.StyleController = this.layoutControl1;
            this.cboRol.TabIndex = 8;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(372, 69);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(202, 20);
            this.txtContrasena.StyleController = this.layoutControl1;
            this.txtContrasena.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(236, 45);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(281, 20);
            this.txtNombreUsuario.StyleController = this.layoutControl1;
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.StyleController = this.layoutControl1;
            this.txtUsuario.TabIndex = 5;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(96, 45);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Properties.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(64, 20);
            this.txtIdUsuario.StyleController = this.layoutControl1;
            this.txtIdUsuario.TabIndex = 4;
            this.txtIdUsuario.EditValueChanged += new System.EventHandler(this.TxtIdUsuario_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(598, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(578, 143);
            this.layoutControlGroup1.Text = "Datos";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.cboRol;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(276, 24);
            this.layoutControlItem5.Text = "Rol:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnNuevo;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(184, 26);
            this.layoutControlItem8.Text = "Boton Nuevo";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnGuardar;
            this.layoutControlItem9.Location = new System.Drawing.Point(184, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(184, 26);
            this.layoutControlItem9.Text = "Boton Guardar";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnEliminar;
            this.layoutControlItem10.Location = new System.Drawing.Point(368, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(186, 26);
            this.layoutControlItem10.Text = "Boton Eliminar";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txtIdUsuario;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem1.Text = "ID Usuario:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txtUsuario;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(276, 24);
            this.layoutControlItem2.Text = "Usuario:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.txtNombreUsuario;
            this.layoutControlItem3.Location = new System.Drawing.Point(140, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem3.Text = "Nombre:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txtContrasena;
            this.layoutControlItem4.Location = new System.Drawing.Point(276, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem4.Text = "Contraseña:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.Control = this.cboVendedor;
            this.layoutControlItem7.Location = new System.Drawing.Point(276, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem7.Text = "Vendedor:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.chkActivo;
            this.layoutControlItem11.Location = new System.Drawing.Point(497, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(57, 24);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.grdUsuarios;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(578, 305);
            this.layoutControlItem6.Text = "Tabla Usuarios";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 468);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCboRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCboVendedore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtIdUsuario;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl grdUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwUsuarios;
        private DevExpress.XtraEditors.LookUpEdit cboRol;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdUsuario;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.LookUpEdit cboVendedor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource;
        private System.Windows.Forms.BindingSource tblRolesBindingSource;
        private System.Windows.Forms.BindingSource tblVendedoresBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdRol;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpCboRol;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdVendedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpCboVendedore;
        private DevExpress.XtraGrid.Columns.GridColumn colstrUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreUsuario;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Columns.GridColumn colbitActivo;
    }
}
