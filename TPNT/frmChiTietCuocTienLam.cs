using DevExpress.Emf;
using System;
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

namespace TPNT
{
   
    public partial class frmChiTietCuocTienLam : Form
    {
        string phuchoi = "";
        string ma = "";
        string maTPNT;
        string maTPNTPH;
        bool kt;
        
        public frmChiTietCuocTienLam(string MaCTL , bool check)
        {
           
            InitializeComponent();
            ma = MaCTL; 
            kt = check;
            btnLuu.Enabled = false;
        }
        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
           if (bdsThemChiTiet.Count <= 0)
            {
                MessageBox.Show("Không còn tác phẩm để thêm ", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            grbThemChiTiet.Visible = true;
            sP_CHITIETCUOCTRIENLAMGridControl.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHoanTac.Enabled = false;
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChiTietCTL.Count <= 0)
            {
                btnXoa.Enabled = false;
                return;
            }    
            if (MessageBox.Show("Bạn có thật sự muốn xóa tác phẩm này khỏi Cuộc Triển Lãm ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    phuchoi = "XOA";
                    DataRowView rowView = (DataRowView)bdsChiTietCTL[bdsChiTietCTL.Position];
                    maTPNT = rowView["MaSoTP"].ToString();
                    maTPNTPH =  rowView["MaSoTP"].ToString();
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SP_DeleteCTCuocTrienLam", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào Stored Procedure
                            command.Parameters.AddWithValue("@maCTL", ma);
                            command.Parameters.AddWithValue("@maTPNT", maTPNT);
 
                            // Thực thi Stored Procedure
                            command.ExecuteNonQuery();
                        }
                    }
                    /*Step 3*/
               

                    this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                    this.SP_TPNT_ChiTietCTLTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SP_TPNT_ChiTietCTLTableAdapter.Fill(this.tPNTDataSet1.SP_TPNT_ChiTietCTL, ma);
                    grbThemChiTiet.Visible = false;
                    sP_CHITIETCUOCTRIENLAMGridControl.Enabled = true;
                    btnHoanTac.Enabled = true;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                   
                    return;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if (bdsThemChiTiet.Count <= 0)
            {
                btnLuu.Enabled= false;
                return;
            }
            try
            {
                phuchoi = "THEM";
                maTPNT = ((DataRowView)bdsThemChiTiet[bdsThemChiTiet.Position])["MaSoTP"].ToString();
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_InsertCTCuocTrienLam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào Stored Procedure
                        command.Parameters.AddWithValue("@maCTL", ma);
                        command.Parameters.AddWithValue("@maTPNT", maTPNT);

                        // Thực thi Stored Procedure
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("thêm Thành Công.\n" + MessageBoxButtons.OK);
                sP_CHITIETCUOCTRIENLAMGridControl.Enabled = true;
                this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                this.SP_TPNT_ChiTietCTLTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_TPNT_ChiTietCTLTableAdapter.Fill(this.tPNTDataSet1.SP_TPNT_ChiTietCTL, ma);
                grbThemChiTiet.Visible = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                maTPNTPH = maTPNT;
                btnHoanTac.Enabled = true;
                return;
            }
            catch (Exception ex)
            {
                /*Step 4*/
                MessageBox.Show("Lỗi Thêm. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);

                return;
            }
        }

       

        private void frmChiTietCuocTienLam_Load(object sender, EventArgs e)
        {
            
            this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);

            this.SP_TPNT_ChiTietCTLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_TPNT_ChiTietCTLTableAdapter.Fill(this.tPNTDataSet1.SP_TPNT_ChiTietCTL, ma);
            if (!Program.mGroup.Equals("QUANLI") || kt == false)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHoanTac.Enabled = false;
                btnLuu.Enabled = false;
            }
               
            if (bdsChiTietCTL.Count <= 0)
            {
                btnXoa.Enabled = false;
                return;
            }
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phuchoi.Equals("THEM"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        phuchoi = "";

                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SP_DeleteCTCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", ma);
                                command.Parameters.AddWithValue("@maTPNT", maTPNTPH);
           
                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        /*Step 3*/


                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                        this.SP_TPNT_ChiTietCTLTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_TPNT_ChiTietCTLTableAdapter.Fill(this.tPNTDataSet1.SP_TPNT_ChiTietCTL, ma);

                        btnHoanTac.Enabled = false;
                        MessageBox.Show("Hoàn Tác thành công ", "Thông báo", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                        return;
                    }
                }
            }
            else if (phuchoi.Equals("XOA"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn Hoàn Tác?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SP_InsertCTCuocTrienLam", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào Stored Procedure
                                command.Parameters.AddWithValue("@maCTL", ma);
                                command.Parameters.AddWithValue("@maTPNT", maTPNTPH);

                                // Thực thi Stored Procedure
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Hoàn Tác Thành Công.\n" + MessageBoxButtons.OK);
                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);
                        this.SP_TPNT_ChiTietCTLTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_TPNT_ChiTietCTLTableAdapter.Fill(this.tPNTDataSet1.SP_TPNT_ChiTietCTL, ma);
                      
                        btnHoanTac.Enabled = false;
                        return;
                    }
                    catch (Exception ex)
                    {
                        /*Step 4*/
                        MessageBox.Show("Lỗi Hoàn Tác. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM, ma);

                        return;
                    }
                }
            }    
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.SP_CHITIETCUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_CHITIETCUOCTRIENLAMTableAdapter.Fill(this.tPNTDataSet1.SP_CHITIETCUOCTRIENLAM,ma);

                grbThemChiTiet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExitGroup_Click(object sender, EventArgs e)
        {

            grbThemChiTiet.Visible = false;
            sP_CHITIETCUOCTRIENLAMGridControl.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnHoanTac.Enabled = true;
            if (phuchoi == "")
            {
                btnHoanTac.Enabled = false;

            }
            if (bdsChiTietCTL.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }
        }
    }
}
