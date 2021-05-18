﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyVatTuChuyenDeCNPM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "DESKTOP-D1DKRD0\\LUU";
        public static String database_login = "sa";
        public static String database_password = "123456";
        public static String maNhanVien = "";
        public static String matKhau = "";

        public static String database = "QLVT_CHUYENDE";
        
        public static frmMain frmChinh = null;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                //Data Source=DESKTOP-D1DKRD0\LUU;Initial Catalog=QLVT_CHUYENDE;User ID=sa;Password=123456
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + database_login + ";Password=" + Program.database_password;
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
        //trả về data chỉ cho xem, nếu có nhiều dòng chỉ cho đi xuống, dùng cho in báo cáo là hợp lý
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //khi muốn tải dữ liệu về rồi sửa rồi update db
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //sử dụng để thi hành sp, view, câu lệnh nhưng ko cần data trả về, chỉ cần mã lỗi thôi
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        public static string FormatDate(string date)
        {
            string[] t = date.Split('/');
            return t[1] + "/" + t[0] + "/" + t[2];
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
