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
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();

            string strLenh2 = "EXEC SP_CHECK_SYSADMIN '" + Program.mlogin + "'";
            SqlDataReader dataReaderTG = Program.ExecSqlDataReader(strLenh2);
            dataReaderTG.Read();
            int check = Int32.Parse(dataReaderTG.GetString(0)); // 
            dataReaderTG.Close();
            Program.conn.Close();
            cmbQuyen.Items.Add("QUANLI");
            cmbQuyen.Items.Add("KHACH");
            cmbQuyen.SelectedItem = "QUANLI";
            if (check == 0)
            {
                panelTTK.Enabled = false;
            } else
            {
                panelTTK.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mk1 = txtMatKhau.Text;
            if (!mk1.Equals(Program.password)) {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau2.ResetText();
                txtMatKhau.Focus();
                return;
            }
            string mk2 = txtMatKhau1.Text;
            string mk3 = txtMatKhau2.Text;
            if (!mk2.Equals(mk3))
            {
                MessageBox.Show("Xác nhận mật khẩu mới không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau2.ResetText();
                txtMatKhau2.Focus();
                return;
            }
            string strLenh2 = "EXEC SP_DOIMATKHAU '" + Program.mlogin + "', '"+ mk1+"', '"+mk2+"'";
            int check = Program.ExecSqlNonQuery(strLenh2,Program.connstr);
            if (check == 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!\nHãy đăng nhập lại.", "Thành công", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string login = txtTaiKhoan.Text;
            string pass = txtPass.Text;
            string name = txtNguoiDung.Text;
            string quyen = cmbQuyen.SelectedItem.ToString();
            if (login.Equals(""))
            {
                MessageBox.Show("Tài khoản không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (pass.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            if (name.Equals(""))
            {
                MessageBox.Show("Tên người dùng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNguoiDung.Focus();
                return;
            }
            string strLenh2 = "EXEC SP_TAOLOGIN '" + login + "', '" + pass + "', '" + name + "', '" + quyen + "'";
            int check = Program.ExecSqlNonQuery(strLenh2, Program.connstr);
            if (check == 1)
            {
                MessageBox.Show("Tài khoản bị trùng!", "Thất bại", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            if (check == 2)
            {
                MessageBox.Show("Tên người dùng bị trùng!", "Thất bại", MessageBoxButtons.OK);
                txtNguoiDung.Focus();
                return;
            }
            if (check == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK);
            }
        }
    }
}
