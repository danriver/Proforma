namespace Proforma.Forms
{
    partial class frmProforma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProforma));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spDescuento = new DevExpress.XtraEditors.SpinEdit();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.mmoInfAdicional = new DevExpress.XtraEditors.MemoEdit();
            this.txtTotalEquiv = new DevExpress.XtraEditors.TextEdit();
            this.grdProductoHist = new DevExpress.XtraGrid.GridControl();
            this.BSCotizacionDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductoHist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecSubtotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdDetalle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCotizacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProducto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecDescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCosto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitExonerado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMovimiento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProveedores1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecMargen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtStrProforma = new DevExpress.XtraEditors.TextEdit();
            this.btnEnviar = new DevExpress.XtraEditors.SimpleButton();
            this.mmoObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtExtension = new DevExpress.XtraEditors.TextEdit();
            this.spMargen = new DevExpress.XtraEditors.SpinEdit();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.txtTasa = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstados = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSEstados = new System.Windows.Forms.BindingSource(this.components);
            this.btnAprobar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.chkFactura = new DevExpress.XtraEditors.CheckEdit();
            this.txtIVA = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.grdDetalleCotizacion = new DevExpress.XtraGrid.GridControl();
            this.vwDetalleCotizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCosto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitExonerado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProveedores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductos1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecMargen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.cmbProveedores = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit6View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtExistencia = new DevExpress.XtraEditors.TextEdit();
            this.cmbProductos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSProductos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit5View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecPrecio3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colintMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitNoExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitExonerado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdTipoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colintIdPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblDetalleCotizaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblMonedas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblPrecios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblTipoProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblProductosXProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbContactos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSContactos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblClientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCotizaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkMostrarSAC = new DevExpress.XtraEditors.CheckEdit();
            this.cmbMoneda = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSMonedas = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colintIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrSimbolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblConfiguracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbVendedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldecIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFecha = new DevExpress.XtraEditors.TextEdit();
            this.chkExonerado = new DevExpress.XtraEditors.CheckEdit();
            this.txtRUC = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtIdCotizacion = new DevExpress.XtraEditors.TextEdit();
            this.cmbClientes = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.BSClientes = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrSiglas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblVendedores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblClientesContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem41 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem42 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BSCotizacion = new System.Windows.Forms.BindingSource(this.components);
            this.BSTipoProducto = new System.Windows.Forms.BindingSource(this.components);
            this.BSPrecios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoInfAdicional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEquiv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductoHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductoHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStrProforma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMargen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit6View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContactos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarSAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExonerado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRUC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCotizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spDescuento);
            this.layoutControl1.Controls.Add(this.txtDescuento);
            this.layoutControl1.Controls.Add(this.mmoInfAdicional);
            this.layoutControl1.Controls.Add(this.txtTotalEquiv);
            this.layoutControl1.Controls.Add(this.grdProductoHist);
            this.layoutControl1.Controls.Add(this.txtStrProforma);
            this.layoutControl1.Controls.Add(this.btnEnviar);
            this.layoutControl1.Controls.Add(this.mmoObservaciones);
            this.layoutControl1.Controls.Add(this.txtCorreo);
            this.layoutControl1.Controls.Add(this.txtCelular);
            this.layoutControl1.Controls.Add(this.txtExtension);
            this.layoutControl1.Controls.Add(this.spMargen);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.btnAnular);
            this.layoutControl1.Controls.Add(this.txtTasa);
            this.layoutControl1.Controls.Add(this.cmbEstados);
            this.layoutControl1.Controls.Add(this.btnAprobar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtTotal);
            this.layoutControl1.Controls.Add(this.chkFactura);
            this.layoutControl1.Controls.Add(this.txtIVA);
            this.layoutControl1.Controls.Add(this.txtSubtotal);
            this.layoutControl1.Controls.Add(this.grdDetalleCotizacion);
            this.layoutControl1.Controls.Add(this.btnAgregarProducto);
            this.layoutControl1.Controls.Add(this.cmbProveedores);
            this.layoutControl1.Controls.Add(this.txtPrecio);
            this.layoutControl1.Controls.Add(this.txtCosto);
            this.layoutControl1.Controls.Add(this.txtCantidad);
            this.layoutControl1.Controls.Add(this.txtExistencia);
            this.layoutControl1.Controls.Add(this.cmbProductos);
            this.layoutControl1.Controls.Add(this.cmbContactos);
            this.layoutControl1.Controls.Add(this.chkMostrarSAC);
            this.layoutControl1.Controls.Add(this.cmbMoneda);
            this.layoutControl1.Controls.Add(this.cmbVendedor);
            this.layoutControl1.Controls.Add(this.txtFecha);
            this.layoutControl1.Controls.Add(this.chkExonerado);
            this.layoutControl1.Controls.Add(this.txtRUC);
            this.layoutControl1.Controls.Add(this.txtTelefono);
            this.layoutControl1.Controls.Add(this.txtDireccion);
            this.layoutControl1.Controls.Add(this.txtIdCotizacion);
            this.layoutControl1.Controls.Add(this.cmbClientes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(133, 116, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1027, 590);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spDescuento
            // 
            this.spDescuento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDescuento.Location = new System.Drawing.Point(780, 363);
            this.spDescuento.Name = "spDescuento";
            this.spDescuento.Properties.BeepOnError = false;
            this.spDescuento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDescuento.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spDescuento.Properties.MaskSettings.Set("mask", "n");
            this.spDescuento.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spDescuento.Size = new System.Drawing.Size(57, 20);
            this.spDescuento.StyleController = this.layoutControl1;
            this.spDescuento.TabIndex = 49;
            this.spDescuento.EditValueChanged += new System.EventHandler(this.spDescuento_EditValueChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(931, 363);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtDescuento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDescuento.Properties.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(72, 20);
            this.txtDescuento.StyleController = this.layoutControl1;
            this.txtDescuento.TabIndex = 48;
            // 
            // mmoInfAdicional
            // 
            this.mmoInfAdicional.Location = new System.Drawing.Point(24, 530);
            this.mmoInfAdicional.Name = "mmoInfAdicional";
            this.mmoInfAdicional.Size = new System.Drawing.Size(436, 36);
            this.mmoInfAdicional.StyleController = this.layoutControl1;
            this.mmoInfAdicional.TabIndex = 47;
            // 
            // txtTotalEquiv
            // 
            this.txtTotalEquiv.Location = new System.Drawing.Point(931, 435);
            this.txtTotalEquiv.Name = "txtTotalEquiv";
            this.txtTotalEquiv.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtTotalEquiv.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalEquiv.Properties.ReadOnly = true;
            this.txtTotalEquiv.Size = new System.Drawing.Size(72, 20);
            this.txtTotalEquiv.StyleController = this.layoutControl1;
            this.txtTotalEquiv.TabIndex = 46;
            // 
            // grdProductoHist
            // 
            this.grdProductoHist.DataSource = this.BSCotizacionDetalle;
            this.grdProductoHist.Location = new System.Drawing.Point(24, 360);
            this.grdProductoHist.MainView = this.vwProductoHist;
            this.grdProductoHist.Name = "grdProductoHist";
            this.grdProductoHist.Size = new System.Drawing.Size(648, 121);
            this.grdProductoHist.TabIndex = 45;
            this.grdProductoHist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwProductoHist});
            // 
            // BSCotizacionDetalle
            // 
            this.BSCotizacionDetalle.DataSource = typeof(Proforma.Models.tblDetalleCotizaciones);
            // 
            // vwProductoHist
            // 
            this.vwProductoHist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecSubtotal2,
            this.coldecIdDetalle1,
            this.coldecIdCotizacion1,
            this.coldecIdProducto2,
            this.coldecCantidad1,
            this.coldecPrecio4,
            this.coldecDescuento1,
            this.coldecCosto2,
            this.coldecIdProveedor1,
            this.colbitExonerado2,
            this.coldecIdUsuario1,
            this.colFechaMovimiento1,
            this.coltblCotizaciones2,
            this.coltblUsuarios2,
            this.coltblProductos2,
            this.coltblProveedores1,
            this.coldecMargen1,
            this.coltblProductos3,
            this.coltblCotizaciones3});
            this.vwProductoHist.GridControl = this.grdProductoHist;
            this.vwProductoHist.Name = "vwProductoHist";
            this.vwProductoHist.OptionsBehavior.Editable = false;
            this.vwProductoHist.OptionsView.ColumnAutoWidth = false;
            this.vwProductoHist.OptionsView.ShowAutoFilterRow = true;
            this.vwProductoHist.OptionsView.ShowGroupPanel = false;
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
            this.coldecSubtotal2.VisibleIndex = 9;
            // 
            // coldecIdDetalle1
            // 
            this.coldecIdDetalle1.FieldName = "decIdDetalle";
            this.coldecIdDetalle1.Name = "coldecIdDetalle1";
            // 
            // coldecIdCotizacion1
            // 
            this.coldecIdCotizacion1.FieldName = "decIdCotizacion";
            this.coldecIdCotizacion1.Name = "coldecIdCotizacion1";
            // 
            // coldecIdProducto2
            // 
            this.coldecIdProducto2.Caption = "Código";
            this.coldecIdProducto2.FieldName = "decIdProducto";
            this.coldecIdProducto2.Name = "coldecIdProducto2";
            this.coldecIdProducto2.Visible = true;
            this.coldecIdProducto2.VisibleIndex = 3;
            // 
            // coldecCantidad1
            // 
            this.coldecCantidad1.Caption = "Cantidad";
            this.coldecCantidad1.DisplayFormat.FormatString = "#,##0";
            this.coldecCantidad1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecCantidad1.FieldName = "decCantidad";
            this.coldecCantidad1.Name = "coldecCantidad1";
            this.coldecCantidad1.Visible = true;
            this.coldecCantidad1.VisibleIndex = 2;
            // 
            // coldecPrecio4
            // 
            this.coldecPrecio4.Caption = "Precio Unitario";
            this.coldecPrecio4.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecPrecio4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecPrecio4.FieldName = "decPrecio";
            this.coldecPrecio4.Name = "coldecPrecio4";
            this.coldecPrecio4.Visible = true;
            this.coldecPrecio4.VisibleIndex = 8;
            // 
            // coldecDescuento1
            // 
            this.coldecDescuento1.FieldName = "decDescuento";
            this.coldecDescuento1.Name = "coldecDescuento1";
            // 
            // coldecCosto2
            // 
            this.coldecCosto2.Caption = "Costo Unitario";
            this.coldecCosto2.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecCosto2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecCosto2.FieldName = "decCosto";
            this.coldecCosto2.Name = "coldecCosto2";
            this.coldecCosto2.Visible = true;
            this.coldecCosto2.VisibleIndex = 6;
            // 
            // coldecIdProveedor1
            // 
            this.coldecIdProveedor1.FieldName = "decIdProveedor";
            this.coldecIdProveedor1.Name = "coldecIdProveedor1";
            // 
            // colbitExonerado2
            // 
            this.colbitExonerado2.FieldName = "bitExonerado";
            this.colbitExonerado2.Name = "colbitExonerado2";
            // 
            // coldecIdUsuario1
            // 
            this.coldecIdUsuario1.FieldName = "decIdUsuario";
            this.coldecIdUsuario1.Name = "coldecIdUsuario1";
            // 
            // colFechaMovimiento1
            // 
            this.colFechaMovimiento1.FieldName = "FechaMovimiento";
            this.colFechaMovimiento1.Name = "colFechaMovimiento1";
            // 
            // coltblCotizaciones2
            // 
            this.coltblCotizaciones2.Caption = "No. Cotización";
            this.coltblCotizaciones2.FieldName = "tblCotizaciones.strNumCotizacion";
            this.coltblCotizaciones2.Name = "coltblCotizaciones2";
            this.coltblCotizaciones2.Visible = true;
            this.coltblCotizaciones2.VisibleIndex = 1;
            // 
            // coltblUsuarios2
            // 
            this.coltblUsuarios2.FieldName = "tblUsuarios";
            this.coltblUsuarios2.Name = "coltblUsuarios2";
            // 
            // coltblProductos2
            // 
            this.coltblProductos2.Caption = "Producto";
            this.coltblProductos2.FieldName = "tblProductos.strProducto";
            this.coltblProductos2.Name = "coltblProductos2";
            this.coltblProductos2.Visible = true;
            this.coltblProductos2.VisibleIndex = 4;
            // 
            // coltblProveedores1
            // 
            this.coltblProveedores1.Caption = "Proveedor";
            this.coltblProveedores1.FieldName = "tblProveedores.strNombre";
            this.coltblProveedores1.Name = "coltblProveedores1";
            this.coltblProveedores1.Visible = true;
            this.coltblProveedores1.VisibleIndex = 5;
            // 
            // coldecMargen1
            // 
            this.coldecMargen1.Caption = "% Margen";
            this.coldecMargen1.DisplayFormat.FormatString = "#,##0.00";
            this.coldecMargen1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecMargen1.FieldName = "decMargen";
            this.coldecMargen1.Name = "coldecMargen1";
            this.coldecMargen1.Visible = true;
            this.coldecMargen1.VisibleIndex = 7;
            // 
            // coltblProductos3
            // 
            this.coltblProductos3.Caption = "Código SAC";
            this.coltblProductos3.FieldName = "tblProductos.strReferencia";
            this.coltblProductos3.Name = "coltblProductos3";
            // 
            // coltblCotizaciones3
            // 
            this.coltblCotizaciones3.Caption = "Fecha";
            this.coltblCotizaciones3.FieldName = "tblCotizaciones.datFechaCreacion";
            this.coltblCotizaciones3.Name = "coltblCotizaciones3";
            this.coltblCotizaciones3.Visible = true;
            this.coltblCotizaciones3.VisibleIndex = 0;
            // 
            // txtStrProforma
            // 
            this.txtStrProforma.Location = new System.Drawing.Point(729, 45);
            this.txtStrProforma.Name = "txtStrProforma";
            this.txtStrProforma.Properties.ReadOnly = true;
            this.txtStrProforma.Size = new System.Drawing.Size(81, 20);
            this.txtStrProforma.StyleController = this.layoutControl1;
            this.txtStrProforma.TabIndex = 44;
            // 
            // btnEnviar
            // 
            this.btnEnviar.ImageOptions.ImageUri.Uri = "outlook%20inspired/glyph_mail;Size16x16";
            this.btnEnviar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEnviar.Location = new System.Drawing.Point(981, 459);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(22, 22);
            this.btnEnviar.StyleController = this.layoutControl1;
            this.btnEnviar.TabIndex = 43;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // mmoObservaciones
            // 
            this.mmoObservaciones.Location = new System.Drawing.Point(488, 530);
            this.mmoObservaciones.Name = "mmoObservaciones";
            this.mmoObservaciones.Size = new System.Drawing.Size(392, 36);
            this.mmoObservaciones.StyleController = this.layoutControl1;
            this.mmoObservaciones.TabIndex = 42;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(342, 45);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(114, 20);
            this.txtCorreo.StyleController = this.layoutControl1;
            this.txtCorreo.TabIndex = 40;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(355, 69);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(101, 20);
            this.txtCelular.StyleController = this.layoutControl1;
            this.txtCelular.TabIndex = 39;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(259, 69);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Properties.ReadOnly = true;
            this.txtExtension.Size = new System.Drawing.Size(50, 20);
            this.txtExtension.StyleController = this.layoutControl1;
            this.txtExtension.TabIndex = 38;
            // 
            // spMargen
            // 
            this.spMargen.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spMargen.Location = new System.Drawing.Point(546, 165);
            this.spMargen.Name = "spMargen";
            this.spMargen.Properties.BeepOnError = false;
            this.spMargen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spMargen.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spMargen.Properties.MaskSettings.Set("mask", "n");
            this.spMargen.Properties.UseMaskAsDisplayFormat = true;
            this.spMargen.Size = new System.Drawing.Size(50, 20);
            this.spMargen.StyleController = this.layoutControl1;
            this.spMargen.TabIndex = 37;
            this.spMargen.EditValueChanged += new System.EventHandler(this.spMargen_EditValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageOptions.ImageUri.Uri = "Print;Size16x16";
            this.btnImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnImprimir.Location = new System.Drawing.Point(955, 459);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(22, 22);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.ImageOptions.ImageUri.Uri = "Cancel;Size16x16";
            this.btnAnular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAnular.Location = new System.Drawing.Point(929, 459);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(22, 22);
            this.btnAnular.StyleController = this.layoutControl1;
            this.btnAnular.TabIndex = 35;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(564, 93);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Properties.ReadOnly = true;
            this.txtTasa.Size = new System.Drawing.Size(121, 20);
            this.txtTasa.StyleController = this.layoutControl1;
            this.txtTasa.TabIndex = 34;
            // 
            // cmbEstados
            // 
            this.cmbEstados.Location = new System.Drawing.Point(815, 69);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstados.Properties.DataSource = this.BSEstados;
            this.cmbEstados.Properties.DisplayMember = "strDescripcion";
            this.cmbEstados.Properties.NullText = "";
            this.cmbEstados.Properties.ReadOnly = true;
            this.cmbEstados.Properties.ValueMember = "intIdEstado";
            this.cmbEstados.Size = new System.Drawing.Size(188, 20);
            this.cmbEstados.StyleController = this.layoutControl1;
            this.cmbEstados.TabIndex = 33;
            this.cmbEstados.EditValueChanged += new System.EventHandler(this.cmbEstados_EditValueChanged);
            // 
            // BSEstados
            // 
            this.BSEstados.DataSource = typeof(Proforma.Models.tblEstados);
            // 
            // btnAprobar
            // 
            this.btnAprobar.ImageOptions.ImageUri.Uri = "Apply;Size16x16";
            this.btnAprobar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAprobar.Location = new System.Drawing.Point(903, 459);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(22, 22);
            this.btnAprobar.StyleController = this.layoutControl1;
            this.btnAprobar.TabIndex = 32;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(877, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(22, 22);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(851, 459);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(22, 22);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(931, 411);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.BeepOnError = false;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(72, 20);
            this.txtTotal.StyleController = this.layoutControl1;
            this.txtTotal.TabIndex = 29;
            // 
            // chkFactura
            // 
            this.chkFactura.Location = new System.Drawing.Point(689, 93);
            this.chkFactura.Name = "chkFactura";
            this.chkFactura.Properties.Caption = "Factura";
            this.chkFactura.Properties.ReadOnly = true;
            this.chkFactura.Size = new System.Drawing.Size(314, 20);
            this.chkFactura.StyleController = this.layoutControl1;
            this.chkFactura.TabIndex = 28;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(931, 387);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtIVA.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIVA.Properties.BeepOnError = false;
            this.txtIVA.Properties.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(72, 20);
            this.txtIVA.StyleController = this.layoutControl1;
            this.txtIVA.TabIndex = 26;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(931, 339);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.BeepOnError = false;
            this.txtSubtotal.Properties.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(72, 20);
            this.txtSubtotal.StyleController = this.layoutControl1;
            this.txtSubtotal.TabIndex = 25;
            // 
            // grdDetalleCotizacion
            // 
            this.grdDetalleCotizacion.DataSource = this.BSCotizacionDetalle;
            this.grdDetalleCotizacion.Location = new System.Drawing.Point(12, 203);
            this.grdDetalleCotizacion.MainView = this.vwDetalleCotizacion;
            this.grdDetalleCotizacion.Name = "grdDetalleCotizacion";
            this.grdDetalleCotizacion.Size = new System.Drawing.Size(1003, 120);
            this.grdDetalleCotizacion.TabIndex = 23;
            this.grdDetalleCotizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwDetalleCotizacion});
            // 
            // vwDetalleCotizacion
            // 
            this.vwDetalleCotizacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdDetalle,
            this.coldecIdCotizacion,
            this.coldecIdProducto1,
            this.coldecCantidad,
            this.coldecPrecio,
            this.coldecDescuento,
            this.coldecCosto1,
            this.coldecIdProveedor,
            this.colbitExonerado1,
            this.coldecIdUsuario,
            this.colFechaMovimiento,
            this.coltblCotizaciones1,
            this.coltblUsuarios1,
            this.coltblProductos,
            this.coldecSubtotal,
            this.coltblProveedores,
            this.coltblProductos1,
            this.coldecMargen});
            this.vwDetalleCotizacion.GridControl = this.grdDetalleCotizacion;
            this.vwDetalleCotizacion.Name = "vwDetalleCotizacion";
            this.vwDetalleCotizacion.OptionsView.ShowGroupPanel = false;
            this.vwDetalleCotizacion.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.vwDetalleCotizacion_RowCellClick);
            this.vwDetalleCotizacion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vwDetalleCotizacion_CellValueChanged);
            this.vwDetalleCotizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vwDetalleCotizacion_KeyDown);
            // 
            // coldecIdDetalle
            // 
            this.coldecIdDetalle.FieldName = "decIdDetalle";
            this.coldecIdDetalle.Name = "coldecIdDetalle";
            // 
            // coldecIdCotizacion
            // 
            this.coldecIdCotizacion.FieldName = "decIdCotizacion";
            this.coldecIdCotizacion.Name = "coldecIdCotizacion";
            // 
            // coldecIdProducto1
            // 
            this.coldecIdProducto1.Caption = "Código";
            this.coldecIdProducto1.FieldName = "decIdProducto";
            this.coldecIdProducto1.Name = "coldecIdProducto1";
            this.coldecIdProducto1.OptionsColumn.AllowEdit = false;
            this.coldecIdProducto1.Visible = true;
            this.coldecIdProducto1.VisibleIndex = 1;
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
            // coldecDescuento
            // 
            this.coldecDescuento.FieldName = "decDescuento";
            this.coldecDescuento.Name = "coldecDescuento";
            // 
            // coldecCosto1
            // 
            this.coldecCosto1.Caption = "Costo Unitario";
            this.coldecCosto1.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecCosto1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecCosto1.FieldName = "decCosto";
            this.coldecCosto1.Name = "coldecCosto1";
            this.coldecCosto1.Visible = true;
            this.coldecCosto1.VisibleIndex = 4;
            // 
            // coldecIdProveedor
            // 
            this.coldecIdProveedor.Caption = "Proveedor";
            this.coldecIdProveedor.FieldName = "decIdProveedor";
            this.coldecIdProveedor.Name = "coldecIdProveedor";
            // 
            // colbitExonerado1
            // 
            this.colbitExonerado1.FieldName = "bitExonerado";
            this.colbitExonerado1.Name = "colbitExonerado1";
            // 
            // coldecIdUsuario
            // 
            this.coldecIdUsuario.FieldName = "decIdUsuario";
            this.coldecIdUsuario.Name = "coldecIdUsuario";
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
            // coltblUsuarios1
            // 
            this.coltblUsuarios1.FieldName = "tblUsuarios";
            this.coltblUsuarios1.Name = "coltblUsuarios1";
            // 
            // coltblProductos
            // 
            this.coltblProductos.Caption = "Código SAC";
            this.coltblProductos.FieldName = "tblProductos.strReferencia";
            this.coltblProductos.Name = "coltblProductos";
            this.coltblProductos.OptionsColumn.AllowEdit = false;
            // 
            // coldecSubtotal
            // 
            this.coldecSubtotal.Caption = "SubTotal";
            this.coldecSubtotal.DisplayFormat.FormatString = "#,##0.0000";
            this.coldecSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldecSubtotal.FieldName = "coldecSubtotal";
            this.coldecSubtotal.Name = "coldecSubtotal";
            this.coldecSubtotal.OptionsColumn.AllowEdit = false;
            this.coldecSubtotal.ShowUnboundExpressionMenu = true;
            this.coldecSubtotal.UnboundDataType = typeof(decimal);
            this.coldecSubtotal.UnboundExpression = "[decCantidad] * [decPrecio]";
            this.coldecSubtotal.Visible = true;
            this.coldecSubtotal.VisibleIndex = 7;
            // 
            // coltblProveedores
            // 
            this.coltblProveedores.Caption = "Proveedor";
            this.coltblProveedores.FieldName = "tblProveedores.strNombre";
            this.coltblProveedores.Name = "coltblProveedores";
            this.coltblProveedores.OptionsColumn.AllowEdit = false;
            this.coltblProveedores.Visible = true;
            this.coltblProveedores.VisibleIndex = 3;
            // 
            // coltblProductos1
            // 
            this.coltblProductos1.Caption = "Producto";
            this.coltblProductos1.FieldName = "tblProductos.strProducto";
            this.coltblProductos1.Name = "coltblProductos1";
            this.coltblProductos1.OptionsColumn.AllowEdit = false;
            this.coltblProductos1.Visible = true;
            this.coltblProductos1.VisibleIndex = 2;
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
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.ImageOptions.ImageUri.Uri = "AddItem;Size16x16";
            this.btnAgregarProducto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(979, 165);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(24, 22);
            this.btnAgregarProducto.StyleController = this.layoutControl1;
            this.btnAgregarProducto.TabIndex = 22;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Location = new System.Drawing.Point(857, 165);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedores.Properties.DataSource = this.BSProveedores;
            this.cmbProveedores.Properties.DisplayMember = "strNombre";
            this.cmbProveedores.Properties.NullText = "";
            this.cmbProveedores.Properties.PopupView = this.searchLookUpEdit6View;
            this.cmbProveedores.Properties.ValueMember = "decIdProveedor";
            this.cmbProveedores.Size = new System.Drawing.Size(118, 20);
            this.cmbProveedores.StyleController = this.layoutControl1;
            this.cmbProveedores.TabIndex = 21;
            // 
            // BSProveedores
            // 
            this.BSProveedores.DataSource = typeof(Proforma.Models.tblProveedores);
            // 
            // searchLookUpEdit6View
            // 
            this.searchLookUpEdit6View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21});
            this.searchLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit6View.Name = "searchLookUpEdit6View";
            this.searchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "decIdProveedor";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Proveedor";
            this.gridColumn15.FieldName = "strNombre";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Dirección";
            this.gridColumn16.FieldName = "strDireccion";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 1;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Teléfono";
            this.gridColumn17.FieldName = "strTelefono";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 2;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Exonerado";
            this.gridColumn18.FieldName = "bitExonerado";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 3;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "RUC";
            this.gridColumn19.FieldName = "strRUC";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 4;
            // 
            // gridColumn20
            // 
            this.gridColumn20.FieldName = "tblDetalleCotizaciones";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "tblProductosXProveedor";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(638, 165);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.BeepOnError = false;
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecio.Properties.MaskSettings.Set("mask", "n4");
            this.txtPrecio.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrecio.Size = new System.Drawing.Size(50, 20);
            this.txtPrecio.StyleController = this.layoutControl1;
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.EditValueChanged += new System.EventHandler(this.txtPrecio_EditValueChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(433, 165);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.BeepOnError = false;
            this.txtCosto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCosto.Properties.MaskSettings.Set("mask", "n4");
            this.txtCosto.Properties.UseMaskAsDisplayFormat = true;
            this.txtCosto.Size = new System.Drawing.Size(50, 20);
            this.txtCosto.StyleController = this.layoutControl1;
            this.txtCosto.TabIndex = 19;
            this.txtCosto.EditValueChanged += new System.EventHandler(this.txtCosto_EditValueChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(744, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.BeepOnError = false;
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidad.Properties.MaskSettings.Set("mask", "d");
            this.txtCantidad.Properties.UseMaskAsDisplayFormat = true;
            this.txtCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad.StyleController = this.layoutControl1;
            this.txtCantidad.TabIndex = 18;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(342, 165);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Properties.BeepOnError = false;
            this.txtExistencia.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtExistencia.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtExistencia.Properties.MaskSettings.Set("mask", "d");
            this.txtExistencia.Properties.ReadOnly = true;
            this.txtExistencia.Properties.UseMaskAsDisplayFormat = true;
            this.txtExistencia.Size = new System.Drawing.Size(50, 20);
            this.txtExistencia.StyleController = this.layoutControl1;
            this.txtExistencia.TabIndex = 17;
            // 
            // cmbProductos
            // 
            this.cmbProductos.Location = new System.Drawing.Point(104, 165);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductos.Properties.DataSource = this.BSProductos;
            this.cmbProductos.Properties.DisplayMember = "strProducto";
            this.cmbProductos.Properties.NullText = "";
            this.cmbProductos.Properties.PopupView = this.searchLookUpEdit5View;
            this.cmbProductos.Properties.ValueMember = "decIdProducto";
            this.cmbProductos.Size = new System.Drawing.Size(177, 20);
            this.cmbProductos.StyleController = this.layoutControl1;
            this.cmbProductos.TabIndex = 16;
            this.cmbProductos.EditValueChanged += new System.EventHandler(this.cmbProductos_EditValueChanged);
            // 
            // BSProductos
            // 
            this.BSProductos.DataSource = typeof(Proforma.Models.tblProductos);
            // 
            // searchLookUpEdit5View
            // 
            this.searchLookUpEdit5View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdProducto,
            this.colstrProducto,
            this.colstrReferencia,
            this.coldecCosto,
            this.coldecPrecio1,
            this.coldecPrecio2,
            this.coldecPrecio3,
            this.colintMoneda,
            this.coldecExistencia,
            this.colbitNoExistencia,
            this.colbitActivo,
            this.colbitExonerado,
            this.coldecIdTipoProducto,
            this.colintIdPrecio,
            this.coltblDetalleCotizaciones,
            this.coltblMonedas,
            this.coltblPrecios,
            this.coltblTipoProductos,
            this.coltblProductosXProveedor});
            this.searchLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
            this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
            // 
            // coldecIdProducto
            // 
            this.coldecIdProducto.Caption = "Código";
            this.coldecIdProducto.FieldName = "decIdProducto";
            this.coldecIdProducto.Name = "coldecIdProducto";
            this.coldecIdProducto.Visible = true;
            this.coldecIdProducto.VisibleIndex = 0;
            // 
            // colstrProducto
            // 
            this.colstrProducto.Caption = "Descripción";
            this.colstrProducto.FieldName = "strProducto";
            this.colstrProducto.Name = "colstrProducto";
            this.colstrProducto.Visible = true;
            this.colstrProducto.VisibleIndex = 1;
            // 
            // colstrReferencia
            // 
            this.colstrReferencia.Caption = "Código SAC";
            this.colstrReferencia.FieldName = "strReferencia";
            this.colstrReferencia.Name = "colstrReferencia";
            this.colstrReferencia.Visible = true;
            this.colstrReferencia.VisibleIndex = 2;
            // 
            // coldecCosto
            // 
            this.coldecCosto.Caption = "Costo";
            this.coldecCosto.FieldName = "decCosto";
            this.coldecCosto.Name = "coldecCosto";
            this.coldecCosto.Visible = true;
            this.coldecCosto.VisibleIndex = 3;
            // 
            // coldecPrecio1
            // 
            this.coldecPrecio1.Caption = "Precio 1";
            this.coldecPrecio1.FieldName = "decPrecio1";
            this.coldecPrecio1.Name = "coldecPrecio1";
            this.coldecPrecio1.Visible = true;
            this.coldecPrecio1.VisibleIndex = 4;
            // 
            // coldecPrecio2
            // 
            this.coldecPrecio2.Caption = "Precio 2";
            this.coldecPrecio2.FieldName = "decPrecio2";
            this.coldecPrecio2.Name = "coldecPrecio2";
            this.coldecPrecio2.Visible = true;
            this.coldecPrecio2.VisibleIndex = 5;
            // 
            // coldecPrecio3
            // 
            this.coldecPrecio3.Caption = "Precio 3";
            this.coldecPrecio3.FieldName = "decPrecio3";
            this.coldecPrecio3.Name = "coldecPrecio3";
            this.coldecPrecio3.Visible = true;
            this.coldecPrecio3.VisibleIndex = 6;
            // 
            // colintMoneda
            // 
            this.colintMoneda.Caption = "Moneda";
            this.colintMoneda.FieldName = "intMoneda";
            this.colintMoneda.Name = "colintMoneda";
            // 
            // coldecExistencia
            // 
            this.coldecExistencia.Caption = "Existencia";
            this.coldecExistencia.FieldName = "decExistencia";
            this.coldecExistencia.Name = "coldecExistencia";
            this.coldecExistencia.Visible = true;
            this.coldecExistencia.VisibleIndex = 7;
            // 
            // colbitNoExistencia
            // 
            this.colbitNoExistencia.Caption = "No Existencia";
            this.colbitNoExistencia.FieldName = "bitNoExistencia";
            this.colbitNoExistencia.Name = "colbitNoExistencia";
            this.colbitNoExistencia.Visible = true;
            this.colbitNoExistencia.VisibleIndex = 8;
            // 
            // colbitActivo
            // 
            this.colbitActivo.FieldName = "bitActivo";
            this.colbitActivo.Name = "colbitActivo";
            // 
            // colbitExonerado
            // 
            this.colbitExonerado.Caption = "Exonerado";
            this.colbitExonerado.FieldName = "bitExonerado";
            this.colbitExonerado.Name = "colbitExonerado";
            this.colbitExonerado.Visible = true;
            this.colbitExonerado.VisibleIndex = 9;
            // 
            // coldecIdTipoProducto
            // 
            this.coldecIdTipoProducto.Caption = "Tipo Producto";
            this.coldecIdTipoProducto.FieldName = "decIdTipoProducto";
            this.coldecIdTipoProducto.Name = "coldecIdTipoProducto";
            // 
            // colintIdPrecio
            // 
            this.colintIdPrecio.Caption = "Precio por Defecto";
            this.colintIdPrecio.FieldName = "intIdPrecio";
            this.colintIdPrecio.Name = "colintIdPrecio";
            // 
            // coltblDetalleCotizaciones
            // 
            this.coltblDetalleCotizaciones.FieldName = "tblDetalleCotizaciones";
            this.coltblDetalleCotizaciones.Name = "coltblDetalleCotizaciones";
            // 
            // coltblMonedas
            // 
            this.coltblMonedas.Caption = "Moneda";
            this.coltblMonedas.FieldName = "tblMonedas.strDescripcion";
            this.coltblMonedas.Name = "coltblMonedas";
            this.coltblMonedas.Visible = true;
            this.coltblMonedas.VisibleIndex = 10;
            // 
            // coltblPrecios
            // 
            this.coltblPrecios.Caption = "Precio por Defecto";
            this.coltblPrecios.FieldName = "tblPrecios.strDescripcion";
            this.coltblPrecios.Name = "coltblPrecios";
            this.coltblPrecios.Visible = true;
            this.coltblPrecios.VisibleIndex = 12;
            // 
            // coltblTipoProductos
            // 
            this.coltblTipoProductos.Caption = "Tipo Producto";
            this.coltblTipoProductos.FieldName = "tblTipoProductos.strTipoProducto";
            this.coltblTipoProductos.Name = "coltblTipoProductos";
            this.coltblTipoProductos.Visible = true;
            this.coltblTipoProductos.VisibleIndex = 11;
            // 
            // coltblProductosXProveedor
            // 
            this.coltblProductosXProveedor.FieldName = "tblProductosXProveedor";
            this.coltblProductosXProveedor.Name = "coltblProductosXProveedor";
            // 
            // cmbContactos
            // 
            this.cmbContactos.Location = new System.Drawing.Point(104, 45);
            this.cmbContactos.Name = "cmbContactos";
            this.cmbContactos.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbContactos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbContactos.Properties.DataSource = this.BSContactos;
            this.cmbContactos.Properties.DisplayMember = "strNombreContacto";
            this.cmbContactos.Properties.NullText = "";
            this.cmbContactos.Properties.PopupView = this.searchLookUpEdit4View;
            this.cmbContactos.Properties.ValueMember = "decIdContacto";
            this.cmbContactos.Size = new System.Drawing.Size(192, 20);
            this.cmbContactos.StyleController = this.layoutControl1;
            this.cmbContactos.TabIndex = 15;
            this.cmbContactos.EditValueChanged += new System.EventHandler(this.cmbContactos_EditValueChanged);
            // 
            // BSContactos
            // 
            this.BSContactos.DataSource = typeof(Proforma.Models.tblClientesContacto);
            // 
            // searchLookUpEdit4View
            // 
            this.searchLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdContacto,
            this.coldecIdCliente,
            this.colstrNombreContacto,
            this.colstrTelefono,
            this.colstrExtension,
            this.colstrCelular,
            this.colstrCorreo,
            this.coltblClientes,
            this.coltblCotizaciones});
            this.searchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
            this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // coldecIdContacto
            // 
            this.coldecIdContacto.FieldName = "decIdContacto";
            this.coldecIdContacto.Name = "coldecIdContacto";
            // 
            // coldecIdCliente
            // 
            this.coldecIdCliente.Caption = "Cliente";
            this.coldecIdCliente.FieldName = "decIdCliente";
            this.coldecIdCliente.Name = "coldecIdCliente";
            // 
            // colstrNombreContacto
            // 
            this.colstrNombreContacto.Caption = "Nombre Contacto";
            this.colstrNombreContacto.FieldName = "strNombreContacto";
            this.colstrNombreContacto.Name = "colstrNombreContacto";
            this.colstrNombreContacto.Visible = true;
            this.colstrNombreContacto.VisibleIndex = 1;
            // 
            // colstrTelefono
            // 
            this.colstrTelefono.Caption = "Teléfono";
            this.colstrTelefono.FieldName = "strTelefono";
            this.colstrTelefono.Name = "colstrTelefono";
            this.colstrTelefono.Visible = true;
            this.colstrTelefono.VisibleIndex = 2;
            // 
            // colstrExtension
            // 
            this.colstrExtension.Caption = "Extensión";
            this.colstrExtension.FieldName = "strExtension";
            this.colstrExtension.Name = "colstrExtension";
            this.colstrExtension.Visible = true;
            this.colstrExtension.VisibleIndex = 3;
            // 
            // colstrCelular
            // 
            this.colstrCelular.Caption = "Celular";
            this.colstrCelular.FieldName = "strCelular";
            this.colstrCelular.Name = "colstrCelular";
            this.colstrCelular.Visible = true;
            this.colstrCelular.VisibleIndex = 4;
            // 
            // colstrCorreo
            // 
            this.colstrCorreo.Caption = "Correo Electrónico";
            this.colstrCorreo.FieldName = "strCorreo";
            this.colstrCorreo.Name = "colstrCorreo";
            this.colstrCorreo.Visible = true;
            this.colstrCorreo.VisibleIndex = 5;
            // 
            // coltblClientes
            // 
            this.coltblClientes.Caption = "Cliente";
            this.coltblClientes.FieldName = "tblClientes.strNombre";
            this.coltblClientes.Name = "coltblClientes";
            this.coltblClientes.Visible = true;
            this.coltblClientes.VisibleIndex = 0;
            // 
            // coltblCotizaciones
            // 
            this.coltblCotizaciones.FieldName = "tblCotizaciones";
            this.coltblCotizaciones.Name = "coltblCotizaciones";
            // 
            // chkMostrarSAC
            // 
            this.chkMostrarSAC.Location = new System.Drawing.Point(884, 530);
            this.chkMostrarSAC.Name = "chkMostrarSAC";
            this.chkMostrarSAC.Properties.Caption = "Mostrar Código SAC";
            this.chkMostrarSAC.Size = new System.Drawing.Size(119, 20);
            this.chkMostrarSAC.StyleController = this.layoutControl1;
            this.chkMostrarSAC.TabIndex = 14;
            this.chkMostrarSAC.CheckedChanged += new System.EventHandler(this.chkMostrarSAC_CheckedChanged);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Location = new System.Drawing.Point(953, 45);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMoneda.Properties.DataSource = this.BSMonedas;
            this.cmbMoneda.Properties.DisplayMember = "strDescripcion";
            this.cmbMoneda.Properties.NullText = "";
            this.cmbMoneda.Properties.PopupView = this.searchLookUpEdit3View;
            this.cmbMoneda.Properties.ReadOnly = true;
            this.cmbMoneda.Properties.ValueMember = "intIdMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(50, 20);
            this.cmbMoneda.StyleController = this.layoutControl1;
            this.cmbMoneda.TabIndex = 13;
            // 
            // BSMonedas
            // 
            this.BSMonedas.DataSource = typeof(Proforma.Models.tblMonedas);
            // 
            // searchLookUpEdit3View
            // 
            this.searchLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colintIdMoneda,
            this.colstrDescripcion,
            this.colstrSimbolo,
            this.coltblConfiguracion,
            this.gridColumn5});
            this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colintIdMoneda
            // 
            this.colintIdMoneda.FieldName = "intIdMoneda";
            this.colintIdMoneda.Name = "colintIdMoneda";
            // 
            // colstrDescripcion
            // 
            this.colstrDescripcion.Caption = "Moneda";
            this.colstrDescripcion.FieldName = "strDescripcion";
            this.colstrDescripcion.Name = "colstrDescripcion";
            this.colstrDescripcion.Visible = true;
            this.colstrDescripcion.VisibleIndex = 0;
            // 
            // colstrSimbolo
            // 
            this.colstrSimbolo.Caption = "Símbolo";
            this.colstrSimbolo.FieldName = "strSimbolo";
            this.colstrSimbolo.Name = "colstrSimbolo";
            this.colstrSimbolo.Visible = true;
            this.colstrSimbolo.VisibleIndex = 1;
            // 
            // coltblConfiguracion
            // 
            this.coltblConfiguracion.FieldName = "tblConfiguracion";
            this.coltblConfiguracion.Name = "coltblConfiguracion";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "tblProductos";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.Location = new System.Drawing.Point(564, 69);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVendedor.Properties.DataSource = this.BSVendedores;
            this.cmbVendedor.Properties.DisplayMember = "strNombreVendedor";
            this.cmbVendedor.Properties.NullText = "";
            this.cmbVendedor.Properties.PopupView = this.searchLookUpEdit2View;
            this.cmbVendedor.Properties.ValueMember = "decIdVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(205, 20);
            this.cmbVendedor.StyleController = this.layoutControl1;
            this.cmbVendedor.TabIndex = 12;
            // 
            // BSVendedores
            // 
            this.BSVendedores.DataSource = typeof(Proforma.Models.tblVendedores);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldecIdVendedor,
            this.colstrNombreVendedor,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.coltblUsuarios,
            this.gridColumn4});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Teléfono";
            this.gridColumn1.FieldName = "strTelefono";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Correo Electrónico";
            this.gridColumn2.FieldName = "strCorreo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "tblCotizaciones";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // coltblUsuarios
            // 
            this.coltblUsuarios.FieldName = "tblUsuarios";
            this.coltblUsuarios.Name = "coltblUsuarios";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "tblClientes";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(852, 45);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Properties.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(50, 20);
            this.txtFecha.StyleController = this.layoutControl1;
            this.txtFecha.TabIndex = 11;
            // 
            // chkExonerado
            // 
            this.chkExonerado.Location = new System.Drawing.Point(381, 93);
            this.chkExonerado.Name = "chkExonerado";
            this.chkExonerado.Properties.Caption = "Exonerado";
            this.chkExonerado.Properties.ReadOnly = true;
            this.chkExonerado.Size = new System.Drawing.Size(75, 20);
            this.chkExonerado.StyleController = this.layoutControl1;
            this.chkExonerado.TabIndex = 10;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(285, 93);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Properties.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(92, 20);
            this.txtRUC.StyleController = this.layoutControl1;
            this.txtRUC.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(104, 69);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(95, 20);
            this.txtTelefono.StyleController = this.layoutControl1;
            this.txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 117);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(352, 20);
            this.txtDireccion.StyleController = this.layoutControl1;
            this.txtDireccion.TabIndex = 7;
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Location = new System.Drawing.Point(564, 45);
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.Properties.ReadOnly = true;
            this.txtIdCotizacion.Size = new System.Drawing.Size(81, 20);
            this.txtIdCotizacion.StyleController = this.layoutControl1;
            this.txtIdCotizacion.TabIndex = 5;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(104, 93);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbClientes.Properties.DataSource = this.BSClientes;
            this.cmbClientes.Properties.DisplayMember = "strNombre";
            this.cmbClientes.Properties.NullText = "";
            this.cmbClientes.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbClientes.Properties.ReadOnly = true;
            this.cmbClientes.Properties.ValueMember = "decIdCliente";
            this.cmbClientes.Size = new System.Drawing.Size(147, 20);
            this.cmbClientes.StyleController = this.layoutControl1;
            this.cmbClientes.TabIndex = 4;
            // 
            // BSClientes
            // 
            this.BSClientes.DataSource = typeof(Proforma.Models.tblClientes);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.colstrNombre,
            this.colstrDireccion,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.colstrRUC,
            this.colstrSiglas,
            this.coltblVendedores,
            this.coltblClientesContacto,
            this.gridColumn12,
            this.gridColumn13});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Código";
            this.gridColumn6.FieldName = "decIdCliente";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // colstrNombre
            // 
            this.colstrNombre.Caption = "Empresa";
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
            this.colstrDireccion.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Teléfono";
            this.gridColumn7.FieldName = "strTelefono";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "decIdVendedor";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Exonerado";
            this.gridColumn9.FieldName = "bitExonerado";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "intIdPrecio";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "bitActivo";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // colstrRUC
            // 
            this.colstrRUC.Caption = "RUC";
            this.colstrRUC.FieldName = "strRUC";
            this.colstrRUC.Name = "colstrRUC";
            this.colstrRUC.Visible = true;
            this.colstrRUC.VisibleIndex = 3;
            // 
            // colstrSiglas
            // 
            this.colstrSiglas.Caption = "Siglas";
            this.colstrSiglas.FieldName = "strSiglas";
            this.colstrSiglas.Name = "colstrSiglas";
            this.colstrSiglas.Visible = true;
            this.colstrSiglas.VisibleIndex = 2;
            // 
            // coltblVendedores
            // 
            this.coltblVendedores.FieldName = "tblVendedores";
            this.coltblVendedores.Name = "coltblVendedores";
            // 
            // coltblClientesContacto
            // 
            this.coltblClientesContacto.FieldName = "tblClientesContacto";
            this.coltblClientesContacto.Name = "coltblClientesContacto";
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "tblCotizaciones";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "tblPrecios";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem20,
            this.layoutControlGroup5,
            this.layoutControlGroup6,
            this.layoutControlGroup4,
            this.layoutControlGroup7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1027, 590);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem12,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem33,
            this.layoutControlItem34,
            this.layoutControlItem6,
            this.layoutControlItem35,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(460, 141);
            this.layoutControlGroup1.Text = "Datos del Cliente";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDireccion;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItem4.Text = "Dirección:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.cmbContactos;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(276, 24);
            this.layoutControlItem12.Text = "Contacto:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtTelefono;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem5.Text = "Teléfono:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbClientes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(231, 24);
            this.layoutControlItem1.Text = "Cliente:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.txtExtension;
            this.layoutControlItem33.Location = new System.Drawing.Point(179, 24);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem33.Text = "Extensión:";
            this.layoutControlItem33.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem33.TextSize = new System.Drawing.Size(51, 13);
            this.layoutControlItem33.TextToControlDistance = 5;
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.txtCelular;
            this.layoutControlItem34.Location = new System.Drawing.Point(289, 24);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(147, 24);
            this.layoutControlItem34.Text = "Celular:";
            this.layoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem34.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem34.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtRUC;
            this.layoutControlItem6.Location = new System.Drawing.Point(231, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem6.Text = "RUC:";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(25, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.txtCorreo;
            this.layoutControlItem35.Location = new System.Drawing.Point(276, 0);
            this.layoutControlItem35.Name = "layoutControlItem35";
            this.layoutControlItem35.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem35.Text = "Correo:";
            this.layoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem35.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem35.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkExonerado;
            this.layoutControlItem7.Location = new System.Drawing.Point(357, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(79, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem24,
            this.layoutControlItem8,
            this.layoutControlItem29,
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem37});
            this.layoutControlGroup2.Location = new System.Drawing.Point(460, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(547, 141);
            this.layoutControlGroup2.Text = "Datos de Cotización";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtIdCotizacion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(165, 24);
            this.layoutControlItem2.Text = "Proforma No.:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.chkFactura;
            this.layoutControlItem24.Location = new System.Drawing.Point(205, 48);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(318, 48);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtFecha;
            this.layoutControlItem8.Location = new System.Drawing.Point(330, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(92, 24);
            this.layoutControlItem8.Text = "Fecha:";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(33, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.txtTasa;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(205, 48);
            this.layoutControlItem29.Text = "T/C:";
            this.layoutControlItem29.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbEstados;
            this.layoutControlItem3.Location = new System.Drawing.Point(289, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(234, 24);
            this.layoutControlItem3.Text = "Estado:";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cmbMoneda;
            this.layoutControlItem10.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(101, 24);
            this.layoutControlItem10.Text = "Moneda:";
            this.layoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(42, 13);
            this.layoutControlItem10.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cmbVendedor;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(289, 24);
            this.layoutControlItem9.Text = "Vendedor:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.txtStrProforma;
            this.layoutControlItem37.Location = new System.Drawing.Point(165, 0);
            this.layoutControlItem37.Name = "layoutControlItem37";
            this.layoutControlItem37.Size = new System.Drawing.Size(165, 24);
            this.layoutControlItem37.Text = "No. Proforma:";
            this.layoutControlItem37.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem15,
            this.layoutControlItem19,
            this.layoutControlItem32});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 141);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1007, 50);
            this.layoutControlGroup3.Text = "Agregar Productos";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cmbProductos;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(261, 26);
            this.layoutControlItem13.Text = "Producto:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtExistencia;
            this.layoutControlItem14.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem14.Text = "Existencia:";
            this.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(52, 13);
            this.layoutControlItem14.TextToControlDistance = 5;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtCosto;
            this.layoutControlItem16.Location = new System.Drawing.Point(372, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem16.Text = "Costo:";
            this.layoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(32, 13);
            this.layoutControlItem16.TextToControlDistance = 5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtPrecio;
            this.layoutControlItem17.Location = new System.Drawing.Point(576, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem17.Text = "Precio:";
            this.layoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(33, 13);
            this.layoutControlItem17.TextToControlDistance = 5;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.cmbProveedores;
            this.layoutControlItem18.Location = new System.Drawing.Point(774, 0);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem18.Text = "Proveedor:";
            this.layoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem18.TextToControlDistance = 5;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtCantidad;
            this.layoutControlItem15.Location = new System.Drawing.Point(668, 0);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(106, 26);
            this.layoutControlItem15.Text = "Cantidad:";
            this.layoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(47, 13);
            this.layoutControlItem15.TextToControlDistance = 5;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnAgregarProducto;
            this.layoutControlItem19.Location = new System.Drawing.Point(955, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.spMargen;
            this.layoutControlItem32.Location = new System.Drawing.Point(463, 0);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(113, 26);
            this.layoutControlItem32.Text = "% Margen:";
            this.layoutControlItem32.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem32.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem32.TextToControlDistance = 5;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.grdDetalleCotizacion;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(1007, 124);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem22,
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27,
            this.layoutControlItem28,
            this.layoutControlItem30,
            this.layoutControlItem36,
            this.layoutControlItem31,
            this.layoutControlItem23,
            this.layoutControlItem39,
            this.layoutControlItem41,
            this.emptySpaceItem1,
            this.layoutControlItem42,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup5.Location = new System.Drawing.Point(676, 315);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(331, 170);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.txtSubtotal;
            this.layoutControlItem22.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem22.Text = "SUBTOTAL";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.txtTotal;
            this.layoutControlItem25.Location = new System.Drawing.Point(151, 72);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem25.Text = "TOTAL";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.btnAgregar;
            this.layoutControlItem26.Location = new System.Drawing.Point(151, 120);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem26.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem26.TextVisible = false;
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.btnGuardar;
            this.layoutControlItem27.Location = new System.Drawing.Point(177, 120);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.btnAprobar;
            this.layoutControlItem28.Location = new System.Drawing.Point(203, 120);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.btnAnular;
            this.layoutControlItem30.Location = new System.Drawing.Point(229, 120);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem30.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem30.TextVisible = false;
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.btnEnviar;
            this.layoutControlItem36.Location = new System.Drawing.Point(281, 120);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem36.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem36.TextVisible = false;
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.btnImprimir;
            this.layoutControlItem31.Location = new System.Drawing.Point(255, 120);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem31.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem31.TextVisible = false;
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.txtIVA;
            this.layoutControlItem23.Location = new System.Drawing.Point(151, 48);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem23.Text = "IVA";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.txtTotalEquiv;
            this.layoutControlItem39.Location = new System.Drawing.Point(151, 96);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem39.Text = "TOTAL";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem41
            // 
            this.layoutControlItem41.Control = this.txtDescuento;
            this.layoutControlItem41.Location = new System.Drawing.Point(151, 24);
            this.layoutControlItem41.Name = "layoutControlItem41";
            this.layoutControlItem41.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem41.Text = "DESCUENTO";
            this.layoutControlItem41.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(141, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 146);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem42
            // 
            this.layoutControlItem42.Control = this.spDescuento;
            this.layoutControlItem42.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem42.Name = "layoutControlItem42";
            this.layoutControlItem42.Size = new System.Drawing.Size(141, 24);
            this.layoutControlItem42.Text = "% Descuento";
            this.layoutControlItem42.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(141, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(141, 98);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem38});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 315);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(676, 170);
            this.layoutControlGroup6.Text = "Historial de Cotizaciones";
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.grdProductoHist;
            this.layoutControlItem38.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem38.Name = "layoutControlItem38";
            this.layoutControlItem38.Size = new System.Drawing.Size(652, 125);
            this.layoutControlItem38.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem38.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem21,
            this.layoutControlItem11});
            this.layoutControlGroup4.Location = new System.Drawing.Point(464, 485);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(543, 85);
            this.layoutControlGroup4.Text = "Observaciones";
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.mmoObservaciones;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem21.MinSize = new System.Drawing.Size(14, 40);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(396, 40);
            this.layoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.chkMostrarSAC;
            this.layoutControlItem11.Location = new System.Drawing.Point(396, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(123, 40);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem40});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 485);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(464, 85);
            this.layoutControlGroup7.Text = "Información Adicional";
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.mmoInfAdicional;
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem40.Name = "layoutControlItem40";
            this.layoutControlItem40.Size = new System.Drawing.Size(440, 40);
            this.layoutControlItem40.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem40.TextVisible = false;
            // 
            // BSCotizacion
            // 
            this.BSCotizacion.DataSource = typeof(Proforma.Models.tblCotizaciones);
            // 
            // BSTipoProducto
            // 
            this.BSTipoProducto.DataSource = typeof(Proforma.Models.tblTipoProductos);
            // 
            // BSPrecios
            // 
            this.BSPrecios.DataSource = typeof(Proforma.Models.tblPrecios);
            // 
            // frmProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1027, 590);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmProforma.IconOptions.Image")));
            this.Name = "frmProforma";
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.frmProforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoInfAdicional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEquiv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductoHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductoHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStrProforma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMargen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit6View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContactos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarSAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExonerado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRUC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCotizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPrecios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtRUC;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtIdCotizacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbVendedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.TextEdit txtFecha;
        private DevExpress.XtraEditors.CheckEdit chkExonerado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnAprobar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.CheckEdit chkFactura;
        private DevExpress.XtraEditors.TextEdit txtIVA;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraGrid.GridControl grdDetalleCotizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView vwDetalleCotizacion;
        private DevExpress.XtraEditors.SimpleButton btnAgregarProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit6View;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtExistencia;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit5View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbContactos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit4View;
        private DevExpress.XtraEditors.CheckEdit chkMostrarSAC;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMoneda;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtTasa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraEditors.SpinEdit spMargen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraEditors.TextEdit txtExtension;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private System.Windows.Forms.BindingSource BSVendedores;
        private System.Windows.Forms.BindingSource BSClientes;
        private System.Windows.Forms.BindingSource BSContactos;
        private System.Windows.Forms.BindingSource BSProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdContacto;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colstrExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colstrCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colstrCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltblClientes;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem35;
        private DevExpress.XtraEditors.MemoEdit mmoObservaciones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.SimpleButton btnEnviar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colstrProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colstrReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCosto;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio2;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio3;
        private DevExpress.XtraGrid.Columns.GridColumn colintMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn coldecExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colbitNoExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colbitActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colbitExonerado;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdTipoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colintIdPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn coltblDetalleCotizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coltblMonedas;
        private DevExpress.XtraGrid.Columns.GridColumn coltblPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn coltblTipoProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductosXProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.BindingSource BSCotizacionDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn coldecDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCosto1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colbitExonerado1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProveedores;
        private System.Windows.Forms.BindingSource BSMonedas;
        private System.Windows.Forms.BindingSource BSEstados;
        private System.Windows.Forms.BindingSource BSCotizacion;
        private DevExpress.XtraEditors.TextEdit txtStrProforma;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem37;
        private System.Windows.Forms.BindingSource BSProveedores;
        private DevExpress.XtraGrid.Columns.GridColumn colintIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colstrDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colstrSimbolo;
        private DevExpress.XtraGrid.Columns.GridColumn coltblConfiguracion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstrDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn colstrRUC;
        private DevExpress.XtraGrid.Columns.GridColumn colstrSiglas;
        private DevExpress.XtraGrid.Columns.GridColumn coltblVendedores;
        private DevExpress.XtraGrid.Columns.GridColumn coltblClientesContacto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn coldecSubtotal;
        private System.Windows.Forms.BindingSource BSTipoProducto;
        private System.Windows.Forms.BindingSource BSPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos1;
        private DevExpress.XtraGrid.GridControl grdProductoHist;
        private DevExpress.XtraGrid.Views.Grid.GridView vwProductoHist;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdDetalle1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdCotizacion1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProducto2;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecPrecio4;
        private DevExpress.XtraGrid.Columns.GridColumn coldecDescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn coldecCosto2;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colbitExonerado2;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMovimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones2;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUsuarios2;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos2;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProveedores1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem38;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraGrid.Columns.GridColumn coldecMargen;
        private DevExpress.XtraEditors.TextEdit txtTotalEquiv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraGrid.Columns.GridColumn coldecMargen1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblProductos3;
        private DevExpress.XtraGrid.Columns.GridColumn coldecSubtotal2;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCotizaciones3;
        private DevExpress.XtraEditors.MemoEdit mmoInfAdicional;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem40;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem41;
        private DevExpress.XtraEditors.SpinEdit spDescuento;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem42;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
