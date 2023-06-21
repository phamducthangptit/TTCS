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
            System.Windows.Forms.Label maSoTPLabel;
            System.Windows.Forms.Label vatLieuLabel;
            System.Windows.Forms.Label chatLieuLabel;
            System.Windows.Forms.Label truongPhaiLabel;
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.dsTPNT = new TPNT.TPNTDataSet();
            this.bdsHoiHoa = new System.Windows.Forms.BindingSource(this.components);
            this.HoiHoaTableAdapter = new TPNT.TPNTDataSetTableAdapters.HoiHoaTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.gcHoiHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTruongPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaTP = new System.Windows.Forms.ComboBox();
            this.txtTruongPhai = new System.Windows.Forms.TextBox();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtVatLieu = new System.Windows.Forms.TextBox();
            maSoTPLabel = new System.Windows.Forms.Label();
            vatLieuLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            truongPhaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoiHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoiHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maSoTPLabel
            // 
            maSoTPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maSoTPLabel.AutoSize = true;
            maSoTPLabel.Location = new System.Drawing.Point(164, 23);
            maSoTPLabel.Name = "maSoTPLabel";
            maSoTPLabel.Size = new System.Drawing.Size(129, 20);
            maSoTPLabel.TabIndex = 0;
            maSoTPLabel.Text = "Mã số tác phẩm:";
            // 
            // vatLieuLabel
            // 
            vatLieuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            vatLieuLabel.AutoSize = true;
            vatLieuLabel.Location = new System.Drawing.Point(164, 105);
            vatLieuLabel.Name = "vatLieuLabel";
            vatLieuLabel.Size = new System.Drawing.Size(68, 20);
            vatLieuLabel.TabIndex = 2;
            vatLieuLabel.Text = "Vật liệu:";
            // 
            // chatLieuLabel
            // 
            chatLieuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chatLieuLabel.AutoSize = true;
            chatLieuLabel.Location = new System.Drawing.Point(764, 29);
            chatLieuLabel.Name = "chatLieuLabel";
            chatLieuLabel.Size = new System.Drawing.Size(77, 20);
            chatLieuLabel.TabIndex = 4;
            chatLieuLabel.Text = "Chất liệu:";
            // 
            // truongPhaiLabel
            // 
            truongPhaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            truongPhaiLabel.AutoSize = true;
            truongPhaiLabel.Location = new System.Drawing.Point(764, 105);
            truongPhaiLabel.Name = "truongPhaiLabel";
            truongPhaiLabel.Size = new System.Drawing.Size(102, 20);
            truongPhaiLabel.TabIndex = 6;
            truongPhaiLabel.Text = "Trường phái:";
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
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChiTiet,
            this.btnLuu,
            this.btnThoat,
            this.barButtonItem1,
            this.btnThem});
            this.barManager1.MainMenu = this.bar2;
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
            this.btnThem.Id = 11;
            this.btnThem.ImageOptions.Image = global::TPNT.Properties.Resources.gallery;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1253, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1253, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 590);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1253, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 590);
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
            // bdsHoiHoa
            // 
            this.bdsHoiHoa.DataMember = "HoiHoa";
            this.bdsHoiHoa.DataSource = this.dsTPNT;
            // 
            // HoiHoaTableAdapter
            // 
            this.HoiHoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoSuuTapTableAdapter = null;
            this.tableAdapterManager.CT_CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.CuocTrienLamTableAdapter = null;
            this.tableAdapterManager.DieuKhacVaTacTuongTableAdapter = null;
            this.tableAdapterManager.HoiHoaTableAdapter = this.HoiHoaTableAdapter;
            this.tableAdapterManager.LoaiDiMuonTableAdapter = null;
            this.tableAdapterManager.LoaiHinhKhacTableAdapter = null;
            this.tableAdapterManager.LoaiSoHuuTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcHoiHoa
            // 
            this.gcHoiHoa.DataSource = this.bdsHoiHoa;
            this.gcHoiHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHoiHoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHoiHoa.Location = new System.Drawing.Point(0, 61);
            this.gcHoiHoa.MainView = this.gridView1;
            this.gcHoiHoa.Margin = new System.Windows.Forms.Padding(4);
            this.gcHoiHoa.MenuManager = this.barManager1;
            this.gcHoiHoa.Name = "gcHoiHoa";
            this.gcHoiHoa.Size = new System.Drawing.Size(1253, 429);
            this.gcHoiHoa.TabIndex = 9;
            this.gcHoiHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.ColumnPanelRowHeight = 40;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colVatLieu,
            this.colChatLieu,
            this.colTruongPhai});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcHoiHoa;
            this.gridView1.GroupRowHeight = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowHeight = 40;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMaSoTP
            // 
            this.colMaSoTP.Caption = "Mã số tác phẩm";
            this.colMaSoTP.FieldName = "MaSoTP";
            this.colMaSoTP.MinWidth = 25;
            this.colMaSoTP.Name = "colMaSoTP";
            this.colMaSoTP.Visible = true;
            this.colMaSoTP.VisibleIndex = 0;
            this.colMaSoTP.Width = 94;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "Vật liệu";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.MinWidth = 25;
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 1;
            this.colVatLieu.Width = 94;
            // 
            // colChatLieu
            // 
            this.colChatLieu.Caption = "Chất liệu";
            this.colChatLieu.FieldName = "ChatLieu";
            this.colChatLieu.MinWidth = 25;
            this.colChatLieu.Name = "colChatLieu";
            this.colChatLieu.Visible = true;
            this.colChatLieu.VisibleIndex = 2;
            this.colChatLieu.Width = 94;
            // 
            // colTruongPhai
            // 
            this.colTruongPhai.Caption = "Trường phái";
            this.colTruongPhai.FieldName = "TruongPhai";
            this.colTruongPhai.MinWidth = 25;
            this.colTruongPhai.Name = "colTruongPhai";
            this.colTruongPhai.Visible = true;
            this.colTruongPhai.VisibleIndex = 3;
            this.colTruongPhai.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaTP);
            this.groupBox1.Controls.Add(truongPhaiLabel);
            this.groupBox1.Controls.Add(this.txtTruongPhai);
            this.groupBox1.Controls.Add(chatLieuLabel);
            this.groupBox1.Controls.Add(this.txtChatLieu);
            this.groupBox1.Controls.Add(vatLieuLabel);
            this.groupBox1.Controls.Add(this.txtVatLieu);
            this.groupBox1.Controls.Add(maSoTPLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1253, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // cmbMaTP
            // 
            this.cmbMaTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaTP.FormattingEnabled = true;
            this.cmbMaTP.Location = new System.Drawing.Point(332, 23);
            this.cmbMaTP.Name = "cmbMaTP";
            this.cmbMaTP.Size = new System.Drawing.Size(213, 28);
            this.cmbMaTP.TabIndex = 8;
            // 
            // txtTruongPhai
            // 
            this.txtTruongPhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTruongPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "TruongPhai", true));
            this.txtTruongPhai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTruongPhai.Location = new System.Drawing.Point(872, 102);
            this.txtTruongPhai.Name = "txtTruongPhai";
            this.txtTruongPhai.Size = new System.Drawing.Size(246, 28);
            this.txtTruongPhai.TabIndex = 7;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChatLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "ChatLieu", true));
            this.txtChatLieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChatLieu.Location = new System.Drawing.Point(872, 29);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(246, 28);
            this.txtChatLieu.TabIndex = 5;
            // 
            // txtVatLieu
            // 
            this.txtVatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVatLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoiHoa, "VatLieu", true));
            this.txtVatLieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVatLieu.Location = new System.Drawing.Point(332, 72);
            this.txtVatLieu.Multiline = true;
            this.txtVatLieu.Name = "txtVatLieu";
            this.txtVatLieu.Size = new System.Drawing.Size(252, 87);
            this.txtVatLieu.TabIndex = 3;
            // 
            // frmHoiHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 671);
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
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private System.Windows.Forms.BindingSource bdsHoiHoa;
        private TPNTDataSet dsTPNT;
        private TPNTDataSetTableAdapters.HoiHoaTableAdapter HoiHoaTableAdapter;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraGrid.GridControl gcHoiHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colChatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTruongPhai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTruongPhai;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtVatLieu;
        private System.Windows.Forms.ComboBox cmbMaTP;
    }
}