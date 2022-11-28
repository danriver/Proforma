
namespace Proforma.Forms
{
    partial class frmBitacora
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
            this.cboUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tblUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstrNombreUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDetalleBitacora = new DevExpress.XtraGrid.GridControl();
            this.tblBitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdVwDetalleBitacora = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatFechaOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTipoRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldecNumRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.datFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.datFechaIni = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colstrUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwDetalleBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboUsuario);
            this.layoutControl1.Controls.Add(this.grdDetalleBitacora);
            this.layoutControl1.Controls.Add(this.btnExcel);
            this.layoutControl1.Controls.Add(this.btnBuscar);
            this.layoutControl1.Controls.Add(this.datFechaFin);
            this.layoutControl1.Controls.Add(this.datFechaIni);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(798, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboUsuario
            // 
            this.cboUsuario.EnterMoveNextControl = true;
            this.cboUsuario.Location = new System.Drawing.Point(419, 45);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUsuario.Properties.DataSource = this.tblUsuariosBindingSource;
            this.cboUsuario.Properties.DisplayMember = "strNombreUsuario";
            this.cboUsuario.Properties.NullText = "";
            this.cboUsuario.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboUsuario.Properties.ValueMember = "decIdUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(293, 20);
            this.cboUsuario.StyleController = this.layoutControl1;
            this.cboUsuario.TabIndex = 10;
            // 
            // tblUsuariosBindingSource
            // 
            this.tblUsuariosBindingSource.DataSource = typeof(Proforma.Models.tblUsuarios);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstrUsuario1,
            this.colstrNombreUsuario1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colstrNombreUsuario1
            // 
            this.colstrNombreUsuario1.Caption = "Nombre";
            this.colstrNombreUsuario1.FieldName = "strNombreUsuario";
            this.colstrNombreUsuario1.Name = "colstrNombreUsuario1";
            this.colstrNombreUsuario1.Visible = true;
            this.colstrNombreUsuario1.VisibleIndex = 1;
            this.colstrNombreUsuario1.Width = 307;
            // 
            // grdDetalleBitacora
            // 
            this.grdDetalleBitacora.DataSource = this.tblBitacoraBindingSource;
            this.grdDetalleBitacora.Location = new System.Drawing.Point(12, 83);
            this.grdDetalleBitacora.MainView = this.grdVwDetalleBitacora;
            this.grdDetalleBitacora.Name = "grdDetalleBitacora";
            this.grdDetalleBitacora.Size = new System.Drawing.Size(774, 373);
            this.grdDetalleBitacora.TabIndex = 9;
            this.grdDetalleBitacora.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwDetalleBitacora});
            // 
            // tblBitacoraBindingSource
            // 
            this.tblBitacoraBindingSource.DataSource = typeof(Proforma.Models.tblBitacoras);
            // 
            // grdVwDetalleBitacora
            // 
            this.grdVwDetalleBitacora.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatFechaOperacion,
            this.colstrOperacion,
            this.colstrTipoRegistro,
            this.coldecNumRegistro,
            this.colstrUsuario,
            this.colstrNombreUsuario});
            this.grdVwDetalleBitacora.GridControl = this.grdDetalleBitacora;
            this.grdVwDetalleBitacora.Name = "grdVwDetalleBitacora";
            this.grdVwDetalleBitacora.OptionsBehavior.Editable = false;
            this.grdVwDetalleBitacora.OptionsView.ShowAutoFilterRow = true;
            this.grdVwDetalleBitacora.OptionsView.ShowGroupPanel = false;
            // 
            // coldatFechaOperacion
            // 
            this.coldatFechaOperacion.Caption = "Fecha Operación";
            this.coldatFechaOperacion.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.coldatFechaOperacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldatFechaOperacion.FieldName = "datFechaOperacion";
            this.coldatFechaOperacion.Name = "coldatFechaOperacion";
            this.coldatFechaOperacion.Visible = true;
            this.coldatFechaOperacion.VisibleIndex = 0;
            // 
            // colstrOperacion
            // 
            this.colstrOperacion.Caption = "Operación";
            this.colstrOperacion.FieldName = "strOperacion";
            this.colstrOperacion.Name = "colstrOperacion";
            this.colstrOperacion.Visible = true;
            this.colstrOperacion.VisibleIndex = 1;
            // 
            // colstrTipoRegistro
            // 
            this.colstrTipoRegistro.Caption = "Tipo Registro";
            this.colstrTipoRegistro.FieldName = "strTipoRegistro";
            this.colstrTipoRegistro.Name = "colstrTipoRegistro";
            this.colstrTipoRegistro.Visible = true;
            this.colstrTipoRegistro.VisibleIndex = 2;
            // 
            // coldecNumRegistro
            // 
            this.coldecNumRegistro.Caption = "Referencia";
            this.coldecNumRegistro.FieldName = "decNumRegistro";
            this.coldecNumRegistro.Name = "coldecNumRegistro";
            this.coldecNumRegistro.Visible = true;
            this.coldecNumRegistro.VisibleIndex = 3;
            // 
            // colstrUsuario
            // 
            this.colstrUsuario.Caption = "Usuario";
            this.colstrUsuario.FieldName = "tblUsuarios.strUsuario";
            this.colstrUsuario.Name = "colstrUsuario";
            this.colstrUsuario.Visible = true;
            this.colstrUsuario.VisibleIndex = 4;
            // 
            // colstrNombreUsuario
            // 
            this.colstrNombreUsuario.Caption = "Nombre";
            this.colstrNombreUsuario.FieldName = "tblUsuarios.strNombreUsuario";
            this.colstrNombreUsuario.Name = "colstrNombreUsuario";
            this.colstrNombreUsuario.Visible = true;
            this.colstrNombreUsuario.VisibleIndex = 5;
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.ImageUri.Uri = "ExportToXLSX;Size16x16";
            this.btnExcel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExcel.Location = new System.Drawing.Point(742, 45);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(22, 22);
            this.btnExcel.StyleController = this.layoutControl1;
            this.btnExcel.TabIndex = 8;
            this.btnExcel.ToolTip = "Exportar a Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageUri.Uri = "Find;Size16x16";
            this.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(716, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 22);
            this.btnBuscar.StyleController = this.layoutControl1;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.ToolTip = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // datFechaFin
            // 
            this.datFechaFin.EditValue = null;
            this.datFechaFin.EnterMoveNextControl = true;
            this.datFechaFin.Location = new System.Drawing.Point(268, 45);
            this.datFechaFin.Name = "datFechaFin";
            this.datFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaFin.Size = new System.Drawing.Size(99, 20);
            this.datFechaFin.StyleController = this.layoutControl1;
            this.datFechaFin.TabIndex = 5;
            // 
            // datFechaIni
            // 
            this.datFechaIni.EditValue = null;
            this.datFechaIni.EnterMoveNextControl = true;
            this.datFechaIni.Location = new System.Drawing.Point(95, 45);
            this.datFechaIni.Name = "datFechaIni";
            this.datFechaIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaIni.Size = new System.Drawing.Size(103, 20);
            this.datFechaIni.StyleController = this.layoutControl1;
            this.datFechaIni.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(798, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(778, 71);
            this.layoutControlGroup1.Text = "Filtro";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.datFechaIni;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(178, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(178, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(178, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Fecha Inicial :";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.datFechaFin;
            this.layoutControlItem2.Location = new System.Drawing.Point(178, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(169, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(169, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(169, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Fecha Final :";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBuscar;
            this.layoutControlItem4.Location = new System.Drawing.Point(692, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnExcel;
            this.layoutControlItem5.Location = new System.Drawing.Point(718, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboUsuario;
            this.layoutControlItem3.Location = new System.Drawing.Point(347, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(345, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(345, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(345, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Usuario :";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(43, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(744, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.grdDetalleBitacora;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(778, 377);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // colstrUsuario1
            // 
            this.colstrUsuario1.Caption = "Usuario";
            this.colstrUsuario1.FieldName = "strUsuario";
            this.colstrUsuario1.Name = "colstrUsuario1";
            this.colstrUsuario1.Visible = true;
            this.colstrUsuario1.VisibleIndex = 0;
            this.colstrUsuario1.Width = 70;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(798, 468);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmBitacora";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwDetalleBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit datFechaIni;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.DateEdit datFechaFin;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl grdDetalleBitacora;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwDetalleBitacora;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource tblBitacoraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldatFechaOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colstrOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTipoRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn coldecNumRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colstrUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreUsuario;
        private DevExpress.XtraEditors.SearchLookUpEdit cboUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colstrNombreUsuario1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colstrUsuario1;
    }
}
