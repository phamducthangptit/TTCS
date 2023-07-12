using DevExpress.Utils.Extensions;
using DevExpress.Utils.MVVM;
using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmTacGia : Form
    {
        private PictureBox pictureBox = new PictureBox();
        private string selectedImagePath = "";
        private string suKien = "";
        private string suKienCT = "";
        private int vitri = 0;
        private int chonAnh = 0;
        public frmTacGia()
        {
            InitializeComponent();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);  

            gcTacGia.Dock = DockStyle.Fill;
            groupBox1.Visible = false;
            if (Program.mGroup.Equals("QUANLI"))
            {
                this.btnThem.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = this.btnImport.Enabled = this.btnExport.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = this.btnHieuChinh.Enabled = false;

                string strLenh = "SELECT * FROM V_SLTG";
                SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
                dataReaderSLTG.Read();
                int slTG = dataReaderSLTG.GetInt32(0);
                dataReaderSLTG.Close();
                if (slTG == 0)
                {
                    this.btnXoa.Enabled = false;
                }
                else this.btnXoa.Enabled = true;
            } else
            {
                this.btnReload.Enabled = this.btnThoat.Enabled = true;
                this.btnImport.Enabled = this.btnExport.Enabled = this.btnThem.Enabled = this.btnLuu.Enabled = this.btnPhucHoi.Enabled = this.btnHieuChinh.Enabled = false;
            }

            
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suKien = "THEM";
            suKienCT = "THEM";
            vitri = bdsTacGia.Position;
            this.txtMaTacGia.ReadOnly = false;
            gcTacGia.Visible = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;

            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = this.txtThoiDai.Enabled = true;

            this.btnImport.Enabled = this.btnExport.Enabled = this.btnChiTiet.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnHieuChinh.Enabled 
                = this.btnReload.Enabled = this.btnThoat.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = false;
            
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            //this.pnlAnh.Visible = false;
            this.lblSLTP.Visible = this.txtSLTP.Visible = false;
            bdsTacGia.AddNew();
            this.btnChonAnh.Visible = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;
            suKien = "HC";
            gcTacGia.Enabled = false;   
            groupBox1.Enabled = true;

            this.btnImport.Enabled = this.btnExport.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnHieuChinh.Enabled 
                = this.btnReload.Enabled = this.btnThoat.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = this.txtThoiDai.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            this.btnChonAnh.Visible = true;
            this.pnlAnh.Visible = true;
            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = this.txtThoiDai.Enabled = true;

            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();
            string strLenh = "SELECT dbo.FN_SLTP('" + maTG + "')";
            SqlDataReader dataReaderSLTP = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTP.Read();
            int sLTP = dataReaderSLTP.GetInt32(0);
            dataReaderSLTP.Close();
            if (sLTP != 0)
            {
                this.txtMaTacGia.ReadOnly = true;
            }
            else this.txtMaTacGia.ReadOnly = false ;

            string pathImage = ((DataRowView)bdsTacGia[vitri])["HinhAnh"].ToString();
            if(pathImage.Trim().Length != 0)
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Resources\\" + pathImage);
                selectedImagePath = pathImage;

                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                this.pnlAnh.AddControl(pictureBox);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "SELECT * FROM V_SLTG";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if(slTG == 0)
            {
                this.btnXoa.Enabled = false;
            } else this.btnXoa.Enabled = true;
            string maTG = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();

                    bdsTacGia.RemoveCurrent();
                    strLenh = "EXEC SP_DELETETG '" + maTG + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                    //File.Delete(((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tác giả. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
                    bdsTacGia.Position = bdsTacGia.Find("MaTacGia", maTG);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            
            if (suKienCT.Equals("THEM"))
            {
                gcTacGia.Visible = true;
                gcTacGia.Dock = DockStyle.Fill;
                groupBox1.Visible = false;
                this.btnImport.Enabled = this.btnExport.Enabled = this.btnChiTiet.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = 
                    this.btnThoat.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                
            }
            else
            {
                this.btnImport.Enabled = this.btnExport.Enabled = this.btnXoa.Enabled = this.btnHieuChinh.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = false;
                this.btnChonAnh.Visible = this.btnThem.Enabled = false;
                this.pnlAnh.Visible = true;
                this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = this.txtThoiDai.Enabled = false;
            }

            this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
            bdsTacGia.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;

            try
            {
                this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
                bdsTacGia.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }


        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp tin hình ảnh (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    chonAnh = 1;
                    selectedImagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(selectedImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    this.pnlAnh.AddControl(pictureBox);
                    this.pnlAnh.Visible = true;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.txtMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtMaTacGia.Focus();
                return;
            }

            if (this.txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtHoTen.Focus();
                return;
            }

            if (this.txtQuocTich.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quốc tịch tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtQuocTich.Focus();
                return;
            }

            if (this.txtPhongCach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phong cách tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtPhongCach.Focus();
                return;
            }

            if (this.txtDienGiai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Diễn giải không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtDienGiai.Focus();
                return;
            }

            if (this.ngaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày sinh không được trống", "Thông báo", MessageBoxButtons.OK);
                this.ngaySinh.Focus();
                return;
            }

            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();

            string[] ngay = this.ngaySinh.Text.Split('/');
            string ngaySinh = ngay[2] + "-" + ngay[1] + "-" + ngay[0];
            string ngayMat = "";
            if (this.ngayMat.Text.Length != 0)
            {
                ngay = this.ngayMat.Text.Split('/');
                ngayMat = ngay[2] + "-" + ngay[1] + "-" + ngay[0];

            }

            if (suKien.Equals("THEM"))
            {
                string strLenh = "EXEC SP_CHECKEXISTSTG '" + this.txtMaTacGia.Text + "'";
                SqlDataReader dataReaderTG = Program.ExecSqlDataReader(strLenh);
                dataReaderTG.Read();
                int check = Int32.Parse(dataReaderTG.GetString(0)); // check xem trong db đã có mã tg này hay chưa
                dataReaderTG.Close();
                Program.conn.Close();
                if(check == 0)
                {
                    string p = "";
                    string uniqueFileName = "";
                    if (chonAnh == 1)
                    {
                        string saveFolderPath = @"" + Application.StartupPath + "\\Resources\\";
                        uniqueFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(selectedImagePath);
                        string saveFilePath = Path.Combine(saveFolderPath, uniqueFileName);

                        p = saveFolderPath + uniqueFileName;
                        File.Copy(selectedImagePath, saveFilePath);


                    }
                    else uniqueFileName = "nophoto.png";
                    bdsTacGia.EndEdit();
                    bdsTacGia.ResetCurrentItem();
                    strLenh = "EXEC SP_INSERTTG '" + this.txtMaTacGia.Text + "', N'" + this.txtHoTen.Text + "', '" + ngaySinh + "', '" + ngayMat + "', '"
                        + this.txtQuocTich.Text + "', N'" + this.txtDienGiai.Text + "', N'" + this.txtPhongCach.Text + "', '" + uniqueFileName + "', N'" + this.txtThoiDai.Text + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                    if (ex == 0) //lưu thành công
                    {
                        chonAnh = 0;
                        gcTacGia.Visible = true;
                        gcTacGia.Dock = DockStyle.Fill;
                        groupBox1.Visible = false;
                        this.btnChiTiet.Enabled = true;
                        MessageBox.Show("Thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK);
                    } else // lưu thất bại
                    {
                        this.btnThem.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = false;
                        this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                        this.btnChonAnh.Visible = true;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mã tác giả đã có trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                suKien = "";
            } else if (suKien.Equals("HC"))
            {
                string anhCu = "", uniqueFileName = "";
                anhCu = ((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString();
                if (chonAnh == 1)
                {
                    string saveFolderPath = @"" + Application.StartupPath + "\\Resources\\";
                    uniqueFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(selectedImagePath);
                    string saveFilePath = Path.Combine(saveFolderPath, uniqueFileName);


                    File.Copy(selectedImagePath, saveFilePath);
                }
                else uniqueFileName = anhCu;
                chonAnh = 0;
                bdsTacGia.EndEdit();
                bdsTacGia.ResetCurrentItem();
                string strLenh = "EXEC SP_UPDATETG '" + maTG + "', '" + this.txtMaTacGia.Text + "', N'" + this.txtHoTen.Text + "', '" + ngaySinh + "', '" + ngayMat + "', N'"
                       + this.txtQuocTich.Text + "', N'" + this.txtDienGiai.Text + "', N'" + this.txtPhongCach.Text + "', '" + uniqueFileName + "', N'" + this.txtThoiDai.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if(ex == 0) // thay đổi thành công
                {
                    suKien = "";
                    chonAnh = 0;
                    gcTacGia.Visible = true;
                    gcTacGia.Dock = DockStyle.Fill;
                    groupBox1.Visible = false;
                    this.btnChiTiet.Enabled = this.btnThem.Enabled = true;
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                } else // thay đổi thất bại
                {
                    this.btnThem.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = false;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                    this.btnChonAnh.Visible = true;
                    return;
                }
                
            }
            gcTacGia.Enabled = true;

            this.btnImport.Enabled = this.btnExport.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled 
                = this.btnBackup.Enabled = this.btnRestore.Enabled = this.btnThem.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
            this.btnChonAnh.Visible = false;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsTacGia.Count == 0) return;
            string pathImage = ((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString();

            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();
            string strLenh = "SELECT dbo.FN_SLTP('" + maTG + "')";
            SqlDataReader dataReaderSLTP = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTP.Read();
            int sLTP = dataReaderSLTP.GetInt32(0);
            dataReaderSLTP.Close();
            this.txtSLTP.Text = sLTP.ToString();

            strLenh = "SELECT * FROM V_SLTG";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if (Program.mGroup.Equals("QUANLI"))
            {
                if (sLTP > 0 || slTG == 0)
                {
                    this.btnXoa.Enabled = false;
                }
                else this.btnXoa.Enabled = true;
            }
            else this.btnXoa.Enabled = false;
            
            if (this.txtMaTacGia.Text.Length == 0 && suKien.Equals("THEM"))
            {
                this.btnXoa.Enabled = false;
                this.txtMaTacGia.Enabled = true;
            }
            if (pathImage.Trim().Length != 0)
            {
                Image image = Image.FromFile(@"" + Application.StartupPath + "\\Resources\\" + pathImage);
                //MessageBox.Show(pathImage);
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                this.pnlAnh.AddControl(pictureBox);
            } else
            {
                Image image = Image.FromFile(@"" + Application.StartupPath + "\\Resources\\nophoto.png");

                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                this.pnlAnh.AddControl(pictureBox);
            }
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (suKienCT.Equals("CT"))
            {
                gcTacGia.Visible = true;
                gcTacGia.Enabled = true;
                gcTacGia.Dock = DockStyle.Fill;
                groupBox1.Visible = false;
                this.btnChiTiet.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = true;
                this.btnHieuChinh.Enabled = false;
                if (Program.mGroup.Equals("QUANLI"))
                {
                    this.btnImport.Enabled = this.btnExport.Enabled = this.btnThem.Enabled = true;
                }
                    
            } else this.Close();
            suKienCT = "";
        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suKienCT = "CT";
            if (Program.mGroup.Equals("QUANLI"))
            {
                this.btnHieuChinh.Enabled = true;
            } else
            {
                this.btnHieuChinh.Enabled = false;
            }
            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = this.txtThoiDai.Enabled = false;
            this.btnImport.Enabled = this.btnExport.Enabled = this.btnThem.Enabled = this.btnChiTiet.Enabled = this.btnBackup.Enabled = this.btnRestore.Enabled = false;
            gcTacGia.Visible = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;
            
            this.lblSLTP.Visible = this.txtSLTP.Visible = true;
            
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
                    for (int i = 0; i < bdsTacGia.List.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsTacGia.List[i];
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
                    var worksheet = workbook.Worksheets.Add("Tác giả");
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
                            "dbo.TacGia";

                        // Set up the column mappings by name.
                        bulkCopy.ColumnMappings.Add("MaTacGia", "MaTacGia");

                        bulkCopy.ColumnMappings.Add("HoTen", "HoTen");

                        bulkCopy.ColumnMappings.Add("NgaySinh", "NgaySinh");

                        bulkCopy.ColumnMappings.Add("NgayMat", "NgayMat");

                        bulkCopy.ColumnMappings.Add("QuocTich", "QuocTich");

                        bulkCopy.ColumnMappings.Add("DienGiai", "DienGiai");

                        bulkCopy.ColumnMappings.Add("PhongCach", "PhongCach");

                        bulkCopy.ColumnMappings.Add("HinhAnh", "HinhAnh");

                        bulkCopy.ColumnMappings.Add("ThoiDai", "ThoiDai");

                        // Write from the source to the destination.

                        bulkCopy.WriteToServer(dataTable);

                    }
                    MessageBox.Show("Dữ liệu đã được nhập thành công từ tập tin Excel!", "Nhập từ Excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi nhập dữ liệu từ Excel: \n{ex.Message}", "Lỗi nhập từ Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.ToString());
                }
                this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
            }
        }
    }
}
