namespace TPNT
{
    partial class frmChonTPNTNullSangTac
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
            this.tPNTDataSet1 = new TPNT.TPNTDataSet1();
            this.bdsNullLoaiHinhSangTac = new System.Windows.Forms.BindingSource(this.components);
            this.view_NullLoaiHinhSangTacTableAdapter = new TPNT.TPNTDataSet1TableAdapters.view_NullLoaiHinhSangTacTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.view_NullLoaiHinhSangTacGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiDai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNullLoaiHinhSangTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_NullLoaiHinhSangTacGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNullLoaiHinhSangTac
            // 
            this.bdsNullLoaiHinhSangTac.DataMember = "view_NullLoaiHinhSangTac";
            this.bdsNullLoaiHinhSangTac.DataSource = this.tPNTDataSet1;
            // 
            // view_NullLoaiHinhSangTacTableAdapter
            // 
            this.view_NullLoaiHinhSangTacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_NullLoaiHinhSangTacGridControl
            // 
            this.view_NullLoaiHinhSangTacGridControl.DataSource = this.bdsNullLoaiHinhSangTac;
            this.view_NullLoaiHinhSangTacGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_NullLoaiHinhSangTacGridControl.Location = new System.Drawing.Point(0, 0);
            this.view_NullLoaiHinhSangTacGridControl.MainView = this.gridView1;
            this.view_NullLoaiHinhSangTacGridControl.Name = "view_NullLoaiHinhSangTacGridControl";
            this.view_NullLoaiHinhSangTacGridControl.Size = new System.Drawing.Size(1071, 450);
            this.view_NullLoaiHinhSangTacGridControl.TabIndex = 1;
            this.view_NullLoaiHinhSangTacGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colTenTP,
            this.colChuDe,
            this.colNamSangTac,
            this.colTacGia,
            this.colQuocGia,
            this.colThoiDai});
            this.gridView1.GridControl = this.view_NullLoaiHinhSangTacGridControl;
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
            // colChuDe
            // 
            this.colChuDe.Caption = "Chủ Đề";
            this.colChuDe.FieldName = "ChuDe";
            this.colChuDe.MinWidth = 25;
            this.colChuDe.Name = "colChuDe";
            this.colChuDe.Visible = true;
            this.colChuDe.VisibleIndex = 2;
            this.colChuDe.Width = 94;
            // 
            // colNamSangTac
            // 
            this.colNamSangTac.Caption = "Năm Sáng Tác";
            this.colNamSangTac.FieldName = "NamSangTac";
            this.colNamSangTac.MinWidth = 25;
            this.colNamSangTac.Name = "colNamSangTac";
            this.colNamSangTac.Visible = true;
            this.colNamSangTac.VisibleIndex = 3;
            this.colNamSangTac.Width = 94;
            // 
            // colTacGia
            // 
            this.colTacGia.Caption = "Tác Giả";
            this.colTacGia.FieldName = "TacGia";
            this.colTacGia.MinWidth = 25;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Visible = true;
            this.colTacGia.VisibleIndex = 5;
            this.colTacGia.Width = 94;
            // 
            // colQuocGia
            // 
            this.colQuocGia.Caption = "Quốc Gia";
            this.colQuocGia.FieldName = "QuocGia";
            this.colQuocGia.MinWidth = 25;
            this.colQuocGia.Name = "colQuocGia";
            this.colQuocGia.Visible = true;
            this.colQuocGia.VisibleIndex = 4;
            this.colQuocGia.Width = 94;
            // 
            // colThoiDai
            // 
            this.colThoiDai.Caption = "Thời Đại";
            this.colThoiDai.FieldName = "ThoiDai";
            this.colThoiDai.MinWidth = 25;
            this.colThoiDai.Name = "colThoiDai";
            this.colThoiDai.Visible = true;
            this.colThoiDai.VisibleIndex = 6;
            this.colThoiDai.Width = 94;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(427, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChonTPNTNullSangTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_NullLoaiHinhSangTacGridControl);
            this.Name = "frmChonTPNTNullSangTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Tác Phẩm Nghệ Thuật";
            this.Load += new System.EventHandler(this.frmChonTPNTNullSangTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNullLoaiHinhSangTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_NullLoaiHinhSangTacGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TPNTDataSet1 tPNTDataSet1;
        private System.Windows.Forms.BindingSource bdsNullLoaiHinhSangTac;
        private TPNTDataSet1TableAdapters.view_NullLoaiHinhSangTacTableAdapter view_NullLoaiHinhSangTacTableAdapter;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl view_NullLoaiHinhSangTacGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP;
        private DevExpress.XtraGrid.Columns.GridColumn colChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiDai;
        private System.Windows.Forms.Button button1;
    }
}