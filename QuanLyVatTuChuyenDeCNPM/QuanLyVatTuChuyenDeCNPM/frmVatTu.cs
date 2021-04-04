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
    public partial class frmVatTu : Form
    {
        Boolean isDangThem = false, isDangSua = false;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vatTuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_VatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.VatTu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.dS.VatTu);
            // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
            this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);
        }

        private void groupBoxVatTu_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textEditMaVT.Text = textEditMaVT.Text.Trim();
            textEditTenVT.Text = textEditTenVT.Text.Trim();
            textEditDVT.Text = textEditDVT.Text.Trim();
            textEditSoLuongTon.Text = textEditSoLuongTon.Text.Trim();

            //------------------------kiểm tra rỗng----------------------start
            if (textEditMaVT.Text.Equals(""))
            {
                MessageBox.Show("Mã vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textEditTenVT.Text.Equals(""))
            {
                MessageBox.Show("Tên vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textEditDVT.Text.Equals(""))
            {
                MessageBox.Show("Đơn vị không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textEditSoLuongTon.Text.Equals(""))
            {
                MessageBox.Show("Số lượng tồn không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //------------------------kiểm tra rỗng----------------------end

            //------------------------kiểm tra số lượng tồn hợp lệ-------------------start
            try
            {
                int slt = int.Parse(textEditSoLuongTon.Text);
                if(slt <= 0 || slt > 9999999)
                {
                    MessageBox.Show("Số lượng tồn phải là số lớn hơn 0 và nhỏ hơn 9999999!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng tồn phải là số!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                textEditSoLuongTon.Focus();
                return;
            }
            //------------------------kiểm tra số lượng tồn hợp lệ-------------------end

            //------------------------kiểm tra trùng----------------------start
            if (isDangThem)
            {
                try
                {
                    string sql = "exec [dbo].[SP_KTTrungMaVatTu] N'" + textEditMaVT.Text + "'";
                    int ketQua = Program.ExecSqlNonQuery(sql);
                    //nếu như chạy sp ko thành công
                    if (ketQua == 1)
                    {
                        textEditMaVT.Focus();
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                
            }
            //------------------------kiểm tra trùng----------------------end


            try
            {
                bds_VatTu.EndEdit();
                bds_VatTu.ResetCurrentItem();
                this.vatTuTableAdapter.Update(this.dS.VatTu); //có trường hợp là khi sửa nhưng ko sửa gì hết thì ko cần update, nhưng tất cả các TH khác đều cần update nên dùng lệnh này luôn

                gc_VatTu.Enabled = true;
                groupBoxVatTu.Enabled = false;
                buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonRefresh.Enabled = buttonThoat.Enabled = true;
                buttonGhi.Enabled = buttonHuy.Enabled = false;
                isDangThem = isDangSua = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void buttonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ktra lỗi
            if (bds_VatTu.Count == 0)
            {
                MessageBox.Show("Không có vật tư để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (bds_CTPhatSinh.Count != 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết phát sinh của phiếu hàng, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            //nếu ko lỗi
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bds_VatTu.RemoveCurrent();
                    this.vatTuTableAdapter.Update(this.dS.VatTu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác xoá bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;

            textEditMaVT.Enabled = false;
            textEditTenVT.Text = textEditTenVT.Text.Trim();
            textEditDVT.Text = textEditDVT.Text.Trim();
            textEditSoLuongTon.Text = textEditSoLuongTon.Text.Trim();

            gc_VatTu.Enabled = false;
            groupBoxVatTu.Enabled = true;
            buttonGhi.Enabled = buttonHuy.Enabled = true;
            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = false;
        }

        private void buttonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.VatTu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.dS.VatTu);
            // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
            this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);
        }

        private void buttonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bds_VatTu.CancelEdit();
                if (isDangThem)
                {
                    bds_VatTu.RemoveCurrent();
                }
                isDangThem = isDangSua = false;
                gc_VatTu.Enabled = true;
                groupBoxVatTu.Enabled = false;
                buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = true;
                buttonGhi.Enabled = buttonHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác huỷ bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void buttonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                isDangThem = true;
                bds_VatTu.AddNew();

                gc_VatTu.Enabled = false;
                groupBoxVatTu.Enabled = true;

                textEditMaVT.Focus();
                textEditMaVT.Enabled = true;

                buttonGhi.Enabled = buttonHuy.Enabled = true;
                buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm vật tư\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
