using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class FrmRPCuocTrienLam : Form
    {
        public FrmRPCuocTrienLam()
        {
            InitializeComponent();
            dtpTuNgay.EditValue = "01/01/2023";
            dtpDenNgay.EditValue = "01/01/2025";
        }
        private bool kiemTra()
        {
            if (soSanhNgay(dtpTuNgay.Text.Trim(), dtpDenNgay.Text.Trim()) == -1)
            {
                MessageBox.Show("Ngày Đến Phải Lớn Hơn Ngày Từ !", "Thông báo", MessageBoxButtons.OK);

                return false;
            }
            return true;
        }
        public static int soSanhNgay(string s1, string s2)
        {
            string[] tmp1 = s1.Split('/');
            string[] tmp2 = s2.Split('/');
            int check1 = (int.Parse(tmp1[2]) * 100 + int.Parse(tmp1[1])) * 100 + int.Parse(tmp1[0]);
            int check2 = (int.Parse(tmp2[2]) * 100 + int.Parse(tmp2[1])) * 100 + int.Parse(tmp2[0]);

            if (check1 > check2)
            {
                return -1;
            }
            else if (check1 == check2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpTuNgay.DateTime;
            DateTime toDate = dtpDenNgay.DateTime;
            Xrpt_CuocTrienLam report = new Xrpt_CuocTrienLam(fromDate, toDate);
       
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpTuNgay.DateTime;
                DateTime toDate = dtpDenNgay.DateTime;
                Xrpt_CuocTrienLam report = new Xrpt_CuocTrienLam(fromDate, toDate);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Chọn vị trí lưu file PDF";
                saveFileDialog.InitialDirectory = @"D:\"; // Thay đổi thư mục mặc định nếu cần thiết

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    /*if (File.Exists(filePath))
                    {
                        DialogResult dr = MessageBox.Show("Tệp tin đã tồn tại tại đường dẫn đã chọn!\nBạn có muốn ghi đè lên?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            report.ExportToPdf(filePath);
                            MessageBox.Show("File ReportCuocTrienLam.pdf đã được ghi thành công tại đường dẫn đã chọn",
                                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {*/
                        report.ExportToPdf(filePath);
                        MessageBox.Show("File ReportCuocTrienLam.pdf đã được ghi thành công tại đường dẫn đã chọn",
                            "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportCuocTrienLam.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
