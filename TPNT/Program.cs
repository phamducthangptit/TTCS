using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace TPNT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        //public static String connstr_publisher = "Data Source=MSI;Initial Catalog=TPNT;Integrated Security=True";

        public static SqlDataReader myReader;

        public static String servername = "ADMIN-PC";



        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TPNT";


        public static String maSoTPNT = "";
        public static String TenTPNT = "";

        public static BindingSource bds_dspm = new BindingSource(); // ds phan manh

        public static String mGroup = "";


        //public static BindingSource bds_dspm = new BindingSource(); // ds phan manh

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300; //5phut timeout
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Lỗi " + e.Message);
                conn.Close();
                return e.State;
            }
            return 0;
        }
        public static int ExecSetUpJob(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300; //5phut timeout
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Lỗi " + e.Message);
                conn.Close();
                return e.State;
            }
            return 0;
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable docFileExcel(string filePath,int trang)
        {

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Đọc file Excel.
            ExcelFile workbook = ExcelFile.Load(filePath);

            // Lấy sheet đầu tiên trong workbook.
            ExcelWorksheet worksheet = workbook.Worksheets[trang];


            // Lấy số lượng hàng và cột trong sheet.
            int rowCount = worksheet.Rows.Count;
            int columnCount = worksheet.CalculateMaxUsedColumns();
            DataTable dataTable = new DataTable();

            // Lấy danh sách cột từ hàng đầu tiên trong bảng tính và thêm chúng vào DataTable
            for (int column = 0; column < columnCount; column++)
            {
                string columnName = worksheet.Cells[0, column].Value?.ToString();
                dataTable.Columns.Add(columnName,typeof(object));
            }

            // Đọc dữ liệu từ các ô trong bảng tính và thêm vào DataTable
            for (int row = 1; row < rowCount; row++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int column = 0; column < columnCount; column++)
                {
                        dataRow[column] = worksheet.Cells[row, column].Value?.ToString();
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin();
            Application.Run(loginForm);
        }
    }
}
