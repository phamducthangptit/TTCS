using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using GemBox.Spreadsheet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPNT
{
   

    public partial class frmCuocTrienLam : Form
    {
        int viTri;
        String hoatdong = "";
        String PhucHoi = "";
        string MaCTL = "";
        string maCTLPH = ""; string maCTLxoa = ""; string maCTLThem = "";
        string tenCTLPH = ""; string tenCTLxoa = "";
        DateTime timeFromPH; DateTime timeFromXoa;
        DateTime timeToPH; DateTime timeToXoa;
        List<string> tpntList = new List<string>();
      

        public frmCuocTrienLam()
        {
            InitializeComponent();
        }



        private void cuocTrienLamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCuocTrienLam.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tPNTDataSet);

        }

        private void cuocTrienLamBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCuocTrienLam.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tPNTDataSet);

        }

        private void frmCuocTrienLam_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.view_ListTPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_ListTPNTTableAdapter.Fill(this.tPNTDataSet1.View_ListTPNT);
            this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
            if (!Program.mGroup.Equals("QUANLI"))
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnHoanTac.Enabled = false;
                btnSaveData.Enabled = false;
                btnExport.Enabled = false;
                btnReport.Enabled = false;
                btnImport.Enabled = false;
            }
            if (bdsCuocTrienLam.Count <= 0)
            {
                btnChiTiet.Enabled = false;
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnExport.Enabled=false;
                btnReport.Enabled=false;
            }

        }
        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCuocTrienLam.Count <= 0)
            {
                btnChiTiet.Enabled = false;
                return;
            }
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            
            btnReload.Enabled = true;
            grbThemCTL.Visible = false;
            DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            MaCTL = rowView["MaSoCTL"].ToString();
            DateTime timeFrom = (DateTime)rowView["NgayBD"];
            bool check = true;
            if (soSanhNgay(DateTime.Today.ToString("dd/MM/yyyy"), timeFrom.ToString("dd/MM/yyyy")) <= 0)
            {
               check = false;
            }
            Form frm = new frmChiTietCuocTienLam(MaCTL,check);
            frm.Show();
        }
        private void LoadCtCuocTrienLam(string MaCTL)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    using (SqlCommand command = new SqlCommand("SP_CHITIETCUOCTRIENLAM", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("MACTL", MaCTL);

                        connection.Open();

                        // Sử dụng SqlDataAdapter để điền dữ liệu từ Stored Procedure vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        //SP_CTCTLGridControl.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            viTri = bdsCuocTrienLam.Position;
            hoatdong = "THEM";
            cuocTrienLamGridControl.Enabled = false;
            bdsCuocTrienLam.AddNew();
            //grbThongTin.Visible = false;
            grbThemCTL.Visible = true;

            
            grbNhap.Enabled = true;
           // grbDSTPNT.Visible = false;
            btnThem.Enabled = false;
            btnChiTiet.Enabled = false;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            btnImport.Enabled = false;
            btnExport.Enabled = false;
            btnReport.Enabled = false;
            btnSaveData.Enabled = true;
         
            dtpFrom.EditValue = "01/01/2023";
            dtpTo.EditValue = "01/01/2023";
        }

        private void bdsTacPhamNgheThuat_CurrentChanged(object sender, EventArgs e)
        {

        }

        
        public static string chuyenDangNgay(string s)
        {
            string[] tmp = s.Split('/');
            return tmp[2] + "/" + tmp[1] + "/" + tmp[0];
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
        private bool kiemTra()
        {
            
            if (txtMaCTL.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã số cuộc triển lãm", "Thông báo", MessageBoxButtons.OK);
                txtMaCTL.Focus();
                return false;
            }


            int check = 0; // Biến để lưu số lần xuất hiện

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_CheckMaCuocTrienLam", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("maCTL", txtMaCTL.Text);

                    SqlParameter outputParameter = new SqlParameter("@Check", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    command.ExecuteNonQuery();

                    check = (int)outputParameter.Value;
                }
            }
            if (check != 0 && hoatdong.Equals("THEM"))
            {
                MessageBox.Show("Mã này đã được sử dụng vui lòng nhập mã khác !", "Thông báo", MessageBoxButtons.OK);
                txtMaCTL.Focus();
                return false;
            }

            if (txtTenCTL.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên cuộc triển lãm", "Thông báo", MessageBoxButtons.OK);
                txtTenCTL.Focus();
                return false;
            }
      

            if (soSanhNgay (dtpFrom.Text.Trim() , dtpTo.Text.Trim()) == -1)
            {
                MessageBox.Show("Ngày Kết Thúc Không Được Nhỏ Hơn Ngày Bắt Đầu !", "Thông báo", MessageBoxButtons.OK);
        
                return false;
            } 
            if (soSanhNgay(DateTime.Today.ToString("dd/MM/yyyy"),dtpFrom.Text.Trim())<= 0)
            {
                MessageBox.Show("Ngày Bắt Đầu Phải Lớn Hơn Ngày Hiện Tại !", "Thông báo", MessageBoxButtons.OK);

                return false;
            }    
            return true;
        }
        private bool tonTai()
        {
        
            int check = 0;
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_CheckMaCuocTrienLam", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào Stored Procedure
                    command.Parameters.AddWithValue("@maCTL", txtMaCTL.Text);
                    command.Parameters.AddWithValue("@Check", check);

                    // Thực thi Stored Procedure
                    command.ExecuteNonQuery();
                }

            }
            if (check == 1) return true;
            return false;
        }
        private void btnSaveData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            if (hoatdong == "") return;
            if (hoatdong.Equals("THEM"))
            {
                if (kiemTra())
                {
                    int check = 0;

                    foreach (DataGridViewRow row in dataGridViewDanhSach.Rows)
                    {
                        DataGridViewCell cell = row.Cells[0];
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().Equals("true"))
                            {

                                check++;
                            }

                        }

                    }
                    if (check == 0) { MessageBox.Show("Vui Lòng Chọn ít nhất 1 TPNT"); return; }
                    else
                    {
                        try
                        {

                            maCTLThem = txtMaCTL.Text;
                            PhucHoi = "THEM";
                            DateTime TGBD = dtpFrom.DateTime;
                            DateTime TGKT = dtpTo.DateTime;
                            using (SqlConnection connection = new SqlConnection(Program.connstr))
                            {
                                connection.Open();

                                using (SqlCommand command = new SqlCommand("SP_InsertCuocTrienLam", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                    // Thêm các tham số vào Stored Procedure
                                    command.Parameters.AddWithValue("@maCTL", txtMaCTL.Text.Trim());
                                    command.Parameters.AddWithValue("@Ten", txtTenCTL.Text.Trim());
                                    command.Parameters.AddWithValue("@TGBD", TGBD);
                                    command.Parameters.AddWithValue("@TGKT", TGKT);

                                    // Thực thi Stored Procedure
                                    command.ExecuteNonQuery();
                                }
                                foreach (DataGridViewRow row in dataGridViewDanhSach.Rows)
                                {
                                    DataGridViewCell daChon = row.Cells[0];
                                    DataGridViewCell maTP = row.Cells[1];

                                    if (daChon.Value != null)
                                    {
                                        if (daChon.Value.ToString().Equals("true"))
                                        {
                                            using (SqlCommand command = new SqlCommand("SP_InsertCTCuocTrienLam", connection))
                                            {
                                                command.CommandType = CommandType.StoredProcedure;

                                                // Thêm các tham số vào Stored Procedure
                                                command.Parameters.AddWithValue("@maCTL", txtMaCTL.Text.Trim());
                                                command.Parameters.AddWithValue("@maTPNT", maTP.Value.ToString());

                                                // Thực thi Stored Procedure
                                                command.ExecuteNonQuery();
                                            }
                                        }

                                    }

                                }


                                grbThemCTL.Visible = false;
                                cuocTrienLamGridControl.Enabled = true;
                                btnThem.Enabled = true;
                                txtMaCTL.ReadOnly = false;
                                txtMaCTL.Text = string.Empty;
                                txtTenCTL.ReadOnly = false;
                                txtTenCTL.Text = string.Empty;
                                dtpFrom.ReadOnly = false;
                                dtpTo.ReadOnly = false;
                                btnThem.Enabled = true;
                                btnHieuChinh.Enabled = true;
                                btnXoa.Enabled = true;
                                btnChiTiet.Enabled = true;
                                btnHoanTac.Enabled = true;
                                btnReload.Enabled = true;
                                btnExport.Enabled = true;
                                btnReport.Enabled = true;
                                btnImport.Enabled = true;
                                btnSaveData.Enabled = false;
                                MessageBox.Show("Thêm Thành Công.\n" + MessageBoxButtons.OK);
                                frmCuocTrienLam_Load(sender, e);
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            // Xử lý ngoại lệ, ví dụ: in thông báo lỗi hoặc thực hiện các hành động khác
                            MessageBox.Show("Lỗi lưu Cuộc Triển Lãm.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                } 

            }
            else if (hoatdong.Equals("HIEUCHINH"))
            {
                if (kiemTra())
                {
                    PhucHoi = "HIEUCHINH";
                    try
                    {
                        DateTime TGBD = dtpFrom.DateTime;
                        DateTime TGKT = dtpTo.DateTime;
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_UpdateCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", txtMaCTL.Text.Trim());
                                command.Parameters.AddWithValue("@Ten", txtTenCTL.Text.Trim());
                                command.Parameters.AddWithValue("@NgayBD", TGBD);
                                command.Parameters.AddWithValue("@NgayKT", TGKT);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        grbThemCTL.Visible = false;
                        cuocTrienLamGridControl.Enabled = true;
                        btnThem.Enabled = true;
                        txtMaCTL.ReadOnly = false;
                        txtMaCTL.Text = string.Empty;
                        txtTenCTL.ReadOnly = false;
                        txtTenCTL.Text = string.Empty;
                        dtpFrom.ReadOnly = false;
                        dtpTo.ReadOnly = false;
                        btnThem.Enabled = true;
                        btnExport.Enabled = true;
                        btnReport.Enabled = true;
                        btnImport.Enabled = true;
                        btnHieuChinh.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHoanTac.Enabled = true;
                        btnReload.Enabled = true;
                        MessageBox.Show("Cập Nhật Thành Công.\n" + MessageBoxButtons.OK);
                        frmCuocTrienLam_Load(sender, e);
                        return;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi hiệu chỉnh Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsCuocTrienLam.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }

                }
            }
        
        }

        

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCuocTrienLam.Count == 0 )
            {
                btnXoa.Enabled = false;
                return;
            }
            DataRowView rowcheck = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            DateTime timeToCHECK = (DateTime)rowcheck["NgayKT"];
            if (soSanhNgay(DateTime.Today.ToString("dd/MM/yyyy"), timeToCHECK.ToString("dd/MM/yyyy")) <= 0)
            {
                MessageBox.Show("Cuộc Triển Lãm này đã diễn ra không thể xóa.\n", "Thông báo", MessageBoxButtons.OK);
                return;
            } 
            if (MessageBox.Show("Bạn có thật sự muốn XÓA Cuộc Triển Lãm này? (Sẽ XÓA luôn cả chi tiết Cuộc Triển Lãm)", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    PhucHoi = "XOA";
                    DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
                    string MaCTL = rowView["MaSoCTL"].ToString();
                    tenCTLxoa = rowView["Ten"].ToString();
                    maCTLxoa = rowView["MaSoCTL"].ToString();
                    timeFromXoa = (DateTime)rowView["NgayBD"];
                    timeToXoa = (DateTime)rowView["NgayKT"];
                    tpntList.Clear();
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SP_CHITIETCUOCTRIENLAM", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm đối số mã vào stored procedure
                            command.Parameters.AddWithValue("@maCTL", MaCTL);

                            // Thực thi stored procedure và đọc kết quả
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Lấy giá trị của cột mã và thêm vào danh sách
                                    string code = reader.GetString(reader.GetOrdinal("MaSoTP"));
                                    tpntList.Add(code);
                                }
                            }
                        }
                        using (SqlCommand command = new SqlCommand("SP_DeleteCuocTrienLam", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maCTL", MaCTL);
                            // Thực thi Stored Procedure
                            command.ExecuteNonQuery();
                        }
                        
                        /*Step 3*/

                        this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);

                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                        this.btnHoanTac.Enabled = true;
                        if (bdsCuocTrienLam.Count <= 0)
                        {
                            btnChiTiet.Enabled = false;
                            btnXoa.Enabled = false;
                            btnHieuChinh.Enabled = false;
                            btnExport.Enabled = false;
                            btnReport.Enabled = false;
                            btnImport.Enabled = true;
                        }    
                    }
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Lỗi xóa . Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsCuocTrienLam.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            
        }

        

        

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy bỏ ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsCuocTrienLam.CancelEdit();
                if (hoatdong.Equals("THEM"))
                {
                    bdsCuocTrienLam.EndEdit();
                    bdsCuocTrienLam.RemoveCurrent();
                   
                }
                btnSaveData.Enabled = false;
             
                cuocTrienLamGridControl.Enabled = true;
                btnThem.Enabled = true;
                btnExport.Enabled = true;
                btnReport.Enabled = true;
                btnImport.Enabled = true;
                btnHieuChinh.Enabled = true;
                btnXoa.Enabled = true;
                btnHoanTac.Enabled = true;
                btnReload.Enabled = true;
                btnChiTiet.Enabled = true;
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
                // Xóa hàng vừa thêm
                btnThem.Enabled = true;
                grbThemCTL.Visible = false;
                txtMaCTL.Text = string.Empty;
                txtTenCTL.Text = string.Empty;
                txtMaCTL.ReadOnly = false;
                txtTenCTL.ReadOnly = false;
                if (PhucHoi == "")
                {
                    btnHoanTac.Enabled = false;

                }
                if (bdsCuocTrienLam.Count == 0)
                {
                    btnXoa.Enabled = false;
                    btnHieuChinh.Enabled = false;
                    btnChiTiet.Enabled=false;
                    return;
                }
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsCuocTrienLam.Count <= 0 )
            {
                btnHieuChinh.Enabled = false;
                return;
            }
            DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            DataRowView drv = ((DataRowView)(bdsCuocTrienLam.Current));
            timeFromPH = (DateTime)drv["NgayBD"];
            timeToPH = (DateTime)drv["NgayKT"];
            if (soSanhNgay(DateTime.Today.ToString("dd/MM/yyyy"), timeFromPH.ToString("dd/MM/yyyy")) <= 0)
            {
                MessageBox.Show("Cuộc Triển Lãm này đã diễn ra không thể hiệu chỉnh.\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            hoatdong = "HIEUCHINH";
        
            btnSaveData.Enabled = true;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            grbNhap.Enabled = true;
            btnExport.Enabled = false;
            btnReport.Enabled = false;
            btnImport.Enabled = false;
            grbThemCTL.Visible = true;
            grbDSTPNT.Visible = false;
            btnChiTiet.Enabled=false;
          
            grbNhap.Text = "Cập Nhật Thông Tin";
            txtMaCTL.ReadOnly = true;
            txtTenCTL.Text = drv["Ten"].ToString();
            txtMaCTL.Text = drv["MaSoCTL"].ToString();
            DateTime timeFrom = (DateTime)drv["NgayBD"];
            DateTime timeTo = (DateTime)drv["NgayKT"];
            tenCTLPH = drv["Ten"].ToString();
            maCTLPH= drv["MaSoCTL"].ToString();
            
            dtpFrom.EditValue = timeFrom.ToString("dd/MM/yyyy");
            dtpTo.EditValue = timeTo.ToString("dd/MM/yyyy");
            txtTenCTL.Focus();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( PhucHoi == "")
            {
                btnHoanTac.Enabled = false;
                return;
                
            }
            if (PhucHoi.Equals("THEM"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {


                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_DeleteCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", maCTLThem);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        /*Step 3*/


                        this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                        frmCuocTrienLam_Load(sender, e);
                        MessageBox.Show("Hoàn Tác thành công ", "Thông báo", MessageBoxButtons.OK);
                        this.btnHoanTac.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsCuocTrienLam.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }
                }
            }

            else if (PhucHoi.Equals("HIEUCHINH"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_UpdateCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", maCTLPH);
                                command.Parameters.AddWithValue("@Ten", tenCTLPH);
                                command.Parameters.AddWithValue("@NgayBD", timeFromPH);
                                command.Parameters.AddWithValue("@NgayKT", timeToPH);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        btnHoanTac.Enabled = false;
                        MessageBox.Show("Hoàn Tác Thành Công.\n" + MessageBoxButtons.OK);
                        frmCuocTrienLam_Load(sender, e);
                        return;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsCuocTrienLam.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }
                }
            }
            else if (PhucHoi.Equals("XOA"))
            {
                  
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                 
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                           
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_InsertCuocTrienLam", connection))
                            {

                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", maCTLxoa);
                                command.Parameters.AddWithValue("@Ten", tenCTLxoa);
                                command.Parameters.AddWithValue("@TGBD", timeFromXoa);
                                command.Parameters.AddWithValue("@TGKT", timeToXoa);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                            foreach (string maTPNT in tpntList)
                            {
                               

                               
                                        using (SqlCommand command = new SqlCommand("SP_InsertCTCuocTrienLam", connection))
                                        {
                                            command.CommandType = CommandType.StoredProcedure;

                                            // Thêm các tham số vào Stored Procedure
                                            command.Parameters.AddWithValue("@maCTL", maCTLxoa);
                                            command.Parameters.AddWithValue("@maTPNT", maTPNT);

                                            // Thực thi Stored Procedure
                                            command.ExecuteNonQuery();
                                        }
                                   
                            }
                   
                            btnHoanTac.Enabled = false;
                            PhucHoi = "";
                            btnChiTiet.Enabled = true;
                            btnXoa.Enabled = true;
                            btnHieuChinh.Enabled = true;
                            btnExport.Enabled = true;
                            btnReport.Enabled = true;
                            tpntList.Clear();
                            MessageBox.Show("Hoàn Tác Thành Công.\n" + MessageBoxButtons.OK);

                            frmCuocTrienLam_Load(sender, e);
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        
                        // Xử lý ngoại lệ, ví dụ: in thông báo lỗi hoặc thực hiện các hành động khác
                        MessageBox.Show("Lỗi hoàn tác Cuộc Triển Lãm.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsCuocTrienLam.Position;

            try
            {
                this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                bdsCuocTrienLam.Position = viTri;
                grbThemCTL.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
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
                    for (int i = 0; i < bdsCuocTrienLam.List.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsCuocTrienLam.List[i];
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
                    var worksheet = workbook.Worksheets.Add("Danh sách cuộc tiển lãm");
                    worksheet.InsertDataTable(dataTable,
                            new InsertDataTableOptions()
                            {
                                ColumnHeaders = true,
                                StartRow = 0
                            });
                    for (int i = 0; i < bdsCuocTrienLam.List.Count; i++)
                    {
                        string maCTLex = ((DataRowView)bdsCuocTrienLam.List[i])["MaSoCTL"].ToString();
                        string sql1 = "EXEC SP_CT_CTL '" + maCTLex + "'";
                        DataTable dt1 = Program.ExecSqlDataTable(sql1);
                        var worksheet1 = workbook.Worksheets.Add(maCTLex);
                        worksheet1.InsertDataTable(dt1,
                                new InsertDataTableOptions()
                                {
                                    ColumnHeaders = true,
                                    StartRow = 0
                                });
                    }


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

                DataTable dataTable = new DataTable();
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

                // Đọc file Excel.
                ExcelFile workbook = ExcelFile.Load(openFileDialog.FileName);

                // Lấy sheet đầu tiên trong workbook.
                ExcelWorksheet worksheet = workbook.Worksheets[0];

                int sheetCount = workbook.Worksheets.Count;
                // Lấy số lượng hàng và cột trong sheet.
                int rowCount = worksheet.Rows.Count;
                int columnCount = worksheet.CalculateMaxUsedColumns();

                // Lấy danh sách cột từ hàng đầu tiên trong bảng tính và thêm chúng vào DataTable
                for (int column = 0; column < columnCount; column++)
                {
                    string columnName = worksheet.Cells[0, column].Value?.ToString();
                    dataTable.Columns.Add(columnName, typeof(object));
                }

                // Đọc dữ liệu từ các ô trong bảng tính và thêm vào DataTable
                for (int row = 1; row < rowCount; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int column = 0; column < columnCount; column++)
                    {
                        dataRow[column] = worksheet.Cells[row, column].Value?.ToString();
                    }
                    dataTable.Rows.Add(dataRow);
                }
                DataTable dataTable1 = new DataTable();
                if (sheetCount > 1)
                {
                    ExcelWorksheet worksheet1 = workbook.Worksheets[1];


                    // Lấy số lượng hàng và cột trong sheet.
                    int rowCount1 = worksheet1.Rows.Count;
                    int columnCount1 = worksheet1.CalculateMaxUsedColumns();

                    // Lấy danh sách cột từ hàng đầu tiên trong bảng tính và thêm chúng vào DataTable
                    for (int column = 0; column < columnCount1; column++)
                    {
                        string columnName = worksheet1.Cells[0, column].Value?.ToString();
                        dataTable1.Columns.Add(columnName, typeof(object));
                    }

                    // Đọc dữ liệu từ các ô trong bảng tính và thêm vào DataTable
                    for (int row = 1; row < rowCount1; row++)
                    {
                        DataRow dataRow = dataTable1.NewRow();
                        for (int column = 0; column < columnCount1; column++)
                        {
                            dataRow[column] = worksheet1.Cells[row, column].Value?.ToString();
                        }
                        dataTable1.Rows.Add(dataRow);
                    }
                    for (int i = 2; i < sheetCount; i++)
                    {
                        worksheet1 = workbook.Worksheets[i];


                        // Lấy số lượng hàng và cột trong sheet.
                        rowCount1 = worksheet1.Rows.Count;
                        columnCount1 = worksheet1.CalculateMaxUsedColumns();
                        for (int row = 1; row < rowCount1; row++)
                        {
                            DataRow dataRow = dataTable1.NewRow();
                            for (int column = 0; column < columnCount1; column++)
                            {
                                dataRow[column] = worksheet1.Cells[row, column].Value?.ToString();
                            }
                            dataTable1.Rows.Add(dataRow);
                        }
                    }
                }
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    { 
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.DestinationTableName =
                                "dbo.CuocTrienLam";

                            // Set up the column mappings by name.
                            SqlBulkCopyColumnMapping ma =
                                new SqlBulkCopyColumnMapping("MaSoCTL", "MaSoCTL");
                            bulkCopy.ColumnMappings.Add(ma);

                            SqlBulkCopyColumnMapping ten =
                                new SqlBulkCopyColumnMapping("Ten", "Ten");
                            bulkCopy.ColumnMappings.Add(ten);

                            SqlBulkCopyColumnMapping ngayBD =
                                new SqlBulkCopyColumnMapping("NgayBD", "NgayBD");
                            bulkCopy.ColumnMappings.Add(ngayBD);

                            SqlBulkCopyColumnMapping ngayKT =
                                new SqlBulkCopyColumnMapping("NgayKT", "NgayKT");
                            bulkCopy.ColumnMappings.Add(ngayKT);

                            // Write from the source to the destination.

                            bulkCopy.WriteToServer(dataTable);
                            if (sheetCount > 1)
                            {
                                bulkCopy.DestinationTableName =
                                    "dbo.CT_CuocTrienLam";
                                bulkCopy.ColumnMappings.Clear();
                                // Set up the column mappings by name.

                                bulkCopy.ColumnMappings.Add("MaSoCTL", "MaSoCTL");

                                bulkCopy.ColumnMappings.Add("MaSoTP", "MaSoTP");

                                bulkCopy.WriteToServer(dataTable1);
                            }
                            transaction.Commit();

                        }
                        MessageBox.Show("Dữ liệu đã được nhập thành công từ tập tin Excel!", "Nhập từ Excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExport.Enabled = true;
                        btnReport.Enabled = true;
                        btnChiTiet.Enabled = true;
                        btnHieuChinh.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHoanTac.Enabled = false;
                        PhucHoi = "";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Đã xảy ra lỗi khi nhập dữ liệu từ Excel: \n{ex.Message}", "Lỗi nhập từ Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                tPNTDataSet.EnforceConstraints = false;

                this.view_ListTPNTTableAdapter.Fill(this.tPNTDataSet1.View_ListTPNT);

                this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
            }
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmRPCuocTrienLam();
            frm.Show();
        }
    }
}
