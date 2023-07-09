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

namespace TPNT
{
    public partial class frmChonTPNTSoHuu : Form
    {
        public frmChonTPNTSoHuu()
        {
            InitializeComponent();
        }

        private void frmChonTPNTSoHuu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tPNTDataSet1.view_NullSoHuu' table. You can move, or remove it, as needed.
            
           
            this.view_NullSoHuuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_NullSoHuuTableAdapter.Fill(this.tPNTDataSet1.view_NullSoHuu);
            if (bdsNullSoHuu.Count <= 0)
            {
                Program.maSoTPNT = "";
                Program.TenTPNT = "";
                MessageBox.Show("Không còn tác phẩm nào để thêm ", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
               
            DataRowView rowView = (DataRowView)bdsNullSoHuu[bdsNullSoHuu.Position];
            DataRowView drv = ((DataRowView)(bdsNullSoHuu.Current));
            string maSoTP = drv["MaSoTP"].ToString();
            string ten = drv["TenTP"].ToString();
            Program.maSoTPNT = maSoTP;
            Program.TenTPNT = ten;
            this.Close();
        }
    }
}
