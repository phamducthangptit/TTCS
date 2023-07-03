namespace TPNT
{
    partial class frmBackup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup_Restore));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lbTiLe = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnChonDuongDan = new System.Windows.Forms.Button();
            this.txtDuongDanBkFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnChonDuongDan1 = new System.Windows.Forms.Button();
            this.txtDuongDan1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlLapLichTheoTuan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.timeTheoTuan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbThu = new System.Windows.Forms.ComboBox();
            this.btnCDDTheoTuan = new System.Windows.Forms.Button();
            this.txtDuongDanTheoTuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaoLichThang = new System.Windows.Forms.Button();
            this.pnlLapLichTheoNgay = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.timeTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.btnCDDTheoNgay = new System.Windows.Forms.Button();
            this.txtDuongDanTheoNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoLichNgay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDsLapLich = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.girdControlWeekly = new DevExpress.XtraGrid.GridControl();
            this.bdsWeeklyJob = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTDataSet = new TPNT.TPNTDataSet();
            this.gcWeeklyjob = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coljob_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnext_run_day1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnextruntime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivetime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactiveendtime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenabled1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_created1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.girdControlDaily = new DevExpress.XtraGrid.GridControl();
            this.bdsDailyJob = new System.Windows.Forms.BindingSource(this.components);
            this.gcDailyjob = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coljob_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnext_run_day = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnextruntime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactiveendtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnable = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDSJob = new System.Windows.Forms.ComboBox();
            this.v_DANHSACHJOBDAILYTableAdapter = new TPNT.TPNTDataSetTableAdapters.V_DANHSACHJOBDAILYTableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSetTableAdapters.TableAdapterManager();
            this.v_DANHSACHJOBWEEKLYTableAdapter = new TPNT.TPNTDataSetTableAdapters.V_DANHSACHJOBWEEKLYTableAdapter();
            this.btnDisable = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlLapLichTheoTuan.SuspendLayout();
            this.pnlLapLichTheoNgay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdControlWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWeeklyJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWeeklyjob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdControlDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDailyJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDailyjob)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1211, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBackup);
            this.tabPage1.Controls.Add(this.lbTiLe);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.btnChonDuongDan);
            this.tabPage1.Controls.Add(this.txtDuongDanBkFull);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1203, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Location = new System.Drawing.Point(593, 452);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 28);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lbTiLe
            // 
            this.lbTiLe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTiLe.AutoSize = true;
            this.lbTiLe.Location = new System.Drawing.Point(371, 207);
            this.lbTiLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTiLe.Name = "lbTiLe";
            this.lbTiLe.Size = new System.Drawing.Size(26, 16);
            this.lbTiLe.TabIndex = 4;
            this.lbTiLe.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(124, 164);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 28);
            this.progressBar.TabIndex = 3;
            // 
            // btnChonDuongDan
            // 
            this.btnChonDuongDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChonDuongDan.Location = new System.Drawing.Point(560, 68);
            this.btnChonDuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonDuongDan.Name = "btnChonDuongDan";
            this.btnChonDuongDan.Size = new System.Drawing.Size(160, 28);
            this.btnChonDuongDan.TabIndex = 2;
            this.btnChonDuongDan.Text = "Chọn dường dẫn";
            this.btnChonDuongDan.UseVisualStyleBackColor = true;
            this.btnChonDuongDan.Click += new System.EventHandler(this.btnChonDuongDan_Click);
            // 
            // txtDuongDanBkFull
            // 
            this.txtDuongDanBkFull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuongDanBkFull.Location = new System.Drawing.Point(148, 68);
            this.txtDuongDanBkFull.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDanBkFull.Name = "txtDuongDanBkFull";
            this.txtDuongDanBkFull.Size = new System.Drawing.Size(385, 22);
            this.txtDuongDanBkFull.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục lưu:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRestore);
            this.tabPage2.Controls.Add(this.btnChonDuongDan1);
            this.tabPage2.Controls.Add(this.txtDuongDan1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1203, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(591, 283);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(100, 28);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnChonDuongDan1
            // 
            this.btnChonDuongDan1.Location = new System.Drawing.Point(551, 76);
            this.btnChonDuongDan1.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonDuongDan1.Name = "btnChonDuongDan1";
            this.btnChonDuongDan1.Size = new System.Drawing.Size(160, 28);
            this.btnChonDuongDan1.TabIndex = 5;
            this.btnChonDuongDan1.Text = "Chọn dường dẫn";
            this.btnChonDuongDan1.UseVisualStyleBackColor = true;
            this.btnChonDuongDan1.Click += new System.EventHandler(this.btnChonDuongDan1_Click);
            // 
            // txtDuongDan1
            // 
            this.txtDuongDan1.Location = new System.Drawing.Point(139, 76);
            this.txtDuongDan1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDan1.Name = "txtDuongDan1";
            this.txtDuongDan1.Size = new System.Drawing.Size(385, 22);
            this.txtDuongDan1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thư mục lưu:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlLapLichTheoTuan);
            this.tabPage3.Controls.Add(this.pnlLapLichTheoNgay);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1203, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lập lịch";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlLapLichTheoTuan
            // 
            this.pnlLapLichTheoTuan.Controls.Add(this.label7);
            this.pnlLapLichTheoTuan.Controls.Add(this.timeTheoTuan);
            this.pnlLapLichTheoTuan.Controls.Add(this.label5);
            this.pnlLapLichTheoTuan.Controls.Add(this.cmbThu);
            this.pnlLapLichTheoTuan.Controls.Add(this.btnCDDTheoTuan);
            this.pnlLapLichTheoTuan.Controls.Add(this.txtDuongDanTheoTuan);
            this.pnlLapLichTheoTuan.Controls.Add(this.label4);
            this.pnlLapLichTheoTuan.Controls.Add(this.btnTaoLichThang);
            this.pnlLapLichTheoTuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLapLichTheoTuan.Location = new System.Drawing.Point(4, 283);
            this.pnlLapLichTheoTuan.Name = "pnlLapLichTheoTuan";
            this.pnlLapLichTheoTuan.Size = new System.Drawing.Size(1195, 229);
            this.pnlLapLichTheoTuan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thời gian thực hiện:";
            // 
            // timeTheoTuan
            // 
            this.timeTheoTuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTheoTuan.CustomFormat = "\"HH:mm:ss\"";
            this.timeTheoTuan.Location = new System.Drawing.Point(245, 170);
            this.timeTheoTuan.Name = "timeTheoTuan";
            this.timeTheoTuan.Size = new System.Drawing.Size(220, 22);
            this.timeTheoTuan.TabIndex = 8;
            this.timeTheoTuan.Value = new System.DateTime(2023, 7, 1, 11, 38, 44, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thứ:";
            // 
            // cmbThu
            // 
            this.cmbThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThu.FormattingEnabled = true;
            this.cmbThu.Location = new System.Drawing.Point(245, 103);
            this.cmbThu.Name = "cmbThu";
            this.cmbThu.Size = new System.Drawing.Size(188, 24);
            this.cmbThu.TabIndex = 6;
            // 
            // btnCDDTheoTuan
            // 
            this.btnCDDTheoTuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCDDTheoTuan.Location = new System.Drawing.Point(687, 65);
            this.btnCDDTheoTuan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCDDTheoTuan.Name = "btnCDDTheoTuan";
            this.btnCDDTheoTuan.Size = new System.Drawing.Size(160, 28);
            this.btnCDDTheoTuan.TabIndex = 5;
            this.btnCDDTheoTuan.Text = "Chọn dường dẫn";
            this.btnCDDTheoTuan.UseVisualStyleBackColor = true;
            this.btnCDDTheoTuan.Click += new System.EventHandler(this.btnCDDTheoTuan_Click);
            // 
            // txtDuongDanTheoTuan
            // 
            this.txtDuongDanTheoTuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuongDanTheoTuan.Location = new System.Drawing.Point(245, 53);
            this.txtDuongDanTheoTuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDanTheoTuan.Name = "txtDuongDanTheoTuan";
            this.txtDuongDanTheoTuan.Size = new System.Drawing.Size(385, 22);
            this.txtDuongDanTheoTuan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thư mục lưu:";
            // 
            // btnTaoLichThang
            // 
            this.btnTaoLichThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaoLichThang.Location = new System.Drawing.Point(968, 170);
            this.btnTaoLichThang.Name = "btnTaoLichThang";
            this.btnTaoLichThang.Size = new System.Drawing.Size(121, 36);
            this.btnTaoLichThang.TabIndex = 1;
            this.btnTaoLichThang.Text = "Tạo lịch";
            this.btnTaoLichThang.UseVisualStyleBackColor = true;
            this.btnTaoLichThang.Click += new System.EventHandler(this.btnTaoLichThang_Click);
            // 
            // pnlLapLichTheoNgay
            // 
            this.pnlLapLichTheoNgay.Controls.Add(this.label6);
            this.pnlLapLichTheoNgay.Controls.Add(this.timeTheoNgay);
            this.pnlLapLichTheoNgay.Controls.Add(this.btnCDDTheoNgay);
            this.pnlLapLichTheoNgay.Controls.Add(this.txtDuongDanTheoNgay);
            this.pnlLapLichTheoNgay.Controls.Add(this.label3);
            this.pnlLapLichTheoNgay.Controls.Add(this.btnTaoLichNgay);
            this.pnlLapLichTheoNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLapLichTheoNgay.Location = new System.Drawing.Point(4, 74);
            this.pnlLapLichTheoNgay.Name = "pnlLapLichTheoNgay";
            this.pnlLapLichTheoNgay.Size = new System.Drawing.Size(1195, 209);
            this.pnlLapLichTheoNgay.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thời gian thực hiện:";
            // 
            // timeTheoNgay
            // 
            this.timeTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTheoNgay.CustomFormat = "\"HH:mm:ss\"";
            this.timeTheoNgay.Location = new System.Drawing.Point(245, 114);
            this.timeTheoNgay.Name = "timeTheoNgay";
            this.timeTheoNgay.Size = new System.Drawing.Size(220, 22);
            this.timeTheoNgay.TabIndex = 6;
            this.timeTheoNgay.Value = new System.DateTime(2023, 7, 1, 11, 38, 44, 0);
            // 
            // btnCDDTheoNgay
            // 
            this.btnCDDTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCDDTheoNgay.Location = new System.Drawing.Point(687, 45);
            this.btnCDDTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.btnCDDTheoNgay.Name = "btnCDDTheoNgay";
            this.btnCDDTheoNgay.Size = new System.Drawing.Size(160, 28);
            this.btnCDDTheoNgay.TabIndex = 5;
            this.btnCDDTheoNgay.Text = "Chọn dường dẫn";
            this.btnCDDTheoNgay.UseVisualStyleBackColor = true;
            this.btnCDDTheoNgay.Click += new System.EventHandler(this.btnCDDTheoNgay_Click);
            // 
            // txtDuongDanTheoNgay
            // 
            this.txtDuongDanTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuongDanTheoNgay.Location = new System.Drawing.Point(245, 45);
            this.txtDuongDanTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDanTheoNgay.Name = "txtDuongDanTheoNgay";
            this.txtDuongDanTheoNgay.Size = new System.Drawing.Size(385, 22);
            this.txtDuongDanTheoNgay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thư mục lưu:";
            // 
            // btnTaoLichNgay
            // 
            this.btnTaoLichNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaoLichNgay.Location = new System.Drawing.Point(968, 147);
            this.btnTaoLichNgay.Name = "btnTaoLichNgay";
            this.btnTaoLichNgay.Size = new System.Drawing.Size(121, 36);
            this.btnTaoLichNgay.TabIndex = 0;
            this.btnTaoLichNgay.Text = "Tạo lịch";
            this.btnTaoLichNgay.UseVisualStyleBackColor = true;
            this.btnTaoLichNgay.Click += new System.EventHandler(this.btnTaoLichNgay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbDsLapLich);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 70);
            this.panel2.TabIndex = 2;
            // 
            // cmbDsLapLich
            // 
            this.cmbDsLapLich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDsLapLich.FormattingEnabled = true;
            this.cmbDsLapLich.Location = new System.Drawing.Point(387, 13);
            this.cmbDsLapLich.Name = "cmbDsLapLich";
            this.cmbDsLapLich.Size = new System.Drawing.Size(364, 24);
            this.cmbDsLapLich.TabIndex = 0;
            this.cmbDsLapLich.SelectedIndexChanged += new System.EventHandler(this.cmbDsLapLich_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.girdControlWeekly);
            this.tabPage4.Controls.Add(this.girdControlDaily);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1203, 516);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh sách lịch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // girdControlWeekly
            // 
            this.girdControlWeekly.DataSource = this.bdsWeeklyJob;
            this.girdControlWeekly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girdControlWeekly.Location = new System.Drawing.Point(3, 309);
            this.girdControlWeekly.MainView = this.gcWeeklyjob;
            this.girdControlWeekly.Name = "girdControlWeekly";
            this.girdControlWeekly.Size = new System.Drawing.Size(1197, 204);
            this.girdControlWeekly.TabIndex = 2;
            this.girdControlWeekly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcWeeklyjob});
            // 
            // bdsWeeklyJob
            // 
            this.bdsWeeklyJob.DataMember = "V_DANHSACHJOBWEEKLY";
            this.bdsWeeklyJob.DataSource = this.tPNTDataSet;
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcWeeklyjob
            // 
            this.gcWeeklyjob.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coljob_name1,
            this.colnext_run_day1,
            this.colnextruntime1,
            this.colExpr1,
            this.colactivetime1,
            this.colactiveendtime1,
            this.colenabled1,
            this.coldate_created1});
            this.gcWeeklyjob.GridControl = this.girdControlWeekly;
            this.gcWeeklyjob.Name = "gcWeeklyjob";
            this.gcWeeklyjob.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gcWeeklyjob_FocusedRowChanged);
            // 
            // coljob_name1
            // 
            this.coljob_name1.Caption = "Tên";
            this.coljob_name1.FieldName = "job_name";
            this.coljob_name1.MinWidth = 25;
            this.coljob_name1.Name = "coljob_name1";
            this.coljob_name1.Visible = true;
            this.coljob_name1.VisibleIndex = 0;
            this.coljob_name1.Width = 258;
            // 
            // colnext_run_day1
            // 
            this.colnext_run_day1.Caption = "Ngày tiếp theo";
            this.colnext_run_day1.FieldName = "next_run_day";
            this.colnext_run_day1.MinWidth = 25;
            this.colnext_run_day1.Name = "colnext_run_day1";
            this.colnext_run_day1.Visible = true;
            this.colnext_run_day1.VisibleIndex = 1;
            this.colnext_run_day1.Width = 99;
            // 
            // colnextruntime1
            // 
            this.colnextruntime1.Caption = "Thời gian thực hiện";
            this.colnextruntime1.FieldName = "nextruntime";
            this.colnextruntime1.MinWidth = 25;
            this.colnextruntime1.Name = "colnextruntime1";
            this.colnextruntime1.Visible = true;
            this.colnextruntime1.VisibleIndex = 2;
            this.colnextruntime1.Width = 124;
            // 
            // colExpr1
            // 
            this.colExpr1.Caption = "Thứ";
            this.colExpr1.FieldName = "freq_interval";
            this.colExpr1.MinWidth = 25;
            this.colExpr1.Name = "colExpr1";
            this.colExpr1.Visible = true;
            this.colExpr1.VisibleIndex = 3;
            this.colExpr1.Width = 41;
            // 
            // colactivetime1
            // 
            this.colactivetime1.Caption = "Thời gian bắt đầu";
            this.colactivetime1.FieldName = "activetime";
            this.colactivetime1.MinWidth = 25;
            this.colactivetime1.Name = "colactivetime1";
            this.colactivetime1.Visible = true;
            this.colactivetime1.VisibleIndex = 4;
            this.colactivetime1.Width = 110;
            // 
            // colactiveendtime1
            // 
            this.colactiveendtime1.Caption = "Thời gian kết thúc";
            this.colactiveendtime1.FieldName = "activeendtime";
            this.colactiveendtime1.MinWidth = 25;
            this.colactiveendtime1.Name = "colactiveendtime1";
            this.colactiveendtime1.Visible = true;
            this.colactiveendtime1.VisibleIndex = 5;
            this.colactiveendtime1.Width = 107;
            // 
            // colenabled1
            // 
            this.colenabled1.Caption = "Trạng thái";
            this.colenabled1.FieldName = "enabled";
            this.colenabled1.MinWidth = 25;
            this.colenabled1.Name = "colenabled1";
            this.colenabled1.Visible = true;
            this.colenabled1.VisibleIndex = 6;
            this.colenabled1.Width = 65;
            // 
            // coldate_created1
            // 
            this.coldate_created1.Caption = "Ngày tạo";
            this.coldate_created1.FieldName = "date_created";
            this.coldate_created1.MinWidth = 25;
            this.coldate_created1.Name = "coldate_created1";
            this.coldate_created1.Visible = true;
            this.coldate_created1.VisibleIndex = 7;
            this.coldate_created1.Width = 71;
            // 
            // girdControlDaily
            // 
            this.girdControlDaily.DataSource = this.bdsDailyJob;
            this.girdControlDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.girdControlDaily.Location = new System.Drawing.Point(3, 89);
            this.girdControlDaily.MainView = this.gcDailyjob;
            this.girdControlDaily.Name = "girdControlDaily";
            this.girdControlDaily.Size = new System.Drawing.Size(1197, 220);
            this.girdControlDaily.TabIndex = 1;
            this.girdControlDaily.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcDailyjob});
            // 
            // bdsDailyJob
            // 
            this.bdsDailyJob.DataMember = "V_DANHSACHJOBDAILY";
            this.bdsDailyJob.DataSource = this.tPNTDataSet;
            // 
            // gcDailyjob
            // 
            this.gcDailyjob.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coljob_name,
            this.colnext_run_day,
            this.colnextruntime,
            this.colactivetime,
            this.colactiveendtime,
            this.colenabled,
            this.coldate_created});
            this.gcDailyjob.GridControl = this.girdControlDaily;
            this.gcDailyjob.Name = "gcDailyjob";
            this.gcDailyjob.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gcDailyjob_FocusedRowChanged);
            // 
            // coljob_name
            // 
            this.coljob_name.Caption = "Tên";
            this.coljob_name.FieldName = "job_name";
            this.coljob_name.MinWidth = 25;
            this.coljob_name.Name = "coljob_name";
            this.coljob_name.Visible = true;
            this.coljob_name.VisibleIndex = 0;
            this.coljob_name.Width = 164;
            // 
            // colnext_run_day
            // 
            this.colnext_run_day.Caption = "Ngày tiếp theo";
            this.colnext_run_day.FieldName = "next_run_day";
            this.colnext_run_day.MinWidth = 25;
            this.colnext_run_day.Name = "colnext_run_day";
            this.colnext_run_day.Visible = true;
            this.colnext_run_day.VisibleIndex = 1;
            this.colnext_run_day.Width = 105;
            // 
            // colnextruntime
            // 
            this.colnextruntime.Caption = "Thời gian thực hiện";
            this.colnextruntime.FieldName = "nextruntime";
            this.colnextruntime.MinWidth = 25;
            this.colnextruntime.Name = "colnextruntime";
            this.colnextruntime.Visible = true;
            this.colnextruntime.VisibleIndex = 2;
            this.colnextruntime.Width = 122;
            // 
            // colactivetime
            // 
            this.colactivetime.Caption = "Thời gian bắt đầu";
            this.colactivetime.FieldName = "activetime";
            this.colactivetime.MinWidth = 25;
            this.colactivetime.Name = "colactivetime";
            this.colactivetime.Visible = true;
            this.colactivetime.VisibleIndex = 3;
            this.colactivetime.Width = 141;
            // 
            // colactiveendtime
            // 
            this.colactiveendtime.Caption = "Thời gian kết thúc";
            this.colactiveendtime.FieldName = "activeendtime";
            this.colactiveendtime.MinWidth = 25;
            this.colactiveendtime.Name = "colactiveendtime";
            this.colactiveendtime.Visible = true;
            this.colactiveendtime.VisibleIndex = 4;
            this.colactiveendtime.Width = 142;
            // 
            // colenabled
            // 
            this.colenabled.Caption = "Trạng thái";
            this.colenabled.FieldName = "enabled";
            this.colenabled.MinWidth = 25;
            this.colenabled.Name = "colenabled";
            this.colenabled.Visible = true;
            this.colenabled.VisibleIndex = 5;
            this.colenabled.Width = 79;
            // 
            // coldate_created
            // 
            this.coldate_created.Caption = "Ngày tạo";
            this.coldate_created.FieldName = "date_created";
            this.coldate_created.MinWidth = 25;
            this.coldate_created.Name = "coldate_created";
            this.coldate_created.Visible = true;
            this.coldate_created.VisibleIndex = 6;
            this.coldate_created.Width = 122;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnDisable);
            this.panel1.Controls.Add(this.btnEnable);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cmbDSJob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnEnable
            // 
            this.btnEnable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEnable.Location = new System.Drawing.Point(179, 43);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(95, 37);
            this.btnEnable.TabIndex = 2;
            this.btnEnable.Text = "Enable";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.ImageOptions.Image = global::TPNT.Properties.Resources.delete_3_1;
            this.btnXoa.Location = new System.Drawing.Point(37, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 37);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmbDSJob
            // 
            this.cmbDSJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDSJob.FormattingEnabled = true;
            this.cmbDSJob.Location = new System.Drawing.Point(387, 13);
            this.cmbDSJob.Name = "cmbDSJob";
            this.cmbDSJob.Size = new System.Drawing.Size(364, 24);
            this.cmbDSJob.TabIndex = 0;
            this.cmbDSJob.SelectedIndexChanged += new System.EventHandler(this.cmbDSJob_SelectedIndexChanged);
            // 
            // v_DANHSACHJOBDAILYTableAdapter
            // 
            this.v_DANHSACHJOBDAILYTableAdapter.ClearBeforeFill = true;
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
            // v_DANHSACHJOBWEEKLYTableAdapter
            // 
            this.v_DANHSACHJOBWEEKLYTableAdapter.ClearBeforeFill = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDisable.Location = new System.Drawing.Point(336, 43);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(95, 37);
            this.btnDisable.TabIndex = 3;
            this.btnDisable.Text = "Disable";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.ImageOptions.Image = global::TPNT.Properties.Resources.refresh;
            this.btnReload.Location = new System.Drawing.Point(488, 43);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(95, 37);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmBackup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 545);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBackup_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup & Restore";
            this.Load += new System.EventHandler(this.frmBackup_Restore_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnlLapLichTheoTuan.ResumeLayout(false);
            this.pnlLapLichTheoTuan.PerformLayout();
            this.pnlLapLichTheoNgay.ResumeLayout(false);
            this.pnlLapLichTheoNgay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.girdControlWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWeeklyJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWeeklyjob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdControlDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDailyJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDailyjob)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lbTiLe;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnChonDuongDan;
        private System.Windows.Forms.TextBox txtDuongDanBkFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnChonDuongDan1;
        private System.Windows.Forms.TextBox txtDuongDan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbDSJob;
        private System.Windows.Forms.Panel panel1;
        private TPNTDataSet tPNTDataSet;
        private System.Windows.Forms.BindingSource bdsDailyJob;
        private TPNTDataSetTableAdapters.V_DANHSACHJOBDAILYTableAdapter v_DANHSACHJOBDAILYTableAdapter;
        private TPNTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl girdControlDaily;
        private DevExpress.XtraGrid.Views.Grid.GridView gcDailyjob;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_name;
        private DevExpress.XtraGrid.Columns.GridColumn colnext_run_day;
        private DevExpress.XtraGrid.Columns.GridColumn colnextruntime;
        private DevExpress.XtraGrid.Columns.GridColumn colactivetime;
        private DevExpress.XtraGrid.Columns.GridColumn colactiveendtime;
        private DevExpress.XtraGrid.Columns.GridColumn colenabled;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_created;
        private System.Windows.Forms.BindingSource bdsWeeklyJob;
        private TPNTDataSetTableAdapters.V_DANHSACHJOBWEEKLYTableAdapter v_DANHSACHJOBWEEKLYTableAdapter;
        private DevExpress.XtraGrid.GridControl girdControlWeekly;
        private DevExpress.XtraGrid.Views.Grid.GridView gcWeeklyjob;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colnext_run_day1;
        private DevExpress.XtraGrid.Columns.GridColumn colnextruntime1;
        private DevExpress.XtraGrid.Columns.GridColumn colExpr1;
        private DevExpress.XtraGrid.Columns.GridColumn colactivetime1;
        private DevExpress.XtraGrid.Columns.GridColumn colactiveendtime1;
        private DevExpress.XtraGrid.Columns.GridColumn colenabled1;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_created1;
        private System.Windows.Forms.Panel pnlLapLichTheoNgay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDsLapLich;
        private System.Windows.Forms.Panel pnlLapLichTheoTuan;
        private System.Windows.Forms.Button btnTaoLichThang;
        private System.Windows.Forms.Button btnTaoLichNgay;
        private System.Windows.Forms.Button btnCDDTheoNgay;
        private System.Windows.Forms.TextBox txtDuongDanTheoNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCDDTheoTuan;
        private System.Windows.Forms.TextBox txtDuongDanTheoTuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timeTheoNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timeTheoTuan;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnEnable;
        private DevExpress.XtraEditors.SimpleButton btnDisable;
        private DevExpress.XtraEditors.SimpleButton btnReload;
    }
}