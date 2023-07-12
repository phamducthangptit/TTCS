namespace TPNT
{
    partial class frmBoSuuTap
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
            System.Windows.Forms.Label tênLabel;
            System.Windows.Forms.Label mã_bộ_sưu_tậpLabel;
            System.Windows.Forms.Label hình_thứcLabel;
            System.Windows.Forms.Label địa_chỉLabel;
            System.Windows.Forms.Label nguoiGDLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label lbMoTa;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoSuuTap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.bdsBoSuuTap = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTDataSet = new TPNT.TPNTDataSet2();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNguoiGiamDinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panelDSBoSuuTap = new System.Windows.Forms.Panel();
            this.v_BO_SUU_TAPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãbộsưutập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHìnhthức = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐịachỉ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_BO_SUU_TAPTableAdapter = new TPNT.TPNTDataSet2TableAdapters.V_BO_SUU_TAPTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet2TableAdapters.TableAdapterManager();
            tênLabel = new System.Windows.Forms.Label();
            mã_bộ_sưu_tậpLabel = new System.Windows.Forms.Label();
            hình_thứcLabel = new System.Windows.Forms.Label();
            địa_chỉLabel = new System.Windows.Forms.Label();
            nguoiGDLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            lbMoTa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoSuuTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            this.panelDSBoSuuTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_BO_SUU_TAPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tênLabel
            // 
            tênLabel.AutoSize = true;
            tênLabel.Location = new System.Drawing.Point(12, 10);
            tênLabel.Name = "tênLabel";
            tênLabel.Size = new System.Drawing.Size(29, 13);
            tênLabel.TabIndex = 0;
            tênLabel.Text = "Tên:";
            // 
            // mã_bộ_sưu_tậpLabel
            // 
            mã_bộ_sưu_tậpLabel.AutoSize = true;
            mã_bộ_sưu_tậpLabel.Location = new System.Drawing.Point(12, 40);
            mã_bộ_sưu_tậpLabel.Name = "mã_bộ_sưu_tậpLabel";
            mã_bộ_sưu_tậpLabel.Size = new System.Drawing.Size(78, 13);
            mã_bộ_sưu_tậpLabel.TabIndex = 2;
            mã_bộ_sưu_tậpLabel.Text = "Mã bộ sưu tập:";
            // 
            // hình_thứcLabel
            // 
            hình_thứcLabel.AutoSize = true;
            hình_thứcLabel.Location = new System.Drawing.Point(12, 70);
            hình_thứcLabel.Name = "hình_thứcLabel";
            hình_thứcLabel.Size = new System.Drawing.Size(56, 13);
            hình_thứcLabel.TabIndex = 4;
            hình_thứcLabel.Text = "Hình thức:";
            // 
            // địa_chỉLabel
            // 
            địa_chỉLabel.AutoSize = true;
            địa_chỉLabel.Location = new System.Drawing.Point(12, 100);
            địa_chỉLabel.Name = "địa_chỉLabel";
            địa_chỉLabel.Size = new System.Drawing.Size(43, 13);
            địa_chỉLabel.TabIndex = 6;
            địa_chỉLabel.Text = "Địa chỉ:";
            // 
            // nguoiGDLabel
            // 
            nguoiGDLabel.AutoSize = true;
            nguoiGDLabel.Location = new System.Drawing.Point(12, 130);
            nguoiGDLabel.Name = "nguoiGDLabel";
            nguoiGDLabel.Size = new System.Drawing.Size(87, 13);
            nguoiGDLabel.TabIndex = 8;
            nguoiGDLabel.Text = "Người giám định:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(12, 160);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(73, 13);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "Số điện thoại:";
            // 
            // lbMoTa
            // 
            lbMoTa.AutoSize = true;
            lbMoTa.Location = new System.Drawing.Point(12, 190);
            lbMoTa.Name = "lbMoTa";
            lbMoTa.Size = new System.Drawing.Size(37, 13);
            lbMoTa.TabIndex = 12;
            lbMoTa.Text = "Mô tả:";
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
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnGhi});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 5;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
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
            this.barDockControlTop.Size = new System.Drawing.Size(1064, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 522);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1064, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1064, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(lbMoTa);
            this.panelThongTin.Controls.Add(this.txtMoTa);
            this.panelThongTin.Controls.Add(sDTLabel);
            this.panelThongTin.Controls.Add(this.txtSDT);
            this.panelThongTin.Controls.Add(nguoiGDLabel);
            this.panelThongTin.Controls.Add(this.txtNguoiGiamDinh);
            this.panelThongTin.Controls.Add(địa_chỉLabel);
            this.panelThongTin.Controls.Add(this.txtDiaChi);
            this.panelThongTin.Controls.Add(hình_thứcLabel);
            this.panelThongTin.Controls.Add(this.txtHinhThuc);
            this.panelThongTin.Controls.Add(mã_bộ_sưu_tậpLabel);
            this.panelThongTin.Controls.Add(this.txtMa);
            this.panelThongTin.Controls.Add(tênLabel);
            this.panelThongTin.Controls.Add(this.txtTen);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThongTin.Enabled = false;
            this.panelThongTin.Location = new System.Drawing.Point(0, 24);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(400, 498);
            this.panelThongTin.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "MoTa", true));
            this.txtMoTa.Location = new System.Drawing.Point(120, 190);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(246, 184);
            this.txtMoTa.TabIndex = 13;
            // 
            // bdsBoSuuTap
            // 
            this.bdsBoSuuTap.DataMember = "V_BO_SUU_TAP";
            this.bdsBoSuuTap.DataSource = this.tPNTDataSet;
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(120, 160);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(246, 20);
            this.txtSDT.TabIndex = 11;
            // 
            // txtNguoiGiamDinh
            // 
            this.txtNguoiGiamDinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "NguoiGD", true));
            this.txtNguoiGiamDinh.Location = new System.Drawing.Point(120, 130);
            this.txtNguoiGiamDinh.Name = "txtNguoiGiamDinh";
            this.txtNguoiGiamDinh.Size = new System.Drawing.Size(246, 20);
            this.txtNguoiGiamDinh.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "Địa chỉ", true));
            this.txtDiaChi.Location = new System.Drawing.Point(120, 100);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "Hình thức", true));
            this.txtHinhThuc.Location = new System.Drawing.Point(120, 70);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.Size = new System.Drawing.Size(246, 20);
            this.txtHinhThuc.TabIndex = 5;
            // 
            // txtMa
            // 
            this.txtMa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "Mã bộ sưu tập", true));
            this.txtMa.Location = new System.Drawing.Point(120, 40);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(246, 20);
            this.txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoSuuTap, "Tên", true));
            this.txtTen.Location = new System.Drawing.Point(120, 10);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 20);
            this.txtTen.TabIndex = 1;
            // 
            // panelDSBoSuuTap
            // 
            this.panelDSBoSuuTap.Controls.Add(this.v_BO_SUU_TAPGridControl);
            this.panelDSBoSuuTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDSBoSuuTap.Location = new System.Drawing.Point(400, 24);
            this.panelDSBoSuuTap.Name = "panelDSBoSuuTap";
            this.panelDSBoSuuTap.Size = new System.Drawing.Size(664, 498);
            this.panelDSBoSuuTap.TabIndex = 5;
            // 
            // v_BO_SUU_TAPGridControl
            // 
            this.v_BO_SUU_TAPGridControl.DataSource = this.bdsBoSuuTap;
            this.v_BO_SUU_TAPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_BO_SUU_TAPGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_BO_SUU_TAPGridControl.MainView = this.gridView1;
            this.v_BO_SUU_TAPGridControl.MenuManager = this.barManager1;
            this.v_BO_SUU_TAPGridControl.Name = "v_BO_SUU_TAPGridControl";
            this.v_BO_SUU_TAPGridControl.Size = new System.Drawing.Size(664, 498);
            this.v_BO_SUU_TAPGridControl.TabIndex = 0;
            this.v_BO_SUU_TAPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãbộsưutập,
            this.colTên,
            this.colHìnhthức,
            this.colĐịachỉ});
            this.gridView1.GridControl = this.v_BO_SUU_TAPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMãbộsưutập
            // 
            this.colMãbộsưutập.FieldName = "Mã bộ sưu tập";
            this.colMãbộsưutập.Name = "colMãbộsưutập";
            this.colMãbộsưutập.Visible = true;
            this.colMãbộsưutập.VisibleIndex = 0;
            // 
            // colTên
            // 
            this.colTên.FieldName = "Tên";
            this.colTên.Name = "colTên";
            this.colTên.Visible = true;
            this.colTên.VisibleIndex = 1;
            // 
            // colHìnhthức
            // 
            this.colHìnhthức.FieldName = "Hình thức";
            this.colHìnhthức.Name = "colHìnhthức";
            this.colHìnhthức.Visible = true;
            this.colHìnhthức.VisibleIndex = 2;
            // 
            // colĐịachỉ
            // 
            this.colĐịachỉ.FieldName = "Địa chỉ";
            this.colĐịachỉ.Name = "colĐịachỉ";
            this.colĐịachỉ.Visible = true;
            this.colĐịachỉ.VisibleIndex = 3;
            // 
            // v_BO_SUU_TAPTableAdapter
            // 
            this.v_BO_SUU_TAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmBoSuuTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 542);
            this.Controls.Add(this.panelDSBoSuuTap);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBoSuuTap";
            this.Text = "Bộ sưu tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBoSuuTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoSuuTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            this.panelDSBoSuuTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_BO_SUU_TAPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelDSBoSuuTap;
        private System.Windows.Forms.BindingSource bdsBoSuuTap;
        private TPNTDataSet2 tPNTDataSet;
        private TPNTDataSet2TableAdapters.V_BO_SUU_TAPTableAdapter v_BO_SUU_TAPTableAdapter;
        private TPNTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_BO_SUU_TAPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãbộsưutập;
        private DevExpress.XtraGrid.Columns.GridColumn colTên;
        private DevExpress.XtraGrid.Columns.GridColumn colHìnhthức;
        private DevExpress.XtraGrid.Columns.GridColumn colĐịachỉ;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNguoiGiamDinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHinhThuc;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
    }
}