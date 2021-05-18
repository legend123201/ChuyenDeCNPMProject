using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuChuyenDeCNPM
{
    public partial class frmTimVatTu : Form
    {
        string maVTCurrent;
        Boolean focusNgoaiFormHopLe = false; //biến này sẽ giải thích bên dưới
        public frmTimVatTu()
        {
            InitializeComponent();
        }

        private void vatTuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_VatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTimVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.VatTu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.dS.VatTu);

            maVTCurrent = "";
            //mới vào thì cái bảng tự focus vào dòng đầu tiên nên mình set luôn maVTCurrent là maVT của cái dòng đầu tiên
            if (bds_VatTu.Count != 0)
            {
                maVTCurrent = ((DataRowView)bds_VatTu[0])["MAVT"].ToString();
            }
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        { 
            if (maVTCurrent == "")
            {
                focusNgoaiFormHopLe = true; //cái meesage box này hiện lên thì cái hàm frmTimVatTu_Deactivate cũng sẽ chạy, như vậy là ko đc, vậy đây chính là trường hợp focus ngoài form nhưng ko close form
                MessageBox.Show("Bạn chưa chọn vật tư!", "Thông báo", MessageBoxButtons.OK);
                focusNgoaiFormHopLe = false;
                return;
            }
            Program.frmChinh.frm_LapPhieu.textEdit_MaVT_CTPS.Text = maVTCurrent;
            this.Close(); //chọn đc rồi thì thoát
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            maVTCurrent = "";
            this.Close();
        }

        private void gv_VatTu_Click(object sender, EventArgs e)
        {
            maVTCurrent = gv_VatTu.GetRowCellValue(gv_VatTu.FocusedRowHandle, "MAVT").ToString().Trim();
        }

        private void frmTimVatTu_Deactivate(object sender, EventArgs e)
        {
            if (!focusNgoaiFormHopLe)
            {
                this.Close();
            } 
        }
    }
}
