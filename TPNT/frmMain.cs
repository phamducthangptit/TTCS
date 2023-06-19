using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExist(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (ftype == f.GetType())
                {
                    return f;
                }
            }
            return null;
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmTacGia));
            if (frm != null) frm.Activate();
            else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmCuocTrienLam));
            if (frm != null) frm.Activate();
            else
            {
                frmCuocTrienLam f = new frmCuocTrienLam();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}