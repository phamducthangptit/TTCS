using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace TPNT
{
    public partial class frmMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private frmLogin frmLG;
        public frmMainMenu(frmLogin frmLG)
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            lbNhom.Text = "Nhóm: " + Program.mGroup;

            lbUser.Text = "Tên: " + Program.username;
            if (Program.mGroup.Equals("KHACH"))
            {
                btnBackupRestore.Visible= btnUser.Visible = false;
            }
            else
            {
                btnBackupRestore.Visible = btnUser.Visible = true;
            }
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.frmLG = frmLG;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 220, 20, 60);
            public static Color color2 = Color.FromArgb(255, 255, 140, 0);
            public static Color color3 = Color.FromArgb(255, 255, 215, 0);
            public static Color color4 = Color.FromArgb(255, 0, 128, 0);
            public static Color color5 = Color.FromArgb(255, 0, 191, 255);
            public static Color color6 = Color.FromArgb(255, 255, 182, 193);
            public static Color color7 = Color.FromArgb(255, 0, 255, 255);
            public static Color color8 = Color.FromArgb(255, 255, 0, 255);
            public static Color color9 = Color.FromArgb(255, 192, 192, 192);
            public static Color color10 = Color.FromArgb(255, 128, 128, 128);
            public static Color color11 = Color.FromArgb(255, 255, 165, 0);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            leftBorderBtn.Size = new Size(7, 60);
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconFormChild.IconChar = currentBtn.IconChar;
                iconFormChild.IconColor = color;
            }
        }

        private void ActivateButton1(object senderBtn, Color color)
        {   leftBorderBtn.Size = new Size(7, 50);
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + currentBtn.Parent.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconFormChild.IconChar = currentBtn.IconChar;
                iconFormChild.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void hideSubMenu()
        {
            panelLoaiHinhSangTac.Visible = false;
            panelLoaiHinhSoHuu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleFormChild.Text = childForm.Text;
        }
        private void btnTacPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTPNT());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmTacGia());
        }

        private void btnCuocTrienLam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmCuocTrienLam());
        }

        private void btnBoSuuTap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmBoSuuTap());
        }

        private void btnLoaiHinhSangTac_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLoaiHinhSangTac);
            ActivateButton(sender, RGBColors.color5);
            lblTitleFormChild.Text = "Loại hình sáng tác";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            
        }



        private void Reset()
        {
            DisableButton();
            hideSubMenu();
            leftBorderBtn.Visible = false;
            iconFormChild.IconChar = IconChar.Home;
            iconFormChild.IconColor = Color.Gainsboro;
            lblTitleFormChild.Text = "Trang chủ";
            currentChildForm = null;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnLoaiHinhSoHuu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelLoaiHinhSoHuu);
            ActivateButton(sender, RGBColors.color9);
            lblTitleFormChild.Text = "LoaiHinhDiMuon";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
           
        }

        private void btnHoiHoa_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color7);
            OpenChildForm(new frmHoiHoa());
        }

        private void btnDiMuon_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color11);
            OpenChildForm(new frmLoaiHinhDiMuon());
            //Form f = new frmLoaiHinhDiMuon();
            //f.Show();
        }

        public static Form CheckExist(Type ftype)
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

        private void btnDieuKhacTacTuong_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color6);
            OpenChildForm(new frmDieuKhacVaTacTuong());
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color8);
        }

        private void btnTaiSanCuaBaoTang_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color10);
            OpenChildForm(new frmTaiSanBaoTang());
        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {
            Form frm = new frmBackup_Restore();
            frm.Show();
        }

        

        private void btnKhac_Click_1(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color8);
            OpenChildForm(new frmLoaiHinhKhac());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            this.frmLG.Show();
            this.Close();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            
            frmLoginBK loginForm = new frmLoginBK();
            DialogResult loginResult = loginForm.ShowDialog();

            if (loginResult == DialogResult.OK)
            {
                Form frm = new frmBackup_Restore();
                //currentChildForm = frm;
                frm.Show();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmTaoLogin();
            DialogResult frmResult = frm.ShowDialog();
            if (frmResult == DialogResult.OK)
            {
                if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
                this.frmLG.Show();
                this.Close();
            }
        }
    }
}
