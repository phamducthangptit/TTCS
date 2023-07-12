namespace TPNT
{
    partial class frmHoiHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoiHoa));
            this.tenLabel = new System.Windows.Forms.Label();
            this.truongPhaiLabel = new System.Windows.Forms.Label();
            this.chatLieuLabel = new System.Windows.Forms.Label();
            this.vatLieuLabel = new System.Windows.Forms.Label();
            this.maSoTPLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.dsTPNT = new TPNT.TPNTDataSet();
            this.v_SELECTHOIHOATableAdapter1 = new TPNT.TPNTDataSetTableAdapters.V_SELECTHOIHOATableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.bdsHoiHoa = new System.Windows.Forms.BindingSource(this.components);
            this.gcHoiHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTruongPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTruongPhai = new System.Windows.Forms.TextBox();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtVatLieu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoiHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoiHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenLabel
            // 
            this.tenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenLabel.AutoSize = true;
            this.tenLabel.Location = new System.Drawing.Point(25, 115);
            this.tenLabel.Name = "tenLabel";
            this.tenLabel.Size = new System.Drawing.Size(34, 17);
            this.tenLabel.TabIndex = 9;
            this.tenLabel.Text = "Tên:";
            // 
            // truongPhaiLabel
            // 
            this.truongPhaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.truongPhaiLabel.AutoSize = true;
            this.truongPhaiLabel.Location = new System.Drawing.Point(504, 184);
            this.truongPhaiLabel.Name = "truongPhaiLabel";
            this.truongPhaiLabel.Size = new System.Drawing.Size(82, 17);
            this.truongPhaiLabel.TabIndex = 6;
            this.truongPhaiLabel.Text = "Trường phái:";
            // 
            // chatLieuLabel
            // 
            this.chatLieuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatLieuLabel.AutoSize = true;
            this.chatLieuLabel.Location = new System.Drawing.Point(25, 183);
            this.chatLieuLabel.Name = "chatLieuLabel";
            this.chatLieuLabel.Size = new System.Drawing.Size(63, 17);
            this.chatLieuLabel.TabIndex = 4;
            this.chatLieuLabel.Text = "Chất liệu:";
            // 
            // vatLieuLabel
            // 
            this.vatLieuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vatLieuLabel.AutoSize = true;
            this.vatLieuLabel.Location = new System.Drawing.Point(504, 92);
            this.vatLieuLabel.Name = "vatLieuLabel";
            this.vatLieuLabel.Size = new System.Drawing.Size(57, 17);
            this.vatLieuLabel.TabIndex = 2;
            this.vatLieuLabel.Text = "Vật liệu:";
            // 
            // maSoTPLabel
            // 
            this.maSoTPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maSoTPLabel.AutoSize = true;
            this.maSoTPLabel.Location = new System.Drawing.Point(25, 56);
            this.maSoTPLabel.Name = "maSoTPLabel";
            this.maSoTPLabel.Size = new System.Drawing.Size(106, 17);
            this.maSoTPLabel.TabIndex = 0;
            this.maSoTPLabel.Text = "Mã số tác phẩm:";
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
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChiTiet,
            this.btnLuu,
            this.barButtonItem1,
            this.btnThem});
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Hovered.Options.UseFont = true;
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bar1.BarAppearance.Pressed.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 11;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
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
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Name = "btnReload";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(966, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 615);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(966, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 583);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(966, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 583);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Id = 7;
            this.btnChiTiet.Name = "btnChiTiet";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // dsTPNT
            // 
            this.dsTPNT.DataSetName = "TPNTDataSet";
            this.dsTPNT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_SELECTHOIHOATableAdapter1
            // 
            this.v_SELECTHOIHOATableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoSuuTapTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.DieuKhacVaTacTuongTableAdapter = null;
            this.tableAdapterManager.HoiHoaTableAdapter = null;
            this.tableAdapterManager.LoaiDiMuonTableAdapter = null;
            this.tableAdapterManager.LoaiHinhKhacTableAdapter = null;
            this.tableAdapterManager.LoaiSoHuuTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsHoiHoa
            // 
            this.bdsHoiHoa.DataMember = "V_SELECTHOIHOA";
            this.bdsHoiHoa.DataSource = this.dsTPNT;
            // 
            // gcHoiHoa
            // 
            this.gcHoiHoa.DataSource = this.bdsHoiHoa;
            this.gcHoiHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHoiHoa.Location = new System.Drawing.Point(0, 32);
            this.gcHoiHoa.MainView = this.gridView1;
            this.gcHoiHoa.MenuManager = this.barManager1;
            this.gcHoiHoa.Name = "gcHoiHoa";
            this.gcHoiHoa.Size = new System.Drawing.Size(966, 332);
            this.gcHoiHoa.TabIndex = 33;
            this.gcHoiHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 20;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colVatLieu,
            this.colChatLieu,
            this.colTruongPhai});
            this.gridView1.GridControl = this.gcHoiHoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowHeight = 20;
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã tác phẩm";
            this.colMa.FieldName = "Ma";
            this.colMa.MinWidth = 25;
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            this.colMa.Width = 94;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên tác phẩm";
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 94;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "Vật liệu";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.MinWidth = 25;
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 2;
            this.colVatLieu.Width = 94;
            // 
            // colChatLieu
            // 
            this.colChatLieu.Caption = "Chất liệu";
            this.colChatLieu.FieldName = "ChatLieu";
            this.colChatLieu.MinWidth = 25;
            this.colChatLieu.Name = "colChatLieu";
            this.colChatLieu.Visible = true;
            this.colChatLieu.VisibleIndex = 3;
            this.colChatLieu.Width = 94;
            // 
            // colTruongPhai
            // 
            this.colTruongPhai.Caption = "Trường phái";
            this.colTruongPhai.FieldName = "TruongPhai";
            this.colTruongPhai.MinWidth = 25;
            this.colTruongPhai.Name = "colTruongPhai";
            this.colTruongPhai.Visible = true;
            this.colTruongPhai.VisibleIndex = 4;
            this.colTruongPhai.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTruongPhai);
            this.groupBox1.Controls.Add(this.txtChatLieu);
            this.groupBox1.Controls.Add(this.txtVatLieu);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Controls.Add(this.tenLabel);
            this.groupBox1.Controls.Add(this.truongPhaiLabel);
            this.groupBox1.Controls.Add(this.chatLieuLabel);
            this.groupBox1.Controls.Add(this.vatLieuLabel);
            this.groupBox1.Controls.Add(this.maSoTPLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 251);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txtTruongPhai
            // 
            this.txtTruongPhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTruongPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "TruongPhai", true));
            this.txtTruongPhai.Location = new System.Drawing.Point(674, 184);
            this.txtTruongPhai.Name = "txtTruongPhai";
            this.txtTruongPhai.Size = new System.Drawing.Size(243, 24);
            this.txtTruongPhai.TabIndex = 17;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChatLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "ChatLieu", true));
            this.txtChatLieu.Location = new System.Drawing.Point(193, 180);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(246, 24);
            this.txtChatLieu.TabIndex = 16;
            // 
            // txtVatLieu
            // 
            this.txtVatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVatLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "VatLieu", true));
            this.txtVatLieu.Location = new System.Drawing.Point(674, 34);
            this.txtVatLieu.Multiline = true;
            this.txtVatLieu.Name = "txtVatLieu";
            this.txtVatLieu.Size = new System.Drawing.Size(243, 131);
            this.txtVatLieu.TabIndex = 15;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(193, 115);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(246, 24);
            this.txtTen.TabIndex = 14;
            // 
            // txtMaTP
            // 
            this.txtMaTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "Ma", true));
            this.txtMaTP.Location = new System.Drawing.Point(193, 56);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.ReadOnly = true;
            this.txtMaTP.Size = new System.Drawing.Size(246, 24);
            this.txtMaTP.TabIndex = 13;
            // 
            // frmHoiHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcHoiHoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoiHoa";
            this.Text = "Hội họa";
            this.Load += new System.EventHandler(this.frmHoiHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoiHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoiHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private TPNTDataSet dsTPNT;
        private TPNTDataSetTableAdapters.V_SELECTHOIHOATableAdapter v_SELECTHOIHOATableAdapter1;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTruongPhai;
        private System.Windows.Forms.BindingSource bdsHoiHoa;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtVatLieu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaTP;
        private DevExpress.XtraGrid.GridControl gcHoiHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colChatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTruongPhai;
        private System.Windows.Forms.Label tenLabel;
        private System.Windows.Forms.Label truongPhaiLabel;
        private System.Windows.Forms.Label chatLieuLabel;
        private System.Windows.Forms.Label vatLieuLabel;
        private System.Windows.Forms.Label maSoTPLabel;
    }
}