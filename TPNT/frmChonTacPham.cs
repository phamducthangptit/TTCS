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
    public partial class frmChonTacPham : Form
    {
        private string maTP = "", tenTP = "";
        public frmChonTacPham()
        {
            InitializeComponent();
        }
        public string MaTP
        {
            get { return maTP; }
            set { maTP = value; }
        }
        public string TenTP
        {
            get { return tenTP; }
            set { tenTP = value; }
        }
        private void frmChonTacPham_Load(object sender, EventArgs e)
        {
            this.v_SELECTTACPHAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_SELECTTACPHAMTableAdapter.Fill(this.tPNTDataSet.V_SELECTTACPHAM);
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            if (bdsTacPham.Count > 0)
            {
                MaTP = ((DataRowView)bdsTacPham[bdsTacPham.Position])["MaSoTP"].ToString();
                TenTP = ((DataRowView)bdsTacPham[bdsTacPham.Position])["TenTP"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa có tác phẩm để chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
