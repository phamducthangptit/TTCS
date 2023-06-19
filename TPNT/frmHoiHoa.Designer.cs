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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.dsTPNT = new TPNT.TPNTDataSet();
            this.bdsHoiHoa = new System.Windows.Forms.BindingSource(this.components);
            this.HoiHoaTableAdapter = new TPNT.TPNTDataSetTableAdapters.HoiHoaTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.hoiHoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTruongPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoiHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoiHoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.btnThem,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem1,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChiTiet,
            this.btnLuu,
            this.btnThoat,
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.btnThem;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = global::TPNT.Properties.Resources.edit_2_;
            this.btnHieuChinh.Name = "btnHieuChinh";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 6;
            this.btnLuu.ImageOptions.Image = global::TPNT.Properties.Resources.floppy_disk;
            this.btnLuu.Name = "btnLuu";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::TPNT.Properties.Resources.delete_3_;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = global::TPNT.Properties.Resources.turn_left;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = global::TPNT.Properties.Resources.refresh_1_;
            this.btnReload.Name = "btnReload";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = global::TPNT.Properties.Resources.logout_2_;
            this.btnThoat.Name = "btnThoat";
            // 
            // btnThem
            // 
            this.btnThem.BarName = "Main menu";
            this.btnThem.DockCol = 0;
            this.btnThem.DockRow = 0;
            this.btnThem.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.btnThem.OptionsBar.MultiLine = true;
            this.btnThem.OptionsBar.UseWholeRow = true;
            this.btnThem.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1230, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1230, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1230, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // btnThem1
            // 
            this.btnThem1.Caption = "Thêm";
            this.btnThem1.Id = 0;
            this.btnThem1.ImageOptions.Image = global::TPNT.Properties.Resources.add_group_1_;
            this.btnThem1.Name = "btnThem1";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Id = 7;
            this.btnChiTiet.Name = "btnChiTiet";
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
            // hoiHoaGridControl
            // 
            this.hoiHoaGridControl.DataSource = this.bdsHoiHoa;
            this.hoiHoaGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoiHoaGridControl.Location = new System.Drawing.Point(0, 61);
            this.hoiHoaGridControl.MainView = this.gridView1;
            this.hoiHoaGridControl.MenuManager = this.barManager1;
            this.hoiHoaGridControl.Name = "hoiHoaGridControl";
            this.hoiHoaGridControl.Size = new System.Drawing.Size(1230, 305);
            this.hoiHoaGridControl.TabIndex = 5;
            this.hoiHoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colVatLieu,
            this.colChatLieu,
            this.colTruongPhai});
            this.gridView1.GridControl = this.hoiHoaGridControl;
            this.gridView1.Name = "gridView1";
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.Image = global::TPNT.Properties.Resources.gallery;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmHoiHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 539);
            this.Controls.Add(this.hoiHoaGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHoiHoa";
            this.Text = "frmHoiHoa";
            this.Load += new System.EventHandler(this.frmHoiHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoiHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoiHoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem1;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar btnThem;
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
        private DevExpress.XtraGrid.GridControl hoiHoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colChatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTruongPhai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}