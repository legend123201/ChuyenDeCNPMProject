using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyVatTuChuyenDeCNPM
{
    public partial class frmDangNhap : Form
    {
        public frmMain f;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if(Program.maNhanVien != "")
            {
                MessageBox.Show("Đăng nhập lỗi! Vui lòng đăng xuất trước!", "", MessageBoxButtons.OK);
                return;
            }

            textEditTaiKhoan.Text = textEditTaiKhoan.Text.Trim();
            textEditMatKhau.Text = textEditMatKhau.Text.Trim();
            if (textEditTaiKhoan.Text == "" || textEditMatKhau.Text == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0) return; //trong hàm này đã có báo lỗi
            string sql = "exec[dbo].[SP_DangNhap] " + textEditTaiKhoan.Text + ", '" + textEditMatKhau.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(sql); 
            if (Program.myReader == null) return;
            Program.myReader.Read();
            string ho = Program.myReader.GetString(0);
            string ten = Program.myReader.GetString(1);

            Program.maNhanVien = textEditTaiKhoan.Text;
            Program.matKhau = textEditMatKhau.Text;

            Program.frmChinh.lblMaNhanVien.Text = "Mã nhân viên: " + Program.maNhanVien;
            Program.frmChinh.lblTenNhanVien.Text = "Tên nhân viên: " + ho + " " + ten;
            Program.frmChinh.lblChucVu.Text = "Chức vụ: Nhân viên";

            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.rbpQuanLy.Visible = true;
            MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            if (Program.maNhanVien == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "", MessageBoxButtons.OK);
                return;
            }
            Program.maNhanVien = "";
            Program.matKhau = "";

            Program.frmChinh.lblMaNhanVien.Text = "Mã nhân viên";
            Program.frmChinh.lblTenNhanVien.Text = "Tên nhân viên";
            Program.frmChinh.lblChucVu.Text = "Chức vụ";

            Program.frmChinh.rbpQuanLy.Visible = false;
            MessageBox.Show("Đăng xuất thành công!", "", MessageBoxButtons.OK);
        }
    }
}
