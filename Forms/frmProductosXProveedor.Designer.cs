
namespace Proforma.Forms
{
    partial class frmProductosXProveedor
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
            this.grdProductosxProveedor = new DevExpress.XtraGrid.GridControl();
            this.BSProductosXProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosxProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BSProductos = new System.Windows.Forms.BindingSource(this.components);
            this.colAgregado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductosXProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdProductosxProveedor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(315, 297);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdProductosxProveedor
            // 
            this.grdProductosxProveedor.DataSource = this.BSProductosXProveedor;
            this.grdProductosxProveedor.Location = new System.Drawing.Point(12, 12);
            this.grdProductosxProveedor.MainView = this.vwProductosxProveedor;
            this.grdProductosxProveedor.Name = "grdProductosxProveedor";
            this.grdProductosxProveedor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.grdProductosxProveedor.Size = new System.Drawing.Size(291, 273);
            this.grdProductosxProveedor.TabIndex = 4;
            this.grdProductosxProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwProductosxProveedor});
            // 
            // BSProductosXProveedor
            // 
            this.BSProductosXProveedor.DataSource = typeof(Proforma.Models.Sp_ProductosXProveedor_Result);
            // 
            // vwProductosxProveedor
            // 
            this.vwProductosxProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProducto,
            this.colAgregado});
            this.vwProductosxProveedor.GridControl = this.grdProductosxProveedor;
            this.vwProductosxProveedor.Name = "vwProductosxProveedor";
            this.vwProductosxProveedor.OptionsView.ColumnAutoWidth = false;
            this.vwProductosxProveedor.OptionsView.ShowAutoFilterRow = true;
            this.vwProductosxProveedor.OptionsView.ShowGroupPanel = false;
            this.vwProductosxProveedor.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vwProductosxProveedor_CellValueChanged);
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.BSProductos;
            this.repositoryItemLookUpEdit1.DisplayMember = "strProducto";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "decIdProducto";
            // 
            // BSProductos
            // 
            this.BSProductos.DataSource = typeof(Proforma.Models.tblProductos);
            // 
            // colAgregado
            // 
            this.colAgregado.Caption = "Agregado";
            this.colAgregado.FieldName = "Agregado";
            this.colAgregado.Name = "colAgregado";
            this.colAgregado.Visible = true;
            this.colAgregado.VisibleIndex = 1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(315, 297);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdProductosxProveedor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(295, 277);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmProductosXProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(315, 297);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductosXProveedor";
            this.Text = "Productos por Proveedor";
            this.Load += new System.EventHandler(this.frmProductosXProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductosXProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdProductosxProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView vwProductosxProveedor;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource BSProductos;
        private System.Windows.Forms.BindingSource BSProductosXProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colAgregado;
    }
}
