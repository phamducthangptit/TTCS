using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void hoiHoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoiHoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTPNT);

        }

        private void frmHoiHoa_Load(object sender, EventArgs e)
        {
            dsTPNT.EnforceConstraints = false;
            this.HoiHoaTableAdapter.Fill(this.dsTPNT.HoiHoa);
            groupBox1.Visible = false;
            gcHoiHoa.Dock = DockStyle.Fill;
            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
            
            /*string maTP = ((DataRowView)bdsHoiHoa[bdsHoiHoa.Position])["MaSoTP"].ToString();
            cmbMaTP.Text = maTP;*/
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sukien = "HC";
            gcHoiHoa.Dock = DockStyle.Top;
            gcHoiHoa.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;

            string maTP = ((DataRowView)bdsHoiHoa[bdsHoiHoa.Position])["MaSoTP"].ToString();
            cmbMaTP.Text = maTP;
            cmbMaTP.Enabled = false;

            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            vitri = bdsHoiHoa.Position;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.txtVatLieu.Text.Trim().Length == 0)
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

            if(sukien.Equals("THEM"))
            {

            } else if (sukien.Equals("HC"))
            {
                try
                {
                    bdsHoiHoa.EndEdit();
                    bdsHoiHoa.ResetCurrentItem();
                    string strLenh = "EXEC SP_UPDATEHOIHOA '" + cmbMaTP.Text + "', N'" + this.txtVatLieu.Text + "', N'" + this.txtChatLieu.Text + "', N'" + this.txtTruongPhai.Text + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                } catch(Exception ex)
                {
                    MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                groupBox1.Visible = false;
                gcHoiHoa.Enabled = true;
                gcHoiHoa.Dock = DockStyle.Fill;
                this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHoiHoa.CancelEdit();
            bdsHoiHoa.Position = vitri;
            gcHoiHoa.Enabled = true;
            gcHoiHoa.Dock = DockStyle.Fill;
            groupBox1.Visible = false;
            this.btnThem.Enabled = this.btnHieuChinh.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsHoiHoa.Position;

            try
            {
                this.HoiHoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HoiHoaTableAdapter.Fill(this.dsTPNT.HoiHoa);
                bdsHoiHoa.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsHoiHoa.Count == 0) return;
            /*string maTP = ((DataRowView)bdsHoiHoa[bdsHoiHoa.Position])["MaSoTP"].ToString();
            cmbMaTP.Text = maTP;*/
        }
    }
}
