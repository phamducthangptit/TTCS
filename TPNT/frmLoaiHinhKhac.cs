using DevExpress.Skins;
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
    public partial class frmLoaiHinhKhac : Form
    {
        private string sukien = "";
        private int vitri = 0;
        public frmLoaiHinhKhac()
        {
            InitializeComponent();
        }

        private void frmLoaiHinhKhac_Load(object sender, EventArgs e)
        {
            this.v_SELECTLOAIHINHKHACTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_SELECTLOAIHINHKHACTableAdapter.Fill(this.tPNTDataSet.V_SELECTLOAIHINHKHAC);

            groupBox1.Visible = false;
            gcLoaiHinhKhac.Dock = DockStyle.Fill;
            if (Program.mGroup.Equals("QUANLI"))
            {
                this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnReload.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;

                string strLenh = "SELECT * FROM V_SLLHK";
                SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
                dataReaderSLTG.Read();
                int slTG = dataReaderSLTG.GetInt32(0);
                dataReaderSLTG.Close();
                if (slTG == 0)
                {
                    this.btnXoa.Enabled = this.btnHieuChinh.Enabled = false;
                }
                else this.btnXoa.Enabled = this.btnHieuChinh.Enabled = true;
            }
            else
            {
                this.btnReload.Enabled = true;
                this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnLuu.Enabled = this.btnPhucHoi.Enabled = this.btnXoa.Enabled = false;
            }

           
        }
        private Form CheckExist(Type ftype)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (ftype == f.GetType())
                {
                    return f;
                }
            }
            return null;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sukien = "THEM";
            bdsLoaiHinhKhac.AddNew();


            if (CheckExist(typeof(frmChonTacPham)) == null)
            {
                frmChonTacPham f = new frmChonTacPham();
                f.Activate();
                f.Show();

                f.FormClosed += (closedSender, args) =>
                {
                    // Lấy dữ liệu từ form mới (frmChonTacPham)
                    this.txtTen.Text = f.TenTP;
                    this.txtMa.Text = f.MaTP;
                };
            }
            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled =  false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            gcLoaiHinhKhac.Dock = DockStyle.Top;
            gcLoaiHinhKhac.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sukien = "HC";
            gcLoaiHinhKhac.Dock = DockStyle.Top;
            gcLoaiHinhKhac.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;

            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            vitri = bdsLoaiHinhKhac.Position;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã tác phẩm không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtMa.Focus();
                return;
            }
            if (this.txtTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Thể loại không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtTheLoai.Focus();
                return;
            }

            if (this.txtPhongCach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phong cách không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtPhongCach.Focus();
                return;
            }

            if (sukien.Equals("THEM"))
            {
                string strLenh = "EXEC SP_INSERTLHK '" + this.txtMa.Text + "', N'" + this.txtTheLoai.Text + "', N'" + this.txtPhongCach.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if(ex == 0) // luu thanh cong
                {
                    bdsLoaiHinhKhac.CancelEdit();
                    bdsLoaiHinhKhac.ResetCurrentItem();
                    groupBox1.Visible = false;
                    gcLoaiHinhKhac.Enabled = true;
                    gcLoaiHinhKhac.Dock = DockStyle.Fill;
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = true;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                    this.v_SELECTLOAIHINHKHACTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_SELECTLOAIHINHKHACTableAdapter.Fill(this.tPNTDataSet.V_SELECTLOAIHINHKHAC);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                } else
                {
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                    gcLoaiHinhKhac.Dock = DockStyle.Top;
                    gcLoaiHinhKhac.Enabled = false;
                    groupBox1.Visible = true;
                    groupBox1.Dock = DockStyle.Fill;
                    return;
                }
            }
            else if (sukien.Equals("HC"))
            {
                string strLenh = "EXEC SP_UPDATELHK '" + this.txtMa.Text + "', N'" + this.txtTheLoai.Text + "', N'" + this.txtPhongCach.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if(ex == 0)
                {
                    bdsLoaiHinhKhac.EndEdit();
                    bdsLoaiHinhKhac.ResetCurrentItem();
                    groupBox1.Visible = false;
                    gcLoaiHinhKhac.Enabled = true;
                    gcLoaiHinhKhac.Dock = DockStyle.Fill;
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = true;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                } else
                {
                    gcLoaiHinhKhac.Dock = DockStyle.Top;
                    gcLoaiHinhKhac.Enabled = false;
                    groupBox1.Visible = true;
                    groupBox1.Dock = DockStyle.Fill;

                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "";
            string maTP = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maTP = ((DataRowView)bdsLoaiHinhKhac[bdsLoaiHinhKhac.Position])["Ma"].ToString();

                    bdsLoaiHinhKhac.RemoveCurrent();
                    strLenh = "EXEC SP_DELETELHK '" + maTP + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.v_SELECTLOAIHINHKHACTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_SELECTLOAIHINHKHACTableAdapter.Fill(this.tPNTDataSet.V_SELECTLOAIHINHKHAC);
                    bdsLoaiHinhKhac.Position = bdsLoaiHinhKhac.Find("Ma", maTP);
                    return;
                }
            }
            strLenh = "SELECT * FROM V_SLLHK";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if (slTG == 0)
            {
                this.btnXoa.Enabled = this.btnHieuChinh.Enabled = false;
            }
            else this.btnXoa.Enabled = this.btnHieuChinh.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLoaiHinhKhac.CancelEdit();
            bdsLoaiHinhKhac.Position = vitri;
            gcLoaiHinhKhac.Enabled = true;
            gcLoaiHinhKhac.Dock = DockStyle.Fill;
            groupBox1.Visible = false;
            string strLenh = "SELECT * FROM V_SLLHK";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if (slTG == 0)
            {
                this.btnXoa.Enabled = this.btnHieuChinh.Enabled = false;
            }
            else this.btnXoa.Enabled = this.btnHieuChinh.Enabled = true;

            this.btnThem.Enabled = this.btnReload.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLoaiHinhKhac.Position;

            try
            {
                this.v_SELECTLOAIHINHKHACTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_SELECTLOAIHINHKHACTableAdapter.Fill(this.tPNTDataSet.V_SELECTLOAIHINHKHAC);
                bdsLoaiHinhKhac.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

    }
}
