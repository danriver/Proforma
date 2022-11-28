
namespace Proforma.Forms
{
    partial class frmVendedores
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
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.grdVendedores = new DevExpress.XtraGrid.GridControl();
            this.BSVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.vwVendedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblClientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtIdVendedor = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtContrasena);
            this.layoutControl1.Controls.Add(this.txtCorreo);
            this.layoutControl1.Controls.Add(this.grdVendedores);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtTelefono);
            this.layoutControl1.Controls.Add(this.txtNombre);
            this.layoutControl1.Controls.Add(this.txtIdVendedor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 207, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(418, 385);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(96, 93);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(111, 20);
            this.txtCorreo.StyleController = this.layoutControl1;
            this.txtCorreo.TabIndex = 2;
            // 
            // grdVendedores
            // 
            this.grdVendedores.DataSource = this.BSVendedores;
            this.grdVendedores.Location = new System.Drawing.Point(12, 179);
            this.grdVendedores.MainView = this.vwVendedores;
            this.grdVendedores.Name = "grdVendedores";
            this.grdVendedores.Size = new System.Drawing.Size(394, 194);
            this.grdVendedores.TabIndex = 7;
            this.grdVendedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwVendedores});
            // 
            // BSVendedores
            // 
            this.BSVendedores.DataSource = typeof(Proforma.Models.tblVendedores);
            // 
            // vwVendedores
            // 
            this.vwVendedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdVendedor,
            this.colstrNombreVendedor,
            this.colstrTelefono,
            this.colstrCorreo,
            this.coltblClientes,
            this.coltblCotizaciones,
            this.coltblUsuarios});
            this.vwVendedores.GridControl = this.grdVendedores;
            this.vwVendedores.Name = "vwVendedores";
            this.vwVendedores.OptionsBehavior.Editable = false;
            this.vwVendedores.OptionsView.ColumnAutoWidth = false;
            this.vwVendedores.OptionsView.ShowAutoFilterRow = true;
            this.vwVendedores.OptionsView.ShowGroupPanel = false;
            this.vwVendedores.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vwVendedores_RowClick);
            // 
            // coldecIdVendedor
            // 
            this.coldecIdVendedor.Caption = "Código";
            this.coldecIdVendedor.FieldName = "decIdVendedor";
            this.coldecIdVendedor.Name = "coldecIdVendedor";
            this.coldecIdVendedor.Visible = true;
            this.coldecIdVendedor.VisibleIndex = 0;
            // 
            // colstrNombreVendedor
            // 
            this.colstrNombreVendedor.Caption = "Nombre";
            this.colstrNombreVendedor.FieldName = "strNombreVendedor";
            this.colstrNombreVendedor.Name = "colstrNombreVendedor";
            this.colstrNombreVendedor.Visible = true;
            this.colstrNombreVendedor.VisibleIndex = 1;
            // 
            // colstrTelefono
            // 
            this.colstrTelefono.Caption = "Teléfono";
            this.colstrTelefono.FieldName = "strTelefono";
            this.colstrTelefono.Name = "colstrTelefono";
            this.colstrTelefono.Visible = true;
            this.colstrTelefono.VisibleIndex = 2;
            // 
            // colstrCorreo
            // 
            this.colstrCorreo.Caption = "Correo";
            this.colstrCorreo.FieldName = "strCorreo";
            this.colstrCorreo.Name = "colstrCorreo";
            this.colstrCorreo.Visible = true;
            this.colstrCorreo.VisibleIndex = 3;
            // 
            // coltblClientes
            // 
            this.coltblClientes.FieldName = "tblClientes";
            this.coltblClientes.Name = "coltblClientes";
            // 
            // coltblCotizaciones
            // 
            this.coltblCotizaciones.FieldName = "tblCotizaciones";
            this.coltblCotizaciones.Name = "coltblCotizaciones";
            // 
            // coltblUsuarios
            // 
            this.coltblUsuarios.FieldName = "tblUsuarios";
            this.coltblUsuarios.Name = "coltblUsuarios";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.ImageUri.Uri = "Delete;Size16x16";
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(273, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 22);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(148, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 22);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(24, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 22);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(283, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.BeepOnError = false;
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtTelefono.Properties.MaskSettings.Set("mask", "([1-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9])|(([1-9][0-9][0-9][0-9]-[0-9][0-9][0-9" +
        "][0-9])/([1-9]?[0-9]?[0-9]?[0-9]?-[0-9]?[0-9]?[0-9]?[0-9]?))");
            this.txtTelefono.Size = new System.Drawing.Size(111, 20);
            this.txtTelefono.StyleController = this.layoutControl1;
            this.txtTelefono.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 20);
            this.txtNombre.StyleController = this.layoutControl1;
            this.txtNombre.TabIndex = 1;
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Location = new System.Drawing.Point(96, 45);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Properties.ReadOnly = true;
            this.txtIdVendedor.Size = new System.Drawing.Size(298, 20);
            this.txtIdVendedor.StyleController = this.layoutControl1;
            this.txtIdVendedor.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(418, 385);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.grdVendedores;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(398, 198);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(398, 167);
            this.layoutControlGroup1.Text = "Datos";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIdVendedor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem1.Text = "Código:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNombre;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem2.Text = "Nombre:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTelefono;
            this.layoutControlItem3.Location = new System.Drawing.Point(187, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(187, 24);
            this.layoutControlItem3.Text = "Teléfono:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAgregar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnGuardar;
            this.layoutControlItem5.Location = new System.Drawing.Point(124, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEliminar;
            this.layoutControlItem6.Location = new System.Drawing.Point(249, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCorreo;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(187, 24);
            this.layoutControlItem8.Text = "Correo:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 13);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(96, 117);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(298, 20);
            this.txtContrasena.StyleController = this.layoutControl1;
            this.txtContrasena.TabIndex = 8;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtContrasena;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem9.Text = "Contraseña:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(60, 13);
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(418, 385);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtIdVendedor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl grdVendedores;
        private DevExpress.XtraGrid.Views.Grid.GridView vwVendedores;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private System.Windows.Forms.BindingSource BSVendedores;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colstrCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltblClientes;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}
