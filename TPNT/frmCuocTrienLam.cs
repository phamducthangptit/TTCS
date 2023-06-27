using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPNT
{
    public partial class frmCuocTrienLam : Form
    {
        public frmCuocTrienLam()
        {
            InitializeComponent();
        }

        

        private void cuocTrienLamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCuocTrienLam.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tPNTDataSet);

        }

        private void cuocTrienLamBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCuocTrienLam.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tPNTDataSet);

        }

        private void frmCuocTrienLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tPNTDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.tPNTDataSet.TPNT);
            // TODO: This line of code loads data into the 'tPNTDataSet.CT_CuocTrienLam' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tPNTDataSet.CuocTrienLam' table. You can move, or remove it, as needed.
            this.cuocTrienLamTableAdapter.Fill(this.tPNTDataSet.CuocTrienLam);

        }

        private void cuocTrienLamGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbThemCTL.Visible = false;
            DataRowView rowView = (DataRowView)bdsCuocTrienLam[bdsCuocTrienLam.Position];
            string MaCTL = rowView["MaSoCTL"].ToString();
            grbThongTin.Visible = true;
            LoadCtCuocTrienLam(MaCTL);
        }
        private void LoadCtCuocTrienLam(string MaCTL)
        {
            
            try
            {
                
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    using (SqlCommand command = new SqlCommand("SP_CHITIETCUOCTRIENLAM", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("MACTL", MaCTL);

                        connection.Open();

                        // Sử dụng SqlDataAdapter để điền dữ liệu từ Stored Procedure vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        SP_CTCTLGridControl.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grbThongTin.Visible=false;
            grbThemCTL.Visible=true;
        }

        
    }
}
