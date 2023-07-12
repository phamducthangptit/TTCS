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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.BackColor = Color.White;
            panelTK.BackColor = Color.White;
            panelMK.BackColor = SystemColors.Control;
            txtMatKhau.BackColor = SystemColors.Control;
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            panelMK.BackColor = Color.White;
            txtMatKhau.BackColor = Color.White;
            txtTaiKhoan.BackColor = SystemColors.Control;
            panelTK.BackColor = SystemColors.Control;
        }

        private void btnAnPass_MouseDown(object sender, MouseEventArgs e)
        {
            btnAnPass.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye1.png");
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnAnPass_MouseUp(object sender, MouseEventArgs e)
        {
            btnAnPass.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye.png");
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.mlogin.Equals(""))
            {
                MessageBox.Show("Tài khoản không thể để trống!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
            if (Program.password.Equals(""))
            {
                MessageBox.Show("Mật khẩu không thể để trống!", "Thông báo ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (Program.KetNoi() == 0) return;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }

            Program.mGroup = Program.myReader.GetString(1);
            Program.myReader.Close();
            Program.conn.Close();
            txtMatKhau.ResetText();
            Form frmMain = new frmMainMenu(this);
            frmMain.Show();
            this.Hide();
        }

        private void btnDNKhach_Click(object sender, EventArgs e)
        {
            Program.mlogin = "khachxem";
            Program.password = "123456";
            if (Program.KetNoi() == 0) return;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }

            Program.mGroup = Program.myReader.GetString(1);
            Program.myReader.Close();
            Program.conn.Close();
            Form frmMain = new frmMainMenu(this);
            frmMain.Show();
            this.Hide();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
