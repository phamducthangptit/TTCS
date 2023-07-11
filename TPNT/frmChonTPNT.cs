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
    public partial class frmChonTPNT : Form
    {
        private frmLoaiHinhDiMuon _parentForm;
        public frmChonTPNT(frmLoaiHinhDiMuon parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void frmChonTPNT_Load(object sender, EventArgs e)
        {
            tPNTDataSet2.EnforceConstraints = false;
            this.v_TAC_GIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet2.V_TAC_GIA);
            this.sP_CHON_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_CHON_TPNTTableAdapter.Fill(this.tPNTDataSet2.SP_CHON_TPNT);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsTPNT.Count == 0) return;
            string hinhAnh = ((DataRowView)bdsTPNT[bdsTPNT.Position])["HinhAnh"].ToString();
            if (hinhAnh.Equals(""))
            {
                hinhAnh = "macDinh.png";
            }
            pictureTPNT.Image = new Bitmap(Application.StartupPath + "//Resources//" + hinhAnh);

            string maTG = ((DataRowView)bdsTPNT[bdsTPNT.Position])["MaTacGia"].ToString();
            int tmp = bdsTG.Find("Mã tác giả", maTG);
            txtTacGia.Text = ((DataRowView)bdsTG[tmp])["Họ và tên"].ToString();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _parentForm.setTPNT((DataRowView)bdsTPNT[bdsTPNT.Position]);
            this.Close();
        }

        private void frmChonTPNT_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm.setTPNT((DataRowView)bdsTPNT[bdsTPNT.Position]);
        }
    }
}
