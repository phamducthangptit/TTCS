using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frmMainMenu()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            lbNhom.Text = "Nhóm: " + Program.mGroup;

            lbUser.Text = "Tên: " + Program.username;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 220, 20, 60);
            public static Color color2 = Color.FromArgb(255, 255, 140, 0);
            public static Color color3 = Color.FromArgb(255, 255, 215, 0);
            public static Color color4 = Color.FromArgb(255, 0, 128, 0);
            public static Color color5 = Color.FromArgb(255, 0, 191, 255);
            public static Color color6 = Color.FromArgb(255, 255, 182, 193);
            public static Color color7 = Color.FromArgb(255, 255, 182, 193);
            public static Color color8 = Color.FromArgb(255, 255, 182, 193);
            public static Color color9 = Color.FromArgb(255, 255, 182, 193);
            public static Color color10 = Color.FromArgb(255, 255, 182, 193);
            public static Color color11 = Color.FromArgb(255, 255, 182, 193);
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
           // OpenChildForm(new frmTacGia());
        }

        private void btnBoSuuTap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmBoSuuTap());
        }

        private void btnLoaiHinhSangTac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            lblTitleFormChild.Text = "Loại hình sáng tác";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            showSubMenu(panelLoaiHinhSangTac);
        }



        private void Reset()
        {
            DisableButton();
            hideSubMenu();
            leftBorderBtn.Visible = false;
            iconFormChild.IconChar = IconChar.Home;
            iconFormChild.IconColor = Color.Gainsboro;
            lblTitleFormChild.Text = "Trang chủ";
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
            ActivateButton(sender, RGBColors.color9);
            lblTitleFormChild.Text = "LoaiHinhDiMuon";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            showSubMenu(panelLoaiHinhSoHuu);
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
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color8);
        }

        private void btnTaiSanCuaBaoTang_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color10);
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

        }
    }
}
