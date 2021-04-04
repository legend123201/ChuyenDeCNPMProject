namespace QuanLyVatTuChuyenDeCNPM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.buttonDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.buttonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.buttonVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.buttonPhieuHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMaNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTenNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblChucVu = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.buttonDangNhap,
            this.buttonThoat,
            this.buttonVatTu,
            this.buttonPhieuHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rbpQuanLy});
            this.ribbonControl1.Size = new System.Drawing.Size(1086, 193);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Caption = "Đăng nhập";
            this.buttonDangNhap.Id = 1;
            this.buttonDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDangNhap.ImageOptions.Image")));
            this.buttonDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonDangNhap.ImageOptions.LargeImage")));
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDangNhap_ItemClick);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Caption = "Thoát";
            this.buttonThoat.Id = 2;
            this.buttonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.Image")));
            this.buttonThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.LargeImage")));
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThoat_ItemClick);
            // 
            // buttonVatTu
            // 
            this.buttonVatTu.Caption = "Vật tư";
            this.buttonVatTu.Id = 3;
            this.buttonVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonVatTu.ImageOptions.Image")));
            this.buttonVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonVatTu.ImageOptions.LargeImage")));
            this.buttonVatTu.Name = "buttonVatTu";
            this.buttonVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonVatTu_ItemClick);
            // 
            // buttonPhieuHang
            // 
            this.buttonPhieuHang.Caption = "Phiếu hàng";
            this.buttonPhieuHang.Id = 4;
            this.buttonPhieuHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonPhieuHang.ImageOptions.Image")));
            this.buttonPhieuHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonPhieuHang.ImageOptions.LargeImage")));
            this.buttonPhieuHang.Name = "buttonPhieuHang";
            this.buttonPhieuHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonPhieuHang_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tài Khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpQuanLy
            // 
            this.rbpQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpQuanLy.Name = "rbpQuanLy";
            this.rbpQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.buttonVatTu);
            this.ribbonPageGroup2.ItemLinks.Add(this.buttonPhieuHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMaNhanVien,
            this.lblTenNhanVien,
            this.lblChucVu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1086, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(102, 20);
            this.lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(64, 20);
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 590);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem buttonThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblMaNhanVien;
        public System.Windows.Forms.ToolStripStatusLabel lblTenNhanVien;
        public System.Windows.Forms.ToolStripStatusLabel lblChucVu;
        private DevExpress.XtraBars.BarButtonItem buttonVatTu;
        private DevExpress.XtraBars.BarButtonItem buttonPhieuHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanLy;
    }
}

