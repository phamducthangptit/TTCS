using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmTaiSanBaoTang : Form
    {
        String hoatDong = "";
        String PhucHoi = "";
        String TinhTrang;
        String maSoTPPH; String maSoTPThem;
        String TriGia;
        DateTime TimeSoHuuPH;
        String TinhTrangXoa;
        String maSoTPXoa;
        String TriGiaXoa;

        DateTime TimeSoHuuXoa;

        int viTri;

        public frmTaiSanBaoTang()
        {
            InitializeComponent();
        }

        private void frmTaiSanBaoTang_Load(object sender, EventArgs e)
        {
            tPNTDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tPNTDataSet1.View_ListLoaiSoHuu' table. You can move, or remove it, as needed.
            this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
            // TODO: This line of code loads data into the 'tPNTDataSet1.View_ListLoaiSoHuu' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'tPNTDataSet1.view_NullSoHuu' table. You can move, or remove it, as needed.
            // this.view_NullSoHuuTableAdapter.Fill(this.tPNTDataSet1.view_NullSoHuu);
            if (!Program.mGroup.Equals("QUANLI"))
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnHoanTac.Enabled = false;
                btnLuu.Enabled = false;
            }
            if (bdsLoaiSoHuu.Count == 0)
            {
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
              
            }
          
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            
            frmChonTPNTSoHuu frmChon = new frmChonTPNTSoHuu();
            frmChon.ShowDialog();
            if (Program.maSoTPNT.Equals(""))
            {
                return;
            }
            hoatDong = "THEM";
            bdsLoaiSoHuu.AddNew();
            view_ListLoaiSoHuuGridControl.Enabled = false;
            btnLuu.Enabled = true;
            groupThongTin.Visible = true;
            groupThongTin.Enabled = true;
            groupThongTin.Text = "Thêm Thông Tin";
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnHoanTac.Enabled = false;
            txtMaTP.Text = Program.maSoTPNT;
            txtTenTP.Text = Program.TenTPNT;
            btnChonLai.Enabled = true;
            btnChonLai.Visible = true;
            dtpSoHuu.EditValue = "01/01/2023";


        }

        private void btnChonLai_Click(object sender, EventArgs e)
        {
            
                frmChonTPNTSoHuu frmChon = new frmChonTPNTSoHuu();
                frmChon.ShowDialog();
                txtMaTP.Text = Program.maSoTPNT;
                txtTenTP.Text = Program.TenTPNT;
            
        }
        private bool kiemTra()
        {
            if (txtTrangThai.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Trạng Thái", "Thông báo", MessageBoxButtons.OK);
                txtTrangThai.Focus();
                return false;
            }



            if (txtTriGia.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Trị Giá", "Thông báo", MessageBoxButtons.OK);
                txtTriGia.Focus();
                return false;
            }
           if (int.Parse(txtTriGia.Text) <= 0)
            {
                MessageBox.Show("Trị Giá phải lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK);
                txtTriGia.Focus();
                return false;
            }    

            return true;
        }



        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hoatDong.Equals("THEM"))
            {
                if (kiemTra())
                {
                    PhucHoi = "THEM"; maSoTPThem = txtMaTP.Text;
                    DateTime timeSoHuu = dtpSoHuu.DateTime;
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                          
                            using (SqlCommand command = new SqlCommand("SP_InsertLoaiSoHuu", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", txtMaTP.Text);
                                command.Parameters.AddWithValue("@NgaySoHuu", timeSoHuu);
                                command.Parameters.AddWithValue("@TinhTrang", txtTrangThai.Text);
                                command.Parameters.AddWithValue("@TriGia", int.Parse(txtTriGia.Text));

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                            groupThongTin.Visible = false;

                            btnThem.Enabled = true;
                            btnHieuChinh.Enabled = true;
                            btnXoa.Enabled = true;
                            btnHoanTac.Enabled = true;
                            btnReload.Enabled = true;
                            btnLuu.Enabled = false;
                            txtMaTP.Text = string.Empty;
                            txtTenTP.Text = string.Empty;
                            txtTrangThai.Text = string.Empty;
                            txtTriGia.Text = string.Empty;
                            MessageBox.Show("Thêm Thành Công.\n" + MessageBoxButtons.OK);
                            view_ListLoaiSoHuuGridControl.Enabled = true;
                            frmTaiSanBaoTang_Load(sender, e);
                            hoatDong = "";
                            Program.maSoTPNT = "";
                            Program.TenTPNT = "";
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ, ví dụ: in thông báo lỗi hoặc thực hiện các hành động khác
                        MessageBox.Show("Lỗi thêm thông tin .\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
            if (hoatDong.Equals("HIEUCHINH"))
            {
                if (kiemTra())
                {
                    DateTime timeSoHuu = dtpSoHuu.DateTime;
                    try
                    {

                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_UpdateLoaiSoHuu", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", txtMaTP.Text);
                                command.Parameters.AddWithValue("@NgaySoHuu", timeSoHuu);
                                command.Parameters.AddWithValue("@TinhTrang", txtTrangThai.Text);
                                command.Parameters.AddWithValue("@TriGia", int.Parse(txtTriGia.Text));

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        view_ListLoaiSoHuuGridControl.Enabled = true;
                        /*Step 3*/
                        viTri = bdsLoaiSoHuu.Position;
                        btnThem.Enabled = true;
                        btnHieuChinh.Enabled = true;
                        btnXoa.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHoanTac.Enabled = true;
                        btnReload.Enabled = true;
                        txtMaTP.Text = string.Empty;
                        txtTenTP.Text = string.Empty;
                        txtTrangThai.Text = string.Empty;
                        txtTriGia.Text = string.Empty;
                        groupThongTin.Visible = false;
                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsLoaiSoHuu.Position = viTri;
                        hoatDong = "";
                        PhucHoi = "HIEUCHINH";
                        MessageBox.Show("Cập Nhật Thành Công ", "Thông báo", MessageBoxButtons.OK);
                       
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hiệu Chỉnh. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsLoaiSoHuu.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }

                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLoaiSoHuu.Position;

            try
            {
                this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                bdsLoaiSoHuu.Position = viTri;
                groupThongTin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsLoaiSoHuu.Count == 0)
            {
                btnHieuChinh.Enabled = false;
                return;
            }
            view_ListLoaiSoHuuGridControl.Enabled = false;
            hoatDong = "HIEUCHINH";
            
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            groupThongTin.Enabled = true;
            groupThongTin.Visible = true;
            groupThongTin.Text = "Cập Nhật Thông Tin";
            DataRowView rowView = (DataRowView)bdsLoaiSoHuu[bdsLoaiSoHuu.Position];
            DataRowView drv = ((DataRowView)(bdsLoaiSoHuu.Current));
            txtTrangThai.Text = drv["Tình Trạng"].ToString();
            txtMaTP.Text = drv["Mã tác phẩm"].ToString();
            txtTenTP.Text = drv["Tên tác phẩm"].ToString();
            txtTriGia.Text = drv["Trị giá"].ToString();
            DateTime TimeSoHuu = (DateTime)drv["Ngày sở hữu"];
            TinhTrang = drv["Tình Trạng"].ToString();
            maSoTPPH= drv["Mã tác phẩm"].ToString();
            TriGia = drv["Trị giá"].ToString();
            TimeSoHuuPH = (DateTime)drv["Ngày sở hữu"];
            dtpSoHuu.EditValue = TimeSoHuu.ToString("dd-MM-yyyy");
            btnChonLai.Visible = false;
            btnChonLai.Enabled = false;
            viTri = bdsLoaiSoHuu.Position;
           
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLoaiSoHuu.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PhucHoi = "XOA";
                try
                {
                  
                    DataRowView rowView = (DataRowView)bdsLoaiSoHuu[bdsLoaiSoHuu.Position];
                    string maTPNT = rowView["Mã tác phẩm"].ToString();
                    TinhTrangXoa = rowView["Tình Trạng"].ToString();
                    maSoTPXoa = rowView["Mã tác phẩm"].ToString();
                    TriGiaXoa = rowView["Trị giá"].ToString();
                    TimeSoHuuXoa = (DateTime)rowView["Ngày sở hữu"];
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SP_DeleteLoaiSoHuu", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maTPNT", maTPNT);
                            // Thực thi Stored Procedure
                            command.ExecuteNonQuery();
                        }
                    }
                    /*Step 3*/
                    viTri = bdsLoaiSoHuu.Position;
                    bdsLoaiSoHuu.RemoveCurrent();

                    this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;


                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    hoatDong = "";
                    this.btnHoanTac.Enabled = true;
                    if (bdsLoaiSoHuu.Count <= 0)
                    {
                        btnXoa.Enabled = false;
                        btnHieuChinh.Enabled = false;
                    }    
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Lỗi xóa thông tin. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsLoaiSoHuu.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
        }

        private void btnExitGroup_Click(object sender, EventArgs e)
        {
            groupThongTin.Visible = false;
            groupThongTin.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHieuChinh.Enabled = true;
            btnReload.Enabled = true;
            btnHoanTac.Enabled = true;
            view_ListLoaiSoHuuGridControl.Enabled = true;
            if (hoatDong.Equals("THEM"))
            {
                bdsLoaiSoHuu.RemoveCurrent();
                bdsLoaiSoHuu.CancelEdit();
            }
            hoatDong = "";
            Program.maSoTPNT = "";
            Program.TenTPNT = "";
            if (bdsLoaiSoHuu.Count == 0)
            {
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
                return;
            }
            if (PhucHoi == "")
            {
                btnHoanTac.Enabled = false;

            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PhucHoi.Equals("THEM"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_DeleteLoaiSoHuu", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", maSoTPThem);
                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        /*Step 3*/
                        viTri = bdsLoaiSoHuu.Position;
                        bdsLoaiSoHuu.RemoveCurrent();

                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;


                        MessageBox.Show("Hoàn Tác thành công ", "Thông báo", MessageBoxButtons.OK);
                        PhucHoi = "";
                        this.btnHoanTac.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsLoaiSoHuu.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }
                }
            }
            else if (PhucHoi.Equals("HIEUCHINH"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {

                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_UpdateLoaiSoHuu", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT",maSoTPPH);
                                command.Parameters.AddWithValue("@NgaySoHuu", TimeSoHuuPH);
                                command.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                                command.Parameters.AddWithValue("@TriGia", int.Parse(TriGia));

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        view_ListLoaiSoHuuGridControl.Enabled = true;
                        /*Step 3*/


                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsLoaiSoHuu.Position = viTri;
                        PhucHoi = "";
                        MessageBox.Show("Hoàn Tác Thành Công ", "Thông báo", MessageBoxButtons.OK);
                        this.btnHoanTac.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListLoaiSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListLoaiSoHuuTableAdapter.Fill(this.tPNTDataSet1.View_ListLoaiSoHuu);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsLoaiSoHuu.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }
                }
            }
            else if (PhucHoi.Equals("XOA"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_InsertLoaiSoHuu", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", maSoTPXoa);
                                command.Parameters.AddWithValue("@NgaySoHuu", TimeSoHuuXoa);
                                command.Parameters.AddWithValue("@TinhTrang",TinhTrangXoa);
                                command.Parameters.AddWithValue("@TriGia", int.Parse(TriGiaXoa));

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                            groupThongTin.Visible = false;

                           
                            MessageBox.Show("Hoàn Tác Thành Công.\n" + MessageBoxButtons.OK);
                            view_ListLoaiSoHuuGridControl.Enabled = true;
                            frmTaiSanBaoTang_Load(sender, e);
                            PhucHoi = "";
                            this.btnHoanTac.Enabled = false;
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ, ví dụ: in thông báo lỗi hoặc thực hiện các hành động khác
                        MessageBox.Show("Lỗi Hoàn Tác .\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không Thể Hoàn Tác .\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
                

        }
    }
}
