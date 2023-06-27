using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
        string maCTLPH = "";
        string tenCTLPH = "";
        DateTime timeFromPH;
        DateTime timeToPH;
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
            // TODO: This line of code loads data into the 'tPNTDataSet.CT_CuocTrienLam' table. You can move, or remove it, as needed.
            /*          this.cT_CuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CT_CuocTrienLam);*/
            // TODO: This line of code loads data into the 'tPNTDataSet1.View_ListTPNT' table. You can move, or remove it, as needed.
            this.view_ListTPNTTableAdapter.Fill(this.tPNTDataSet1.View_ListTPNT);
            // TODO: This line of code loads data into the 'tPNTDataSet.TPNT' table. You can move, or remove it, as needed.
            //this.tPNTTableAdapter.Fill(this.tPNTDataSet.TPNT);
            // TODO: This line of code loads data into the 'tPNTDataSet.CT_CuocTrienLam' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tPNTDataSet.CuocTrienLam' table. You can move, or remove it, as needed.
            this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
            if (bdsCuocTrienLam.Count <= 0)
            {
                btnChiTiet.Enabled = false;
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
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
            btnLuu.Visible = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
    
            btnReload.Enabled = true;
            grbThemCTL.Visible = false;
            DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            MaCTL = rowView["MaSoCTL"].ToString();
            Form frm = new frmChiTietCuocTienLam(MaCTL);
            frm.Show();
        }
        private void LoadCtCuocTrienLam(string MaCTL)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
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
            grbDSTPNT.Visible = false;
            btnThem.Enabled = false;
            btnChiTiet.Enabled = false;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            btnSaveData.Enabled = true;
            dtpFrom.EditValue = "01/01/2023";
            dtpTo.EditValue = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void bdsTacPhamNgheThuat_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                txtMaCTL.ReadOnly = true;
                txtTenCTL.ReadOnly = true;
                dtpFrom.ReadOnly = true;
                dtpTo.ReadOnly = true;
                grbDSTPNT.Visible = true;

            }    
          
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

            using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
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
            using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
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
            Console.Write("TEST :" + check);
            if (check == 1) return true;
            return false;
        }
        private void btnSaveData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("TEST\n");
            foreach (DataGridViewRow row in dataGridViewDanhSach.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    Console.WriteLine(cell.Value);
                }
            }

            if (hoatdong == "") return;
            if (hoatdong.Equals("THEM"))
            {

                int check = 0;
                maCTLPH = txtMaCTL.Text;
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
                if (check == 0) { MessageBox.Show("Vui Lòng CHọn ít nhất 1 tpnt"); return; }
                else
                {
                    try
                    {
                        PhucHoi = "THEM";
                        DateTime TGBD = dtpFrom.DateTime;
                        DateTime TGKT = dtpTo.DateTime;
                        using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
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
                            btnLuu.Visible = true;
                            btnHieuChinh.Enabled = true;
                            btnXoa.Enabled = true;
                            btnChiTiet.Enabled = true;
                            btnHoanTac.Enabled = true;
                            btnReload.Enabled = true;
                            MessageBox.Show("thêm Thành Công.\n" + MessageBoxButtons.OK);
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
            else if (hoatdong.Equals("HIEUCHINH"))
            {
                if (kiemTra())
                {
                    PhucHoi = "HIEUCHINH";
                    try
                    {
                        DateTime TGBD = dtpFrom.DateTime;
                        DateTime TGKT = dtpTo.DateTime;
                        using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
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
                        btnLuu.Visible = true;
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

        private void grbThemCTL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbDSTPNT_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCuocTrienLam.Count == 0 )
            {
                btnXoa.Enabled = false;
                return;
            }
            //DataRowView rowView1 = (DataRowView)bdsChiTietTacPhamNgheThuat[bdsChiTietTacPhamNgheThuat.Position];
           // string MaTP = rowView1["MaSoSP"].ToString();
            //Console.Write(MaTP);
          
            if (MessageBox.Show("Bạn có thật sự muốn xóa Cuộc Triển Lãm này? (Sẽ không thể Phục Hồi)", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    PhucHoi = "XOA";
                    DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
                    string MaCTL = rowView["MaSoCTL"].ToString();
                    using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SP_DeleteCuocTrienLam", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maCTL", MaCTL);
                            // Thực thi Stored Procedure
                            command.ExecuteNonQuery();
                        }
                    }
                        /*Step 3*/
                     
                   

                    this.cuocTrienLamTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = false;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa . Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsCuocTrienLam.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            
        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //grbThongTin.Visible = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy bỏ ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (hoatdong.Equals("THEM"))
                {
                    bdsCuocTrienLam.EndEdit();
                    bdsCuocTrienLam.RemoveCurrent();
                   
                }
                btnSaveData.Enabled = false;
                bdsCuocTrienLam.CancelEdit();
                cuocTrienLamGridControl.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Visible = true;
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
            hoatdong = "HIEUCHINH";
        
            btnSaveData.Enabled = true;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            grbNhap.Enabled = true;
            grbThemCTL.Visible = true;
            grbDSTPNT.Visible = false;
            btnChiTiet.Enabled=false;
            btnLuu.Visible = false;
            grbNhap.Text = "Cập Nhật Thông Tin";
            DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            DataRowView drv = ((DataRowView)(bdsCuocTrienLam.Current));
            txtMaCTL.ReadOnly = true;
            txtTenCTL.Text = drv["Ten"].ToString();
            txtMaCTL.Text = drv["MaSoCTL"].ToString();
            DateTime timeFrom = (DateTime)drv["NgayBD"];
            DateTime timeTo = (DateTime)drv["NgayKT"];
            tenCTLPH = drv["Ten"].ToString();
            maCTLPH= drv["MaSoCTL"].ToString();
            timeFromPH = (DateTime)drv["NgayBD"];
            timeToPH= (DateTime)drv["NgayKT"];
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
                      
                       
                        using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_DeleteCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", maCTLPH);
                                
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
                    try {
                    using (SqlConnection connection = new SqlConnection(Program.connstr_publisher))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SP_UpdateCuocTrienLam", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maCTL", maCTLPH);
                            command.Parameters.AddWithValue("@Ten",tenCTLPH);
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
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsCuocTrienLam.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
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
    }
}
