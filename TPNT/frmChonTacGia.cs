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
    public partial class frmChonTacGia : Form
    {
        private frmTPNT _parentForm;
        public frmChonTacGia(frmTPNT parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void frmChonTacGia_Load(object sender, EventArgs e)
        {
            tPNTDataSet.EnforceConstraints = false;
            this.v_TAC_GIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TAC_GIATableAdapter.Fill(this.tPNTDataSet.V_TAC_GIA);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsTG.Count == 0) return;
            string fileName = ((DataRowView)bdsTG[bdsTG.Position])["HinhAnh"].ToString();
            if(fileName.Equals(""))
            {
                fileName = "macDinh.png";
            }
            pictureTG.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + fileName);
            string maTG = ((DataRowView)bdsTG[bdsTG.Position])["Mã tác giả"].ToString();
            string tenTG = ((DataRowView)bdsTG[bdsTG.Position])["Họ và tên"].ToString();
            _parentForm.setTG(maTG, tenTG);
        }

     

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
