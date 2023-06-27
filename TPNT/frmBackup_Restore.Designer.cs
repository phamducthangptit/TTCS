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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lbTiLe = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnChonDuongDan = new System.Windows.Forms.Button();
            this.txtDuongDanBkFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChonDuongDan1 = new System.Windows.Forms.Button();
            this.txtDuongDan1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 461);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(445, 367);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lbTiLe
            // 
            this.lbTiLe.AutoSize = true;
            this.lbTiLe.Location = new System.Drawing.Point(278, 168);
            this.lbTiLe.Name = "lbTiLe";
            this.lbTiLe.Size = new System.Drawing.Size(21, 13);
            this.lbTiLe.TabIndex = 4;
            this.lbTiLe.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 133);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(390, 23);
            this.progressBar.TabIndex = 3;
            // 
            // btnChonDuongDan
            // 
            this.btnChonDuongDan.Location = new System.Drawing.Point(420, 55);
            this.btnChonDuongDan.Name = "btnChonDuongDan";
            this.btnChonDuongDan.Size = new System.Drawing.Size(120, 23);
            this.btnChonDuongDan.TabIndex = 2;
            this.btnChonDuongDan.Text = "Chọn dường dẫn";
            this.btnChonDuongDan.UseVisualStyleBackColor = true;
            this.btnChonDuongDan.Click += new System.EventHandler(this.btnChonDuongDan_Click);
            // 
            // txtDuongDanBkFull
            // 
            this.txtDuongDanBkFull.Location = new System.Drawing.Point(111, 55);
            this.txtDuongDanBkFull.Name = "txtDuongDanBkFull";
            this.txtDuongDanBkFull.Size = new System.Drawing.Size(290, 20);
            this.txtDuongDanBkFull.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục lưu:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRestore);
            this.tabPage2.Controls.Add(this.btnChonDuongDan1);
            this.tabPage2.Controls.Add(this.txtDuongDan1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lập lịch";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChonDuongDan1
            // 
            this.btnChonDuongDan1.Location = new System.Drawing.Point(413, 62);
            this.btnChonDuongDan1.Name = "btnChonDuongDan1";
            this.btnChonDuongDan1.Size = new System.Drawing.Size(120, 23);
            this.btnChonDuongDan1.TabIndex = 5;
            this.btnChonDuongDan1.Text = "Chọn dường dẫn";
            this.btnChonDuongDan1.UseVisualStyleBackColor = true;
            this.btnChonDuongDan1.Click += new System.EventHandler(this.btnChonDuongDan1_Click);
            // 
            // txtDuongDan1
            // 
            this.txtDuongDan1.Location = new System.Drawing.Point(104, 62);
            this.txtDuongDan1.Name = "txtDuongDan1";
            this.txtDuongDan1.Size = new System.Drawing.Size(290, 20);
            this.txtDuongDan1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thư mục lưu:";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(443, 230);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // frmBackup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBackup_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup & Restore";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}