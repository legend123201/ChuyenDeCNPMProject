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
    public partial class frmLapPhieu : Form
    {
        Boolean isFocusOnTablePhatSinh = true;
        Boolean isDangThem = false, isDangSua = false;

        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void phatSinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_PhatSinh.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.PhatSinh' table. You can move, or remove it, as needed.
            this.phatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phatSinhTableAdapter.Fill(this.dS.PhatSinh);

            // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
            this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);

            //lọc bảng chi tiết phát sinh theo dòng đầu tiên của bảng phát sinh luôn
            if (bds_PhatSinh.Count != 0)
            {
                string phieu = ((DataRowView)bds_PhatSinh[0])["PHIEU"].ToString();
                this.bds_CTPhatSinh.Filter = "PHIEU = '" + phieu + "'";

            }

            cmb_Loai_PS.Items.Add("N");
            cmb_Loai_PS.Items.Add("X");
            cmb_Loai_PS.DropDownStyle = ComboBoxStyle.DropDownList; //nhớ chỉnh thêm trong giao diện sửa databinding phần text của conbobox thành none 

            textEdit_MaNV_PS.Enabled = false; //mã nhân viên ko bao giờ đc sửa
            textEdit_Phieu_CTPS.Enabled = false;//mã phiếu trong chi tiết phát sinh ko bao giờ đc sửa

            groupBoxPhatSinh.Enabled = groupBoxCTPhatSinh.Enabled = false;
            buttonGhi.Enabled = buttonHuy.Enabled = false;
        }

        private void gc_PhatSinh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("bạn đã click", "", MessageBoxButtons.OK);
            isFocusOnTablePhatSinh = true;

        }

        private void gc_CTPhatSinh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("bạn đã click", "", MessageBoxButtons.OK);
            isFocusOnTablePhatSinh = false;
        }

        private void gv_PhatSinh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
            this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);

            string phieu = gv_PhatSinh.GetRowCellValue(gv_PhatSinh.FocusedRowHandle, "PHIEU").ToString().Trim();
            this.bds_CTPhatSinh.Filter = "PHIEU = '" + phieu + "'";

        }
        
        private void buttonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                //ktra lỗi
                if (bds_PhatSinh.Count == 0)
                {
                    MessageBox.Show("Không có phiếu để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                if (bds_CTPhatSinh.Count != 0)
                {
                    MessageBox.Show("Phiếu đã có vật tư trong phiếu hàng, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                //nếu ko lỗi
                if (MessageBox.Show("Bạn có thật sự muốn phiếu hàng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bds_PhatSinh.RemoveCurrent();
                        this.phatSinhTableAdapter.Update(this.dS.PhatSinh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thao tác xoá bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                //ktra lỗi
                if (bds_CTPhatSinh.Count == 0)
                {
                    MessageBox.Show("Không có chi tiết trong phiếu để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                //nếu ko lỗi
                if (MessageBox.Show("Bạn có thật sự muốn chi tiết phiếu hàng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bds_CTPhatSinh.RemoveCurrent();
                        this.cT_PhatSinhTableAdapter.Update(this.dS.CT_PhatSinh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thao tác xoá bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void buttonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;

            if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                if (bds_PhatSinh.Count == 0)
                {
                    MessageBox.Show("Không có phiếu để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                textEdit_Phieu_PS.Enabled = false;

                textEdit_HoTenKH_PS.Text = textEdit_HoTenKH_PS.Text.Trim();

                gc_PhatSinh.Enabled = gc_CTPhatSinh.Enabled = groupBoxCTPhatSinh.Enabled = false;
                groupBoxPhatSinh.Enabled = true;
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                if (bds_CTPhatSinh.Count == 0)
                {
                    MessageBox.Show("Không có chi tiết trong phiếu để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                textEdit_MaVT_CTPS.Enabled = false;

                textEdit_DonGia_CTPS.Text = textEdit_DonGia_CTPS.Text.Trim();
                textEdit_SoLuong_CTPS.Text = textEdit_SoLuong_CTPS.Text.Trim();

                gc_PhatSinh.Enabled = gc_CTPhatSinh.Enabled = groupBoxPhatSinh.Enabled = false;
                groupBoxCTPhatSinh.Enabled = true;
            }
            buttonGhi.Enabled = buttonHuy.Enabled = true;
            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = false;
        }

        private void buttonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.PhatSinh' table. You can move, or remove it, as needed.
            this.phatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phatSinhTableAdapter.Fill(this.dS.PhatSinh);

            // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
            this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);

            //lọc bảng chi tiết phát sinh theo dòng đầu tiên của bảng phát sinh luôn
            if (bds_PhatSinh.Count != 0)
            {
                string phieu = gv_PhatSinh.GetRowCellValue(gv_PhatSinh.FocusedRowHandle, "PHIEU").ToString();
                this.bds_CTPhatSinh.Filter = "PHIEU = '" + phieu + "'";
            }
        }

        private void buttonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                try
                {
                    bds_PhatSinh.CancelEdit();
                    if (isDangThem)
                    {
                        if (bds_PhatSinh.Count != 0) //phải bỏ trong if (đọc note bên dưới trc), bởi vì do lỗi bên dưới, mà xoá dòng đang chọn thì làm gì có dòng đang chọn khi lúc đầu rỗng, nên nó sẽ báo lỗi
                        {
                            bds_PhatSinh.RemoveCurrent();
                        }
                        //thêm 2 dòng bên dưới bởi vì khi mà remove dòng mới nhưng dòng mới chưa nhập gì thì nó xoá luôn dòng đang chọn của lần trước, chưa update nên database chưa mất, nên fill lại là đc
                        // TODO: This line of code loads data into the 'dS.PhatSinh' table. You can move, or remove it, as needed.
                        this.phatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phatSinhTableAdapter.Fill(this.dS.PhatSinh);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác huỷ bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                try
                {
                    bds_CTPhatSinh.CancelEdit();
                    if (isDangThem)
                    {
                        if(bds_CTPhatSinh.Count != 0) //phải bỏ trong if (đọc note bên dưới trc), bởi vì do lỗi bên dưới, mà xoá dòng đang chọn thì làm gì có dòng đang chọn khi lúc đầu rỗng, nên nó sẽ báo lỗi
                        {
                            bds_CTPhatSinh.RemoveCurrent();
                        }
                        
                        //note: thêm 2 dòng bên dưới bởi vì khi mà remove dòng mới nhưng dòng mới chưa nhập gì thì nó xoá luôn dòng đang chọn của lần trước, chưa update nên database chưa mất, nên fill lại là đc
                        
                        // TODO: This line of code loads data into the 'dS.CT_PhatSinh' table. You can move, or remove it, as needed.
                        this.cT_PhatSinhTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cT_PhatSinhTableAdapter.Fill(this.dS.CT_PhatSinh);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác huỷ bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            isDangThem = isDangSua = false;

            groupBoxPhatSinh.Enabled = groupBoxCTPhatSinh.Enabled = false;
            gc_PhatSinh.Enabled = gc_CTPhatSinh.Enabled = true;

            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = true;
            buttonGhi.Enabled = buttonHuy.Enabled = false;
        }

        private void buttonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                textEdit_Phieu_PS.Text = textEdit_Phieu_PS.Text.Trim();
                dateEdit_Ngay_PS.Text = dateEdit_Ngay_PS.Text.Trim();
                textEdit_HoTenKH_PS.Text = textEdit_HoTenKH_PS.Text.Trim();
                textEdit_MaNV_PS.Text = textEdit_MaNV_PS.Text.Trim();

                //------------------------kiểm tra rỗng----------------------start
                if (textEdit_Phieu_PS.Text.Equals(""))
                {
                    MessageBox.Show("Mã phiếu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (dateEdit_Ngay_PS.Text.Equals(""))
                {
                    MessageBox.Show("Ngày lập không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (textEdit_HoTenKH_PS.Text.Equals(""))
                {
                    MessageBox.Show("Họ tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                //------------------------kiểm tra rỗng----------------------end

                //------------------------kiểm tra trùng----------------------start
                if (isDangThem)
                {
                    try
                    {
                        string sql = "exec [dbo].[SP_KTTrungPhieuPhatSinh] N'" + textEdit_Phieu_PS.Text + "'";
                        int ketQua = Program.ExecSqlNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                            textEdit_Phieu_PS.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //------------------------kiểm tra trùng----------------------end

                try
                {
                    bds_PhatSinh.EndEdit();
                    bds_PhatSinh.ResetCurrentItem();
                    this.phatSinhTableAdapter.Update(this.dS.PhatSinh); //có trường hợp là khi sửa nhưng ko sửa gì hết thì ko cần update, nhưng tất cả các TH khác đều cần update nên dùng lệnh này luôn
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                //nếu thêm thành công ở bảng phát sinh, thì phải filter bảng chi tiết phát sinh lại
                string phieu = gv_PhatSinh.GetRowCellValue(gv_PhatSinh.FocusedRowHandle, "PHIEU").ToString().Trim();
                this.bds_CTPhatSinh.Filter = "PHIEU = '" + phieu + "'";
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                textEdit_Phieu_CTPS.Text = textEdit_Phieu_CTPS.Text.Trim();
                textEdit_MaVT_CTPS.Text = textEdit_MaVT_CTPS.Text.Trim();
                textEdit_DonGia_CTPS.Text = textEdit_DonGia_CTPS.Text.Trim();
                textEdit_SoLuong_CTPS.Text = textEdit_SoLuong_CTPS.Text.Trim();

                //------------------------kiểm tra rỗng----------------------start
                if (textEdit_MaVT_CTPS.Text.Equals(""))
                {
                    MessageBox.Show("Mã vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (textEdit_DonGia_CTPS.Text.Equals(""))
                {
                    MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (textEdit_SoLuong_CTPS.Text.Equals(""))
                {
                    MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                //------------------------kiểm tra rỗng----------------------end

                //------------------------kiểm tra số học--------------------start
                try
                {
                    int soluong = int.Parse(textEdit_SoLuong_CTPS.Text);
                    if (soluong <= 0 || soluong > 9999999)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0 và nhỏ hơn 9999999!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Số lượng phải là số nguyên!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    textEdit_SoLuong_CTPS.Focus();
                    return;
                }

                try
                {
                    float dongia = float.Parse(textEdit_DonGia_CTPS.Text);
                    if (dongia <= 0 || dongia > 999999999)
                    {
                        MessageBox.Show("Đơn giá phải là số thực lớn hơn 0 và nhỏ hơn 999999999!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đơn giá phải là số thực!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    textEdit_DonGia_CTPS.Focus();
                    return;
                }
                //------------------------kiểm tra số học--------------------end

                //------------------------kiểm tra tồn tại vật tư--------------------start
                if (isDangThem)
                {
                    try
                    {
                        string sql = "exec [dbo].[SP_KTTonTaiMaVatTu] N'" + textEdit_MaVT_CTPS.Text + "'";
                        int ketQua = Program.ExecSqlNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                            textEdit_MaVT_CTPS.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //------------------------kiểm tra tồn tại vật tư--------------------end

                //------------------------kiểm tra trùng----------------------start
                if (isDangThem)
                {
                    try
                    {
                        string sql = "exec [dbo].[SP_KTTrungChiTietPhatSinh] N'" + textEdit_Phieu_CTPS.Text + "', N'" + textEdit_MaVT_CTPS.Text + "'";
                        int ketQua = Program.ExecSqlNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                            textEdit_MaVT_CTPS.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //------------------------kiểm tra trùng----------------------end

                try
                {
         
                    bds_CTPhatSinh.EndEdit();
                    bds_CTPhatSinh.ResetCurrentItem();
                    this.cT_PhatSinhTableAdapter.Update(this.dS.CT_PhatSinh); //có trường hợp là khi sửa nhưng ko sửa gì hết thì ko cần update, nhưng tất cả các TH khác đều cần update nên dùng lệnh này luôn
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác không thành công! Đã có lỗi xảy ra!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            groupBoxPhatSinh.Enabled = groupBoxCTPhatSinh.Enabled = false;
            gc_PhatSinh.Enabled = gc_CTPhatSinh.Enabled = true;

            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = true;
            buttonGhi.Enabled = buttonHuy.Enabled = false;

            isDangThem = isDangSua = false;
        }

   

        private void buttonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangThem = true;
            if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                try
                {
                    bds_PhatSinh.AddNew();

                    gc_PhatSinh.Enabled = gc_CTPhatSinh.Enabled = groupBoxCTPhatSinh.Enabled = false;
                    groupBoxPhatSinh.Enabled = true;

                    //textEdit_Phieu_PS.Focus();
                    textEdit_Phieu_PS.Enabled = true;

                    textEdit_MaNV_PS.Text = Program.maNhanVien;
                    cmb_Loai_PS.SelectedIndex = 1; cmb_Loai_PS.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phiếu!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                try
                {
                    bds_CTPhatSinh.AddNew();
                   
                    gc_PhatSinh.Enabled = groupBoxPhatSinh.Enabled = false;
                    gc_CTPhatSinh.Enabled = false; //sẽ gây ra lỗi ko addnew mà cứ giữ hàng hiện tại và sửa hàng hiện tại
                    groupBoxCTPhatSinh.Enabled = true;

                    //textEdit_MaVT_CTPS.Focus(); 
                    textEdit_MaVT_CTPS.Enabled = true;

                    textEdit_Phieu_CTPS.Text = gv_PhatSinh.GetRowCellValue(gv_PhatSinh.FocusedRowHandle, "PHIEU").ToString().Trim(); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm vật tư vào phiếu!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            buttonGhi.Enabled = buttonHuy.Enabled = true;
            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = buttonRefresh.Enabled = false;
        }
    }
}


/*
         if (isFocusOnTablePhatSinh)
            {
                //nếu đang focus bảng phát sinh
                
            }
            else
            {
                //nếu đang focus bảng chi tiết phát sinh
                
            }         
         */