namespace TPNT
{
    partial class frmChonTPNTSoHuu
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
            this.bdsNullSoHuu = new System.Windows.Forms.BindingSource(this.components);
            this.view_NullSoHuuTableAdapter = new TPNT.TPNTDataSet1TableAdapters.view_NullSoHuuTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet1TableAdapters.TableAdapterManager();
            this.view_NullSoHuuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSangTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNullSoHuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_NullSoHuuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tPNTDataSet1
            // 
            this.tPNTDataSet1.DataSetName = "TPNTDataSet1";
            this.tPNTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNullSoHuu
            // 
            this.bdsNullSoHuu.DataMember = "view_NullSoHuu";
            this.bdsNullSoHuu.DataSource = this.tPNTDataSet1;
            // 
            // view_NullSoHuuTableAdapter
            // 
            this.view_NullSoHuuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_NullSoHuuGridControl
            // 
            this.view_NullSoHuuGridControl.DataSource = this.bdsNullSoHuu;
            this.view_NullSoHuuGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_NullSoHuuGridControl.Location = new System.Drawing.Point(0, 0);
            this.view_NullSoHuuGridControl.MainView = this.gridView1;
            this.view_NullSoHuuGridControl.Name = "view_NullSoHuuGridControl";
            this.view_NullSoHuuGridControl.Size = new System.Drawing.Size(1067, 545);
            this.view_NullSoHuuGridControl.TabIndex = 1;
            this.view_NullSoHuuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoTP,
            this.colTenTP,
            this.colChuDe,
            this.colNamSangTac,
            this.colTacGia});
            this.gridView1.GridControl = this.view_NullSoHuuGridControl;
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
            this.colMaSoTP.Width = 154;
            // 
            // colTenTP
            // 
            this.colTenTP.Caption = "Tên TP";
            this.colTenTP.FieldName = "TenTP";
            this.colTenTP.MinWidth = 25;
            this.colTenTP.Name = "colTenTP";
            this.colTenTP.Visible = true;
            this.colTenTP.VisibleIndex = 1;
            this.colTenTP.Width = 154;
            // 
            // colChuDe
            // 
            this.colChuDe.Caption = "Chủ Đề";
            this.colChuDe.FieldName = "ChuDe";
            this.colChuDe.MinWidth = 25;
            this.colChuDe.Name = "colChuDe";
            this.colChuDe.Visible = true;
            this.colChuDe.VisibleIndex = 2;
            this.colChuDe.Width = 154;
            // 
            // colNamSangTac
            // 
            this.colNamSangTac.Caption = "Năm Sáng Tác";
            this.colNamSangTac.FieldName = "NamSangTac";
            this.colNamSangTac.MinWidth = 25;
            this.colNamSangTac.Name = "colNamSangTac";
            this.colNamSangTac.Visible = true;
            this.colNamSangTac.VisibleIndex = 3;
            this.colNamSangTac.Width = 137;
            // 
            // colTacGia
            // 
            this.colTacGia.Caption = "Tác Giả";
            this.colTacGia.FieldName = "TacGia";
            this.colTacGia.MinWidth = 25;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Visible = true;
            this.colTacGia.VisibleIndex = 4;
            this.colTacGia.Width = 171;
            // 
            // btnChon
            // 
            this.btnChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChon.BackColor = System.Drawing.Color.Lime;
            this.btnChon.Location = new System.Drawing.Point(435, 433);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(187, 41);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // frmChonTPNTSoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 545);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.view_NullSoHuuGridControl);
            this.Name = "frmChonTPNTSoHuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Tác Phẩm Nghệ Thuật";
            this.Load += new System.EventHandler(this.frmChonTPNTSoHuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNullSoHuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_NullSoHuuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TPNTDataSet1 tPNTDataSet1;
        private System.Windows.Forms.BindingSource bdsNullSoHuu;
        private TPNTDataSet1TableAdapters.view_NullSoHuuTableAdapter view_NullSoHuuTableAdapter;
        private TPNTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl view_NullSoHuuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTP;
        private DevExpress.XtraGrid.Columns.GridColumn colChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSangTac;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia;
        private System.Windows.Forms.Button btnChon;
    }
}