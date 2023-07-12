namespace TPNT
{
    partial class frmChonTPNT
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
            System.Windows.Forms.Label loiDienGiaiLabel;
            System.Windows.Forms.Label thoiDaiLabel;
            System.Windows.Forms.Label quốc_giaLabel;
            System.Windows.Forms.Label chuDeLabel;
            System.Windows.Forms.Label năm_sáng_tácLabel;
            System.Windows.Forms.Label mã_tác_phẩmLabel;
            System.Windows.Forms.Label tên_tác_phẩmLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.loiDienGiaiTextBox = new System.Windows.Forms.TextBox();
            this.bdsTPNT = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTDataSet2 = new TPNT.TPNTDataSet2();
            this.thoiDaiTextBox = new System.Windows.Forms.TextBox();
            this.quốc_giaTextBox = new System.Windows.Forms.TextBox();
            this.chuDeTextBox = new System.Windows.Forms.TextBox();
            this.năm_sáng_tácTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mã_tác_phẩmTextBox = new System.Windows.Forms.TextBox();
            this.tên_tác_phẩmTextBox = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureTPNT = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_CHON_TPNTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãtácphẩm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTêntácphẩm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNămsángtác = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuốcgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.sP_CHON_TPNTTableAdapter = new TPNT.TPNTDataSet2TableAdapters.SP_CHON_TPNTTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet2TableAdapters.TableAdapterManager();
            this.bdsTG = new System.Windows.Forms.BindingSource(this.components);
            this.v_TAC_GIATableAdapter = new TPNT.TPNTDataSet2TableAdapters.V_TAC_GIATableAdapter();
            loiDienGiaiLabel = new System.Windows.Forms.Label();
            thoiDaiLabel = new System.Windows.Forms.Label();
            quốc_giaLabel = new System.Windows.Forms.Label();
            chuDeLabel = new System.Windows.Forms.Label();
            năm_sáng_tácLabel = new System.Windows.Forms.Label();
            mã_tác_phẩmLabel = new System.Windows.Forms.Label();
            tên_tác_phẩmLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.năm_sáng_tácTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTPNT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHON_TPNTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).BeginInit();
            this.SuspendLayout();
            // 
            // loiDienGiaiLabel
            // 
            loiDienGiaiLabel.AutoSize = true;
            loiDienGiaiLabel.Location = new System.Drawing.Point(5, 279);
            loiDienGiaiLabel.Name = "loiDienGiaiLabel";
            loiDienGiaiLabel.Size = new System.Drawing.Size(66, 13);
            loiDienGiaiLabel.TabIndex = 40;
            loiDienGiaiLabel.Text = "Lời diễn giải:";
            // 
            // thoiDaiLabel
            // 
            thoiDaiLabel.AutoSize = true;
            thoiDaiLabel.Location = new System.Drawing.Point(192, 242);
            thoiDaiLabel.Name = "thoiDaiLabel";
            thoiDaiLabel.Size = new System.Drawing.Size(49, 13);
            thoiDaiLabel.TabIndex = 38;
            thoiDaiLabel.Text = "Thời đại:";
            // 
            // quốc_giaLabel
            // 
            quốc_giaLabel.AutoSize = true;
            quốc_giaLabel.Location = new System.Drawing.Point(14, 242);
            quốc_giaLabel.Name = "quốc_giaLabel";
            quốc_giaLabel.Size = new System.Drawing.Size(53, 13);
            quốc_giaLabel.TabIndex = 37;
            quốc_giaLabel.Text = "Quốc gia:";
            // 
            // chuDeLabel
            // 
            chuDeLabel.AutoSize = true;
            chuDeLabel.Location = new System.Drawing.Point(170, 145);
            chuDeLabel.Name = "chuDeLabel";
            chuDeLabel.Size = new System.Drawing.Size(45, 13);
            chuDeLabel.TabIndex = 36;
            chuDeLabel.Text = "Chủ đề:";
            // 
            // năm_sáng_tácLabel
            // 
            năm_sáng_tácLabel.AutoSize = true;
            năm_sáng_tácLabel.Location = new System.Drawing.Point(170, 111);
            năm_sáng_tácLabel.Name = "năm_sáng_tácLabel";
            năm_sáng_tácLabel.Size = new System.Drawing.Size(76, 13);
            năm_sáng_tácLabel.TabIndex = 35;
            năm_sáng_tácLabel.Text = "Năm sáng tác:";
            // 
            // mã_tác_phẩmLabel
            // 
            mã_tác_phẩmLabel.AutoSize = true;
            mã_tác_phẩmLabel.Location = new System.Drawing.Point(170, 75);
            mã_tác_phẩmLabel.Name = "mã_tác_phẩmLabel";
            mã_tác_phẩmLabel.Size = new System.Drawing.Size(72, 13);
            mã_tác_phẩmLabel.TabIndex = 34;
            mã_tác_phẩmLabel.Text = "Mã tác phẩm:";
            // 
            // tên_tác_phẩmLabel
            // 
            tên_tác_phẩmLabel.AutoSize = true;
            tên_tác_phẩmLabel.Location = new System.Drawing.Point(170, 25);
            tên_tác_phẩmLabel.Name = "tên_tác_phẩmLabel";
            tên_tác_phẩmLabel.Size = new System.Drawing.Size(76, 13);
            tên_tác_phẩmLabel.TabIndex = 33;
            tên_tác_phẩmLabel.Text = "Tên tác phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loiDienGiaiTextBox);
            this.panel1.Controls.Add(this.thoiDaiTextBox);
            this.panel1.Controls.Add(this.quốc_giaTextBox);
            this.panel1.Controls.Add(this.chuDeTextBox);
            this.panel1.Controls.Add(this.năm_sáng_tácTextEdit);
            this.panel1.Controls.Add(this.mã_tác_phẩmTextBox);
            this.panel1.Controls.Add(this.tên_tác_phẩmTextBox);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(loiDienGiaiLabel);
            this.panel1.Controls.Add(thoiDaiLabel);
            this.panel1.Controls.Add(quốc_giaLabel);
            this.panel1.Controls.Add(chuDeLabel);
            this.panel1.Controls.Add(năm_sáng_tácLabel);
            this.panel1.Controls.Add(mã_tác_phẩmLabel);
            this.panel1.Controls.Add(tên_tác_phẩmLabel);
            this.panel1.Controls.Add(this.pictureTPNT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 542);
            this.panel1.TabIndex = 0;
            // 
            // loiDienGiaiTextBox
            // 
            this.loiDienGiaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "LoiDienGiai", true));
            this.loiDienGiaiTextBox.Location = new System.Drawing.Point(77, 276);
            this.loiDienGiaiTextBox.Multiline = true;
            this.loiDienGiaiTextBox.Name = "loiDienGiaiTextBox";
            this.loiDienGiaiTextBox.Size = new System.Drawing.Size(275, 170);
            this.loiDienGiaiTextBox.TabIndex = 57;
            // 
            // bdsTPNT
            // 
            this.bdsTPNT.DataMember = "SP_CHON_TPNT";
            this.bdsTPNT.DataSource = this.tPNTDataSet2;
            // 
            // tPNTDataSet2
            // 
            this.tPNTDataSet2.DataSetName = "TPNTDataSet2";
            this.tPNTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thoiDaiTextBox
            // 
            this.thoiDaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "ThoiDai", true));
            this.thoiDaiTextBox.Location = new System.Drawing.Point(252, 239);
            this.thoiDaiTextBox.Name = "thoiDaiTextBox";
            this.thoiDaiTextBox.Size = new System.Drawing.Size(100, 20);
            this.thoiDaiTextBox.TabIndex = 56;
            // 
            // quốc_giaTextBox
            // 
            this.quốc_giaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "Quốc gia", true));
            this.quốc_giaTextBox.Location = new System.Drawing.Point(77, 239);
            this.quốc_giaTextBox.Name = "quốc_giaTextBox";
            this.quốc_giaTextBox.Size = new System.Drawing.Size(100, 20);
            this.quốc_giaTextBox.TabIndex = 55;
            // 
            // chuDeTextBox
            // 
            this.chuDeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "ChuDe", true));
            this.chuDeTextBox.Location = new System.Drawing.Point(252, 142);
            this.chuDeTextBox.Name = "chuDeTextBox";
            this.chuDeTextBox.Size = new System.Drawing.Size(144, 20);
            this.chuDeTextBox.TabIndex = 54;
            // 
            // năm_sáng_tácTextEdit
            // 
            this.năm_sáng_tácTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTPNT, "Năm sáng tác", true));
            this.năm_sáng_tácTextEdit.Location = new System.Drawing.Point(252, 108);
            this.năm_sáng_tácTextEdit.Name = "năm_sáng_tácTextEdit";
            this.năm_sáng_tácTextEdit.Size = new System.Drawing.Size(144, 20);
            this.năm_sáng_tácTextEdit.TabIndex = 53;
            // 
            // mã_tác_phẩmTextBox
            // 
            this.mã_tác_phẩmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "Mã tác phẩm", true));
            this.mã_tác_phẩmTextBox.Location = new System.Drawing.Point(252, 72);
            this.mã_tác_phẩmTextBox.Name = "mã_tác_phẩmTextBox";
            this.mã_tác_phẩmTextBox.Size = new System.Drawing.Size(144, 20);
            this.mã_tác_phẩmTextBox.TabIndex = 52;
            // 
            // tên_tác_phẩmTextBox
            // 
            this.tên_tác_phẩmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTPNT, "Tên tác phẩm", true));
            this.tên_tác_phẩmTextBox.Location = new System.Drawing.Point(173, 41);
            this.tên_tác_phẩmTextBox.Name = "tên_tác_phẩmTextBox";
            this.tên_tác_phẩmTextBox.Size = new System.Drawing.Size(223, 20);
            this.tên_tác_phẩmTextBox.TabIndex = 51;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(252, 182);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(144, 21);
            this.txtTacGia.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tác giả:";
            // 
            // pictureTPNT
            // 
            this.pictureTPNT.Location = new System.Drawing.Point(14, 15);
            this.pictureTPNT.Name = "pictureTPNT";
            this.pictureTPNT.Size = new System.Drawing.Size(150, 200);
            this.pictureTPNT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTPNT.TabIndex = 32;
            this.pictureTPNT.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_CHON_TPNTGridControl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(416, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 542);
            this.panel2.TabIndex = 1;
            // 
            // sP_CHON_TPNTGridControl
            // 
            this.sP_CHON_TPNTGridControl.DataSource = this.bdsTPNT;
            this.sP_CHON_TPNTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_CHON_TPNTGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_CHON_TPNTGridControl.MainView = this.gridView1;
            this.sP_CHON_TPNTGridControl.Name = "sP_CHON_TPNTGridControl";
            this.sP_CHON_TPNTGridControl.Size = new System.Drawing.Size(648, 488);
            this.sP_CHON_TPNTGridControl.TabIndex = 1;
            this.sP_CHON_TPNTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãtácphẩm,
            this.colTêntácphẩm,
            this.colNămsángtác,
            this.colQuốcgia});
            this.gridView1.GridControl = this.sP_CHON_TPNTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMãtácphẩm
            // 
            this.colMãtácphẩm.FieldName = "Mã tác phẩm";
            this.colMãtácphẩm.Name = "colMãtácphẩm";
            this.colMãtácphẩm.Visible = true;
            this.colMãtácphẩm.VisibleIndex = 0;
            // 
            // colTêntácphẩm
            // 
            this.colTêntácphẩm.FieldName = "Tên tác phẩm";
            this.colTêntácphẩm.Name = "colTêntácphẩm";
            this.colTêntácphẩm.Visible = true;
            this.colTêntácphẩm.VisibleIndex = 1;
            // 
            // colNămsángtác
            // 
            this.colNămsángtác.FieldName = "Năm sáng tác";
            this.colNămsángtác.Name = "colNămsángtác";
            this.colNămsángtác.Visible = true;
            this.colNămsángtác.VisibleIndex = 2;
            // 
            // colQuốcgia
            // 
            this.colQuốcgia.FieldName = "Quốc gia";
            this.colQuốcgia.Name = "colQuốcgia";
            this.colQuốcgia.Visible = true;
            this.colQuốcgia.VisibleIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 54);
            this.panel3.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(552, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // sP_CHON_TPNTTableAdapter
            // 
            this.sP_CHON_TPNTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsTG
            // 
            this.bdsTG.DataMember = "V_TAC_GIA";
            this.bdsTG.DataSource = this.tPNTDataSet2;
            // 
            // v_TAC_GIATableAdapter
            // 
            this.v_TAC_GIATableAdapter.ClearBeforeFill = true;
            // 
            // frmChonTPNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonTPNT";
            this.Text = "frmChonTPNT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChonTPNT_FormClosing);
            this.Load += new System.EventHandler(this.frmChonTPNT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.năm_sáng_tácTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTPNT)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHON_TPNTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private TPNTDataSet2 tPNTDataSet2;
        private System.Windows.Forms.BindingSource bdsTPNT;
        private TPNTDataSet2TableAdapters.SP_CHON_TPNTTableAdapter sP_CHON_TPNTTableAdapter;
        private TPNTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureTPNT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox loiDienGiaiTextBox;
        private System.Windows.Forms.TextBox thoiDaiTextBox;
        private System.Windows.Forms.TextBox quốc_giaTextBox;
        private System.Windows.Forms.TextBox chuDeTextBox;
        private DevExpress.XtraEditors.TextEdit năm_sáng_tácTextEdit;
        private System.Windows.Forms.TextBox mã_tác_phẩmTextBox;
        private System.Windows.Forms.TextBox tên_tác_phẩmTextBox;
        private DevExpress.XtraGrid.GridControl sP_CHON_TPNTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource bdsTG;
        private TPNTDataSet2TableAdapters.V_TAC_GIATableAdapter v_TAC_GIATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMãtácphẩm;
        private DevExpress.XtraGrid.Columns.GridColumn colTêntácphẩm;
        private DevExpress.XtraGrid.Columns.GridColumn colNămsángtác;
        private DevExpress.XtraGrid.Columns.GridColumn colQuốcgia;
    }
}