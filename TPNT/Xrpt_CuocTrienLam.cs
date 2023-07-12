using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TPNT
{
    public partial class Xrpt_CuocTrienLam : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_CuocTrienLam()
        {
            InitializeComponent();
            this.sqlDataSource1.Fill();
        }
        public Xrpt_CuocTrienLam(DateTime fromDate, DateTime toDate)
        {
           
            InitializeComponent();
            xr_txtTu.Text = fromDate.ToString("dd/MM/yyyy");
            xr_txtDen.Text = toDate.ToString("dd/MM/yyyy");
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;
            this.sqlDataSource1.Fill();
        }
    }
}
