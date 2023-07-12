namespace TPNT
{
    partial class frmCuocTrienLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuocTrienLam));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveData = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnImport = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tPNTDataSet = new TPNT.TPNTDataSet();
            this.bdsCuocTrienLam = new System.Windows.Forms.BindingSource(this.components);
            this.cuocTrienLamTableAdapter = new TPNT.TPNTDataSetTableAdapters.CuocTrienLamTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoCTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cuocTrienLamGridControl = new DevExpress.XtraGrid.GridControl();
            this.tPNTDataSet1 = new TPNT.TPNTDataSet1();
            this.tableAdapterManager1 = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.bds_view_ListTPNT = new System.Windows.Forms.BindingSource(this.components);
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.dtpTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblFrom = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCTL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaCTL = new System.Windows.Forms.TextBox();
            this.lblMaCTL = new DevExpress.XtraEditors.LabelControl();
            this.grbDSTPNT = new System.Windows.Forms.GroupBox();
            this.dataGridViewDanhSach = new System.Windows.Forms.DataGridView();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maSoTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSangTacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTACGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThemCTL = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.view_ListTPNTTableAdapter = new TPNT.TPNTDataSet1TableAdapters.View_ListTPNTTableAdapter();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuocTrienLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuocTrienLamGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_view_ListTPNT)).BeginInit();
            this.grbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCTL.Properties)).BeginInit();
            this.grbDSTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbThemCTL)).BeginInit();
            this.grbThemCTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnHieuChinh,
            this.btnChiTiet,
            this.btnHoanTac,
            this.btnReload,
            this.btnSaveData,
            this.btnExport,
            this.btnImport,
            this.btnReport});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChiTiet),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveData),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReport)});
            this.bar3.Text = "Tools";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "Chi Tiết";
            this.btnChiTiet.Id = 3;
            this.btnChiTiet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTiet.ImageOptions.SvgImage")));
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTiet_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Caption = "Lưu";
            this.btnSaveData.Enabled = false;
            this.btnSaveData.Id = 6;
            this.btnSaveData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveData.ImageOptions.SvgImage")));
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaveData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveData_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn Tác";
            this.btnHoanTac.Enabled = false;
            this.btnHoanTac.Id = 4;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Export";
            this.btnExport.Id = 7;
            this.btnExport.ImageOptions.Image = global::TPNT.Properties.Resources.exporttoxlsx_16x161;
            this.btnExport.ImageOptions.LargeImage = global::TPNT.Properties.Resources.exporttoxlsx_16x161;
            this.btnExport.Name = "btnExport";
            this.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // btnImport
            // 
            this.btnImport.Caption = "Import";
            this.btnImport.Id = 8;
            this.btnImport.ImageOptions.Image = global::TPNT.Properties.Resources.importmap_16x161;
            this.btnImport.ImageOptions.LargeImage = global::TPNT.Properties.Resources.importmap_16x161;
            this.btnImport.Name = "btnImport";
            this.btnImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImport_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1131, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 730);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1131, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1131, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCuocTrienLam
            // 
            this.bdsCuocTrienLam.DataMember = "CuocTrienLam";
            this.bdsCuocTrienLam.DataSource = this.tPNTDataSet;
            // 
            // cuocTrienLamTableAdapter
            // 
            this.cuocTrienLamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoSuuTapTableAdapter = null;
            this.tableAdapterManager.CT_CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.CuocTrienLamTableAdapter = this.cuocTrienLamTableAdapter;
            this.tableAdapterManager.DieuKhacVaTacTuongTableAdapter = null;
            this.tableAdapterManager.HoiHoaTableAdapter = null;
            this.tableAdapterManager.LoaiDiMuonTableAdapter = null;
            this.tableAdapterManager.LoaiHinhKhacTableAdapter = null;
            this.tableAdapterManager.LoaiSoHuuTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoCTL,
            this.colTen,
            this.colNgayBD,
            this.colNgayKT});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.cuocTrienLamGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1249;
            // 
            // colMaSoCTL
            // 
            this.colMaSoCTL.Caption = "Mã Số";
            this.colMaSoCTL.FieldName = "MaSoCTL";
            this.colMaSoCTL.MinWidth = 39;
            this.colMaSoCTL.Name = "colMaSoCTL";
            this.colMaSoCTL.Visible = true;
            this.colMaSoCTL.VisibleIndex = 0;
            this.colMaSoCTL.Width = 145;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 39;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 145;
            // 
            // colNgayBD
            // 
            this.colNgayBD.Caption = "Ngày Bắt Đầu";
            this.colNgayBD.FieldName = "NgayBD";
            this.colNgayBD.MinWidth = 39;
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Visible = true;
            this.colNgayBD.VisibleIndex = 2;
            this.colNgayBD.Width = 145;
            // 
            // colNgayKT
            // 
            this.colNgayKT.Caption = "Ngày Kết Thúc";
            this.colNgayKT.FieldName = "NgayKT";
            this.colNgayKT.MinWidth = 39;
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Visible = true;
            this.colNgayKT.VisibleIndex = 3;
            this.colNgayKT.Width = 145;
            // 
            // cuocTrienLamGridControl
            // 
            this.cuocTrienLamGridControl.DataSource = this.bdsCuocTrienLam;
            this.cuocTrienLamGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuocTrienLamGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.cuocTrienLamGridControl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cuocTrienLamGridControl.Location = new System.Drawing.Point(0, 30);
            this.cuocTrienLamGridControl.MainView = this.gridView1;
            this.cuocTrienLamGridControl.Margin = new System.Windows.Forms.Padding(5);
            this.cuocTrienLamGridControl.MenuManager = this.barManager1;
            this.cuocTrienLamGridControl.Name = "cuocTrienLamGridControl";
            this.cuocTrienLamGridControl.Size = new System.Drawing.Size(1131, 700);
            this.cuocTrienLamGridControl.TabIndex = 5;
            this.cuocTrienLamGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bds_view_ListTPNT
            // 
            this.bds_view_ListTPNT.DataMember = "View_ListTPNT";
            this.bds_view_ListTPNT.DataSource = this.tPNTDataSet1;
            // 
            // grbNhap
            // 
            this.grbNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbNhap.Controls.Add(this.dtpTo);
            this.grbNhap.Controls.Add(this.dtpFrom);
            this.grbNhap.Controls.Add(this.labelControl3);
            this.grbNhap.Controls.Add(this.lblFrom);
            this.grbNhap.Controls.Add(this.txtTenCTL);
            this.grbNhap.Controls.Add(this.labelControl1);
            this.grbNhap.Controls.Add(this.txtMaCTL);
            this.grbNhap.Controls.Add(this.lblMaCTL);
            this.grbNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbNhap.Location = new System.Drawing.Point(2, 28);
            this.grbNhap.Margin = new System.Windows.Forms.Padding(5);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Padding = new System.Windows.Forms.Padding(5);
            this.grbNhap.Size = new System.Drawing.Size(852, 244);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Nhập Thông Tin";
            // 
            // dtpTo
            // 
            this.dtpTo.EditValue = null;
            this.dtpTo.Location = new System.Drawing.Point(149, 171);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.MenuManager = this.barManager1;
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Size = new System.Drawing.Size(156, 22);
            this.dtpTo.TabIndex = 7;
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(149, 122);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.MenuManager = this.barManager1;
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Size = new System.Drawing.Size(156, 22);
            this.dtpFrom.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 177);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Kết Thúc :";
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(15, 126);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 16);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "Bắt Đầu :";
            // 
            // txtTenCTL
            // 
            this.txtTenCTL.Location = new System.Drawing.Point(621, 66);
            this.txtTenCTL.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenCTL.MenuManager = this.barManager1;
            this.txtTenCTL.Name = "txtTenCTL";
            this.txtTenCTL.Size = new System.Drawing.Size(189, 22);
            this.txtTenCTL.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(400, 68);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Cuộc Triển Lãm :";
            // 
            // txtMaCTL
            // 
            this.txtMaCTL.Location = new System.Drawing.Point(149, 66);
            this.txtMaCTL.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaCTL.Name = "txtMaCTL";
            this.txtMaCTL.Size = new System.Drawing.Size(153, 23);
            this.txtMaCTL.TabIndex = 1;
            // 
            // lblMaCTL
            // 
            this.lblMaCTL.Location = new System.Drawing.Point(15, 73);
            this.lblMaCTL.Margin = new System.Windows.Forms.Padding(5);
            this.lblMaCTL.Name = "lblMaCTL";
            this.lblMaCTL.Size = new System.Drawing.Size(71, 16);
            this.lblMaCTL.TabIndex = 0;
            this.lblMaCTL.Text = "Mã Số CTL :";
            // 
            // grbDSTPNT
            // 
            this.grbDSTPNT.Controls.Add(this.dataGridViewDanhSach);
            this.grbDSTPNT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDSTPNT.Location = new System.Drawing.Point(854, 28);
            this.grbDSTPNT.Margin = new System.Windows.Forms.Padding(5);
            this.grbDSTPNT.Name = "grbDSTPNT";
            this.grbDSTPNT.Padding = new System.Windows.Forms.Padding(5);
            this.grbDSTPNT.Size = new System.Drawing.Size(275, 244);
            this.grbDSTPNT.TabIndex = 1;
            this.grbDSTPNT.TabStop = false;
            this.grbDSTPNT.Text = "Chọn  Tác Phẩm  Trong Cuộc Triển Lãm";
            // 
            // dataGridViewDanhSach
            // 
            this.dataGridViewDanhSach.AllowUserToAddRows = false;
            this.dataGridViewDanhSach.AllowUserToDeleteRows = false;
            this.dataGridViewDanhSach.AllowUserToResizeColumns = false;
            this.dataGridViewDanhSach.AllowUserToResizeRows = false;
            this.dataGridViewDanhSach.AutoGenerateColumns = false;
            this.dataGridViewDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon,
            this.maSoTPDataGridViewTextBoxColumn,
            this.TenTP,
            this.chuDeDataGridViewTextBoxColumn,
            this.namSangTacDataGridViewTextBoxColumn,
            this.tENTACGIADataGridViewTextBoxColumn});
            this.dataGridViewDanhSach.DataSource = this.bds_view_ListTPNT;
            this.dataGridViewDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSach.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDanhSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewDanhSach.Location = new System.Drawing.Point(5, 21);
            this.dataGridViewDanhSach.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewDanhSach.Name = "dataGridViewDanhSach";
            this.dataGridViewDanhSach.RowHeadersVisible = false;
            this.dataGridViewDanhSach.RowHeadersWidth = 51;
            this.dataGridViewDanhSach.RowTemplate.Height = 24;
            this.dataGridViewDanhSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDanhSach.ShowCellErrors = false;
            this.dataGridViewDanhSach.ShowCellToolTips = false;
            this.dataGridViewDanhSach.ShowEditingIcon = false;
            this.dataGridViewDanhSach.ShowRowErrors = false;
            this.dataGridViewDanhSach.Size = new System.Drawing.Size(265, 218);
            this.dataGridViewDanhSach.TabIndex = 0;
            // 
            // colChon
            // 
            this.colChon.FalseValue = "false";
            this.colChon.HeaderText = "Đã Chọn";
            this.colChon.IndeterminateValue = "null";
            this.colChon.MinimumWidth = 6;
            this.colChon.Name = "colChon";
            this.colChon.TrueValue = "true";
            // 
            // maSoTPDataGridViewTextBoxColumn
            // 
            this.maSoTPDataGridViewTextBoxColumn.DataPropertyName = "MaSoTP";
            this.maSoTPDataGridViewTextBoxColumn.HeaderText = "Mã Số TP";
            this.maSoTPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSoTPDataGridViewTextBoxColumn.Name = "maSoTPDataGridViewTextBoxColumn";
            this.maSoTPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenTP
            // 
            this.TenTP.DataPropertyName = "TenTP";
            this.TenTP.HeaderText = "Tên tác phẩm";
            this.TenTP.MinimumWidth = 6;
            this.TenTP.Name = "TenTP";
            this.TenTP.ReadOnly = true;
            // 
            // chuDeDataGridViewTextBoxColumn
            // 
            this.chuDeDataGridViewTextBoxColumn.DataPropertyName = "ChuDe";
            this.chuDeDataGridViewTextBoxColumn.HeaderText = "Chủ Đề";
            this.chuDeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuDeDataGridViewTextBoxColumn.Name = "chuDeDataGridViewTextBoxColumn";
            this.chuDeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namSangTacDataGridViewTextBoxColumn
            // 
            this.namSangTacDataGridViewTextBoxColumn.DataPropertyName = "NamSangTac";
            this.namSangTacDataGridViewTextBoxColumn.HeaderText = "Năm Sáng Tác";
            this.namSangTacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namSangTacDataGridViewTextBoxColumn.Name = "namSangTacDataGridViewTextBoxColumn";
            this.namSangTacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENTACGIADataGridViewTextBoxColumn
            // 
            this.tENTACGIADataGridViewTextBoxColumn.DataPropertyName = "TENTACGIA";
            this.tENTACGIADataGridViewTextBoxColumn.HeaderText = "Tác Giả";
            this.tENTACGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENTACGIADataGridViewTextBoxColumn.Name = "tENTACGIADataGridViewTextBoxColumn";
            this.tENTACGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grbThemCTL
            // 
            this.grbThemCTL.Controls.Add(this.simpleButton3);
            this.grbThemCTL.Controls.Add(this.grbDSTPNT);
            this.grbThemCTL.Controls.Add(this.grbNhap);
            this.grbThemCTL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbThemCTL.Location = new System.Drawing.Point(0, 456);
            this.grbThemCTL.Margin = new System.Windows.Forms.Padding(5);
            this.grbThemCTL.Name = "grbThemCTL";
            this.grbThemCTL.Size = new System.Drawing.Size(1131, 274);
            this.grbThemCTL.TabIndex = 20;
            this.grbThemCTL.Text = "Thêm Cuộc Triển Lãm Mới";
            this.grbThemCTL.Visible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1092, 0);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(36, 28);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // view_ListTPNTTableAdapter
            // 
            this.view_ListTPNTTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Report";
            this.btnReport.Id = 9;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.LargeImage")));
            this.btnReport.Name = "btnReport";
            this.btnReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // frmCuocTrienLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1131, 750);
            this.Controls.Add(this.grbThemCTL);
            this.Controls.Add(this.cuocTrienLamGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCuocTrienLam";
            this.Text = "Cuộc Triển Lãm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuocTrienLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuocTrienLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuocTrienLamGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_view_ListTPNT)).EndInit();
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCTL.Properties)).EndInit();
            this.grbDSTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbThemCTL)).EndInit();
            this.grbThemCTL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.BindingSource bdsCuocTrienLam;
        private TPNTDataSet tPNTDataSet;
        private TPNTDataSetTableAdapters.CuocTrienLamTableAdapter cuocTrienLamTableAdapter;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cuocTrienLamGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoCTL;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKT;
        private TPNTDataSet1 tPNTDataSet1;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bds_view_ListTPNT;
        private DevExpress.XtraBars.BarButtonItem btnSaveData;
        private DevExpress.XtraEditors.GroupControl grbThemCTL;
        private System.Windows.Forms.GroupBox grbDSTPNT;
        private System.Windows.Forms.GroupBox grbNhap;
        private DevExpress.XtraEditors.DateEdit dtpTo;
        private DevExpress.XtraEditors.DateEdit dtpFrom;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraEditors.TextEdit txtTenCTL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMaCTL;
        private DevExpress.XtraEditors.LabelControl lblMaCTL;
        private TPNTDataSet1TableAdapters.View_ListTPNTTableAdapter view_ListTPNTTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridView dataGridViewDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.BarButtonItem btnImport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSangTacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTACGIADataGridViewTextBoxColumn;
        private DevExpress.XtraBars.BarButtonItem btnReport;
    }
}