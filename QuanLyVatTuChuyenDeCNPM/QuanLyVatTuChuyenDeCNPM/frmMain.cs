using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyVatTuChuyenDeCNPM
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmLapPhieu frm_LapPhieu = null;
       
        public frmMain()
        {
            InitializeComponent();
            rbpQuanLy.Visible = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void buttonDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                //f.f = this;
                f.Show();
            }
        }

        private void buttonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonPhieuHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLapPhieu));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_LapPhieu = new frmLapPhieu();
                frm_LapPhieu.MdiParent = this;
                frm_LapPhieu.Show();
            }
        }

        private void buttonVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null)
                frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
