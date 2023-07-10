namespace TPNT
{
    partial class frmChiTietCuocTienLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietCuocTienLam));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grbThemChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.btnExitGroup = new DevExpress.XtraEditors.SimpleButton();
            this.sP_TPNT_ChiTietCTLGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsThemChiTiet = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTDataSet1 = new TPNT.TPNTDataSet1();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacGia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsChiTietCTL = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CHITIETCUOCTRIENLAMTableAdapter = new TPNT.TPNTDataSet1TableAdapters.SP_CHITIETCUOCTRIENLAMTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.sP_CHITIETCUOCTRIENLAMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SP_TPNT_ChiTietCTLTableAdapter = new TPNT.TPNTDataSet1TableAdapters.SP_TPNT_ChiTietCTLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbThemChiTiet)).BeginInit();
            this.grbThemChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TPNT_ChiTietCTLGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThemChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietCTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHITIETCUOCTRIENLAMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnLuu,
            this.btnHoanTac,
            this.btnReload});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
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
            this.btnLuu.Id = 2;
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
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 638);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 608);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 608);
            // 
            // grbThemChiTiet
            // 
            this.grbThemChiTiet.Controls.Add(this.btnExitGroup);
            this.grbThemChiTiet.Controls.Add(this.sP_TPNT_ChiTietCTLGridControl);
            this.grbThemChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbThemChiTiet.Location = new System.Drawing.Point(0, 369);
            this.grbThemChiTiet.Name = "grbThemChiTiet";
            this.grbThemChiTiet.Size = new System.Drawing.Size(1134, 269);
            this.grbThemChiTiet.TabIndex = 16;
            this.grbThemChiTiet.Text = "Thêm Chi Tiết";
            this.grbThemChiTiet.Visible = false;
            // 
            // btnExitGroup
            // 
            this.btnExitGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitGroup.ImageOptions.Image")));
            this.btnExitGroup.Location = new System.Drawing.Point(1095, 0);
            this.btnExitGroup.Name = "btnExitGroup";
            this.btnExitGroup.Size = new System.Drawing.Size(34, 26);
            this.btnExitGroup.TabIndex = 34;
            this.btnExitGroup.Click += new System.EventHandler(this.btnExitGroup_Click);
            // 
            // sP_TPNT_ChiTietCTLGridControl
            // 
            this.sP_TPNT_ChiTietCTLGridControl.DataSource = this.bdsThemChiTiet;
            this.sP_TPNT_ChiTietCTLGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_TPNT_ChiTietCTLGridControl.Location = new System.Drawing.Point(2, 28);
            this.sP_TPNT_ChiTietCTLGridControl.MainView = this.gridView2;
            this.sP_TPNT_ChiTietCTLGridControl.MenuManager = this.barManager1;
            this.sP_TPNT_ChiTietCTLGridControl.Name = "sP_TPNT_ChiTietCTLGridControl";
            this.sP_TPNT_ChiTietCTLGridControl.Size = new System.Drawing.Size(1130, 239);
            this.sP_TPNT_ChiTietCTLGridControl.TabIndex = 0;
            this.sP_TPNT_ChiTietCTLGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsThemChiTiet
            // 
            this.bdsThemChiTiet.DataMember = "SP_TPNT_ChiTietCTL";
            this.bdsThemChiTiet.DataSource = this.tPNTDataSet1;
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP1,
            this.colTenTP1,
            this.colNamSangTac1,
            this.colTacGia1});
            this.gridView2.GridControl = this.sP_TPNT_ChiTietCTLGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colMaSoTP1
            // 
            this.colMaSoTP1.Caption = "Mã Số TP";
            this.colMaSoTP1.FieldName = "MaSoTP";
            this.colMaSoTP1.MinWidth = 25;
            this.colMaSoTP1.Name = "colMaSoTP1";
            this.colMaSoTP1.Visible = true;
            this.colMaSoTP1.VisibleIndex = 0;
            this.colMaSoTP1.Width = 94;
            // 
            // colTenTP1
            // 
            this.colTenTP1.Caption = "Tên TP";
            this.colTenTP1.FieldName = "TenTP";
            this.colTenTP1.MinWidth = 25;
            this.colTenTP1.Name = "colTenTP1";
            this.colTenTP1.Visible = true;
            this.colTenTP1.VisibleIndex = 1;
            this.colTenTP1.Width = 94;
            // 
            // colNamSangTac1
            // 
            this.colNamSangTac1.Caption = "Năm Sáng Tác";
            this.colNamSangTac1.FieldName = "NamSangTac";
            this.colNamSangTac1.MinWidth = 25;
            this.colNamSangTac1.Name = "colNamSangTac1";
            this.colNamSangTac1.Visible = true;
            this.colNamSangTac1.VisibleIndex = 2;
            this.colNamSangTac1.Width = 94;
            // 
            // colTacGia1
            // 
            this.colTacGia1.Caption = "Tác Giả";
            this.colTacGia1.FieldName = "TacGia";
            this.colTacGia1.MinWidth = 25;
            this.colTacGia1.Name = "colTacGia1";
            this.colTacGia1.Visible = true;
            this.colTacGia1.VisibleIndex = 3;
            this.colTacGia1.Width = 94;
            // 
            // bdsChiTietCTL
            // 
            this.bdsChiTietCTL.DataMember = "SP_CHITIETCUOCTRIENLAM";
            this.bdsChiTietCTL.DataSource = this.tPNTDataSet1;
            // 
            // SP_CHITIETCUOCTRIENLAMTableAdapter
            // 
            this.SP_CHITIETCUOCTRIENLAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_CHITIETCUOCTRIENLAMGridControl
            // 
            this.sP_CHITIETCUOCTRIENLAMGridControl.DataSource = this.bdsChiTietCTL;
            this.sP_CHITIETCUOCTRIENLAMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_CHITIETCUOCTRIENLAMGridControl.Location = new System.Drawing.Point(0, 30);
            this.sP_CHITIETCUOCTRIENLAMGridControl.MainView = this.gridView1;
            this.sP_CHITIETCUOCTRIENLAMGridControl.MenuManager = this.barManager1;
            this.sP_CHITIETCUOCTRIENLAMGridControl.Name = "sP_CHITIETCUOCTRIENLAMGridControl";
            this.sP_CHITIETCUOCTRIENLAMGridControl.Size = new System.Drawing.Size(1134, 339);
            this.sP_CHITIETCUOCTRIENLAMGridControl.TabIndex = 29;
            this.sP_CHITIETCUOCTRIENLAMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colTenTP,
            this.colNamSangTac,
            this.colChuDe,
            this.colTacGia});
            this.gridView1.GridControl = this.sP_CHITIETCUOCTRIENLAMGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaSoTP
            // 
            this.colMaSoTP.Caption = "Mã Số TP";
            this.colMaSoTP.FieldName = "MaSoTP";
            this.colMaSoTP.MinWidth = 25;
            this.colMaSoTP.Name = "colMaSoTP";
            this.colMaSoTP.Visible = true;
            this.colMaSoTP.VisibleIndex = 0;
            this.colMaSoTP.Width = 94;
            // 
            // colTenTP
            // 
            this.colTenTP.Caption = "Tên TP";
            this.colTenTP.FieldName = "TenTP";
            this.colTenTP.MinWidth = 25;
            this.colTenTP.Name = "colTenTP";
            this.colTenTP.Visible = true;
            this.colTenTP.VisibleIndex = 1;
            this.colTenTP.Width = 94;
            // 
            // colNamSangTac
            // 
            this.colNamSangTac.Caption = "Năm Sáng Tác";
            this.colNamSangTac.FieldName = "NamSangTac";
            this.colNamSangTac.MinWidth = 25;
            this.colNamSangTac.Name = "colNamSangTac";
            this.colNamSangTac.Visible = true;
            this.colNamSangTac.VisibleIndex = 2;
            this.colNamSangTac.Width = 94;
            // 
            // colChuDe
            // 
            this.colChuDe.Caption = "Chủ Đề";
            this.colChuDe.FieldName = "ChuDe";
            this.colChuDe.MinWidth = 25;
            this.colChuDe.Name = "colChuDe";
            this.colChuDe.Visible = true;
            this.colChuDe.VisibleIndex = 3;
            this.colChuDe.Width = 94;
            // 
            // colTacGia
            // 
            this.colTacGia.Caption = "Tác Giả";
            this.colTacGia.FieldName = "TacGia";
            this.colTacGia.MinWidth = 25;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Visible = true;
            this.colTacGia.VisibleIndex = 4;
            this.colTacGia.Width = 94;
            // 
            // SP_TPNT_ChiTietCTLTableAdapter
            // 
            this.SP_TPNT_ChiTietCTLTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTietCuocTienLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 658);
            this.Controls.Add(this.sP_CHITIETCUOCTRIENLAMGridControl);
            this.Controls.Add(this.grbThemChiTiet);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChiTietCuocTienLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Cuộc Triển Lãm";
            this.Load += new System.EventHandler(this.frmChiTietCuocTienLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbThemChiTiet)).EndInit();
            this.grbThemChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_TPNT_ChiTietCTLGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThemChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietCTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHITIETCUOCTRIENLAMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl grbThemChiTiet;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private System.Windows.Forms.BindingSource bdsChiTietCTL;
        private TPNTDataSet1 tPNTDataSet1;
        private TPNTDataSet1TableAdapters.SP_CHITIETCUOCTRIENLAMTableAdapter SP_CHITIETCUOCTRIENLAMTableAdapter;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_CHITIETCUOCTRIENLAMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac;
        private DevExpress.XtraGrid.Columns.GridColumn colChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP;
        private System.Windows.Forms.BindingSource bdsThemChiTiet;
        private TPNTDataSet1TableAdapters.SP_TPNT_ChiTietCTLTableAdapter SP_TPNT_ChiTietCTLTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_TPNT_ChiTietCTLGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP1;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac1;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia1;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraEditors.SimpleButton btnExitGroup;
    }
}