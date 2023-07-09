using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmLoginBK : Form
    {
        public frmLoginBK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string loginName = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            if (loginName.Equals(""))
            {
                MessageBox.Show("Tài khoản không thể để trống!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
            if (pass.Equals(""))
            {
                MessageBox.Show("Mật khẩu không thể để trống!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + loginName + ";password=" + pass;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            string strLenh = "EXEC SP_DANGNHAP '" + loginName + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
          
            Program.myReader.Close();
            Program.conn.Close();
            string strLenh2 = "EXEC SP_CHECK_SYSADMIN '" + loginName + "'";
            SqlDataReader dataReaderTG = Program.ExecSqlDataReader(strLenh2);
            dataReaderTG.Read();
            int check = Int32.Parse(dataReaderTG.GetString(0)); // 
            dataReaderTG.Close();
            Program.conn.Close();
            if (check == 0)
            {
                MessageBox.Show("Tài khoản này không đủ quyền để thực hiện Backup & Restore!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
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
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
