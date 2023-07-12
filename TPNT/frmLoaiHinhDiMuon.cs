using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Media;

namespace TPNT
{
    public partial class frmLoaiHinhDiMuon : Form
    {
        string suKien = "";
        int viTri;
        int viTriBST;
        public frmLoaiHinhDiMuon()
        {
            InitializeComponent();
        }

        private void frmLoaiHinhDiMuon_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.v_TAC_GIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);
            this.v_BO_SUU_TAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_BO_SUU_TAPTableAdapter.Fill(this.tPNTDataSet.V_BO_SUU_TAP);
            this.sP_BOSUUTAP_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BOSUUTAP_TPNTTableAdapter.Fill(this.tPNTDataSet.SP_BOSUUTAP_TPNT);

            if (Program.mGroup.Equals("KHACH"))
            {
                btnThem.Enabled = btnHieuChinh.Enabled =
                    btnXoa.Enabled  = false;
            }
            else
            {
                if (bdsBoSuuTap.Count == 0)
                {
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
                }
                if (bdsLoaiDiMuon.Count == 0)
                {
                    btnHieuChinh.Enabled = btnXoa.Enabled = false;
                } else
                {
                    btnHieuChinh.Enabled = btnXoa.Enabled = true;
                }
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (bdsLoaiDiMuon.Count == 0)
            {
                return;
            }


            string hinhAnh = ((DataRowView)bdsLoaiDiMuon[bdsLoaiDiMuon.Position])["HinhAnh"].ToString();
            if (hinhAnh.Equals(""))
            {
                hinhAnh = "macDinh.png";
            }
            pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + hinhAnh);
            //if (bdsTG.Count == 0) return;
            string maTG = ((DataRowView)bdsLoaiDiMuon[bdsLoaiDiMuon.Position])["MaTacGia"].ToString();
            int tmp = bdsTG.Find("Mã tác giả", maTG);
            if (tmp == -1)
            {
                txtTacGia.ResetText();
                return;
            }
            txtTacGia.Text = ((DataRowView)bdsTG[tmp])["Họ và tên"].ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (bdsLoaiDiMuon.Count == 0)
            {
                pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + "macDinh.png");
                txtTacGia.ResetText();
                return;
            }

            viTriBST = bdsBoSuuTap.Position;
            string hinhAnh = ((DataRowView)bdsLoaiDiMuon[bdsLoaiDiMuon.Position])["HinhAnh"].ToString();
            if (hinhAnh.Equals(""))
            {
                hinhAnh = "macDinh.png";
            }
            pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + hinhAnh);
            string maTG = ((DataRowView)bdsLoaiDiMuon[bdsLoaiDiMuon.Position])["MaTacGia"].ToString();
            int tmp = bdsTG.Find("Mã tác giả", maTG);
            txtTacGia.Text = ((DataRowView)bdsTG[tmp])["Họ và tên"].ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLoaiDiMuon.Position;
            suKien = "THEM";
            bdsLoaiDiMuon.AddNew();
            panelThongTin2.Enabled = true;
            panelDSTPNT.Enabled = false;
            panelDSBoSuuTap.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled =true;
            btnChonTP.Visible = true;
            Form form = new frmChonTPNT(this);
            form.Show();
        }

        public void setTPNT (object data)
        {
            DataRowView newData = (DataRowView)data;
            DataRow newRow = newData.Row;

             txtMa.Text = newRow["Mã tác phẩm"].ToString();
            txtTen.Text = newRow["Tên tác phẩm"].ToString();
           
            txtNam.Text = newRow["Năm sáng tác"].ToString();
            txtChuDe.Text = newRow["ChuDe"].ToString();
            txtQuocGia.Text = newRow["Quốc gia"].ToString();
            txtThoiDai.Text = newRow["ThoiDai"].ToString();
            txtLoiDienGiai.Text = newRow["LoiDienGiai"].ToString();
            string hinhAnh = newRow["HinhAnh"].ToString();
            if (hinhAnh.Equals(""))
            {
                hinhAnh = "macDinh.png";
            }
            pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + hinhAnh);
            string maTG = newRow["MaTacGia"].ToString();
            int tmp = bdsTG.Find("Mã tác giả", maTG);
            txtTacGia.Text = ((DataRowView)bdsTG[tmp])["Họ và tên"].ToString();
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ngayMuon = deNgayMuon.Text.ToString();
            string ngayTra = deNgayTra.Text.ToString();
            string maBST = ((DataRowView)bdsBoSuuTap[bdsBoSuuTap.Position])["Mã bộ sưu tập"].ToString();
            string maTPNT = txtMa.Text.ToString();
            if (ngayMuon.Equals(""))
            {
                MessageBox.Show("Ngày mượn không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                deNgayMuon.Focus();
                return;
            }
            if (ngayTra.Equals(""))
            {
                MessageBox.Show("Ngày trả không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                deNgayTra.Focus();
                return;
            }
            if (soSanhNgay(ngayMuon,ngayTra) == -1)
            {
                MessageBox.Show("Ngày trả không được nhỏ hơn ngày mượn", "Điền thiếu thông tin", MessageBoxButtons.OK);
                deNgayTra.Focus();
                return;
            }
            string strLenh = "";
            if (suKien.Equals("THEM")) {
                strLenh = "SP_INSERT_LOAIDIMUON '"
                        + maTPNT + "', '"
                    + chuyenDangNgay(ngayMuon) + "', '"
                         + chuyenDangNgay(ngayTra) + "', '"
                         + maBST + 
                        "'"
                        ;
            }
            if (suKien.Equals("HIEUCHINH"))
            {
                strLenh = "SP_UPDATE_LOAIDIMUON '"
                        + maTPNT + "', '"
                   + chuyenDangNgay(ngayMuon) + "', '"
                         + chuyenDangNgay(ngayTra) +    
                        "'"
                        ;
            }
            int result = Program.ExecSqlNonQuery(strLenh, Program.connstr);
            if (result == 0)
            {
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            }

            //this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);
            bdsLoaiDiMuon.EndEdit();
            this.sP_BOSUUTAP_TPNTTableAdapter.Fill(this.tPNTDataSet.SP_BOSUUTAP_TPNT);

            panelThongTin2.Enabled = false;
            panelDSTPNT.Enabled = true;
            panelDSBoSuuTap.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled =false;
            btnChonTP.Visible = false;
            suKien = "";
            viTri = bdsLoaiDiMuon.Position;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = frmMainMenu.CheckExist(typeof(frmChonTPNT));
            if (frm != null) { frm.Close(); }
            bdsLoaiDiMuon.RemoveCurrent();
            bdsLoaiDiMuon.EndEdit();
            panelThongTin2.Enabled = false;
            panelDSTPNT.Enabled = true;
            panelDSBoSuuTap.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled =false;
            btnChonTP.Visible = false;
            suKien = "";
            this.sP_BOSUUTAP_TPNTTableAdapter.Fill(this.tPNTDataSet.SP_BOSUUTAP_TPNT);
            bdsLoaiDiMuon.Position = viTri;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ten = txtTen.Text.ToString();
            string tenBST = txtBST.Text.ToString();
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn xoá " + ten +
                " ra khỏi bộ sưu tập "+tenBST+ " ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                string ma = txtMa.Text.Trim();
                string strLenh = "DELETE FROM LoaiDiMuon WHERE MaSoTP = '"
                           + ma +
                           "'"
                           ;
                int result = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if (result == 0)
                {
                    MessageBox.Show("Xoá tác phẩm thành công", "", MessageBoxButtons.OK);
                }
                this.sP_BOSUUTAP_TPNTTableAdapter.Fill(this.tPNTDataSet.SP_BOSUUTAP_TPNT);
                if (bdsLoaiDiMuon.Count == 0)
                {
                    pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + "macDinh.png");
                    txtTacGia.ResetText();
                    btnHieuChinh.Enabled = btnXoa.Enabled = false;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);
            this.v_BO_SUU_TAPTableAdapter.Fill(this.tPNTDataSet.V_BO_SUU_TAP);
            this.sP_BOSUUTAP_TPNTTableAdapter.Fill(this.tPNTDataSet.SP_BOSUUTAP_TPNT);
            bdsLoaiDiMuon.Position = viTri;
            bdsBoSuuTap.Position= viTriBST;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLoaiDiMuon.Position;
            suKien = "HIEUCHINH";
            //bdsLoaiDiMuon.AddNew();
            panelThongTin2.Enabled = true;
            panelDSTPNT.Enabled = false;
            panelDSBoSuuTap.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
        }

        private void btnChonTP_Click(object sender, EventArgs e)
        {
            Form frm = frmMainMenu.CheckExist(typeof(frmChonTPNT));
            if (frm != null) { frm.Show(); }
            else
            {
                Form form = new frmChonTPNT(this);
                form.Show();
            }
        }
    }
}
