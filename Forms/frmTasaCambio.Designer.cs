
namespace Proforma.Forms
{
    partial class frmTasaCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTasaCambio));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDeslizamiento = new DevExpress.XtraEditors.TextEdit();
            this.rdOpcion = new DevExpress.XtraEditors.RadioGroup();
            this.txtTasa = new DevExpress.XtraEditors.TextEdit();
            this.spDias = new DevExpress.XtraEditors.SpinEdit();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.grdTasa = new DevExpress.XtraGrid.GridControl();
            this.BSTasa = new System.Windows.Forms.BindingSource(this.components);
            this.vwTasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecIdConfiguracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblConfiguracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeslizamiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOpcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDeslizamiento);
            this.layoutControl1.Controls.Add(this.rdOpcion);
            this.layoutControl1.Controls.Add(this.txtTasa);
            this.layoutControl1.Controls.Add(this.spDias);
            this.layoutControl1.Controls.Add(this.dtFecha);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.grdTasa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(217, 411);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDeslizamiento
            // 
            this.txtDeslizamiento.Location = new System.Drawing.Point(104, 153);
            this.txtDeslizamiento.Name = "txtDeslizamiento";
            this.txtDeslizamiento.Properties.BeepOnError = false;
            this.txtDeslizamiento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDeslizamiento.Properties.MaskSettings.Set("mask", "n4");
            this.txtDeslizamiento.Size = new System.Drawing.Size(89, 20);
            this.txtDeslizamiento.StyleController = this.layoutControl1;
            this.txtDeslizamiento.TabIndex = 11;
            // 
            // rdOpcion
            // 
            this.rdOpcion.Location = new System.Drawing.Point(24, 117);
            this.rdOpcion.Name = "rdOpcion";
            this.rdOpcion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdOpcion.Properties.Appearance.Options.UseBackColor = true;
            this.rdOpcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdOpcion.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Igual"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Desliz. Diario")});
            this.rdOpcion.Size = new System.Drawing.Size(169, 32);
            this.rdOpcion.StyleController = this.layoutControl1;
            this.rdOpcion.TabIndex = 10;
            this.rdOpcion.EditValueChanged += new System.EventHandler(this.rdOpcion_EditValueChanged);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(104, 93);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Properties.BeepOnError = false;
            this.txtTasa.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTasa.Properties.MaskSettings.Set("mask", "n4");
            this.txtTasa.Size = new System.Drawing.Size(89, 20);
            this.txtTasa.StyleController = this.layoutControl1;
            this.txtTasa.TabIndex = 9;
            // 
            // spDias
            // 
            this.spDias.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spDias.Location = new System.Drawing.Point(104, 69);
            this.spDias.Name = "spDias";
            this.spDias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDias.Properties.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.spDias.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spDias.Size = new System.Drawing.Size(89, 20);
            this.spDias.StyleController = this.layoutControl1;
            this.spDias.TabIndex = 8;
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(104, 45);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(89, 20);
            this.dtFecha.StyleController = this.layoutControl1;
            this.dtFecha.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(134, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 22);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "simpleButton1";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdTasa
            // 
            this.grdTasa.DataSource = this.BSTasa;
            this.grdTasa.Location = new System.Drawing.Point(12, 215);
            this.grdTasa.MainView = this.vwTasa;
            this.grdTasa.Name = "grdTasa";
            this.grdTasa.Size = new System.Drawing.Size(193, 184);
            this.grdTasa.TabIndex = 4;
            this.grdTasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwTasa});
            // 
            // BSTasa
            // 
            this.BSTasa.DataSource = typeof(Proforma.Models.tblCambioMoneda);
            // 
            // vwTasa
            // 
            this.vwTasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatFecha,
            this.coldecTipoCambio,
            this.coldecIdConfiguracion,
            this.coltblConfiguracion});
            this.vwTasa.GridControl = this.grdTasa;
            this.vwTasa.Name = "vwTasa";
            this.vwTasa.OptionsBehavior.Editable = false;
            this.vwTasa.OptionsView.ShowAutoFilterRow = true;
            this.vwTasa.OptionsView.ShowGroupPanel = false;
            this.vwTasa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldatFecha, DevExpress.Data.ColumnSortOrder.Descending)});
            this.vwTasa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vwTasa_KeyDown);
            // 
            // coldatFecha
            // 
            this.coldatFecha.Caption = "Fecha";
            this.coldatFecha.FieldName = "datFecha";
            this.coldatFecha.Name = "coldatFecha";
            this.coldatFecha.Visible = true;
            this.coldatFecha.VisibleIndex = 0;
            // 
            // coldecTipoCambio
            // 
            this.coldecTipoCambio.Caption = "Tasa";
            this.coldecTipoCambio.FieldName = "decTipoCambio";
            this.coldecTipoCambio.Name = "coldecTipoCambio";
            this.coldecTipoCambio.Visible = true;
            this.coldecTipoCambio.VisibleIndex = 1;
            // 
            // coldecIdConfiguracion
            // 
            this.coldecIdConfiguracion.FieldName = "decIdConfiguracion";
            this.coldecIdConfiguracion.Name = "coldecIdConfiguracion";
            // 
            // coltblConfiguracion
            // 
            this.coltblConfiguracion.FieldName = "tblConfiguracion";
            this.coltblConfiguracion.Name = "coltblConfiguracion";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(217, 411);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTasa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 203);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(197, 188);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(197, 203);
            this.layoutControlGroup1.Text = "Crear Tasa";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtFecha;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(173, 24);
            this.layoutControlItem4.Text = "Fecha Inicial:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spDias;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(173, 24);
            this.layoutControlItem5.Text = "Cant. de días:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.rdOpcion;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(173, 36);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(110, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtTasa;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(173, 24);
            this.layoutControlItem6.Text = "Tasa Inicial";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAgregar;
            this.layoutControlItem2.Location = new System.Drawing.Point(110, 132);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(63, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtDeslizamiento;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(173, 24);
            this.layoutControlItem8.Text = "Desliz. Diario:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(68, 13);
            // 
            // frmTasaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(217, 411);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmTasaCambio.IconOptions.Image")));
            this.Name = "frmTasaCambio";
            this.Text = "Tasa de Cambio";
            this.Load += new System.EventHandler(this.frmTasaCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDeslizamiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOpcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl grdTasa;
        private DevExpress.XtraGrid.Views.Grid.GridView vwTasa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtDeslizamiento;
        private DevExpress.XtraEditors.RadioGroup rdOpcion;
        private DevExpress.XtraEditors.TextEdit txtTasa;
        private DevExpress.XtraEditors.SpinEdit spDias;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource BSTasa;
        private DevExpress.XtraGrid.Columns.GridColumn coldatFecha;
        private DevExpress.XtraGrid.Columns.GridColumn coldecTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn coldecIdConfiguracion;
        private DevExpress.XtraGrid.Columns.GridColumn coltblConfiguracion;
    }
}
