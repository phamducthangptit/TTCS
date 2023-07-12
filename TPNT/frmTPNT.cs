using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Media;
using System.Data.SqlClient;
using GemBox.Spreadsheet;
using System.Reflection;
using DevExpress.XtraCharts.Native;


namespace TPNT
{
    public partial class frmTPNT : Form
    {
        string filePath = "";
        string suKien = "";
        public static string maTG = "";
        int viTri;
        int soLuong = 0;
        public frmTPNT()
        {
            InitializeComponent();
        }

        private void frmTPNT_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.v_TAC_GIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);
            this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);

            string strLenh1 = " SELECT dbo.FN_COUNT_TPNT ()";
            SqlDataReader dataReader1 = Program.ExecSqlDataReader(strLenh1);
            dataReader1.Read();
            soLuong = dataReader1.GetInt32(0);
            lbCount.Text = soLuong.ToString(); 
            dataReader1.Close();
            Program.conn.Close();
            if (Program.mGroup.Equals("KHACH") ){
                btnThem.Enabled = btnHieuChinh.Enabled =
                    btnXoa.Enabled =
                    btnExport.Enabled =
                    btnImport.Enabled = false;
            } else
            {
                btnThem.Enabled = btnHieuChinh.Enabled =
                    btnXoa.Enabled =
                    btnExport.Enabled =
                    btnImport.Enabled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsTPNT.Count == 0)
            {  
                btnExport.Enabled = false;
                return;
            } 
            string hinhAnh = ((DataRowView)bdsTPNT[bdsTPNT.Position])["HinhAnh"].ToString();
            if (hinhAnh.Equals(""))
            {
                hinhAnh = "macDinh.png";
            }
            pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + hinhAnh);
            
            maTG = ((DataRowView)bdsTPNT[bdsTPNT.Position])["MaTacGia"].ToString();
            int tmp = bdsTG.Find("Mã tác giả", maTG);
            if (tmp == -1) return;
            txtTacGia.Text = ((DataRowView)bdsTG[tmp])["Họ và tên"].ToString(); 
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTPNT.Position;
            suKien = "THEM";
            panelDSTPNT.Enabled = false;
            panelThongTin.Enabled = true;
            bdsTPNT.AddNew();
            txtMa.Enabled = true;
            btnThemAnh.Visible = true;
            btnChonTG.Visible = true;
            maTG = "";
            txtTacGia.ResetText();
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHieuChinh.Enabled=btnExport.Enabled = btnImport.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp tin";
            openFileDialog.Filter = "Tệp tin hình ảnh|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                pictureTPNT.Image = new Bitmap(filePath);
                //MessageBox.Show("Tải lên thành công!");

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (suKien.Equals("")) return;
            string ten = txtTen.Text.Trim();
            string ma = txtMa.Text.Trim();
            string nam = txtNam.Text.Trim();
            string chuDe = txtChuDe.Text.Trim();
            string quocGia = txtQuocGia.Text.Trim();
            string thoiDai = txtThoiDai.Text.Trim();
            string loiDienGiai = txtLoiDienGiai.Text.Trim();
            string destinationFolder = @"" + Application.StartupPath + "\\Resources\\";
            string fileName = Path.GetFileName(filePath);
            if (ma.Equals(""))
            {
                MessageBox.Show("Mã tác phẩm nghệ thuật không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            if (ten.Equals(""))
            {
                MessageBox.Show("Tên tác phẩm nghệ thuật không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (maTG.Equals(""))
            {
                MessageBox.Show("Tác giả của tác phẩm nghệ thuật không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtTacGia.Focus();
                return;
            }
            if (fileName.Equals(""))
            {
                fileName = "macDinh.png";
            }
            string destinationPath = Path.Combine(destinationFolder, fileName);
            
            if (!File.Exists(destinationPath))
            {
                File.Copy(filePath, destinationPath);
            }
            string strLenh = "";
            if (suKien.Equals("THEM"))
            {
                 strLenh = "SP_INSERT_TPNT '"
                        + ma + "', N'"
                        + ten + "', '"
                         + fileName + "', '"
                         + nam + "', N'"
                         + chuDe + "', N'"
                        + quocGia + "', N'"
                        + thoiDai + "', N'"
                        + loiDienGiai + "', '"
                        + maTG +
                        "'"
                        ;
                
                int result = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (result == 0)
                {
                    MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
                    soLuong += 1;
                    lbCount.Text = soLuong.ToString();
                }
            } else if (suKien.Equals("HIEUCHINH"))
            {
                strLenh = "SP_UPDATE_TPNT '"
                        + ma + "', N'"
                        + ten + "', '"
                         + fileName + "', '"
                         + nam + "', N'"
                         + chuDe + "', N'"
                        + quocGia + "', N'"
                        + thoiDai + "', N'"
                        + loiDienGiai + "', '"
                        + maTG +
                        "'"
                        ;
                int result = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (result == 0)
                {
                    MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
                }
            }
            
            this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);
            bdsTPNT.Position = viTri;
            panelDSTPNT.Enabled = true;
            panelThongTin.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHieuChinh.Enabled = btnExport.Enabled = btnImport.Enabled = true;
            btnThemAnh.Visible = false;
            btnChonTG.Visible = false;
            suKien = "";
            

        }

        private void btnChonTG_Click(object sender, EventArgs e)
        {
            Form form = new frmChonTacGia(this);
            form.Show();
        }
        public void setTG (string ma, string ten) {
            maTG = ma;
            txtTacGia.Text = ten;
        }




        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);
   
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTPNT.Position;
            suKien = "HIEUCHINH";
            txtMa.Enabled = false;
            panelDSTPNT.Enabled = false;
            panelThongTin.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHieuChinh.Enabled = btnExport.Enabled = btnImport.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ten = txtTen.Text.Trim();
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn xoá "+ten+" ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                string ma = txtMa.Text.Trim();
                string strLenh = "DELETE FROM TPNT WHERE MaSoTP = '"
                           + ma +
                           "'"
                           ;
                int result = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (result == 0)
                {
                    MessageBox.Show("Xoá tác phẩm thành công", "", MessageBoxButtons.OK);
                    soLuong -= 1;
                    lbCount.Text = soLuong.ToString();
                }
                this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                panelDSTPNT.Enabled = true;
                panelThongTin.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHieuChinh.Enabled = btnExport.Enabled = btnImport.Enabled = true;
                btnThemAnh.Visible = false;
                btnChonTG.Visible = false;
                suKien = "";
                this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);
                bdsTPNT.Position = viTri;
        }
       
        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy DataTable từ BindingSource
                    DataTable dataTable = new DataTable();
                    for (int i = 0; i < bdsTPNT.List.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsTPNT.List[i];
                        DataRow row = rowView.Row;
                        if (i == 0)
                        {
                            foreach (DataColumn column in row.Table.Columns)
                            {
                                dataTable.Columns.Add(column.ColumnName);
                            }
                        }
                        dataTable.ImportRow(row);
                    }
                    // Xuất DataTable ra Excel
                    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

                    var workbook = new ExcelFile();
                    var worksheet = workbook.Worksheets.Add("TPNT");
                    worksheet.InsertDataTable(dataTable,
                            new InsertDataTableOptions()
                            {
                                ColumnHeaders = true,
                                StartRow = 0
                            });
                    workbook.Save(saveFileDialog.FileName);

                    MessageBox.Show("Dữ liệu đã được xuất thành công vào tập tin Excel!", "Xuất Excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xuất dữ liệu ra Excel: {ex.Message}", "Lỗi xuất Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Import an Excel File"
            };
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = Program.docFileExcel(openFileDialog.FileName, 0);
                try
                {
                    using (SqlBulkCopy bulkCopy =
                       new SqlBulkCopy(Program.connstr))
                    {
                        bulkCopy.DestinationTableName =
                            "dbo.TPNT";

                        // Set up the column mappings by name.
                        bulkCopy.ColumnMappings.Add("Mã tác phẩm", "MaSoTP");

                        bulkCopy.ColumnMappings.Add("Tên tác phẩm", "TenTP");

                        bulkCopy.ColumnMappings.Add("Năm sáng tác", "NamSangTac");

                        bulkCopy.ColumnMappings.Add("ChuDe", "ChuDe");

                        bulkCopy.ColumnMappings.Add("Quốc gia", "QuocGia");

                        bulkCopy.ColumnMappings.Add("ThoiDai", "ThoiDai");

                        bulkCopy.ColumnMappings.Add("LoiDienGiai", "LoiDienGiai");

                        bulkCopy.ColumnMappings.Add("MaTacGia", "MaTacGia");

                        bulkCopy.ColumnMappings.Add("HinhAnh", "HinhAnh");

                        // Write from the source to the destination.

                        bulkCopy.WriteToServer(dataTable);
                        MessageBox.Show("Dữ liệu đã được nhập thành công từ tập tin Excel!", "Nhập từ Excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi nhập dữ liệu từ Excel: \n{ex.Message}", "Lỗi nhập từ Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                this.v_TAC_GIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);
                this.v_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_TPNTTableAdapter.Fill(this.tPNTDataSet.V_TPNT);

                string strLenh1 = " SELECT dbo.FN_COUNT_TPNT ()";
                SqlDataReader dataReader1 = Program.ExecSqlDataReader(strLenh1);
                dataReader1.Read();
                soLuong = dataReader1.GetInt32(0);
                lbCount.Text = soLuong.ToString();
                dataReader1.Close();
                Program.conn.Close();
            }
        }
    }
}
