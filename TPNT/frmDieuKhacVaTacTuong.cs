using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmDieuKhacVaTacTuong : Form
    {
        String hoatDong = "";
        String PhucHoi = "";
        String maSoTPNTPH = ""; String maSoTPNTXoa = ""; String maSoTPNTThem = "";
        String ChieuCao; String ChieuCaoXoa;
        String KhoiLuong; String KhoiLuongXoa;
        String PhongCach; String PhongCachXoa;
        String VatLieu; String VatLieuXoa;
        int viTri;
        public frmDieuKhacVaTacTuong()
        {
            InitializeComponent();
        }

        private void frmDieuKhacVaTacTuong_Load(object sender, EventArgs e)
        {
            tPNTDataSet1.EnforceConstraints = false;
            this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tPNTDataSet1.View_ListDieuKhacTacTuong' table. You can move, or remove it, as needed.
            this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
            if (!Program.mGroup.Equals("QUANLI"))
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnHoanTac.Enabled = false;
                btnLuu.Enabled = false; 
            }
            if (bdsDieuKhacTacTuong.Count == 0)
            {
                btnXoa.Enabled = false;
                btnHieuChinh.Enabled = false;

            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {



            frmChonTPNTNullSangTac frmChon = new frmChonTPNTNullSangTac();

            frmChon.ShowDialog();
            if (Program.maSoTPNT.Equals(""))
            {
                return;
            }
            hoatDong = "THEM";
            view_ListDieuKhacTacTuongGridControl.Enabled = false;
            bdsDieuKhacTacTuong.AddNew();
            groupThongTin.Visible = true;
            groupThongTin.Enabled = true;
            groupThongTin.Text = "Thêm Thông Tin";
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHoanTac.Enabled = false;
            txtMaSoTP.Text = Program.maSoTPNT;
            txtTenTacPham.Text = Program.TenTPNT;
            btnChonLai.Enabled = true;
            btnChonLai.Visible = true;
            txtKhoiLuong.Focus();
        }

        private void btnChonLai_Click(object sender, EventArgs e)
        {
            frmChonTPNTNullSangTac frmChon = new frmChonTPNTNullSangTac();
            frmChon.ShowDialog();
            txtMaSoTP.Text = Program.maSoTPNT;
            txtTenTacPham.Text = Program.TenTPNT;
        }
        private bool kiemTra()
        {
            if (txtKhoiLuong.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Khối Lượng", "Thông báo", MessageBoxButtons.OK);
                txtKhoiLuong.Focus();
                return false;
            }



            if (txtVatLieu.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Vật Liệu", "Thông báo", MessageBoxButtons.OK);
                txtVatLieu.Focus();
                return false;
            }
            if (txtChieuCao.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Chiều Cao", "Thông báo", MessageBoxButtons.OK);
                txtChieuCao.Focus();
                return false;
            }
            if (txtPhongCach.Text == "")
            {
                MessageBox.Show("Không bỏ trống ô Phong Cách", "Thông báo", MessageBoxButtons.OK);
                txtPhongCach.Focus();
                return false;
            }
            if (int.Parse(txtKhoiLuong.Text) <= 0)
            {
                MessageBox.Show("Khối Lượng phải lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK);
                txtKhoiLuong.Focus();
                return false;
            }
            if (int.Parse(txtChieuCao.Text) <= 0)
            {
                MessageBox.Show("Chiều Cao phải lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK);
                txtChieuCao.Focus();
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
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_InsertDieuKhacVaTacTuong", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", txtMaSoTP.Text);
                                command.Parameters.AddWithValue("@KhoiLuong", float.Parse(txtKhoiLuong.Text));
                                command.Parameters.AddWithValue("@VatLieu", txtVatLieu.Text);
                                command.Parameters.AddWithValue("@ChieuCao", float.Parse(txtChieuCao.Text));
                                command.Parameters.AddWithValue("@PhongCach", txtPhongCach.Text);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                            maSoTPNTThem = txtMaSoTP.Text;
                            groupThongTin.Visible = false;

                            btnThem.Enabled = true;
                            btnHieuChinh.Enabled = true;
                            btnXoa.Enabled = true;
                            btnHoanTac.Enabled = true;
                            btnLuu.Enabled = false;
                            btnReload.Enabled = true;
                            txtMaSoTP.Text = string.Empty;
                            txtTenTacPham.Text = string.Empty;
                            txtKhoiLuong.Text = string.Empty;
                            txtChieuCao.Text = string.Empty;
                            txtPhongCach.Text = string.Empty;
                            txtVatLieu.Text = string.Empty;
                            MessageBox.Show("Thêm Thành Công.\n" + MessageBoxButtons.OK);
                            view_ListDieuKhacTacTuongGridControl.Enabled = true;
                            frmDieuKhacVaTacTuong_Load(sender, e);
                            hoatDong = "";
                            Program.maSoTPNT = "";
                            Program.TenTPNT = "";
                            btnHoanTac.Enabled = true;
                            PhucHoi = "THEM";
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ, ví dụ: in thông báo lỗi hoặc thực hiện các hành động khác
                        MessageBox.Show("Lỗi lưu sáng tác .\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
            if (hoatDong.Equals("HIEUCHINH"))
            {
                if (kiemTra())
                {
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_UpdateDieuKhacVaTacTuong", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", txtMaSoTP.Text);
                                command.Parameters.AddWithValue("@KhoiLuong", float.Parse(txtKhoiLuong.Text));
                                command.Parameters.AddWithValue("@VatLieu", txtVatLieu.Text);
                                command.Parameters.AddWithValue("@ChieuCao", float.Parse(txtChieuCao.Text));
                                command.Parameters.AddWithValue("@PhongCach", txtPhongCach.Text);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        view_ListDieuKhacTacTuongGridControl.Enabled = true;
                        /*Step 3*/
                        viTri = bdsDieuKhacTacTuong.Position;
                        btnThem.Enabled = true;
                        btnHieuChinh.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHoanTac.Enabled = true;
                        btnLuu.Enabled = false;
                        btnReload.Enabled = true;
                        txtMaSoTP.Text = string.Empty;
                        txtTenTacPham.Text = string.Empty;
                        txtKhoiLuong.Text = string.Empty;
                        txtChieuCao.Text = string.Empty;
                        txtPhongCach.Text = string.Empty;
                        txtVatLieu.Text = string.Empty;
                        groupThongTin.Visible = false;
                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsDieuKhacTacTuong.Position = viTri;
                        hoatDong = "";
                        MessageBox.Show("Cập Nhật Thành Công ", "Thông báo", MessageBoxButtons.OK);
                        this.btnHoanTac.Enabled = true;
                        PhucHoi = "HIEUCHINH";
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hiệu Chỉnh. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsDieuKhacTacTuong.Position = viTri;
                        //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                        return;
                    }

                }

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDieuKhacTacTuong.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                try
                {
                    DataRowView rowView = (DataRowView)bdsDieuKhacTacTuong[bdsDieuKhacTacTuong.Position];
                    string maTPNT = rowView["MaSoTP"].ToString();
                    KhoiLuongXoa = rowView["KhoiLuong"].ToString();
                    maSoTPNTXoa = rowView["MaSoTP"].ToString();
                    ChieuCaoXoa = rowView["ChieuCao"].ToString();
                    VatLieuXoa = rowView["VatLieu"].ToString();
                    PhongCachXoa = rowView["PhongCach"].ToString();
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SP_DeleteDieuKhacVaTacTuong", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maTPNT", maTPNT);
                            // Thực thi Stored Procedure
                            command.ExecuteNonQuery();
                        }
                    }
                    /*Step 3*/
                    viTri = bdsDieuKhacTacTuong.Position;


                    this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    hoatDong = "";
                    this.btnHoanTac.Enabled = true;
                    PhucHoi = "XOA";
                    if (bdsDieuKhacTacTuong.Count <= 0)
                    {
                        btnXoa.Enabled = false;
                        btnHieuChinh.Enabled = false;
                    }    
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Lỗi xóa thông tin. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsDieuKhacTacTuong.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDieuKhacTacTuong.Count == 0)
            {
                btnHieuChinh.Enabled = false;
                return;
            }
            view_ListDieuKhacTacTuongGridControl.Enabled = false;
            hoatDong = "HIEUCHINH";

            btnLuu.Enabled = true;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHoanTac.Enabled = false;
            btnReload.Enabled = false;
            groupThongTin.Enabled = true;
            groupThongTin.Visible = true;
            groupThongTin.Text = "Cập Nhật Thông Tin";
            DataRowView rowView = (DataRowView)bdsDieuKhacTacTuong[bdsDieuKhacTacTuong.Position];
            DataRowView drv = ((DataRowView)(bdsDieuKhacTacTuong.Current));
            txtKhoiLuong.Text = drv["KhoiLuong"].ToString();
            txtMaSoTP.Text = drv["MaSoTP"].ToString();
            txtTenTacPham.Text = drv["TenTP"].ToString();
            txtChieuCao.Text = drv["ChieuCao"].ToString();
            txtVatLieu.Text = drv["VatLieu"].ToString();
            txtPhongCach.Text = drv["PhongCach"].ToString();

            KhoiLuong = drv["KhoiLuong"].ToString();
            maSoTPNTPH = drv["MaSoTP"].ToString();
            ChieuCao = drv["ChieuCao"].ToString();
            VatLieu = drv["VatLieu"].ToString();
            PhongCach = drv["PhongCach"].ToString();
            btnChonLai.Visible = false;
            btnChonLai.Enabled = false;
            viTri = bdsDieuKhacTacTuong.Position;
            txtKhoiLuong.Focus();
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
            view_ListDieuKhacTacTuongGridControl.Enabled = true;
            if (hoatDong.Equals("THEM"))
            {
                bdsDieuKhacTacTuong.RemoveCurrent();
                bdsDieuKhacTacTuong.CancelEdit();
            }
            hoatDong = "";
            Program.maSoTPNT = "";
            Program.TenTPNT = "";
            if (bdsDieuKhacTacTuong.Count == 0)
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

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDieuKhacTacTuong.Position;

            try
            {
                this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                bdsDieuKhacTacTuong.Position = viTri;
                groupThongTin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PhucHoi.Equals("THEM"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác ?" , "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {

                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_DeleteDieuKhacVaTacTuong", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", maSoTPNTThem);
                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        /*Step 3*/



                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;

                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        MessageBox.Show("Hoàn Tác thành công " , "Thông báo", MessageBoxButtons.OK);
                        PhucHoi = "";
                        btnHoanTac.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsDieuKhacTacTuong.Position = viTri;
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

                            using (SqlCommand command = new SqlCommand("SP_UpdateDieuKhacVaTacTuong", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", maSoTPNTPH);
                                command.Parameters.AddWithValue("@KhoiLuong", float.Parse(KhoiLuong));
                                command.Parameters.AddWithValue("@VatLieu", VatLieu);
                                command.Parameters.AddWithValue("@ChieuCao", float.Parse(ChieuCao));
                                command.Parameters.AddWithValue("@PhongCach", PhongCach);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        view_ListDieuKhacTacTuongGridControl.Enabled = true;
                        /*Step 3*/


                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsDieuKhacTacTuong.Position = viTri;
                        PhucHoi = "";
                        MessageBox.Show("Hoàn Tác Thành Công ", "Thông báo", MessageBoxButtons.OK);
                        btnHoanTac.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        this.view_ListDieuKhacTacTuongTableAdapter.Connection.ConnectionString = Program.connstr;
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.view_ListDieuKhacTacTuongTableAdapter.Fill(this.tPNTDataSet1.View_ListDieuKhacTacTuong);
                        // tro ve vi tri cua nhan vien dang bi loi
                        bdsDieuKhacTacTuong.Position = viTri;
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

                            using (SqlCommand command = new SqlCommand("SP_InsertDieuKhacVaTacTuong", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maTPNT", maSoTPNTXoa);
                                command.Parameters.AddWithValue("@KhoiLuong", float.Parse(KhoiLuongXoa));
                                command.Parameters.AddWithValue("@VatLieu", VatLieuXoa);
                                command.Parameters.AddWithValue("@ChieuCao", float.Parse(ChieuCaoXoa));
                                command.Parameters.AddWithValue("@PhongCach", PhongCachXoa);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                            groupThongTin.Visible = false;


                            MessageBox.Show("Hoàn Tác Thành Công.\n" + MessageBoxButtons.OK);
                            view_ListDieuKhacTacTuongGridControl.Enabled = true;
                            frmDieuKhacVaTacTuong_Load(sender, e);
                            PhucHoi = "";
                            btnHoanTac.Enabled = false;
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
