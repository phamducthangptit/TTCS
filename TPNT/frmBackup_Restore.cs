using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TPNT
{
    public partial class frmBackup_Restore : Form
    {
        private BackgroundWorker backupWorker;

        public frmBackup_Restore()
        {
            InitializeComponent();
            backupWorker = new BackgroundWorker();
            backupWorker.WorkerReportsProgress = true;
            backupWorker.WorkerSupportsCancellation = true;
            backupWorker.DoWork += BackupWorker_DoWork;
            backupWorker.ProgressChanged += BackupWorker_ProgressChanged;
            backupWorker.RunWorkerCompleted += BackupWorker_RunWorkerCompleted;


            cmbDSJob.Items.Add("Danh sách lịch Backup theo ngày");
            cmbDSJob.Items.Add("Danh sách lịch Backup theo tuần");
            cmbDSJob.SelectedIndex = 0;

            cmbDsLapLich.Items.Add("Lập lịch Backup theo ngày");
            cmbDsLapLich.Items.Add("Lập lịch Backup theo tuần");
            cmbDsLapLich.SelectedIndex = 0;

            cmbThu.Items.Add("Thứ Hai");
            cmbThu.Items.Add("Thứ Ba");
            cmbThu.Items.Add("Thứ Tư");
            cmbThu.Items.Add("Thứ Năm");
            cmbThu.Items.Add("Thứ Sáu");
            cmbThu.Items.Add("Thứ Bảy");
            cmbThu.Items.Add("Chủ Nhật");
            cmbThu.SelectedIndex = 0;

            timeTheoNgay.Format = DateTimePickerFormat.Custom;
            timeTheoNgay.CustomFormat = "HH:mm:ss";

            timeTheoNgay.Format = DateTimePickerFormat.Time;
            timeTheoNgay.ShowUpDown = true;

            timeTheoTuan.Format = DateTimePickerFormat.Custom;
            timeTheoTuan.CustomFormat = "HH:mm:ss";

            timeTheoTuan.Format = DateTimePickerFormat.Time;
            timeTheoTuan.ShowUpDown = true;

            if(bdsDailyJob.Count == 0)
            {
                btnXoa.Enabled = false;
            } else 
            { 
                btnXoa.Enabled = true; 
            }
        }

        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "File .bak (.bak)|*.bak";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDan = openFileDialog.FileName;
                    if(File.Exists(duongDan)){
                        File.Delete(duongDan);
                    }
                    this.txtDuongDanBkFull.Text = duongDan;
                }
            }
        }
        private void BackupWorker_DoWork(object sender, DoWorkEventArgs e)
        {   
            int progressPercentage = 0;
            bool isCancelled = false;
            Task.Run(() =>
            {
                string strLenh = "EXEC SP_BACKUPFULLDB '" + this.txtDuongDanBkFull.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (ex == 0)
                {
                    
                } else
                {
                    backupWorker.CancelAsync();
                }
            });
            while (!File.Exists(this.txtDuongDanBkFull.Text))
            {
                if (backupWorker.CancellationPending)
                {
                    e.Cancel = true;
                    isCancelled = true;
                    break;
                }
                Random random = new Random();
                int randomNumber = random.Next(1, 11);
                if (progressPercentage < 99)
                {
                    progressPercentage += randomNumber;
                    backupWorker.ReportProgress(progressPercentage);
                }
                Thread.Sleep(1000); // Tạm dừng 1 giây (có thể điều chỉnh thời gian tùy ý)

            }
            if (!isCancelled)
            {
                progressPercentage = 100;
                backupWorker.ReportProgress(progressPercentage);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            backupWorker.RunWorkerAsync();
        }

        private void BackupWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật giá trị của ProgressBar dựa trên tiến trình backup
            progressBar.Value = e.ProgressPercentage;
            lbTiLe.Text = e.ProgressPercentage.ToString() +"%";
        }

        private void BackupWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelled", "Thông báo", MessageBoxButtons.OK);
            }
            else if (e.Error != null)
            {
                // Có lỗi xảy ra trong quá trình thực hiện công việc
                // Xử lý tại đây
            }
            else
            {
                // Công việc hoàn thành thành công
                // Xử lý tại đây
                MessageBox.Show("Backup dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnChonDuongDan1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp (.bak)|*.bak";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtDuongDan1.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string str1 = string.Format("ALTER DATABASE [TPNT] " +
               " SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
               );
            int tmp = Program.ExecSqlNonQuery(str1, Program.connstr);
            string strLenh = "USE MASTER RESTORE DATABASE TPNT FROM DISK =  '" + this.txtDuongDan1.Text + "' WITH REPLACE, RECOVERY;";
            int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
            if (ex == 0)
            {
                MessageBox.Show("Restore dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Restore dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            str1 = string.Format("ALTER DATABASE [TPNT] " +
                " SET MULTI_USER"
                );
            tmp = Program.ExecSqlNonQuery(str1, Program.connstr);
        }

        private void frmBackup_Restore_Load(object sender, EventArgs e)
        {
            this.v_DANHSACHJOBWEEKLYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DANHSACHJOBDAILYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DANHSACHJOBWEEKLYTableAdapter.Fill(this.tPNTDataSet.V_DANHSACHJOBWEEKLY);
            this.v_DANHSACHJOBDAILYTableAdapter.Fill(this.tPNTDataSet.V_DANHSACHJOBDAILY);

            for (int i = 0; i < bdsWeeklyJob.Count; i++)
            {
                int fq = Int32.Parse(((DataRowView)bdsWeeklyJob[i])["freq_interval"].ToString());
                if(fq == 1)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "CN";
                } else if(fq == 2)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Hai";
                } else if(fq == 4)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Ba";
                } else if(fq == 8)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Tư";
                } else if (fq == 16)
                {
                   ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Năm";
                } else if(fq == 32)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Sáu";
                } else if(fq == 64)
                {
                    ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Bảy";
                }
            }
        }
        private void reload()
        {
            
            if (cmbDSJob.SelectedIndex == 0)
            {
                int vitri = bdsDailyJob.Position;
                this.v_DANHSACHJOBDAILYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_DANHSACHJOBDAILYTableAdapter.Fill(this.tPNTDataSet.V_DANHSACHJOBDAILY);
                bdsDailyJob.Position = vitri;
                girdControlWeekly.Visible = false;
                girdControlDaily.Visible = true;
                girdControlDaily.Dock = DockStyle.Fill;
                if (bdsDailyJob.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                }
            }
            else
            {
                int vitri = bdsWeeklyJob.Position;
                this.v_DANHSACHJOBWEEKLYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_DANHSACHJOBWEEKLYTableAdapter.Fill(this.tPNTDataSet.V_DANHSACHJOBWEEKLY);
                bdsWeeklyJob.Position = vitri;
                girdControlDaily.Visible = false;
                girdControlWeekly.Visible = true;
                girdControlWeekly.Dock = DockStyle.Fill;
                if (bdsWeeklyJob.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                }
                for (int i = 0; i < bdsWeeklyJob.Count; i++)
                {
                    int fq = Int32.Parse(((DataRowView)bdsWeeklyJob[i])["freq_interval"].ToString());
                    if (fq == 1)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "CN";
                    }
                    else if (fq == 2)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Hai";
                    }
                    else if (fq == 4)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Ba";
                    }
                    else if (fq == 8)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Tư";
                    }
                    else if (fq == 16)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Năm";
                    }
                    else if (fq == 32)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Sáu";
                    }
                    else if (fq == 64)
                    {
                        ((DataRowView)bdsWeeklyJob[i])["freq_interval"] = "Bảy";
                    }
                }
            }
        }
        private void cmbDSJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void btnTaoLichNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = timeTheoNgay.Value;
            int hour = selectedTime.Hour;
            int minute = selectedTime.Minute;
            int second = selectedTime.Second;
            string tmp = "", tmp1 = "";
            if(second < 10)
            {
                tmp = "0" + second;
            } else
            {
                tmp = second + "";
            }
            if (minute < 10)
            {
                tmp1 = "0" + minute;
            }
            else
            {
                tmp1 = minute + "";
            }
            string hTmp = hour + "" + tmp1 + "" + tmp;
            int h = Int32.Parse(hTmp);
            if(txtDuongDanTheoNgay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đường dẫn không được trống", "Thông báo", MessageBoxButtons.OK);
                txtDuongDanTheoNgay.Focus();
                return;
            }
            string strLenh = "EXEC SP_SET_UP_JOB_FOR_BACKUP_DAILY '" + this.txtDuongDanTheoNgay.Text + "', " + h;
            int ex = Program.ExecSetUpJob(strLenh, Program.connstr);
            if(ex == 0)
            {
                MessageBox.Show("Tạo lịch Backup theo ngày thành công", "Thông báo", MessageBoxButtons.OK);
                return;
            } else
            {
                MessageBox.Show("Lịch Backup này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnTaoLichThang_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = timeTheoTuan.Value;
            int hour = selectedTime.Hour;
            int minute = selectedTime.Minute;
            int second = selectedTime.Second;
            string tmp = "", tmp1 = "";
            if (second < 10)
            {
                tmp = "0" + second;
            }
            else
            {
                tmp = second + "";
            }
            if (minute < 10)
            {
                tmp1 = "0" + minute;
            }
            else
            {
                tmp1 = minute + "";
            }
            string hTmp = hour + "" + tmp1 + "" + tmp;
            int h = Int32.Parse(hTmp);
            if (txtDuongDanTheoTuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đường dẫn không được trống", "Thông báo", MessageBoxButtons.OK);
                txtDuongDanTheoTuan.Focus();
                return;
            }
            int thu = 0;
            if (cmbThu.SelectedIndex == 0)
            {
                thu = 2;
            }
            else if (cmbThu.SelectedIndex == 1)
            {
                thu = 4;
            }
            else if (cmbThu.SelectedIndex == 2)
            {
                thu = 8;
            }
            else if (cmbThu.SelectedIndex == 3)
            {
                thu = 16;
            }
            else if (cmbThu.SelectedIndex == 4)
            {
                thu = 32;
            }
            else if (cmbThu.SelectedIndex == 5)
            {
                thu = 64;
            }
            else thu = 1;
            string strLenh = "EXEC SP_SET_UP_JOB_FOR_BACKUP_WEEKLY '" + this.txtDuongDanTheoTuan.Text + "', " + h + ", " + thu;
            int ex = Program.ExecSetUpJob(strLenh, Program.connstr);
            if (ex == 0)
            {
                MessageBox.Show("Tạo lịch Backup theo tuần thành công", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Lịch Backup này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private void cmbDsLapLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDsLapLich.SelectedIndex == 0)
            {
                pnlLapLichTheoNgay.Visible = true;
                pnlLapLichTheoNgay.Dock = DockStyle.Fill;
                pnlLapLichTheoTuan.Visible = false;
            } else
            {
                pnlLapLichTheoTuan.Visible = true;
                pnlLapLichTheoTuan.Dock = DockStyle.Fill;
                pnlLapLichTheoNgay.Visible = false;
            }
        }

        private void btnCDDTheoNgay_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "File .bak (.bak)|*.bak";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDan = openFileDialog.FileName;
                    if (File.Exists(duongDan))
                    {
                        File.Delete(duongDan);
                    }
                    this.txtDuongDanTheoNgay.Text = duongDan;
                }

            }
        }

        private void btnCDDTheoTuan_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "File .bak (.bak)|*.bak";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDan = openFileDialog.FileName;
                    if (File.Exists(duongDan))
                    {
                        File.Delete(duongDan);
                    }
                    this.txtDuongDanTheoTuan.Text = duongDan;
                }
            }
        }

        private void gcDailyjob_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsDailyJob.Count == 0) return;
            int enable = Int32.Parse(((DataRowView)bdsDailyJob[bdsDailyJob.Position])["enabled"].ToString());
            if(enable == 1)
            {
                btnEnable.Enabled = false;
                btnDisable.Enabled = true;
            } else
            {
                btnEnable.Enabled = true;
                btnDisable.Enabled = false;
            }
        }

        private void gcWeeklyjob_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsWeeklyJob.Count == 0) return;
            int enable = Int32.Parse(((DataRowView)bdsWeeklyJob[bdsWeeklyJob.Position])["enabled"].ToString());
            if (enable == 1)
            {
                btnEnable.Enabled = false;
                btnDisable.Enabled = true;
            }
            else
            {
                btnEnable.Enabled = true;
                btnDisable.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa lịch Backup này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string jobname = "";
                if (cmbDSJob.SelectedIndex == 0) // xoa job ngay
                {
                    jobname = ((DataRowView)bdsDailyJob[bdsDailyJob.Position])["job_name"].ToString();
                    bdsDailyJob.RemoveCurrent();
                }
                else // xoa job tuan
                {
                    jobname = ((DataRowView)bdsWeeklyJob[bdsWeeklyJob.Position])["job_name"].ToString();
                    bdsWeeklyJob.RemoveCurrent();
                }
                string strLenh = "EXEC SP_DELETEJOBBACKUP '" + jobname + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (ex == 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            string jobname = "";
            if (cmbDSJob.SelectedIndex == 0) // enable job ngay
            {
                jobname = ((DataRowView)bdsDailyJob[bdsDailyJob.Position])["job_name"].ToString();
            }
            else // enable job tuan
            {
                jobname = ((DataRowView)bdsWeeklyJob[bdsWeeklyJob.Position])["job_name"].ToString();
            }
            string strLenh = "EXEC SP_ENABLEDJOB '" + jobname + "'";
            int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
            if (ex == 0)
            {
                MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK);
            }
            reload();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            string jobname = "";
            if (cmbDSJob.SelectedIndex == 0) // disable job ngay
            {
                jobname = ((DataRowView)bdsDailyJob[bdsDailyJob.Position])["job_name"].ToString();
            }
            else // disable job tuan
            {
                jobname = ((DataRowView)bdsWeeklyJob[bdsWeeklyJob.Position])["job_name"].ToString();
            }
            string strLenh = "EXEC SP_DISABLEDJOB '" + jobname + "'";
            int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
            if (ex == 0)
            {
                MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK);
            }
            reload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void frmBackup_Restore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
           // MessageBox.Show("" + Program.connstr, "", MessageBoxButtons.OK);
        }


    }
}
