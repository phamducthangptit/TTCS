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
    public partial class frmChonTPNTNullSangTac : Form
    {
        public frmChonTPNTNullSangTac()
        {
            InitializeComponent();
        }

        private void frmChonTPNTNullSangTac_Load(object sender, EventArgs e)

        {
            this.view_NullLoaiHinhSangTacTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tPNTDataSet1.view_NullLoaiHinhSangTac' table. You can move, or remove it, as needed.
            this.view_NullLoaiHinhSangTacTableAdapter.Fill(this.tPNTDataSet1.view_NullLoaiHinhSangTac);
            if (bdsNullLoaiHinhSangTac.Count <= 0)
            {
                Program.maSoTPNT = "";
                Program.TenTPNT = "";
                MessageBox.Show("Không còn tác phẩm nào để thêm ", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)bdsNullLoaiHinhSangTac[bdsNullLoaiHinhSangTac.Position];
            DataRowView drv = ((DataRowView)(bdsNullLoaiHinhSangTac.Current));
            string maSoTP = drv["MaSoTP"].ToString();
            string ten = drv["TenTP"].ToString();
            Program.maSoTPNT = maSoTP;
            Program.TenTPNT = ten;
            this.Close();
        }
    }
}
