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
    }
}
