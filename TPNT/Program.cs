using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TPNT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String connstr_publisher = "Data Source=MSI;Initial Catalog=TPNT;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";

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
                MessageBox.Show("Lỗi " + e.Message);
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


        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin();
            DialogResult loginResult = loginForm.ShowDialog();

            if (loginResult == DialogResult.OK)
            {
                // Thực hiện các xử lý sau khi đăng nhập thành công
                frmMainMenu mainMenuForm = new frmMainMenu();
                Application.Run(mainMenuForm);
            }
        }
    }
}
