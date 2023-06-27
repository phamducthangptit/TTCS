namespace TPNT
{
    partial class frmChonTacPham
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
            this.tPNTDataSet = new TPNT.TPNTDataSet();
            this.bdsTacPham = new System.Windows.Forms.BindingSource(this.components);
            this.v_SELECTTACPHAMTableAdapter = new TPNT.TPNTDataSetTableAdapters.V_SELECTTACPHAMTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.v_SELECTTACPHAMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiDai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoiDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_SELECTTACPHAMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTacPham
            // 
            this.bdsTacPham.DataMember = "V_SELECTTACPHAM";
            this.bdsTacPham.DataSource = this.tPNTDataSet;
            // 
            // v_SELECTTACPHAMTableAdapter
            // 
            this.v_SELECTTACPHAMTableAdapter.ClearBeforeFill = true;
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
            // v_SELECTTACPHAMGridControl
            // 
            this.v_SELECTTACPHAMGridControl.DataSource = this.bdsTacPham;
            this.v_SELECTTACPHAMGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_SELECTTACPHAMGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.v_SELECTTACPHAMGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_SELECTTACPHAMGridControl.MainView = this.gridView1;
            this.v_SELECTTACPHAMGridControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.v_SELECTTACPHAMGridControl.Name = "v_SELECTTACPHAMGridControl";
            this.v_SELECTTACPHAMGridControl.Size = new System.Drawing.Size(1101, 433);
            this.v_SELECTTACPHAMGridControl.TabIndex = 1;
            this.v_SELECTTACPHAMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.ColumnPanelRowHeight = 62;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colTenTP,
            this.colHoTen,
            this.colNamSangTac,
            this.colChuDe,
            this.colQuocGia,
            this.colThoiDai,
            this.colLoiDienGiai});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.v_SELECTTACPHAMGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView1.RowHeight = 62;
            // 
            // colMaSoTP
            // 
            this.colMaSoTP.Caption = "Mã số TP";
            this.colMaSoTP.FieldName = "MaSoTP";
            this.colMaSoTP.MinWidth = 39;
            this.colMaSoTP.Name = "colMaSoTP";
            this.colMaSoTP.Visible = true;
            this.colMaSoTP.VisibleIndex = 0;
            this.colMaSoTP.Width = 146;
            // 
            // colTenTP
            // 
            this.colTenTP.Caption = "Tên tác phẩm";
            this.colTenTP.FieldName = "TenTP";
            this.colTenTP.MinWidth = 39;
            this.colTenTP.Name = "colTenTP";
            this.colTenTP.Visible = true;
            this.colTenTP.VisibleIndex = 1;
            this.colTenTP.Width = 290;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Tên tác giả";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 39;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 2;
            this.colHoTen.Width = 231;
            // 
            // colNamSangTac
            // 
            this.colNamSangTac.Caption = "Năm sáng tác";
            this.colNamSangTac.FieldName = "NamSangTac";
            this.colNamSangTac.MinWidth = 39;
            this.colNamSangTac.Name = "colNamSangTac";
            this.colNamSangTac.Visible = true;
            this.colNamSangTac.VisibleIndex = 3;
            this.colNamSangTac.Width = 186;
            // 
            // colChuDe
            // 
            this.colChuDe.Caption = "Chủ đề";
            this.colChuDe.FieldName = "ChuDe";
            this.colChuDe.MinWidth = 39;
            this.colChuDe.Name = "colChuDe";
            this.colChuDe.Visible = true;
            this.colChuDe.VisibleIndex = 4;
            this.colChuDe.Width = 186;
            // 
            // colQuocGia
            // 
            this.colQuocGia.Caption = "Quốc gia";
            this.colQuocGia.FieldName = "QuocGia";
            this.colQuocGia.MinWidth = 39;
            this.colQuocGia.Name = "colQuocGia";
            this.colQuocGia.Visible = true;
            this.colQuocGia.VisibleIndex = 5;
            this.colQuocGia.Width = 186;
            // 
            // colThoiDai
            // 
            this.colThoiDai.Caption = "Thời đại";
            this.colThoiDai.FieldName = "ThoiDai";
            this.colThoiDai.MinWidth = 39;
            this.colThoiDai.Name = "colThoiDai";
            this.colThoiDai.Visible = true;
            this.colThoiDai.VisibleIndex = 6;
            this.colThoiDai.Width = 186;
            // 
            // colLoiDienGiai
            // 
            this.colLoiDienGiai.Caption = "Lời diễn giải";
            this.colLoiDienGiai.FieldName = "LoiDienGiai";
            this.colLoiDienGiai.MinWidth = 39;
            this.colLoiDienGiai.Name = "colLoiDienGiai";
            this.colLoiDienGiai.Visible = true;
            this.colLoiDienGiai.VisibleIndex = 7;
            this.colLoiDienGiai.Width = 224;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 92);
            this.panel1.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(633, 36);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnChon
            // 
            this.btnChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChon.Location = new System.Drawing.Point(293, 36);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(112, 35);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // frmChonTacPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.v_SELECTTACPHAMGridControl);
            this.Name = "frmChonTacPham";
            this.Text = "frmChonTacPham";
            this.Load += new System.EventHandler(this.frmChonTacPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_SELECTTACPHAMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TPNTDataSet tPNTDataSet;
        private System.Windows.Forms.BindingSource bdsTacPham;
        private TPNTDataSetTableAdapters.V_SELECTTACPHAMTableAdapter v_SELECTTACPHAMTableAdapter;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_SELECTTACPHAMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac;
        private DevExpress.XtraGrid.Columns.GridColumn colChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiDai;
        private DevExpress.XtraGrid.Columns.GridColumn colLoiDienGiai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChon;
    }
}