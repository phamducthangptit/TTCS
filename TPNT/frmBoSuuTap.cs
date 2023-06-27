﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TPNT
{
    public partial class frmBoSuuTap : Form
    {
        string suKien = "";
        int viTri;
        public frmBoSuuTap()
        {
            InitializeComponent();
        }

        private void frmBoSuuTap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tPNTDataSet.V_BO_SUU_TAP' table. You can move, or remove it, as needed.
            tPNTDataSet.EnforceConstraints = false;
            this.v_BO_SUU_TAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_BO_SUU_TAPTableAdapter.Fill(this.tPNTDataSet.V_BO_SUU_TAP);
            viTri = bdsBoSuuTap.Position;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBoSuuTap.Position;
            suKien = "THEM";
            bdsBoSuuTap.AddNew();
            panelDSBoSuuTap.Enabled = false;
            panelThongTin.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBoSuuTap.Position;
            suKien = "HIEUCHINH";
            panelDSBoSuuTap.Enabled = false;
            panelThongTin.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (suKien.Equals("")) return;
            bdsBoSuuTap.Position = viTri ;
            suKien = "";
            panelDSBoSuuTap.Enabled = true;
            panelThongTin.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.v_BO_SUU_TAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_BO_SUU_TAPTableAdapter.Fill(this.tPNTDataSet.V_BO_SUU_TAP);
            bdsBoSuuTap.Position = viTri ;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (suKien.Equals("")) return;
            string ma = txtMa.Text.Trim();
            string ten = txtTen.Text.Trim();
            string hinhThuc = txtHinhThuc.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string nguoiGD = txtNguoiGiamDinh.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (ma.Equals(""))
            {
                MessageBox.Show("Mã bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            if (ten.Equals(""))
            {
                MessageBox.Show("Tên bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (hinhThuc.Equals(""))
            {
                MessageBox.Show("Hình thức bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtHinhThuc.Focus();
                return;
            }

            if (diaChi.Equals(""))
            {
                MessageBox.Show("Địa chỉ bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }

            if (nguoiGD.Equals(""))
            {
                MessageBox.Show("Người giám định bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtNguoiGiamDinh.Focus();
                return;
            }
            if (sdt.Equals(""))
            {
                MessageBox.Show("Số điện thoại bộ sưu tập không được thiếu", "Điền thiếu thông tin", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            string lenh = "";
            if (suKien.Equals("THEM"))
            {
                lenh = "SP_INSERT_BST '"
                        + ma + "', N'"
                        + ten + "', N'"
                + hinhThuc + "', '"
                         + moTa + "', N'"
                         + diaChi + "', N'"
                        + nguoiGD + "', N'"
                        + sdt +
                        "'"
                        ;
            } else if (suKien.Equals("HIEUCHINH"))
            {
                lenh = "SP_UPDATE_BST '"
                        + ma + "', N'"
                        + ten + "', N'"
                + hinhThuc + "', '"
                         + moTa + "', N'"
                         + diaChi + "', N'"
                        + nguoiGD + "', N'"
                        + sdt +
                        "'"
                        ;
            }
            int result = Program.ExecSqlNonQuery(lenh, Program.connstr);
            if (result == 0)
            {
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            }
        }
    }
}
