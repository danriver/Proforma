
namespace Proforma.Forms
{
    partial class frmConsultasCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasCotizaciones));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.chkSAC = new DevExpress.XtraEditors.CheckEdit();
            this.btnEnviar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalEquiv = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtIVA = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.grdCotizacionDet = new DevExpress.XtraGrid.GridControl();
            this.BSDetalleCotizacion = new System.Windows.Forms.BindingSource(this.components);
            this.vwCotizacionDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCotizacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecMargen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecDescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitExonerado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecSubtotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProveedores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.txtStrCotizacion = new DevExpress.XtraEditors.TextEdit();
            this.cmbClientes = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSClientes = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitExonerado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colintIdPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrSiglas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblPrecios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCotizacionEnc = new DevExpress.XtraGrid.GridControl();
            this.BSCotizacion = new System.Windows.Forms.BindingSource(this.components);
            this.vwCotizacionEnc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colintEstadoCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNumCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblClientesContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblClientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblEstados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblVendedores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblDetalleCotizaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEquiv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacionDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDetalleCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStrCotizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacionEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnBuscar);
            this.layoutControl1.Controls.Add(this.txtDescuento);
            this.layoutControl1.Controls.Add(this.chkSAC);
            this.layoutControl1.Controls.Add(this.btnEnviar);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.btnEditar);
            this.layoutControl1.Controls.Add(this.txtTotalEquiv);
            this.layoutControl1.Controls.Add(this.txtTotal);
            this.layoutControl1.Controls.Add(this.txtIVA);
            this.layoutControl1.Controls.Add(this.txtSubtotal);
            this.layoutControl1.Controls.Add(this.grdCotizacionDet);
            this.layoutControl1.Controls.Add(this.dtFin);
            this.layoutControl1.Controls.Add(this.dtInicio);
            this.layoutControl1.Controls.Add(this.txtStrCotizacion);
            this.layoutControl1.Controls.Add(this.cmbClientes);
            this.layoutControl1.Controls.Add(this.grdCotizacionEnc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 76, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1124, 449);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(966, 268);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtDescuento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDescuento.Properties.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(134, 20);
            this.txtDescuento.StyleController = this.layoutControl1;
            this.txtDescuento.TabIndex = 15;
            // 
            // chkSAC
            // 
            this.chkSAC.Location = new System.Drawing.Point(881, 141);
            this.chkSAC.Name = "chkSAC";
            this.chkSAC.Properties.Caption = "Código SAC";
            this.chkSAC.Size = new System.Drawing.Size(157, 20);
            this.chkSAC.StyleController = this.layoutControl1;
            this.chkSAC.TabIndex = 14;
            this.chkSAC.CheckedChanged += new System.EventHandler(this.chkSAC_CheckedChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.ImageOptions.ImageUri.Uri = "outlook%20inspired/glyph_mail;Size16x16";
            this.btnEnviar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEnviar.Location = new System.Drawing.Point(1029, 364);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(71, 22);
            this.btnEnviar.StyleController = this.layoutControl1;
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageOptions.ImageUri.Uri = "Print;Size16x16";
            this.btnImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnImprimir.Location = new System.Drawing.Point(955, 364);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 22);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.ImageUri.Uri = "Edit;Size16x16";
            this.btnEditar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditar.Location = new System.Drawing.Point(881, 364);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 22);
            this.btnEditar.StyleController = this.layoutControl1;
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTotalEquiv
            // 
            this.txtTotalEquiv.Location = new System.Drawing.Point(966, 340);
            this.txtTotalEquiv.Name = "txtTotalEquiv";
            this.txtTotalEquiv.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtTotalEquiv.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalEquiv.Properties.ReadOnly = true;
            this.txtTotalEquiv.Size = new System.Drawing.Size(134, 20);
            this.txtTotalEquiv.StyleController = this.layoutControl1;
            this.txtTotalEquiv.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(966, 316);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 20);
            this.txtTotal.StyleController = this.layoutControl1;
            this.txtTotal.TabIndex = 9;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(966, 292);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtIVA.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIVA.Properties.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(134, 20);
            this.txtIVA.StyleController = this.layoutControl1;
            this.txtIVA.TabIndex = 8;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(966, 244);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(134, 20);
            this.txtSubtotal.StyleController = this.layoutControl1;
            this.txtSubtotal.TabIndex = 7;
            // 
            // grdCotizacionDet
            // 
            this.grdCotizacionDet.DataSource = this.BSDetalleCotizacion;
            this.grdCotizacionDet.Location = new System.Drawing.Point(12, 211);
            this.grdCotizacionDet.MainView = this.vwCotizacionDet;
            this.grdCotizacionDet.Name = "grdCotizacionDet";
            this.grdCotizacionDet.Size = new System.Drawing.Size(843, 226);
            this.grdCotizacionDet.TabIndex = 6;
            this.grdCotizacionDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwCotizacionDet});
            // 
            // BSDetalleCotizacion
            // 
            this.BSDetalleCotizacion.DataSource = typeof(Proforma.Models.tblDetalleCotizaciones);
            // 
            // vwCotizacionDet
            // 
            this.vwCotizacionDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdDetalle,
            this.coldecIdCotizacion1,
            this.coldecIdProducto,
            this.coldecCantidad,
            this.coldecCosto,
            this.coldecMargen,
            this.coldecPrecio,
            this.coldecDescuento1,
            this.coldecIdProveedor,
            this.colbitExonerado1,
            this.coldecIdUsuario1,
            this.colFechaMovimiento,
            this.coltblCotizaciones1,
            this.coltblProductos,
            this.coltblUsuarios1,
            this.coldecSubtotal2,
            this.coltblProveedores,
            this.coltblProductos1});
            this.vwCotizacionDet.GridControl = this.grdCotizacionDet;
            this.vwCotizacionDet.Name = "vwCotizacionDet";
            this.vwCotizacionDet.OptionsBehavior.Editable = false;
            this.vwCotizacionDet.OptionsView.ColumnAutoWidth = false;
            this.vwCotizacionDet.OptionsView.ShowAutoFilterRow = true;
            this.vwCotizacionDet.OptionsView.ShowGroupPanel = false;
            // 
            // coldecIdDetalle
            // 
            this.coldecIdDetalle.FieldName = "decIdDetalle";
            this.coldecIdDetalle.Name = "coldecIdDetalle";
            // 
            // coldecIdCotizacion1
            // 
            this.coldecIdCotizacion1.FieldName = "decIdCotizacion";
            this.coldecIdCotizacion1.Name = "coldecIdCotizacion1";
            // 
            // coldecIdProducto
            // 
            this.coldecIdProducto.Caption = "Código";
            this.coldecIdProducto.FieldName = "decIdProducto";
            this.coldecIdProducto.Name = "coldecIdProducto";
            this.coldecIdProducto.Visible = true;
            this.coldecIdProducto.VisibleIndex = 1;
            // 
            // coldecCantidad
            // 
            this.coldecCantidad.Caption = "Cantidad";
            this.coldecCantidad.DisplayFormat.FormatString = "#,##0";
            this.coldecCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecCantidad.FieldName = "decCantidad";
            this.coldecCantidad.Name = "coldecCantidad";
            this.coldecCantidad.Visible = true;
            this.coldecCantidad.VisibleIndex = 0;
            // 
            // coldecCosto
            // 
            this.coldecCosto.Caption = "Costo Unitario";
            this.coldecCosto.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecCosto.FieldName = "decCosto";
            this.coldecCosto.Name = "coldecCosto";
            this.coldecCosto.Visible = true;
            this.coldecCosto.VisibleIndex = 4;
            // 
            // coldecMargen
            // 
            this.coldecMargen.Caption = "% Margen";
            this.coldecMargen.DisplayFormat.FormatString = "#,##0.00";
            this.coldecMargen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecMargen.FieldName = "decMargen";
            this.coldecMargen.Name = "coldecMargen";
            this.coldecMargen.Visible = true;
            this.coldecMargen.VisibleIndex = 5;
            // 
            // coldecPrecio
            // 
            this.coldecPrecio.Caption = "Precio Unitario";
            this.coldecPrecio.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecPrecio.FieldName = "decPrecio";
            this.coldecPrecio.Name = "coldecPrecio";
            this.coldecPrecio.Visible = true;
            this.coldecPrecio.VisibleIndex = 6;
            // 
            // coldecDescuento1
            // 
            this.coldecDescuento1.FieldName = "decDescuento";
            this.coldecDescuento1.Name = "coldecDescuento1";
            // 
            // coldecIdProveedor
            // 
            this.coldecIdProveedor.FieldName = "decIdProveedor";
            this.coldecIdProveedor.Name = "coldecIdProveedor";
            // 
            // colbitExonerado1
            // 
            this.colbitExonerado1.FieldName = "bitExonerado";
            this.colbitExonerado1.Name = "colbitExonerado1";
            // 
            // coldecIdUsuario1
            // 
            this.coldecIdUsuario1.FieldName = "decIdUsuario";
            this.coldecIdUsuario1.Name = "coldecIdUsuario1";
            // 
            // colFechaMovimiento
            // 
            this.colFechaMovimiento.FieldName = "FechaMovimiento";
            this.colFechaMovimiento.Name = "colFechaMovimiento";
            // 
            // coltblCotizaciones1
            // 
            this.coltblCotizaciones1.FieldName = "tblCotizaciones";
            this.coltblCotizaciones1.Name = "coltblCotizaciones1";
            // 
            // coltblProductos
            // 
            this.coltblProductos.Caption = "Producto";
            this.coltblProductos.FieldName = "tblProductos.strProducto";
            this.coltblProductos.Name = "coltblProductos";
            this.coltblProductos.Visible = true;
            this.coltblProductos.VisibleIndex = 2;
            // 
            // coltblUsuarios1
            // 
            this.coltblUsuarios1.FieldName = "tblUsuarios";
            this.coltblUsuarios1.Name = "coltblUsuarios1";
            // 
            // coldecSubtotal2
            // 
            this.coldecSubtotal2.Caption = "Subtotal";
            this.coldecSubtotal2.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecSubtotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecSubtotal2.FieldName = "coldecSubtotal2";
            this.coldecSubtotal2.Name = "coldecSubtotal2";
            this.coldecSubtotal2.ShowUnboundExpressionMenu = true;
            this.coldecSubtotal2.UnboundDataType = typeof(decimal);
            this.coldecSubtotal2.UnboundExpression = "[decCantidad] * [decPrecio]";
            this.coldecSubtotal2.Visible = true;
            this.coldecSubtotal2.VisibleIndex = 7;
            // 
            // coltblProveedores
            // 
            this.coltblProveedores.Caption = "Proveedor";
            this.coltblProveedores.FieldName = "tblProveedores.strNombre";
            this.coltblProveedores.Name = "coltblProveedores";
            this.coltblProveedores.Visible = true;
            this.coltblProveedores.VisibleIndex = 3;
            // 
            // coltblProductos1
            // 
            this.coltblProductos1.Caption = "Código SAC";
            this.coltblProductos1.FieldName = "tblProductos.strReferencia";
            this.coltblProductos1.Name = "coltblProductos1";
            // 
            // dtFin
            // 
            this.dtFin.EditValue = null;
            this.dtFin.Location = new System.Drawing.Point(966, 117);
            this.dtFin.Name = "dtFin";
            this.dtFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Size = new System.Drawing.Size(134, 20);
            this.dtFin.StyleController = this.layoutControl1;
            this.dtFin.TabIndex = 5;
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(966, 93);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(134, 20);
            this.dtInicio.StyleController = this.layoutControl1;
            this.dtInicio.TabIndex = 4;
            // 
            // txtStrCotizacion
            // 
            this.txtStrCotizacion.Location = new System.Drawing.Point(966, 45);
            this.txtStrCotizacion.Name = "txtStrCotizacion";
            this.txtStrCotizacion.Size = new System.Drawing.Size(134, 20);
            this.txtStrCotizacion.StyleController = this.layoutControl1;
            this.txtStrCotizacion.TabIndex = 2;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(966, 69);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbClientes.Properties.DataSource = this.BSClientes;
            this.cmbClientes.Properties.DisplayMember = "strNombre";
            this.cmbClientes.Properties.NullText = "";
            this.cmbClientes.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbClientes.Properties.ValueMember = "decIdCliente";
            this.cmbClientes.Size = new System.Drawing.Size(134, 20);
            this.cmbClientes.StyleController = this.layoutControl1;
            this.cmbClientes.TabIndex = 3;
            // 
            // BSClientes
            // 
            this.BSClientes.DataSource = typeof(Proforma.Models.tblClientes);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colstrNombre,
            this.colstrDireccion,
            this.colstrTelefono,
            this.gridColumn2,
            this.colbitExonerado,
            this.colintIdPrecio,
            this.colbitActivo,
            this.colstrRUC,
            this.colstrSiglas,
            this.gridColumn3,
            this.coltblCotizaciones,
            this.coltblPrecios,
            this.gridColumn4});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "decIdCliente";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colstrNombre
            // 
            this.colstrNombre.Caption = "Cliente";
            this.colstrNombre.FieldName = "strNombre";
            this.colstrNombre.Name = "colstrNombre";
            this.colstrNombre.Visible = true;
            this.colstrNombre.VisibleIndex = 1;
            // 
            // colstrDireccion
            // 
            this.colstrDireccion.Caption = "Dirección";
            this.colstrDireccion.FieldName = "strDireccion";
            this.colstrDireccion.Name = "colstrDireccion";
            this.colstrDireccion.Visible = true;
            this.colstrDireccion.VisibleIndex = 2;
            // 
            // colstrTelefono
            // 
            this.colstrTelefono.Caption = "Teléfono";
            this.colstrTelefono.FieldName = "strTelefono";
            this.colstrTelefono.Name = "colstrTelefono";
            this.colstrTelefono.Visible = true;
            this.colstrTelefono.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "decIdVendedor";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colbitExonerado
            // 
            this.colbitExonerado.FieldName = "bitExonerado";
            this.colbitExonerado.Name = "colbitExonerado";
            // 
            // colintIdPrecio
            // 
            this.colintIdPrecio.FieldName = "intIdPrecio";
            this.colintIdPrecio.Name = "colintIdPrecio";
            // 
            // colbitActivo
            // 
            this.colbitActivo.FieldName = "bitActivo";
            this.colbitActivo.Name = "colbitActivo";
            // 
            // colstrRUC
            // 
            this.colstrRUC.Caption = "RUC";
            this.colstrRUC.FieldName = "strRUC";
            this.colstrRUC.Name = "colstrRUC";
            this.colstrRUC.Visible = true;
            this.colstrRUC.VisibleIndex = 4;
            // 
            // colstrSiglas
            // 
            this.colstrSiglas.Caption = "Siglas";
            this.colstrSiglas.FieldName = "strSiglas";
            this.colstrSiglas.Name = "colstrSiglas";
            this.colstrSiglas.Visible = true;
            this.colstrSiglas.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "tblClientesContacto";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // coltblCotizaciones
            // 
            this.coltblCotizaciones.FieldName = "tblCotizaciones";
            this.coltblCotizaciones.Name = "coltblCotizaciones";
            // 
            // coltblPrecios
            // 
            this.coltblPrecios.FieldName = "tblPrecios";
            this.coltblPrecios.Name = "coltblPrecios";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "tblVendedores";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // grdCotizacionEnc
            // 
            this.grdCotizacionEnc.DataSource = this.BSCotizacion;
            this.grdCotizacionEnc.Location = new System.Drawing.Point(12, 12);
            this.grdCotizacionEnc.MainView = this.vwCotizacionEnc;
            this.grdCotizacionEnc.Name = "grdCotizacionEnc";
            this.grdCotizacionEnc.Size = new System.Drawing.Size(843, 195);
            this.grdCotizacionEnc.TabIndex = 0;
            this.grdCotizacionEnc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwCotizacionEnc});
            // 
            // BSCotizacion
            // 
            this.BSCotizacion.DataSource = typeof(Proforma.Models.tblCotizaciones);
            // 
            // vwCotizacionEnc
            // 
            this.vwCotizacionEnc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecTotal,
            this.coldecIdCotizacion,
            this.coldecIdCliente,
            this.coldecIdContacto,
            this.coldecIdVendedor,
            this.coldecIdUsuario,
            this.coldatFechaCreacion,
            this.coldecSubtotal,
            this.coldecIva,
            this.coldecDescuento,
            this.colstrObservaciones,
            this.colintEstadoCotizacion,
            this.colbitFactura,
            this.coldatFechaVencimiento,
            this.colstrNumCotizacion,
            this.coltblUsuarios,
            this.coltblClientesContacto,
            this.coltblClientes,
            this.coltblEstados,
            this.coltblVendedores,
            this.coltblDetalleCotizaciones});
            this.vwCotizacionEnc.GridControl = this.grdCotizacionEnc;
            this.vwCotizacionEnc.Name = "vwCotizacionEnc";
            this.vwCotizacionEnc.OptionsBehavior.Editable = false;
            this.vwCotizacionEnc.OptionsView.ColumnAutoWidth = false;
            this.vwCotizacionEnc.OptionsView.ShowAutoFilterRow = true;
            this.vwCotizacionEnc.OptionsView.ShowGroupPanel = false;
            this.vwCotizacionEnc.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldatFechaCreacion, DevExpress.Data.ColumnSortOrder.Descending)});
            this.vwCotizacionEnc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vwCotizacionEnc_RowClick);
            this.vwCotizacionEnc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vwCotizacionEnc_FocusedRowChanged);
            // 
            // coldecTotal
            // 
            this.coldecTotal.Caption = "Total";
            this.coldecTotal.DisplayFormat.FormatString = "#,##0.00";
            this.coldecTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecTotal.FieldName = "coldecTotal";
            this.coldecTotal.Name = "coldecTotal";
            this.coldecTotal.ShowUnboundExpressionMenu = true;
            this.coldecTotal.UnboundDataType = typeof(decimal);
            this.coldecTotal.UnboundExpression = "Iif([decSubtotal] = null, 0, [decSubtotal]) - Iif([decDescuento] = null, 0, [decD" +
    "escuento]) + Iif([decIva] = null, 0, [decIva])";
            this.coldecTotal.Visible = true;
            this.coldecTotal.VisibleIndex = 8;
            // 
            // coldecIdCotizacion
            // 
            this.coldecIdCotizacion.FieldName = "decIdCotizacion";
            this.coldecIdCotizacion.Name = "coldecIdCotizacion";
            // 
            // coldecIdCliente
            // 
            this.coldecIdCliente.FieldName = "decIdCliente";
            this.coldecIdCliente.Name = "coldecIdCliente";
            // 
            // coldecIdContacto
            // 
            this.coldecIdContacto.FieldName = "decIdContacto";
            this.coldecIdContacto.Name = "coldecIdContacto";
            // 
            // coldecIdVendedor
            // 
            this.coldecIdVendedor.FieldName = "decIdVendedor";
            this.coldecIdVendedor.Name = "coldecIdVendedor";
            // 
            // coldecIdUsuario
            // 
            this.coldecIdUsuario.FieldName = "decIdUsuario";
            this.coldecIdUsuario.Name = "coldecIdUsuario";
            // 
            // coldatFechaCreacion
            // 
            this.coldatFechaCreacion.Caption = "Fecha";
            this.coldatFechaCreacion.FieldName = "datFechaCreacion";
            this.coldatFechaCreacion.Name = "coldatFechaCreacion";
            this.coldatFechaCreacion.Visible = true;
            this.coldatFechaCreacion.VisibleIndex = 1;
            // 
            // coldecSubtotal
            // 
            this.coldecSubtotal.Caption = "Subtotal";
            this.coldecSubtotal.DisplayFormat.FormatString = "#,##0.00";
            this.coldecSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecSubtotal.FieldName = "decSubtotal";
            this.coldecSubtotal.Name = "coldecSubtotal";
            this.coldecSubtotal.Visible = true;
            this.coldecSubtotal.VisibleIndex = 5;
            // 
            // coldecIva
            // 
            this.coldecIva.Caption = "IVA";
            this.coldecIva.DisplayFormat.FormatString = "#,##0.00";
            this.coldecIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecIva.FieldName = "decIva";
            this.coldecIva.Name = "coldecIva";
            this.coldecIva.Visible = true;
            this.coldecIva.VisibleIndex = 7;
            // 
            // coldecDescuento
            // 
            this.coldecDescuento.Caption = "Descuento";
            this.coldecDescuento.DisplayFormat.FormatString = "#,##0.00";
            this.coldecDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecDescuento.FieldName = "decDescuento";
            this.coldecDescuento.Name = "coldecDescuento";
            this.coldecDescuento.Visible = true;
            this.coldecDescuento.VisibleIndex = 6;
            // 
            // colstrObservaciones
            // 
            this.colstrObservaciones.Caption = "Observaciones";
            this.colstrObservaciones.FieldName = "strObservaciones";
            this.colstrObservaciones.Name = "colstrObservaciones";
            this.colstrObservaciones.Visible = true;
            this.colstrObservaciones.VisibleIndex = 11;
            // 
            // colintEstadoCotizacion
            // 
            this.colintEstadoCotizacion.FieldName = "intEstadoCotizacion";
            this.colintEstadoCotizacion.Name = "colintEstadoCotizacion";
            // 
            // colbitFactura
            // 
            this.colbitFactura.Caption = "Factura";
            this.colbitFactura.FieldName = "bitFactura";
            this.colbitFactura.Name = "colbitFactura";
            this.colbitFactura.Visible = true;
            this.colbitFactura.VisibleIndex = 10;
            // 
            // coldatFechaVencimiento
            // 
            this.coldatFechaVencimiento.FieldName = "datFechaVencimiento";
            this.coldatFechaVencimiento.Name = "coldatFechaVencimiento";
            // 
            // colstrNumCotizacion
            // 
            this.colstrNumCotizacion.Caption = "Proforma No.";
            this.colstrNumCotizacion.FieldName = "strNumCotizacion";
            this.colstrNumCotizacion.Name = "colstrNumCotizacion";
            this.colstrNumCotizacion.Visible = true;
            this.colstrNumCotizacion.VisibleIndex = 0;
            // 
            // coltblUsuarios
            // 
            this.coltblUsuarios.FieldName = "tblUsuarios";
            this.coltblUsuarios.Name = "coltblUsuarios";
            // 
            // coltblClientesContacto
            // 
            this.coltblClientesContacto.Caption = "Contacto";
            this.coltblClientesContacto.FieldName = "tblClientesContacto.strNombreContacto";
            this.coltblClientesContacto.Name = "coltblClientesContacto";
            this.coltblClientesContacto.Visible = true;
            this.coltblClientesContacto.VisibleIndex = 3;
            // 
            // coltblClientes
            // 
            this.coltblClientes.Caption = "Empresa";
            this.coltblClientes.FieldName = "tblClientes.strNombre";
            this.coltblClientes.Name = "coltblClientes";
            this.coltblClientes.Visible = true;
            this.coltblClientes.VisibleIndex = 2;
            // 
            // coltblEstados
            // 
            this.coltblEstados.Caption = "Estado";
            this.coltblEstados.FieldName = "tblEstados.strDescripcion";
            this.coltblEstados.Name = "coltblEstados";
            this.coltblEstados.Visible = true;
            this.coltblEstados.VisibleIndex = 9;
            // 
            // coltblVendedores
            // 
            this.coltblVendedores.Caption = "Vendedor";
            this.coltblVendedores.FieldName = "tblVendedores.strNombreVendedor";
            this.coltblVendedores.Name = "coltblVendedores";
            this.coltblVendedores.Visible = true;
            this.coltblVendedores.VisibleIndex = 4;
            // 
            // coltblDetalleCotizaciones
            // 
            this.coltblDetalleCotizaciones.FieldName = "tblDetalleCotizaciones";
            this.coltblDetalleCotizaciones.Name = "coltblDetalleCotizaciones";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1124, 449);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem11,
            this.layoutControlItem13});
            this.layoutControlGroup1.Location = new System.Drawing.Point(857, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(247, 199);
            this.layoutControlGroup1.Text = "Criterios de Búsqueda";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtStrCotizacion;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem3.Text = "No. Cotización:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbClientes;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem2.Text = "Cliente:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtInicio;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem4.Text = "Fecha Inicio:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtFin;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem5.Text = "Fecha Fin:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(223, 32);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.chkSAC;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(847, 199);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 230);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 230);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 230);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem10,
            this.emptySpaceItem3,
            this.layoutControlItem12});
            this.layoutControlGroup2.Location = new System.Drawing.Point(857, 199);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(247, 230);
            this.layoutControlGroup2.Text = "Totales";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSubtotal;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem7.Text = "SUBTOTAL";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtIVA;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem8.Text = "IVA";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtTotal;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem9.Text = "TOTAL";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.btnEditar;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(74, 26);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnImprimir;
            this.layoutControlItem16.Location = new System.Drawing.Point(74, 120);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(74, 26);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.btnEnviar;
            this.layoutControlItem17.Location = new System.Drawing.Point(148, 120);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(75, 26);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtTotalEquiv;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem10.Text = "TOTAL";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(223, 39);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtDescuento;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem12.Text = "DESCUENTO";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.grdCotizacionDet;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(847, 230);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(847, 230);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(847, 230);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCotizacionEnc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(847, 199);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(847, 199);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(847, 199);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(847, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(10, 199);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 199);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 199);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageUri.Uri = "Find;Size16x16";
            this.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(1042, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 22);
            this.btnBuscar.StyleController = this.layoutControl1;
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnBuscar;
            this.layoutControlItem13.Location = new System.Drawing.Point(161, 96);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(62, 26);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // frmConsultasCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1124, 449);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmConsultasCotizaciones.IconOptions.Image")));
            this.Name = "frmConsultasCotizaciones";
            this.Text = "Listado de Cotizaciones";
            this.Load += new System.EventHandler(this.frmConsultasCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEquiv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacionDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDetalleCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStrCotizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacionEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdCotizacionEnc;
        private DevExpress.XtraGrid.Views.Grid.GridView vwCotizacionEnc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.TextEdit txtStrCotizacion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtTotalEquiv;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtIVA;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraGrid.GridControl grdCotizacionDet;
        private DevExpress.XtraGrid.Views.Grid.GridView vwCotizacionDet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnEnviar;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.BindingSource BSCotizacion;
        private System.Windows.Forms.BindingSource BSDetalleCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdContacto;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn coldatFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldecSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIva;
        private DevExpress.XtraGrid.Columns.GridColumn coldecDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colstrObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colintEstadoCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colbitFactura;
        private DevExpress.XtraGrid.Columns.GridColumn coldatFechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNumCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn coltblClientesContacto;
        private DevExpress.XtraGrid.Columns.GridColumn coltblClientes;
        private DevExpress.XtraGrid.Columns.GridColumn coltblEstados;
        private DevExpress.XtraGrid.Columns.GridColumn coltblVendedores;
        private DevExpress.XtraGrid.Columns.GridColumn coltblDetalleCotizaciones;
        private System.Windows.Forms.BindingSource BSClientes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstrDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colbitExonerado;
        private DevExpress.XtraGrid.Columns.GridColumn colintIdPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colbitActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colstrRUC;
        private DevExpress.XtraGrid.Columns.GridColumn colstrSiglas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coltblPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCotizacion1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCosto;
        private DevExpress.XtraGrid.Columns.GridColumn coldecMargen;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn coldecDescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colbitExonerado1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProveedores;
        private DevExpress.XtraEditors.CheckEdit chkSAC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Columns.GridColumn coldecTotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldecSubtotal2;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos1;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
    }
}
