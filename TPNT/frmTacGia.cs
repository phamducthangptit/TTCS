﻿using DevExpress.Utils.Extensions;
using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmTacGia : Form
    {
        private PictureBox pictureBox = new PictureBox();
        private string selectedImagePath = "";
        private string suKien = "";
        private string suKienCT = "";
        private int vitri = 0;
        private int chonAnh = 0;
        public frmTacGia()
        {
            InitializeComponent();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);  

            gcTacGia.Dock = DockStyle.Fill;
            groupBox1.Visible = false;

            this.btnThem.Enabled =   this.btnReload.Enabled = this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = this.btnHieuChinh.Enabled = false;

            string strLenh = "SELECT * FROM V_SLTG";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if (slTG == 0)
            {
                this.btnXoa.Enabled = false;
            }
            else this.btnXoa.Enabled = true;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suKien = "THEM";
            suKienCT = "THEM";
            vitri = bdsTacGia.Position;
            this.txtMaTacGia.ReadOnly = false;
            gcTacGia.Visible = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;

            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = true;
            this.btnChiTiet.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnHieuChinh.Enabled 
                = this.btnReload.Enabled = this.btnThoat.Enabled = false;
            
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            this.pnlAnh.Visible = false;
            this.lblSLTP.Visible = this.txtSLTP.Visible = false;
            bdsTacGia.AddNew();
            this.btnChonAnh.Visible = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;
            suKien = "HC";
            gcTacGia.Enabled = false;
            groupBox1.Enabled = true;

            this.btnThem.Enabled = this.btnXoa.Enabled = this.btnHieuChinh.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = false;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = true;
            this.btnChonAnh.Visible = true;
            this.pnlAnh.Visible = true;
            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = true;

            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();
            string strLenh = "SELECT dbo.FN_SLTP('" + maTG + "')";
            SqlDataReader dataReaderSLTP = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTP.Read();
            int sLTP = dataReaderSLTP.GetInt32(0);
            dataReaderSLTP.Close();
            if (sLTP != 0)
            {
                this.txtMaTacGia.ReadOnly = true;
            }
            else this.txtMaTacGia.ReadOnly = false ;

            string pathImage = ((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString();
            Image image = Image.FromFile(pathImage);
            selectedImagePath = pathImage;

            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Fill;
            this.pnlAnh.AddControl(pictureBox);


        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "SELECT * FROM V_SLTG";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();
            if(slTG == 0)
            {
                this.btnXoa.Enabled = false;
            } else this.btnXoa.Enabled= true;
            string maTG = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();

                    bdsTacGia.RemoveCurrent();
                    strLenh = "EXEC SP_DELETETG '" + maTG + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                    //File.Delete(((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tác giả. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
                    bdsTacGia.Position = bdsTacGia.Find("MaTacGia", maTG);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            bdsTacGia.Position = vitri;
            if (suKienCT.Equals("THEM"))
            {
                gcTacGia.Visible = true;
                gcTacGia.Dock = DockStyle.Fill;
                groupBox1.Visible = false;
                this.btnChiTiet.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                
            }
            else
            {
                this.btnXoa.Enabled = this.btnHieuChinh.Enabled = this.btnReload.Enabled = this.btnThoat.Enabled = true;
                this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
                this.btnChonAnh.Visible = this.btnThem.Enabled = false;
                this.pnlAnh.Visible = true;
                this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = false;
            }

            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;

            try
            {
                this.TacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TacGiaTableAdapter.Fill(this.tPNTDataSet.TacGia);
                bdsTacGia.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void tacGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tPNTDataSet);

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp tin hình ảnh (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    chonAnh = 1;
                    selectedImagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(selectedImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    this.pnlAnh.AddControl(pictureBox);
                    this.pnlAnh.Visible = true;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.txtMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtMaTacGia.Focus();
                return;
            }

            if (this.txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtHoTen.Focus();
                return;
            }

            if (this.txtQuocTich.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quốc tịch tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtQuocTich.Focus();
                return;
            }

            if (this.txtPhongCach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phong cách tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtPhongCach.Focus();
                return;
            }

            if (this.txtDienGiai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Diễn giải không được trống", "Thông báo", MessageBoxButtons.OK);
                this.txtDienGiai.Focus();
                return;
            }

            if (this.ngaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày sinh không được trống", "Thông báo", MessageBoxButtons.OK);
                this.ngaySinh.Focus();
                return;
            }

            if(selectedImagePath.Trim().Length == 0)
            {
                MessageBox.Show("Ảnh của tác giả không được trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();

            string[] ngay = this.ngaySinh.Text.Split('/');
            string ngaySinh = ngay[2] + "-" + ngay[1] + "-" + ngay[0];
            string ngayMat = "";
            if (this.ngayMat.Text.Length != 0)
            {
                ngay = this.ngayMat.Text.Split('/');
                ngayMat = ngay[2] + "-" + ngay[1] + "-" + ngay[0];

            }

            //truong hop them moi hoac chinh sua ma co chinh sua ma
            if (suKien.Equals("THEM"))
            {
                string strLenh = "EXEC SP_CHECKEXISTSTG '" + this.txtMaTacGia.Text + "'";
                SqlDataReader dataReaderTG = Program.ExecSqlDataReader(strLenh);
                dataReaderTG.Read();
                int check = Int32.Parse(dataReaderTG.GetString(0)); // check xem trong db đã có mã tg này hay chưa
                dataReaderTG.Close();
                Program.conn.Close();
                if(check == 0)
                {
                    try
                    {
                        string p = "";
                        if (chonAnh == 1)
                        {
                            string saveFolderPath = @"E:\Dev\C#\TPNT\TPNT\Images\ImageTacgia\";
                            string uniqueFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(selectedImagePath);
                            string saveFilePath = Path.Combine(saveFolderPath, uniqueFileName);

                            p = saveFolderPath + uniqueFileName;
                            File.Copy(selectedImagePath, saveFilePath);

                            
                        }
                        
                        bdsTacGia.EndEdit();
                        bdsTacGia.ResetCurrentItem();
                        strLenh = "EXEC SP_INSERTTG '" + this.txtMaTacGia.Text + "', '" + this.txtHoTen.Text + "', '" + ngaySinh + "', '" + ngayMat + "', '"
                            + this.txtQuocTich.Text + "', '" + this.txtDienGiai.Text + "', '" + this.txtPhongCach.Text + "', '" + p + "'";
                        int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                        chonAnh = 0;
                        gcTacGia.Visible = true;
                        gcTacGia.Dock = DockStyle.Fill;
                        groupBox1.Visible = false;
                        this.btnChiTiet.Enabled = true;
                        this.btnHieuChinh.Enabled = false;
                    } catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi tác giả.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mã tác giả đã có trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                suKien = "";
            } else if (suKien.Equals("HC"))
            {
                try
                {
                    string anhCu = "", p = "";
                    anhCu = ((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString();
                    if (chonAnh == 1)
                    {
                        string saveFolderPath = @"E:\Dev\C#\TPNT\TPNT\Images\ImageTacgia\";
                        string uniqueFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(selectedImagePath);
                        string saveFilePath = Path.Combine(saveFolderPath, uniqueFileName);

                        p = saveFolderPath + uniqueFileName;
                        
                        File.Copy(selectedImagePath, saveFilePath);
                    }
                    if (p.Length == 0) p = anhCu;
                    chonAnh = 0;
                    bdsTacGia.EndEdit();
                    bdsTacGia.ResetCurrentItem();

                    
                    string strLenh = "EXEC SP_UPDATETG '" + maTG + "', '" + this.txtMaTacGia.Text + "', '" + this.txtHoTen.Text + "', '" + ngaySinh + "', '" + ngayMat + "', '"
                           + this.txtQuocTich.Text + "', '" + this.txtDienGiai.Text + "', '" + this.txtPhongCach.Text + "', '" + p + "'";
                    int ex = Program.ExecSqlNonQuery(strLenh, Program.connstr);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi tác giả.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                suKien = "";
            }

            gcTacGia.Enabled = true;
            if (suKienCT.Equals("CT"))
            {
                this.btnThem.Enabled = false;
            }
            else this.btnThem.Enabled = true;

            this.btnXoa.Enabled =  this.btnReload.Enabled = this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = this.btnPhucHoi.Enabled = false;
            this.btnChonAnh.Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsTacGia.Count == 0) return;
            string pathImage = ((DataRowView)bdsTacGia[bdsTacGia.Position])["HinhAnh"].ToString();

            string maTG = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();
            string strLenh = "SELECT dbo.FN_SLTP('" + maTG + "')";
            SqlDataReader dataReaderSLTP = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTP.Read();
            int sLTP = dataReaderSLTP.GetInt32(0);
            dataReaderSLTP.Close();
            this.txtSLTP.Text = sLTP.ToString();

            strLenh = "SELECT * FROM V_SLTG";
            SqlDataReader dataReaderSLTG = Program.ExecSqlDataReader(strLenh);
            dataReaderSLTG.Read();
            int slTG = dataReaderSLTG.GetInt32(0);
            dataReaderSLTG.Close();

            if (sLTP > 0 || slTG == 0)
            {
                this.btnXoa.Enabled = false;
            }
            else this.btnXoa.Enabled = true;

            if (this.txtMaTacGia.Text.Length == 0 && suKien.Equals("THEM"))
            {
                this.btnXoa.Enabled = false;
                this.txtMaTacGia.Enabled = true;
            }
            
            if (pathImage.Trim().Length != 0)
            {
                Image image = Image.FromFile(pathImage);

                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                this.pnlAnh.AddControl(pictureBox);
            }
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (suKienCT.Equals("CT"))
            {
                gcTacGia.Visible = true;
                gcTacGia.Enabled = true;
                gcTacGia.Dock = DockStyle.Fill;
                groupBox1.Visible = false;
                this.btnChiTiet.Enabled = true;
                this.btnHieuChinh.Enabled = false;
                this.btnThem.Enabled = true;
            } else this.Close();
            suKienCT = "";
        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suKienCT = "CT";

            this.txtMaTacGia.Enabled = this.txtHoTen.Enabled = this.ngaySinh.Enabled = this.ngayMat.Enabled =
                this.txtQuocTich.Enabled = this.txtPhongCach.Enabled = this.txtDienGiai.Enabled = false;
            this.btnThem.Enabled = this.btnChiTiet.Enabled = false;
            gcTacGia.Visible = false;
            groupBox1.Visible = true;
            groupBox1.Dock = DockStyle.Fill;
            this.btnHieuChinh.Enabled = true;
            this.lblSLTP.Visible = this.txtSLTP.Visible = true;
            
        }
    }
}
