namespace TPNT
{
    partial class frmTacGia
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
            System.Windows.Forms.Label maTacGiaLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label ngayMatLabel;
            System.Windows.Forms.Label quocTichLabel;
            System.Windows.Forms.Label dienGiaiLabel;
            System.Windows.Forms.Label phongCachLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.tPNTDataSet = new TPNT.TPNTDataSet();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.TacGiaTableAdapter = new TPNT.TPNTDataSetTableAdapters.TacGiaTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.gcTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.pnlAnh = new System.Windows.Forms.Panel();
            this.txtPhongCach = new System.Windows.Forms.TextBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.ngayMat = new DevExpress.XtraEditors.DateEdit();
            this.ngaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            maTacGiaLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            ngayMatLabel = new System.Windows.Forms.Label();
            quocTichLabel = new System.Windows.Forms.Label();
            dienGiaiLabel = new System.Windows.Forms.Label();
            phongCachLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinh.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Location = new System.Drawing.Point(57, 5);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(88, 20);
            maTacGiaLabel.TabIndex = 0;
            maTacGiaLabel.Text = "Mã tác giả:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(57, 73);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(62, 20);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Họ tên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(60, 122);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(85, 20);
            ngaySinhLabel.TabIndex = 4;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // ngayMatLabel
            // 
            ngayMatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngayMatLabel.AutoSize = true;
            ngayMatLabel.Location = new System.Drawing.Point(60, 191);
            ngayMatLabel.Name = "ngayMatLabel";
            ngayMatLabel.Size = new System.Drawing.Size(83, 20);
            ngayMatLabel.TabIndex = 6;
            ngayMatLabel.Text = "Ngày mất:";
            // 
            // quocTichLabel
            // 
            quocTichLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            quocTichLabel.AutoSize = true;
            quocTichLabel.Location = new System.Drawing.Point(476, 10);
            quocTichLabel.Name = "quocTichLabel";
            quocTichLabel.Size = new System.Drawing.Size(83, 20);
            quocTichLabel.TabIndex = 8;
            quocTichLabel.Text = "Quốc tịch:";
            // 
            // dienGiaiLabel
            // 
            dienGiaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dienGiaiLabel.AutoSize = true;
            dienGiaiLabel.Location = new System.Drawing.Point(476, 122);
            dienGiaiLabel.Name = "dienGiaiLabel";
            dienGiaiLabel.Size = new System.Drawing.Size(76, 20);
            dienGiaiLabel.TabIndex = 10;
            dienGiaiLabel.Text = "Diễn giải:";
            // 
            // phongCachLabel
            // 
            phongCachLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phongCachLabel.AutoSize = true;
            phongCachLabel.Location = new System.Drawing.Point(476, 62);
            phongCachLabel.Name = "phongCachLabel";
            phongCachLabel.Size = new System.Drawing.Size(97, 20);
            phongCachLabel.TabIndex = 12;
            phongCachLabel.Text = "Phong cách:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChiTiet,
            this.btnLuu,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::TPNT.Properties.Resources.add_group_1_;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = global::TPNT.Properties.Resources.edit_2_;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 6;
            this.btnLuu.ImageOptions.Image = global::TPNT.Properties.Resources.floppy_disk;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::TPNT.Properties.Resources.delete_3_;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = global::TPNT.Properties.Resources.turn_left;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = global::TPNT.Properties.Resources.refresh_1_;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = global::TPNT.Properties.Resources.logout_2_;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1356, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 653);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1356, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1356, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Id = 7;
            this.btnChiTiet.Name = "btnChiTiet";
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataMember = "TacGia";
            this.bdsTacGia.DataSource = this.tPNTDataSet;
            // 
            // TacGiaTableAdapter
            // 
            this.TacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoSuuTapTableAdapter = null;
            this.tableAdapterManager.CT_CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.DieuKhacVaTacTuongTableAdapter = null;
            this.tableAdapterManager.HoiHoaTableAdapter = null;
            this.tableAdapterManager.LoaiDiMuonTableAdapter = null;
            this.tableAdapterManager.LoaiHinhKhacTableAdapter = null;
            this.tableAdapterManager.LoaiSoHuuTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = this.TacGiaTableAdapter;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTacGia
            // 
            this.gcTacGia.DataSource = this.bdsTacGia;
            this.gcTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTacGia.Location = new System.Drawing.Point(0, 61);
            this.gcTacGia.MainView = this.gridView1;
            this.gcTacGia.MenuManager = this.barManager1;
            this.gcTacGia.Name = "gcTacGia";
            this.gcTacGia.Size = new System.Drawing.Size(1356, 328);
            this.gcTacGia.TabIndex = 5;
            this.gcTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTacGia,
            this.colHoTen,
            this.colNgaySinh,
            this.colNgayMat,
            this.colQuocTich,
            this.colDienGiai,
            this.colPhongCach});
            this.gridView1.GridControl = this.gcTacGia;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.Caption = "Mã tác giả";
            this.colMaTacGia.FieldName = "MaTacGia";
            this.colMaTacGia.MinWidth = 25;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.VisibleIndex = 0;
            this.colMaTacGia.Width = 94;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 25;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 94;
            // 
            // colNgayMat
            // 
            this.colNgayMat.Caption = "Ngày mất";
            this.colNgayMat.FieldName = "NgayMat";
            this.colNgayMat.MinWidth = 25;
            this.colNgayMat.Name = "colNgayMat";
            this.colNgayMat.Visible = true;
            this.colNgayMat.VisibleIndex = 3;
            this.colNgayMat.Width = 94;
            // 
            // colQuocTich
            // 
            this.colQuocTich.Caption = "Quốc tịch";
            this.colQuocTich.FieldName = "QuocTich";
            this.colQuocTich.MinWidth = 25;
            this.colQuocTich.Name = "colQuocTich";
            this.colQuocTich.Visible = true;
            this.colQuocTich.VisibleIndex = 4;
            this.colQuocTich.Width = 94;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn giải";
            this.colDienGiai.FieldName = "DienGiai";
            this.colDienGiai.MinWidth = 25;
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 5;
            this.colDienGiai.Width = 94;
            // 
            // colPhongCach
            // 
            this.colPhongCach.Caption = "Phong cách";
            this.colPhongCach.FieldName = "PhongCach";
            this.colPhongCach.MinWidth = 25;
            this.colPhongCach.Name = "colPhongCach";
            this.colPhongCach.Visible = true;
            this.colPhongCach.VisibleIndex = 6;
            this.colPhongCach.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.pnlAnh);
            this.groupBox1.Controls.Add(phongCachLabel);
            this.groupBox1.Controls.Add(this.txtPhongCach);
            this.groupBox1.Controls.Add(dienGiaiLabel);
            this.groupBox1.Controls.Add(this.txtDienGiai);
            this.groupBox1.Controls.Add(quocTichLabel);
            this.groupBox1.Controls.Add(this.txtQuocTich);
            this.groupBox1.Controls.Add(ngayMatLabel);
            this.groupBox1.Controls.Add(this.ngayMat);
            this.groupBox1.Controls.Add(ngaySinhLabel);
            this.groupBox1.Controls.Add(this.ngaySinh);
            this.groupBox1.Controls.Add(hoTenLabel);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(maTacGiaLabel);
            this.groupBox1.Controls.Add(this.txtMaTacGia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1356, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // txtSLTP
            // 
            this.txtSLTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSLTP.Location = new System.Drawing.Point(631, 226);
            this.txtSLTP.Name = "txtSLTP";
            this.txtSLTP.ReadOnly = true;
            this.txtSLTP.Size = new System.Drawing.Size(100, 28);
            this.txtSLTP.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số lượng tác phẩm:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChonAnh.Location = new System.Drawing.Point(1081, 244);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(120, 38);
            this.btnChonAnh.TabIndex = 15;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Visible = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // pnlAnh
            // 
            this.pnlAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAnh.Location = new System.Drawing.Point(928, -32);
            this.pnlAnh.Name = "pnlAnh";
            this.pnlAnh.Size = new System.Drawing.Size(416, 270);
            this.pnlAnh.TabIndex = 14;
            // 
            // txtPhongCach
            // 
            this.txtPhongCach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhongCach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "PhongCach", true));
            this.txtPhongCach.Location = new System.Drawing.Point(631, 54);
            this.txtPhongCach.Name = "txtPhongCach";
            this.txtPhongCach.Size = new System.Drawing.Size(179, 28);
            this.txtPhongCach.TabIndex = 13;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDienGiai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "DienGiai", true));
            this.txtDienGiai.Location = new System.Drawing.Point(631, 96);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(268, 82);
            this.txtDienGiai.TabIndex = 11;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuocTich.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "QuocTich", true));
            this.txtQuocTich.Location = new System.Drawing.Point(631, 7);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(179, 28);
            this.txtQuocTich.TabIndex = 9;
            // 
            // ngayMat
            // 
            this.ngayMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngayMat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "NgayMat", true));
            this.ngayMat.EditValue = null;
            this.ngayMat.Location = new System.Drawing.Point(165, 188);
            this.ngayMat.MenuManager = this.barManager1;
            this.ngayMat.Name = "ngayMat";
            this.ngayMat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMat.Size = new System.Drawing.Size(125, 22);
            this.ngayMat.TabIndex = 7;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "NgaySinh", true));
            this.ngaySinh.EditValue = null;
            this.ngaySinh.Location = new System.Drawing.Point(165, 133);
            this.ngaySinh.MenuManager = this.barManager1;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinh.Size = new System.Drawing.Size(125, 22);
            this.ngaySinh.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "HoTen", true));
            this.txtHoTen.Location = new System.Drawing.Point(162, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 28);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaTacGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "MaTacGia", true));
            this.txtMaTacGia.Location = new System.Drawing.Point(162, 2);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(149, 28);
            this.txtMaTacGia.TabIndex = 1;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcTacGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTacGia";
            this.Text = "Tác giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private TPNTDataSet tPNTDataSet;
        private TPNTDataSetTableAdapters.TacGiaTableAdapter TacGiaTableAdapter;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMat;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocTich;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongCach;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhongCach;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.TextBox txtQuocTich;
        private DevExpress.XtraEditors.DateEdit ngayMat;
        private DevExpress.XtraEditors.DateEdit ngaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Panel pnlAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtSLTP;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
    }
}