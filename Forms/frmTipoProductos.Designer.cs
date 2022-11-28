
namespace Proforma.Forms
{
    partial class frmTipoProductos
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
            this.txtIncrementoPrecio3 = new DevExpress.XtraEditors.TextEdit();
            this.txtIncrementoPrecio2 = new DevExpress.XtraEditors.TextEdit();
            this.grdTipoProductos = new DevExpress.XtraGrid.GridControl();
            this.BSTipoProductos = new System.Windows.Forms.BindingSource(this.components);
            this.vwTipoProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdTipoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTipoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIncrementoPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIncrementoPrecio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIncrementoPrecio3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtIncrementoPrecio1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtIdTipoProducto = new DevExpress.XtraEditors.TextEdit();
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
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTipoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTipoProducto.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtIncrementoPrecio3);
            this.layoutControl1.Controls.Add(this.txtIncrementoPrecio2);
            this.layoutControl1.Controls.Add(this.grdTipoProductos);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtIncrementoPrecio1);
            this.layoutControl1.Controls.Add(this.txtTipoProducto);
            this.layoutControl1.Controls.Add(this.txtIdTipoProducto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(501, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtIncrementoPrecio3
            // 
            this.txtIncrementoPrecio3.Location = new System.Drawing.Point(421, 93);
            this.txtIncrementoPrecio3.Name = "txtIncrementoPrecio3";
            this.txtIncrementoPrecio3.Properties.BeepOnError = false;
            this.txtIncrementoPrecio3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIncrementoPrecio3.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIncrementoPrecio3.Properties.MaskSettings.Set("mask", "n");
            this.txtIncrementoPrecio3.Size = new System.Drawing.Size(56, 20);
            this.txtIncrementoPrecio3.StyleController = this.layoutControl1;
            this.txtIncrementoPrecio3.TabIndex = 4;
            // 
            // txtIncrementoPrecio2
            // 
            this.txtIncrementoPrecio2.Location = new System.Drawing.Point(270, 93);
            this.txtIncrementoPrecio2.Name = "txtIncrementoPrecio2";
            this.txtIncrementoPrecio2.Properties.BeepOnError = false;
            this.txtIncrementoPrecio2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIncrementoPrecio2.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIncrementoPrecio2.Properties.MaskSettings.Set("mask", "n");
            this.txtIncrementoPrecio2.Size = new System.Drawing.Size(60, 20);
            this.txtIncrementoPrecio2.StyleController = this.layoutControl1;
            this.txtIncrementoPrecio2.TabIndex = 3;
            // 
            // grdTipoProductos
            // 
            this.grdTipoProductos.DataSource = this.BSTipoProductos;
            this.grdTipoProductos.Location = new System.Drawing.Point(12, 155);
            this.grdTipoProductos.MainView = this.vwTipoProductos;
            this.grdTipoProductos.Name = "grdTipoProductos";
            this.grdTipoProductos.Size = new System.Drawing.Size(477, 301);
            this.grdTipoProductos.TabIndex = 8;
            this.grdTipoProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwTipoProductos});
            // 
            // BSTipoProductos
            // 
            this.BSTipoProductos.DataSource = typeof(Proforma.Models.tblTipoProductos);
            // 
            // vwTipoProductos
            // 
            this.vwTipoProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdTipoProducto,
            this.colstrTipoProducto,
            this.coltblProductos,
            this.coldecIncrementoPrecio1,
            this.coldecIncrementoPrecio2,
            this.coldecIncrementoPrecio3});
            this.vwTipoProductos.GridControl = this.grdTipoProductos;
            this.vwTipoProductos.Name = "vwTipoProductos";
            this.vwTipoProductos.OptionsBehavior.Editable = false;
            this.vwTipoProductos.OptionsView.ColumnAutoWidth = false;
            this.vwTipoProductos.OptionsView.ShowAutoFilterRow = true;
            this.vwTipoProductos.OptionsView.ShowGroupPanel = false;
            this.vwTipoProductos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.vwTipoProductos_RowCellClick);
            // 
            // coldecIdTipoProducto
            // 
            this.coldecIdTipoProducto.Caption = "Código";
            this.coldecIdTipoProducto.FieldName = "decIdTipoProducto";
            this.coldecIdTipoProducto.Name = "coldecIdTipoProducto";
            this.coldecIdTipoProducto.Visible = true;
            this.coldecIdTipoProducto.VisibleIndex = 0;
            // 
            // colstrTipoProducto
            // 
            this.colstrTipoProducto.Caption = "Tipo de Producto";
            this.colstrTipoProducto.FieldName = "strTipoProducto";
            this.colstrTipoProducto.Name = "colstrTipoProducto";
            this.colstrTipoProducto.Visible = true;
            this.colstrTipoProducto.VisibleIndex = 1;
            // 
            // coltblProductos
            // 
            this.coltblProductos.FieldName = "tblProductos";
            this.coltblProductos.Name = "coltblProductos";
            // 
            // coldecIncrementoPrecio1
            // 
            this.coldecIncrementoPrecio1.Caption = "% Incr. Precio 1";
            this.coldecIncrementoPrecio1.FieldName = "decIncrementoPrecio1";
            this.coldecIncrementoPrecio1.Name = "coldecIncrementoPrecio1";
            this.coldecIncrementoPrecio1.Visible = true;
            this.coldecIncrementoPrecio1.VisibleIndex = 2;
            // 
            // coldecIncrementoPrecio2
            // 
            this.coldecIncrementoPrecio2.Caption = "% Incr. Precio 2";
            this.coldecIncrementoPrecio2.FieldName = "decIncrementoPrecio2";
            this.coldecIncrementoPrecio2.Name = "coldecIncrementoPrecio2";
            this.coldecIncrementoPrecio2.Visible = true;
            this.coldecIncrementoPrecio2.VisibleIndex = 3;
            // 
            // coldecIncrementoPrecio3
            // 
            this.coldecIncrementoPrecio3.Caption = "% Incr. Precio 3";
            this.coldecIncrementoPrecio3.FieldName = "decIncrementoPrecio3";
            this.coldecIncrementoPrecio3.Name = "coldecIncrementoPrecio3";
            this.coldecIncrementoPrecio3.Visible = true;
            this.coldecIncrementoPrecio3.VisibleIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.ImageUri.Uri = "Delete;Size16x16";
            this.btnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(328, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 22);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(176, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 22);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(24, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 22);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIncrementoPrecio1
            // 
            this.txtIncrementoPrecio1.Location = new System.Drawing.Point(121, 93);
            this.txtIncrementoPrecio1.Name = "txtIncrementoPrecio1";
            this.txtIncrementoPrecio1.Properties.BeepOnError = false;
            this.txtIncrementoPrecio1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIncrementoPrecio1.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIncrementoPrecio1.Properties.MaskSettings.Set("mask", "n");
            this.txtIncrementoPrecio1.Size = new System.Drawing.Size(58, 20);
            this.txtIncrementoPrecio1.StyleController = this.layoutControl1;
            this.txtIncrementoPrecio1.TabIndex = 2;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(121, 69);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(356, 20);
            this.txtTipoProducto.StyleController = this.layoutControl1;
            this.txtTipoProducto.TabIndex = 1;
            // 
            // txtIdTipoProducto
            // 
            this.txtIdTipoProducto.Location = new System.Drawing.Point(121, 45);
            this.txtIdTipoProducto.Name = "txtIdTipoProducto";
            this.txtIdTipoProducto.Properties.ReadOnly = true;
            this.txtIdTipoProducto.Size = new System.Drawing.Size(356, 20);
            this.txtIdTipoProducto.StyleController = this.layoutControl1;
            this.txtIdTipoProducto.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(501, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.grdTipoProductos;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(481, 305);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(481, 143);
            this.layoutControlGroup1.Text = "Datos";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIdTipoProducto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(457, 24);
            this.layoutControlItem1.Text = "Código:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTipoProducto;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(457, 24);
            this.layoutControlItem2.Text = "Tipo de Producto:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtIncrementoPrecio1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(159, 24);
            this.layoutControlItem3.Text = "% Incr. Precio 1:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAgregar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(152, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnGuardar;
            this.layoutControlItem5.Location = new System.Drawing.Point(152, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEliminar;
            this.layoutControlItem6.Location = new System.Drawing.Point(304, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(153, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtIncrementoPrecio2;
            this.layoutControlItem8.Location = new System.Drawing.Point(159, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(151, 24);
            this.layoutControlItem8.Text = "% Incr. Precio 2:";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(82, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtIncrementoPrecio3;
            this.layoutControlItem9.Location = new System.Drawing.Point(310, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(147, 24);
            this.layoutControlItem9.Text = "% Incr. Precio 3:";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(82, 13);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // frmTipoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(501, 468);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTipoProductos";
            this.Text = "Tipo de Productos";
            this.Load += new System.EventHandler(this.frmTipoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTipoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncrementoPrecio1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTipoProducto.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdTipoProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView vwTipoProductos;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.TextEdit txtIncrementoPrecio1;
        private DevExpress.XtraEditors.TextEdit txtTipoProducto;
        private DevExpress.XtraEditors.TextEdit txtIdTipoProducto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource BSTipoProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdTipoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTipoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtIncrementoPrecio3;
        private DevExpress.XtraEditors.TextEdit txtIncrementoPrecio2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIncrementoPrecio1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIncrementoPrecio2;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIncrementoPrecio3;
    }
}
