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
    public partial class frmHoiHoa : Form
    {
        private string sukien = "";
        private int vitri = 0;
        
        public frmHoiHoa()
        {
            InitializeComponent();
        }

        private void frmHoiHoa_Load(object sender, EventArgs e)
        {
            this.v_SELECTHOIHOATableAdapter1.Connection.ConnectionString = Program.connstr;
            this.v_SELECTHOIHOATableAdapter1.Fill(this.dsTPNT.V_SELECTHOIHOA);
            groupBox1.Visible = false;
            gcHoiHoa.Dock = DockStyle.Fill;
            if (Program.mGroup.Equals("QUANLI"))
            {
                this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnReload.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;

                string strLenh = "SELECT * FROM V_SLHOIHOA";
                SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
                dataReaderSLTG.Read();
                int slTG = dataReaderSLTG.GetInt32(0);
                dataReaderSLTG.Close();
                if (slTG == 0)
                {
                    this.btnXoa.Enabled = this.btnHieuChinh.Enabled = false;
                }
                else this.btnXoa.Enabled = this.btnHieuChinh.Enabled = true;
            } else
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
            bdsHoiHoa.AddNew();
            

            if (CheckExist(typeof(frmChonTacPham)) == null)
            {
                frmChonTacPham f = new frmChonTacPham();
                f.Activate();
                f.Show();

                f.FormClosed += (closedSender, args) =>
                {
                    // Lấy dữ liệu từ form mới (frmChonTacPham)
                    this.txtTen.Text = f.TenTP;
                    this.txtMaTP.Text = f.MaTP;
                };
            }
            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            gcHoiHoa.Dock = DockStyle.Top;
            gcHoiHoa.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sukien = "HC";
            gcHoiHoa.Dock = DockStyle.Top;
            gcHoiHoa.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;

            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            vitri = bdsHoiHoa.Position;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtMaTP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã tác phẩm không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtMaTP.Focus();
                return;
            }

            if (this.txtVatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vật liệu không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtVatLieu.Focus();
                return;
            }

            if (this.txtChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chất liệu không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtChatLieu.Focus();
                return;
            }

            if (this.txtTruongPhai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường phái không được trống!", "Thông báo", MessageBoxButtons.OK);
                this.txtTruongPhai.Focus();
                return;
            }
            
            if (sukien.Equals("THEM"))
            {
                string strLenh = "EXEC SP_INSERTHOIHOA '" + this.txtMaTP.Text + "', N'" + this.txtVatLieu.Text + "', N'" + this.txtChatLieu.Text + "', N'" + this.txtTruongPhai.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if(ex == 0) // thêm thành công
                {
                    bdsHoiHoa.CancelEdit();
                    bdsHoiHoa.ResetCurrentItem();
                    groupBox1.Visible = false;
                    gcHoiHoa.Enabled = true;
                    gcHoiHoa.Dock = DockStyle.Fill;
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = true;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                    this.v_SELECTHOIHOATableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.v_SELECTHOIHOATableAdapter1.Fill(this.dsTPNT.V_SELECTHOIHOA);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                } else if(ex == 16)
                {
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                    gcHoiHoa.Dock = DockStyle.Top;
                    gcHoiHoa.Enabled = false;
                    groupBox1.Visible = true;
                    groupBox1.Dock = DockStyle.Fill;
                    return;
                }
                
                
               
            } else if (sukien.Equals("HC"))
            {
                string strLenh = "EXEC SP_UPDATEHOIHOA '" + this.txtMaTP.Text + "', N'" + this.txtVatLieu.Text + "', N'" + this.txtChatLieu.Text + "', N'" + this.txtTruongPhai.Text + "'";
                int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                if(ex == 0)
                {
                    bdsHoiHoa.EndEdit();
                    bdsHoiHoa.ResetCurrentItem();
                    groupBox1.Visible = false;
                    gcHoiHoa.Enabled = true;
                    gcHoiHoa.Dock = DockStyle.Fill;
                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = true;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                } else
                {
                    gcHoiHoa.Dock = DockStyle.Top;
                    gcHoiHoa.Enabled = false;
                    groupBox1.Visible = true;
                    groupBox1.Dock = DockStyle.Fill;

                    this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = false;
                    this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
                    return;
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
                    maTP = ((DataRowView)bdsHoiHoa[bdsHoiHoa.Position])["Ma"].ToString();

                    bdsHoiHoa.RemoveCurrent();
                    strLenh = "EXEC SP_DELETEHOIHOA '" + maTP + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.v_SELECTHOIHOATableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.v_SELECTHOIHOATableAdapter1.Fill(this.dsTPNT.V_SELECTHOIHOA);
                    bdsHoiHoa.Position = bdsHoiHoa.Find("Ma", maTP);
                    return;
                }
            }
            strLenh = "SELECT * FROM V_SLHOIHOA";
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
            bdsHoiHoa.CancelEdit();
            bdsHoiHoa.Position = vitri;
            gcHoiHoa.Enabled = true;
            gcHoiHoa.Dock = DockStyle.Fill;
            groupBox1.Visible = false;

            string strLenh = "SELECT * FROM V_SLHOIHOA";
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
            vitri = bdsHoiHoa.Position;

            try
            {
                this.v_SELECTHOIHOATableAdapter1.Connection.ConnectionString = Program.connstr;
                this.v_SELECTHOIHOATableAdapter1.Fill(this.dsTPNT.V_SELECTHOIHOA);
                bdsHoiHoa.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

    }
}
