namespace TPNT
{
    partial class frmDieuKhacVaTacTuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuKhacVaTacTuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.tPNTDataSet1 = new TPNT.TPNTDataSet1();
            this.bdsDieuKhacTacTuong = new System.Windows.Forms.BindingSource(this.components);
            this.view_ListDieuKhacTacTuongTableAdapter = new TPNT.TPNTDataSet1TableAdapters.View_ListDieuKhacTacTuongTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.view_ListDieuKhacTacTuongGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoiLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChieuCao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.btnExitGroup = new DevExpress.XtraEditors.SimpleButton();
            this.lblPhongCach = new DevExpress.XtraEditors.LabelControl();
            this.txtPhongCach = new DevExpress.XtraEditors.TextEdit();
            this.btnChonLai = new System.Windows.Forms.Button();
            this.txtVatLieu = new DevExpress.XtraEditors.TextEdit();
            this.txtChieuCao = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoiLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTacPham = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoTP = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDieuKhacTacTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ListDieuKhacTacTuongGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChieuCao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTacPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoTP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnHieuChinh,
            this.btnHoanTac,
            this.barButtonItem5,
            this.btnLuu,
            this.btnReload,
            this.btnBackup,
            this.btnRestore});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(275, 166);
            this.bar1.FloatSize = new System.Drawing.Size(451, 32);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
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
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(970, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 533);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(970, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(970, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Backup";
            this.btnBackup.Id = 7;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore";
            this.btnRestore.Id = 8;
            this.btnRestore.Name = "btnRestore";
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDieuKhacTacTuong
            // 
            this.bdsDieuKhacTacTuong.DataMember = "View_ListDieuKhacTacTuong";
            this.bdsDieuKhacTacTuong.DataSource = this.tPNTDataSet1;
            // 
            // view_ListDieuKhacTacTuongTableAdapter
            // 
            this.view_ListDieuKhacTacTuongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_ListDieuKhacTacTuongGridControl
            // 
            this.view_ListDieuKhacTacTuongGridControl.DataSource = this.bdsDieuKhacTacTuong;
            this.view_ListDieuKhacTacTuongGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_ListDieuKhacTacTuongGridControl.Location = new System.Drawing.Point(0, 30);
            this.view_ListDieuKhacTacTuongGridControl.MainView = this.gridView1;
            this.view_ListDieuKhacTacTuongGridControl.MenuManager = this.barManager1;
            this.view_ListDieuKhacTacTuongGridControl.Name = "view_ListDieuKhacTacTuongGridControl";
            this.view_ListDieuKhacTacTuongGridControl.Size = new System.Drawing.Size(970, 503);
            this.view_ListDieuKhacTacTuongGridControl.TabIndex = 5;
            this.view_ListDieuKhacTacTuongGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colTenTP,
            this.colTENTACGIA,
            this.colNamSangTac,
            this.colQuocGia,
            this.colKhoiLuong,
            this.colVatLieu,
            this.colChieuCao,
            this.colPhongCach});
            this.gridView1.DetailHeight = 328;
            this.gridView1.GridControl = this.view_ListDieuKhacTacTuongGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // colMaSoTP
            // 
            this.colMaSoTP.Caption = "Mã Số TP";
            this.colMaSoTP.FieldName = "MaSoTP";
            this.colMaSoTP.MinWidth = 22;
            this.colMaSoTP.Name = "colMaSoTP";
            this.colMaSoTP.Visible = true;
            this.colMaSoTP.VisibleIndex = 0;
            this.colMaSoTP.Width = 82;
            // 
            // colTenTP
            // 
            this.colTenTP.Caption = "Tên TP";
            this.colTenTP.FieldName = "TenTP";
            this.colTenTP.MinWidth = 22;
            this.colTenTP.Name = "colTenTP";
            this.colTenTP.Visible = true;
            this.colTenTP.VisibleIndex = 1;
            this.colTenTP.Width = 82;
            // 
            // colTENTACGIA
            // 
            this.colTENTACGIA.Caption = "Tên Tác Giả";
            this.colTENTACGIA.FieldName = "TENTACGIA";
            this.colTENTACGIA.MinWidth = 22;
            this.colTENTACGIA.Name = "colTENTACGIA";
            this.colTENTACGIA.Visible = true;
            this.colTENTACGIA.VisibleIndex = 3;
            this.colTENTACGIA.Width = 82;
            // 
            // colNamSangTac
            // 
            this.colNamSangTac.Caption = "Năm Sáng Tác";
            this.colNamSangTac.FieldName = "NamSangTac";
            this.colNamSangTac.MinWidth = 22;
            this.colNamSangTac.Name = "colNamSangTac";
            this.colNamSangTac.Visible = true;
            this.colNamSangTac.VisibleIndex = 2;
            this.colNamSangTac.Width = 82;
            // 
            // colQuocGia
            // 
            this.colQuocGia.Caption = "Quốc Gia";
            this.colQuocGia.FieldName = "QuocGia";
            this.colQuocGia.MinWidth = 22;
            this.colQuocGia.Name = "colQuocGia";
            this.colQuocGia.Visible = true;
            this.colQuocGia.VisibleIndex = 4;
            this.colQuocGia.Width = 82;
            // 
            // colKhoiLuong
            // 
            this.colKhoiLuong.Caption = "Khối Lượng";
            this.colKhoiLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKhoiLuong.FieldName = "KhoiLuong";
            this.colKhoiLuong.MinWidth = 22;
            this.colKhoiLuong.Name = "colKhoiLuong";
            this.colKhoiLuong.Visible = true;
            this.colKhoiLuong.VisibleIndex = 5;
            this.colKhoiLuong.Width = 82;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "Vật Liệu";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.MinWidth = 22;
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 6;
            this.colVatLieu.Width = 82;
            // 
            // colChieuCao
            // 
            this.colChieuCao.Caption = "Chiều Cao";
            this.colChieuCao.FieldName = "ChieuCao";
            this.colChieuCao.MinWidth = 22;
            this.colChieuCao.Name = "colChieuCao";
            this.colChieuCao.Visible = true;
            this.colChieuCao.VisibleIndex = 7;
            this.colChieuCao.Width = 82;
            // 
            // colPhongCach
            // 
            this.colPhongCach.Caption = "Phong Cách";
            this.colPhongCach.FieldName = "PhongCach";
            this.colPhongCach.MinWidth = 22;
            this.colPhongCach.Name = "colPhongCach";
            this.colPhongCach.Visible = true;
            this.colPhongCach.VisibleIndex = 8;
            this.colPhongCach.Width = 82;
            // 
            // groupThongTin
            // 
            this.groupThongTin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupThongTin.Controls.Add(this.btnExitGroup);
            this.groupThongTin.Controls.Add(this.lblPhongCach);
            this.groupThongTin.Controls.Add(this.txtPhongCach);
            this.groupThongTin.Controls.Add(this.btnChonLai);
            this.groupThongTin.Controls.Add(this.txtVatLieu);
            this.groupThongTin.Controls.Add(this.txtChieuCao);
            this.groupThongTin.Controls.Add(this.txtKhoiLuong);
            this.groupThongTin.Controls.Add(this.txtTenTacPham);
            this.groupThongTin.Controls.Add(this.txtMaSoTP);
            this.groupThongTin.Controls.Add(this.label5);
            this.groupThongTin.Controls.Add(this.label4);
            this.groupThongTin.Controls.Add(this.label3);
            this.groupThongTin.Controls.Add(this.label2);
            this.groupThongTin.Controls.Add(this.label1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongTin.Location = new System.Drawing.Point(0, 266);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(970, 267);
            this.groupThongTin.TabIndex = 10;
            this.groupThongTin.Text = "Thêm Thông Tin";
            this.groupThongTin.Visible = false;
            // 
            // btnExitGroup
            // 
            this.btnExitGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitGroup.ImageOptions.Image")));
            this.btnExitGroup.Location = new System.Drawing.Point(936, 0);
            this.btnExitGroup.Name = "btnExitGroup";
            this.btnExitGroup.Size = new System.Drawing.Size(34, 26);
            this.btnExitGroup.TabIndex = 15;
            this.btnExitGroup.Click += new System.EventHandler(this.btnExitGroup_Click);
            // 
            // lblPhongCach
            // 
            this.lblPhongCach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhongCach.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongCach.Appearance.Options.UseFont = true;
            this.lblPhongCach.Location = new System.Drawing.Point(407, 217);
            this.lblPhongCach.Name = "lblPhongCach";
            this.lblPhongCach.Size = new System.Drawing.Size(90, 19);
            this.lblPhongCach.TabIndex = 12;
            this.lblPhongCach.Text = "Phong Cách :";
            // 
            // txtPhongCach
            // 
            this.txtPhongCach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhongCach.Location = new System.Drawing.Point(513, 214);
            this.txtPhongCach.MenuManager = this.barManager1;
            this.txtPhongCach.Name = "txtPhongCach";
            this.txtPhongCach.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongCach.Properties.Appearance.Options.UseFont = true;
            this.txtPhongCach.Size = new System.Drawing.Size(109, 26);
            this.txtPhongCach.TabIndex = 10;
            // 
            // btnChonLai
            // 
            this.btnChonLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonLai.BackColor = System.Drawing.Color.Lime;
            this.btnChonLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonLai.Location = new System.Drawing.Point(719, 82);
            this.btnChonLai.Name = "btnChonLai";
            this.btnChonLai.Size = new System.Drawing.Size(109, 27);
            this.btnChonLai.TabIndex = 10;
            this.btnChonLai.Text = "Chọn Lại TPNT";
            this.btnChonLai.UseVisualStyleBackColor = false;
            this.btnChonLai.Click += new System.EventHandler(this.btnChonLai_Click);
            // 
            // txtVatLieu
            // 
            this.txtVatLieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVatLieu.Location = new System.Drawing.Point(513, 152);
            this.txtVatLieu.MenuManager = this.barManager1;
            this.txtVatLieu.Name = "txtVatLieu";
            this.txtVatLieu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatLieu.Properties.Appearance.Options.UseFont = true;
            this.txtVatLieu.Size = new System.Drawing.Size(109, 26);
            this.txtVatLieu.TabIndex = 8;
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChieuCao.Location = new System.Drawing.Point(235, 214);
            this.txtChieuCao.MenuManager = this.barManager1;
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChieuCao.Properties.Appearance.Options.UseFont = true;
            this.txtChieuCao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtChieuCao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtChieuCao.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtChieuCao.Properties.MaskSettings.Set("mask", "d");
            this.txtChieuCao.Size = new System.Drawing.Size(109, 26);
            this.txtChieuCao.TabIndex = 9;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhoiLuong.Location = new System.Drawing.Point(235, 152);
            this.txtKhoiLuong.MenuManager = this.barManager1;
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoiLuong.Properties.Appearance.Options.UseFont = true;
            this.txtKhoiLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKhoiLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKhoiLuong.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtKhoiLuong.Properties.MaskSettings.Set("mask", "d");
            this.txtKhoiLuong.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtKhoiLuong.Size = new System.Drawing.Size(109, 26);
            this.txtKhoiLuong.TabIndex = 7;
            // 
            // txtTenTacPham
            // 
            this.txtTenTacPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenTacPham.Location = new System.Drawing.Point(513, 84);
            this.txtTenTacPham.MenuManager = this.barManager1;
            this.txtTenTacPham.Name = "txtTenTacPham";
            this.txtTenTacPham.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTacPham.Properties.Appearance.Options.UseFont = true;
            this.txtTenTacPham.Properties.ReadOnly = true;
            this.txtTenTacPham.Size = new System.Drawing.Size(109, 26);
            this.txtTenTacPham.TabIndex = 6;
            // 
            // txtMaSoTP
            // 
            this.txtMaSoTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSoTP.Location = new System.Drawing.Point(235, 84);
            this.txtMaSoTP.MenuManager = this.barManager1;
            this.txtMaSoTP.Name = "txtMaSoTP";
            this.txtMaSoTP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoTP.Properties.Appearance.Options.UseFont = true;
            this.txtMaSoTP.Properties.ReadOnly = true;
            this.txtMaSoTP.Size = new System.Drawing.Size(109, 26);
            this.txtMaSoTP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chiều Cao :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vật Liệu :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khối Lượng :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tác Phẩm :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số TP :";
            // 
            // frmDieuKhacVaTacTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 553);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.view_ListDieuKhacTacTuongGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDieuKhacVaTacTuong";
            this.Text = "Điêu Khắc Và Tác Tượng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDieuKhacVaTacTuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDieuKhacTacTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ListDieuKhacTacTuongGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChieuCao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTacPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoTP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.BindingSource bdsDieuKhacTacTuong;
        private TPNTDataSet1 tPNTDataSet1;
        private TPNTDataSet1TableAdapters.View_ListDieuKhacTacTuongTableAdapter view_ListDieuKhacTacTuongTableAdapter;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl view_ListDieuKhacTacTuongGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoiLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colChieuCao;
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonLai;
        private DevExpress.XtraEditors.TextEdit txtVatLieu;
        private DevExpress.XtraEditors.TextEdit txtChieuCao;
        private DevExpress.XtraEditors.TextEdit txtKhoiLuong;
        private DevExpress.XtraEditors.TextEdit txtTenTacPham;
        private DevExpress.XtraEditors.TextEdit txtMaSoTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl lblPhongCach;
        private DevExpress.XtraEditors.TextEdit txtPhongCach;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongCach;
        private DevExpress.XtraEditors.SimpleButton btnExitGroup;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
    }
}