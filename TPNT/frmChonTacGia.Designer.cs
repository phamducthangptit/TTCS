namespace TPNT
{
    partial class frmChonTacGia
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
            System.Windows.Forms.Label họ_và_tênLabel;
            System.Windows.Forms.Label mã_tác_giảLabel;
            System.Windows.Forms.Label ngày_sinhLabel;
            System.Windows.Forms.Label quốc_tịchLabel;
            System.Windows.Forms.Label ngayMatLabel;
            System.Windows.Forms.Label phong_cáchLabel;
            System.Windows.Forms.Label dienGiaiLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dienGiaiTextBox = new System.Windows.Forms.TextBox();
            this.bdsTG = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTDataSet = new TPNT.TPNTDataSet2();
            this.phong_cáchTextBox = new System.Windows.Forms.TextBox();
            this.quốc_tịchTextBox = new System.Windows.Forms.TextBox();
            this.ngayMatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngày_sinhDateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.mã_tác_giảTextBox = new System.Windows.Forms.TextBox();
            this.họ_và_tênTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureTG = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.v_TAC_GIAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãtácgiả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọvàtên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuốctịch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongcách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.v_TAC_GIATableAdapter = new TPNT.TPNTDataSet2TableAdapters.V_TAC_GIATableAdapter();
            this.tableAdapterManager = new TPNT.TPNTDataSet2TableAdapters.TableAdapterManager();
            họ_và_tênLabel = new System.Windows.Forms.Label();
            mã_tác_giảLabel = new System.Windows.Forms.Label();
            ngày_sinhLabel = new System.Windows.Forms.Label();
            quốc_tịchLabel = new System.Windows.Forms.Label();
            ngayMatLabel = new System.Windows.Forms.Label();
            phong_cáchLabel = new System.Windows.Forms.Label();
            dienGiaiLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngày_sinhDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngày_sinhDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTG)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_TAC_GIAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // họ_và_tênLabel
            // 
            họ_và_tênLabel.AutoSize = true;
            họ_và_tênLabel.Location = new System.Drawing.Point(195, 32);
            họ_và_tênLabel.Name = "họ_và_tênLabel";
            họ_và_tênLabel.Size = new System.Drawing.Size(57, 13);
            họ_và_tênLabel.TabIndex = 1;
            họ_và_tênLabel.Text = "Họ và tên:";
            // 
            // mã_tác_giảLabel
            // 
            mã_tác_giảLabel.AutoSize = true;
            mã_tác_giảLabel.Location = new System.Drawing.Point(195, 83);
            mã_tác_giảLabel.Name = "mã_tác_giảLabel";
            mã_tác_giảLabel.Size = new System.Drawing.Size(60, 13);
            mã_tác_giảLabel.TabIndex = 3;
            mã_tác_giảLabel.Text = "Mã tác giả:";
            // 
            // ngày_sinhLabel
            // 
            ngày_sinhLabel.AutoSize = true;
            ngày_sinhLabel.Location = new System.Drawing.Point(195, 121);
            ngày_sinhLabel.Name = "ngày_sinhLabel";
            ngày_sinhLabel.Size = new System.Drawing.Size(57, 13);
            ngày_sinhLabel.TabIndex = 5;
            ngày_sinhLabel.Text = "Ngày sinh:";
            // 
            // quốc_tịchLabel
            // 
            quốc_tịchLabel.AutoSize = true;
            quốc_tịchLabel.Location = new System.Drawing.Point(195, 189);
            quốc_tịchLabel.Name = "quốc_tịchLabel";
            quốc_tịchLabel.Size = new System.Drawing.Size(56, 13);
            quốc_tịchLabel.TabIndex = 7;
            quốc_tịchLabel.Text = "Quốc tịch:";
            // 
            // ngayMatLabel
            // 
            ngayMatLabel.AutoSize = true;
            ngayMatLabel.Location = new System.Drawing.Point(195, 158);
            ngayMatLabel.Name = "ngayMatLabel";
            ngayMatLabel.Size = new System.Drawing.Size(56, 13);
            ngayMatLabel.TabIndex = 9;
            ngayMatLabel.Text = "Ngay Mat:";
            // 
            // phong_cáchLabel
            // 
            phong_cáchLabel.AutoSize = true;
            phong_cáchLabel.Location = new System.Drawing.Point(29, 258);
            phong_cáchLabel.Name = "phong_cáchLabel";
            phong_cáchLabel.Size = new System.Drawing.Size(68, 13);
            phong_cáchLabel.TabIndex = 11;
            phong_cáchLabel.Text = "Phong cách:";
            // 
            // dienGiaiLabel
            // 
            dienGiaiLabel.AutoSize = true;
            dienGiaiLabel.Location = new System.Drawing.Point(29, 318);
            dienGiaiLabel.Name = "dienGiaiLabel";
            dienGiaiLabel.Size = new System.Drawing.Size(53, 13);
            dienGiaiLabel.TabIndex = 13;
            dienGiaiLabel.Text = "Dien Giai:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dienGiaiTextBox);
            this.panel1.Controls.Add(this.phong_cáchTextBox);
            this.panel1.Controls.Add(this.quốc_tịchTextBox);
            this.panel1.Controls.Add(this.ngayMatDateEdit);
            this.panel1.Controls.Add(this.ngày_sinhDateEdit1);
            this.panel1.Controls.Add(this.mã_tác_giảTextBox);
            this.panel1.Controls.Add(this.họ_và_tênTextBox1);
            this.panel1.Controls.Add(dienGiaiLabel);
            this.panel1.Controls.Add(phong_cáchLabel);
            this.panel1.Controls.Add(ngayMatLabel);
            this.panel1.Controls.Add(quốc_tịchLabel);
            this.panel1.Controls.Add(ngày_sinhLabel);
            this.panel1.Controls.Add(mã_tác_giảLabel);
            this.panel1.Controls.Add(họ_và_tênLabel);
            this.panel1.Controls.Add(this.pictureTG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 542);
            this.panel1.TabIndex = 0;
            // 
            // dienGiaiTextBox
            // 
            this.dienGiaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTG, "DienGiai", true));
            this.dienGiaiTextBox.Location = new System.Drawing.Point(88, 315);
            this.dienGiaiTextBox.Name = "dienGiaiTextBox";
            this.dienGiaiTextBox.Size = new System.Drawing.Size(100, 20);
            this.dienGiaiTextBox.TabIndex = 22;
            // 
            // bdsTG
            // 
            this.bdsTG.DataMember = "V_TAC_GIA";
            this.bdsTG.DataSource = this.tPNTDataSet;
            // 
            // tPNTDataSet
            // 
            this.tPNTDataSet.DataSetName = "TPNTDataSet";
            this.tPNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phong_cáchTextBox
            // 
            this.phong_cáchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTG, "Phong cách", true));
            this.phong_cáchTextBox.Location = new System.Drawing.Point(103, 255);
            this.phong_cáchTextBox.Name = "phong_cáchTextBox";
            this.phong_cáchTextBox.Size = new System.Drawing.Size(100, 20);
            this.phong_cáchTextBox.TabIndex = 21;
            // 
            // quốc_tịchTextBox
            // 
            this.quốc_tịchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTG, "Quốc tịch", true));
            this.quốc_tịchTextBox.Location = new System.Drawing.Point(261, 186);
            this.quốc_tịchTextBox.Name = "quốc_tịchTextBox";
            this.quốc_tịchTextBox.Size = new System.Drawing.Size(100, 20);
            this.quốc_tịchTextBox.TabIndex = 20;
            // 
            // ngayMatDateEdit
            // 
            this.ngayMatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "NgayMat", true));
            this.ngayMatDateEdit.EditValue = null;
            this.ngayMatDateEdit.Location = new System.Drawing.Point(261, 155);
            this.ngayMatDateEdit.Name = "ngayMatDateEdit";
            this.ngayMatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMatDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ngayMatDateEdit.TabIndex = 19;
            // 
            // ngày_sinhDateEdit1
            // 
            this.ngày_sinhDateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "Ngày sinh", true));
            this.ngày_sinhDateEdit1.EditValue = null;
            this.ngày_sinhDateEdit1.Location = new System.Drawing.Point(261, 118);
            this.ngày_sinhDateEdit1.Name = "ngày_sinhDateEdit1";
            this.ngày_sinhDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngày_sinhDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngày_sinhDateEdit1.Size = new System.Drawing.Size(100, 20);
            this.ngày_sinhDateEdit1.TabIndex = 18;
            // 
            // mã_tác_giảTextBox
            // 
            this.mã_tác_giảTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTG, "Mã tác giả", true));
            this.mã_tác_giảTextBox.Location = new System.Drawing.Point(261, 83);
            this.mã_tác_giảTextBox.Name = "mã_tác_giảTextBox";
            this.mã_tác_giảTextBox.Size = new System.Drawing.Size(100, 20);
            this.mã_tác_giảTextBox.TabIndex = 17;
            // 
            // họ_và_tênTextBox1
            // 
            this.họ_và_tênTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTG, "Họ và tên", true));
            this.họ_và_tênTextBox1.Location = new System.Drawing.Point(198, 54);
            this.họ_và_tênTextBox1.Name = "họ_và_tênTextBox1";
            this.họ_và_tênTextBox1.Size = new System.Drawing.Size(216, 20);
            this.họ_và_tênTextBox1.TabIndex = 16;
            // 
            // pictureTG
            // 
            this.pictureTG.Location = new System.Drawing.Point(32, 29);
            this.pictureTG.Name = "pictureTG";
            this.pictureTG.Size = new System.Drawing.Size(150, 200);
            this.pictureTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTG.TabIndex = 0;
            this.pictureTG.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.v_TAC_GIAGridControl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(437, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 542);
            this.panel2.TabIndex = 1;
            // 
            // v_TAC_GIAGridControl
            // 
            this.v_TAC_GIAGridControl.DataSource = this.bdsTG;
            this.v_TAC_GIAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_TAC_GIAGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_TAC_GIAGridControl.MainView = this.gridView1;
            this.v_TAC_GIAGridControl.Name = "v_TAC_GIAGridControl";
            this.v_TAC_GIAGridControl.Size = new System.Drawing.Size(627, 463);
            this.v_TAC_GIAGridControl.TabIndex = 1;
            this.v_TAC_GIAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãtácgiả,
            this.colHọvàtên,
            this.colNgàysinh,
            this.colQuốctịch,
            this.colPhongcách});
            this.gridView1.GridControl = this.v_TAC_GIAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMãtácgiả
            // 
            this.colMãtácgiả.FieldName = "Mã tác giả";
            this.colMãtácgiả.Name = "colMãtácgiả";
            this.colMãtácgiả.Visible = true;
            this.colMãtácgiả.VisibleIndex = 0;
            // 
            // colHọvàtên
            // 
            this.colHọvàtên.FieldName = "Họ và tên";
            this.colHọvàtên.Name = "colHọvàtên";
            this.colHọvàtên.Visible = true;
            this.colHọvàtên.VisibleIndex = 1;
            // 
            // colNgàysinh
            // 
            this.colNgàysinh.FieldName = "Ngày sinh";
            this.colNgàysinh.Name = "colNgàysinh";
            this.colNgàysinh.Visible = true;
            this.colNgàysinh.VisibleIndex = 2;
            // 
            // colQuốctịch
            // 
            this.colQuốctịch.FieldName = "Quốc tịch";
            this.colQuốctịch.Name = "colQuốctịch";
            this.colQuốctịch.Visible = true;
            this.colQuốctịch.VisibleIndex = 3;
            // 
            // colPhongcách
            // 
            this.colPhongcách.FieldName = "Phong cách";
            this.colPhongcách.Name = "colPhongcách";
            this.colPhongcách.Visible = true;
            this.colPhongcách.VisibleIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 79);
            this.panel3.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(539, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // v_TAC_GIATableAdapter
            // 
            this.v_TAC_GIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TPNT.TPNTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmChonTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChonTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn tác giả";
            this.Load += new System.EventHandler(this.frmChonTacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngày_sinhDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngày_sinhDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTG)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_TAC_GIAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private TPNTDataSet2 tPNTDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureTG;
        private System.Windows.Forms.BindingSource bdsTG;
        private TPNTDataSet2TableAdapters.V_TAC_GIATableAdapter v_TAC_GIATableAdapter;
        private TPNTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_TAC_GIAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãtácgiả;
        private DevExpress.XtraGrid.Columns.GridColumn colHọvàtên;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colQuốctịch;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongcách;
        private System.Windows.Forms.TextBox dienGiaiTextBox;
        private System.Windows.Forms.TextBox phong_cáchTextBox;
        private System.Windows.Forms.TextBox quốc_tịchTextBox;
        private DevExpress.XtraEditors.DateEdit ngayMatDateEdit;
        private DevExpress.XtraEditors.DateEdit ngày_sinhDateEdit1;
        private System.Windows.Forms.TextBox mã_tác_giảTextBox;
        private System.Windows.Forms.TextBox họ_và_tênTextBox1;
    }
}