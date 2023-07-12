namespace TPNT
{
    partial class frmTaiSanBaoTang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiSanBaoTang));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.btnExitGroup = new DevExpress.XtraEditors.SimpleButton();
            this.dtpSoHuu = new DevExpress.XtraEditors.DateEdit();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTP = new DevExpress.XtraEditors.TextEdit();
            this.txtTriGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTP = new DevExpress.XtraEditors.TextEdit();
            this.btnChonLai = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tPNTDataSet1 = new TPNT.TPNTDataSet1();
            this.bdsLoaiSoHuu = new System.Windows.Forms.BindingSource(this.components);
            this.view_ListLoaiSoHuuTableAdapter = new TPNT.TPNTDataSet1TableAdapters.View_ListLoaiSoHuuTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.view_ListLoaiSoHuuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãtácphẩm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàysởhữu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTìnhTrạng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrịgiá = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNămsángtác = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTêntácphẩm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSoHuu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSoHuu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTriGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiSoHuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ListLoaiSoHuuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Hovered.Options.UseFont = true;
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Pressed.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar2.BarAppearance.Disabled.Options.UseFont = true;
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar2.BarAppearance.Pressed.Options.UseFont = true;
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
            this.btnLuu,
            this.btnHoanTac,
            this.btnReload});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload)});
            this.bar3.Text = "Tools";
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
            this.btnLuu.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(917, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(917, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(917, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.btnExitGroup);
            this.groupThongTin.Controls.Add(this.dtpSoHuu);
            this.groupThongTin.Controls.Add(this.txtTrangThai);
            this.groupThongTin.Controls.Add(this.txtTenTP);
            this.groupThongTin.Controls.Add(this.txtTriGia);
            this.groupThongTin.Controls.Add(this.txtMaTP);
            this.groupThongTin.Controls.Add(this.btnChonLai);
            this.groupThongTin.Controls.Add(this.labelControl5);
            this.groupThongTin.Controls.Add(this.labelControl4);
            this.groupThongTin.Controls.Add(this.labelControl3);
            this.groupThongTin.Controls.Add(this.labelControl2);
            this.groupThongTin.Controls.Add(this.labelControl1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongTin.Location = new System.Drawing.Point(0, 272);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(917, 217);
            this.groupThongTin.TabIndex = 6;
            this.groupThongTin.Text = "Thêm Thông Tin";
            this.groupThongTin.Visible = false;
            // 
            // btnExitGroup
            // 
            this.btnExitGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitGroup.ImageOptions.Image")));
            this.btnExitGroup.Location = new System.Drawing.Point(879, 0);
            this.btnExitGroup.Name = "btnExitGroup";
            this.btnExitGroup.Size = new System.Drawing.Size(34, 26);
            this.btnExitGroup.TabIndex = 16;
            this.btnExitGroup.Click += new System.EventHandler(this.btnExitGroup_Click);
            // 
            // dtpSoHuu
            // 
            this.dtpSoHuu.EditValue = null;
            this.dtpSoHuu.Location = new System.Drawing.Point(171, 132);
            this.dtpSoHuu.MenuManager = this.barManager1;
            this.dtpSoHuu.Name = "dtpSoHuu";
            this.dtpSoHuu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSoHuu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSoHuu.Size = new System.Drawing.Size(109, 22);
            this.dtpSoHuu.TabIndex = 9;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(442, 132);
            this.txtTrangThai.MenuManager = this.barManager1;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(109, 22);
            this.txtTrangThai.TabIndex = 10;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(442, 75);
            this.txtTenTP.MenuManager = this.barManager1;
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Properties.ReadOnly = true;
            this.txtTenTP.Size = new System.Drawing.Size(109, 22);
            this.txtTenTP.TabIndex = 7;
            // 
            // txtTriGia
            // 
            this.txtTriGia.EditValue = "";
            this.txtTriGia.Location = new System.Drawing.Point(662, 133);
            this.txtTriGia.MenuManager = this.barManager1;
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Properties.DisplayFormat.FormatString = "n";
            this.txtTriGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTriGia.Properties.EditFormat.FormatString = "n";
            this.txtTriGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTriGia.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTriGia.Properties.MaskSettings.Set("mask", "d");
            this.txtTriGia.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtTriGia.Size = new System.Drawing.Size(109, 22);
            this.txtTriGia.TabIndex = 11;
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(171, 75);
            this.txtMaTP.MenuManager = this.barManager1;
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Properties.ReadOnly = true;
            this.txtMaTP.Size = new System.Drawing.Size(109, 22);
            this.txtMaTP.TabIndex = 6;
            // 
            // btnChonLai
            // 
            this.btnChonLai.BackColor = System.Drawing.Color.Lime;
            this.btnChonLai.Location = new System.Drawing.Point(662, 68);
            this.btnChonLai.Name = "btnChonLai";
            this.btnChonLai.Size = new System.Drawing.Size(109, 34);
            this.btnChonLai.TabIndex = 8;
            this.btnChonLai.Text = "Chọn Lại TPNT";
            this.btnChonLai.UseVisualStyleBackColor = false;
            this.btnChonLai.Click += new System.EventHandler(this.btnChonLai_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(596, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Trị Giá :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tình Trạng :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày Sở Hữu : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(316, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Tác Phẩm :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Số TP :";
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLoaiSoHuu
            // 
            this.bdsLoaiSoHuu.DataMember = "View_ListLoaiSoHuu";
            this.bdsLoaiSoHuu.DataSource = this.tPNTDataSet1;
            // 
            // view_ListLoaiSoHuuTableAdapter
            // 
            this.view_ListLoaiSoHuuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_ListLoaiSoHuuGridControl
            // 
            this.view_ListLoaiSoHuuGridControl.DataSource = this.bdsLoaiSoHuu;
            this.view_ListLoaiSoHuuGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_ListLoaiSoHuuGridControl.Location = new System.Drawing.Point(0, 30);
            this.view_ListLoaiSoHuuGridControl.MainView = this.gridView1;
            this.view_ListLoaiSoHuuGridControl.MenuManager = this.barManager1;
            this.view_ListLoaiSoHuuGridControl.Name = "view_ListLoaiSoHuuGridControl";
            this.view_ListLoaiSoHuuGridControl.Size = new System.Drawing.Size(917, 242);
            this.view_ListLoaiSoHuuGridControl.TabIndex = 11;
            this.view_ListLoaiSoHuuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãtácphẩm,
            this.colNgàysởhữu,
            this.colTìnhTrạng,
            this.colTrịgiá,
            this.colNămsángtác,
            this.colTêntácphẩm,
            this.colTácgiả});
            this.gridView1.DetailHeight = 328;
            this.gridView1.GridControl = this.view_ListLoaiSoHuuGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // colMãtácphẩm
            // 
            this.colMãtácphẩm.FieldName = "Mã tác phẩm";
            this.colMãtácphẩm.MinWidth = 25;
            this.colMãtácphẩm.Name = "colMãtácphẩm";
            this.colMãtácphẩm.Visible = true;
            this.colMãtácphẩm.VisibleIndex = 0;
            this.colMãtácphẩm.Width = 94;
            // 
            // colNgàysởhữu
            // 
            this.colNgàysởhữu.FieldName = "Ngày sở hữu";
            this.colNgàysởhữu.MinWidth = 25;
            this.colNgàysởhữu.Name = "colNgàysởhữu";
            this.colNgàysởhữu.Visible = true;
            this.colNgàysởhữu.VisibleIndex = 1;
            this.colNgàysởhữu.Width = 94;
            // 
            // colTìnhTrạng
            // 
            this.colTìnhTrạng.FieldName = "Tình Trạng";
            this.colTìnhTrạng.MinWidth = 25;
            this.colTìnhTrạng.Name = "colTìnhTrạng";
            this.colTìnhTrạng.Visible = true;
            this.colTìnhTrạng.VisibleIndex = 2;
            this.colTìnhTrạng.Width = 94;
            // 
            // colTrịgiá
            // 
            this.colTrịgiá.FieldName = "Trị giá";
            this.colTrịgiá.MinWidth = 25;
            this.colTrịgiá.Name = "colTrịgiá";
            this.colTrịgiá.Visible = true;
            this.colTrịgiá.VisibleIndex = 3;
            this.colTrịgiá.Width = 94;
            // 
            // colNămsángtác
            // 
            this.colNămsángtác.FieldName = "Năm sáng tác";
            this.colNămsángtác.MinWidth = 25;
            this.colNămsángtác.Name = "colNămsángtác";
            this.colNămsángtác.Visible = true;
            this.colNămsángtác.VisibleIndex = 4;
            this.colNămsángtác.Width = 94;
            // 
            // colTêntácphẩm
            // 
            this.colTêntácphẩm.FieldName = "Tên tác phẩm";
            this.colTêntácphẩm.MinWidth = 25;
            this.colTêntácphẩm.Name = "colTêntácphẩm";
            this.colTêntácphẩm.Visible = true;
            this.colTêntácphẩm.VisibleIndex = 5;
            this.colTêntácphẩm.Width = 94;
            // 
            // colTácgiả
            // 
            this.colTácgiả.FieldName = "Tác giả";
            this.colTácgiả.MinWidth = 25;
            this.colTácgiả.Name = "colTácgiả";
            this.colTácgiả.Visible = true;
            this.colTácgiả.VisibleIndex = 6;
            this.colTácgiả.Width = 94;
            // 
            // frmTaiSanBaoTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(917, 509);
            this.Controls.Add(this.view_ListLoaiSoHuuGridControl);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaiSanBaoTang";
            this.Text = "Tài Sản Của Bảo Tàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaiSanBaoTang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSoHuu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSoHuu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTriGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiSoHuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ListLoaiSoHuuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private DevExpress.XtraEditors.DateEdit dtpSoHuu;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
        private DevExpress.XtraEditors.TextEdit txtTenTP;
        private DevExpress.XtraEditors.TextEdit txtTriGia;
        private DevExpress.XtraEditors.TextEdit txtMaTP;
        private System.Windows.Forms.Button btnChonLai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExitGroup;
        private System.Windows.Forms.BindingSource bdsLoaiSoHuu;
        private TPNTDataSet1 tPNTDataSet1;
        private TPNTDataSet1TableAdapters.View_ListLoaiSoHuuTableAdapter view_ListLoaiSoHuuTableAdapter;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl view_ListLoaiSoHuuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãtácphẩm;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàysởhữu;
        private DevExpress.XtraGrid.Columns.GridColumn colTìnhTrạng;
        private DevExpress.XtraGrid.Columns.GridColumn colTrịgiá;
        private DevExpress.XtraGrid.Columns.GridColumn colNămsángtác;
        private DevExpress.XtraGrid.Columns.GridColumn colTêntácphẩm;
        private DevExpress.XtraGrid.Columns.GridColumn colTácgiả;
    }
}