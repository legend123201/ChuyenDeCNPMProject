namespace QuanLyVatTuChuyenDeCNPM
{
    partial class frmLapPhieu
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
            System.Windows.Forms.Label pHIEULabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label pHIEULabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label lOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.buttonThem = new DevExpress.XtraBars.BarButtonItem();
            this.buttonXoa = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSua = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGhi = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.buttonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.buttonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QuanLyVatTuChuyenDeCNPM.DS();
            this.bds_PhatSinh = new System.Windows.Forms.BindingSource(this.components);
            this.phatSinhTableAdapter = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.PhatSinhTableAdapter();
            this.tableAdapterManager = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.TableAdapterManager();
            this.gc_PhatSinh = new DevExpress.XtraGrid.GridControl();
            this.gv_PhatSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCTPhatSinh = new System.Windows.Forms.GroupBox();
            this.buttonTimVatTu = new System.Windows.Forms.Button();
            this.textEdit_DonGia_CTPS = new DevExpress.XtraEditors.TextEdit();
            this.bds_CTPhatSinh = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_SoLuong_CTPS = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_MaVT_CTPS = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Phieu_CTPS = new DevExpress.XtraEditors.TextEdit();
            this.gc_CTPhatSinh = new DevExpress.XtraGrid.GridControl();
            this.gv_CTPhatSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPHIEU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPhatSinh = new System.Windows.Forms.GroupBox();
            this.cmb_Loai_PS = new System.Windows.Forms.ComboBox();
            this.textEdit_MaNV_PS = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_HoTenKH_PS = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit_Ngay_PS = new DevExpress.XtraEditors.DateEdit();
            this.textEdit_Phieu_PS = new DevExpress.XtraEditors.TextEdit();
            this.cT_PhatSinhTableAdapter = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.CT_PhatSinhTableAdapter();
            this.labelBangDangThaoTac = new DevExpress.XtraBars.BarStaticItem();
            pHIEULabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            pHIEULabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            lOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhatSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhatSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhatSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxCTPhatSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DonGia_CTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhatSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoLuong_CTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaVT_CTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Phieu_CTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPhatSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPhatSinh)).BeginInit();
            this.groupBoxPhatSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaNV_PS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTenKH_PS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Ngay_PS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Ngay_PS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Phieu_PS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pHIEULabel
            // 
            pHIEULabel.AutoSize = true;
            pHIEULabel.Location = new System.Drawing.Point(39, 87);
            pHIEULabel.Name = "pHIEULabel";
            pHIEULabel.Size = new System.Drawing.Size(70, 17);
            pHIEULabel.TabIndex = 0;
            pHIEULabel.Text = "Mã phiếu:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(39, 151);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(39, 279);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(132, 17);
            hOTENKHLabel.TabIndex = 6;
            hOTENKHLabel.Text = "Họ tên khách hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(39, 343);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(97, 17);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // pHIEULabel1
            // 
            pHIEULabel1.AutoSize = true;
            pHIEULabel1.Location = new System.Drawing.Point(545, 59);
            pHIEULabel1.Name = "pHIEULabel1";
            pHIEULabel1.Size = new System.Drawing.Size(70, 17);
            pHIEULabel1.TabIndex = 0;
            pHIEULabel1.Text = "Mã phiếu:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(545, 158);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(70, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(1002, 158);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(1002, 59);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(61, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // lOAILabel
            // 
            lOAILabel.AutoSize = true;
            lOAILabel.Location = new System.Drawing.Point(41, 215);
            lOAILabel.Name = "lOAILabel";
            lOAILabel.Size = new System.Drawing.Size(39, 17);
            lOAILabel.TabIndex = 9;
            lOAILabel.Text = "Loại:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.buttonThem,
            this.buttonXoa,
            this.buttonSua,
            this.buttonThoat,
            this.buttonHuy,
            this.buttonGhi,
            this.barButtonItem1,
            this.buttonRefresh,
            this.labelBangDangThaoTac});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.labelBangDangThaoTac)});
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // buttonThem
            // 
            this.buttonThem.Caption = "Thêm";
            this.buttonThem.Id = 0;
            this.buttonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.ImageOptions.Image")));
            this.buttonThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.ImageOptions.LargeImage")));
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThem_ItemClick);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Caption = "Xoá";
            this.buttonXoa.Id = 1;
            this.buttonXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.ImageOptions.Image")));
            this.buttonXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.ImageOptions.LargeImage")));
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonXoa_ItemClick);
            // 
            // buttonSua
            // 
            this.buttonSua.Caption = "Sửa";
            this.buttonSua.Id = 2;
            this.buttonSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.ImageOptions.Image")));
            this.buttonSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.ImageOptions.LargeImage")));
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSua_ItemClick);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Caption = "Ghi";
            this.buttonGhi.Id = 5;
            this.buttonGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGhi.ImageOptions.Image")));
            this.buttonGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonGhi.ImageOptions.LargeImage")));
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonGhi_ItemClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Caption = "Refresh";
            this.buttonRefresh.Id = 7;
            this.buttonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageOptions.Image")));
            this.buttonRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageOptions.LargeImage")));
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRefresh_ItemClick);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Caption = "Huỷ";
            this.buttonHuy.Id = 4;
            this.buttonHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.ImageOptions.Image")));
            this.buttonHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonHuy.ImageOptions.LargeImage")));
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonHuy_ItemClick);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Caption = "Thoát";
            this.buttonThoat.Id = 3;
            this.buttonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.Image")));
            this.buttonThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.LargeImage")));
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1683, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 782);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1683, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 725);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1683, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 725);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_PhatSinh
            // 
            this.bds_PhatSinh.DataMember = "PhatSinh";
            this.bds_PhatSinh.DataSource = this.dS;
            // 
            // phatSinhTableAdapter
            // 
            this.phatSinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PhatSinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhatSinhTableAdapter = this.phatSinhTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTuChuyenDeCNPM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // gc_PhatSinh
            // 
            this.gc_PhatSinh.DataSource = this.bds_PhatSinh;
            this.gc_PhatSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_PhatSinh.Location = new System.Drawing.Point(0, 57);
            this.gc_PhatSinh.MainView = this.gv_PhatSinh;
            this.gc_PhatSinh.MenuManager = this.barManager1;
            this.gc_PhatSinh.Name = "gc_PhatSinh";
            this.gc_PhatSinh.Size = new System.Drawing.Size(1683, 213);
            this.gc_PhatSinh.TabIndex = 5;
            this.gc_PhatSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PhatSinh});
            this.gc_PhatSinh.Click += new System.EventHandler(this.gc_PhatSinh_Click);
            // 
            // gv_PhatSinh
            // 
            this.gv_PhatSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU,
            this.colNGAY,
            this.colLOAI,
            this.colHOTENKH,
            this.colMANV});
            this.gv_PhatSinh.GridControl = this.gc_PhatSinh;
            this.gv_PhatSinh.GroupPanelText = "Phát sinh";
            this.gv_PhatSinh.Name = "gv_PhatSinh";
            this.gv_PhatSinh.Click += new System.EventHandler(this.gv_PhatSinh_Click);
            // 
            // colPHIEU
            // 
            this.colPHIEU.AppearanceCell.Options.UseTextOptions = true;
            this.colPHIEU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHIEU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHIEU.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHIEU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHIEU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHIEU.FieldName = "PHIEU";
            this.colPHIEU.MinWidth = 25;
            this.colPHIEU.Name = "colPHIEU";
            this.colPHIEU.OptionsColumn.AllowEdit = false;
            this.colPHIEU.Visible = true;
            this.colPHIEU.VisibleIndex = 0;
            this.colPHIEU.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAY.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colLOAI
            // 
            this.colLOAI.AppearanceCell.Options.UseTextOptions = true;
            this.colLOAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOAI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLOAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOAI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.MinWidth = 25;
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.OptionsColumn.AllowEdit = false;
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 2;
            this.colLOAI.Width = 94;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.AppearanceCell.Options.UseTextOptions = true;
            this.colHOTENKH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENKH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOTENKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTENKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENKH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 3;
            this.colHOTENKH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.Options.UseTextOptions = true;
            this.colMANV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMANV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMANV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMANV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMANV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxCTPhatSinh);
            this.panel1.Controls.Add(this.gc_CTPhatSinh);
            this.panel1.Controls.Add(this.groupBoxPhatSinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 512);
            this.panel1.TabIndex = 11;
            // 
            // groupBoxCTPhatSinh
            // 
            this.groupBoxCTPhatSinh.Controls.Add(this.buttonTimVatTu);
            this.groupBoxCTPhatSinh.Controls.Add(dONGIALabel);
            this.groupBoxCTPhatSinh.Controls.Add(this.textEdit_DonGia_CTPS);
            this.groupBoxCTPhatSinh.Controls.Add(sOLUONGLabel);
            this.groupBoxCTPhatSinh.Controls.Add(this.textEdit_SoLuong_CTPS);
            this.groupBoxCTPhatSinh.Controls.Add(mAVTLabel);
            this.groupBoxCTPhatSinh.Controls.Add(this.textEdit_MaVT_CTPS);
            this.groupBoxCTPhatSinh.Controls.Add(pHIEULabel1);
            this.groupBoxCTPhatSinh.Controls.Add(this.textEdit_Phieu_CTPS);
            this.groupBoxCTPhatSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCTPhatSinh.Location = new System.Drawing.Point(397, 220);
            this.groupBoxCTPhatSinh.Name = "groupBoxCTPhatSinh";
            this.groupBoxCTPhatSinh.Size = new System.Drawing.Size(1286, 292);
            this.groupBoxCTPhatSinh.TabIndex = 2;
            this.groupBoxCTPhatSinh.TabStop = false;
            this.groupBoxCTPhatSinh.Enter += new System.EventHandler(this.groupBoxCTPhatSinh_Enter);
            // 
            // buttonTimVatTu
            // 
            this.buttonTimVatTu.Location = new System.Drawing.Point(783, 150);
            this.buttonTimVatTu.Name = "buttonTimVatTu";
            this.buttonTimVatTu.Size = new System.Drawing.Size(79, 32);
            this.buttonTimVatTu.TabIndex = 8;
            this.buttonTimVatTu.Text = "Tìm";
            this.buttonTimVatTu.UseVisualStyleBackColor = true;
            this.buttonTimVatTu.Click += new System.EventHandler(this.buttonTimVatTu_Click);
            // 
            // textEdit_DonGia_CTPS
            // 
            this.textEdit_DonGia_CTPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPhatSinh, "DONGIA", true));
            this.textEdit_DonGia_CTPS.Location = new System.Drawing.Point(1084, 56);
            this.textEdit_DonGia_CTPS.MenuManager = this.barManager1;
            this.textEdit_DonGia_CTPS.Name = "textEdit_DonGia_CTPS";
            this.textEdit_DonGia_CTPS.Size = new System.Drawing.Size(137, 22);
            this.textEdit_DonGia_CTPS.TabIndex = 7;
            // 
            // bds_CTPhatSinh
            // 
            this.bds_CTPhatSinh.DataMember = "CT_PhatSinh";
            this.bds_CTPhatSinh.DataSource = this.dS;
            // 
            // textEdit_SoLuong_CTPS
            // 
            this.textEdit_SoLuong_CTPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPhatSinh, "SOLUONG", true));
            this.textEdit_SoLuong_CTPS.Location = new System.Drawing.Point(1084, 155);
            this.textEdit_SoLuong_CTPS.MenuManager = this.barManager1;
            this.textEdit_SoLuong_CTPS.Name = "textEdit_SoLuong_CTPS";
            this.textEdit_SoLuong_CTPS.Size = new System.Drawing.Size(137, 22);
            this.textEdit_SoLuong_CTPS.TabIndex = 5;
            // 
            // textEdit_MaVT_CTPS
            // 
            this.textEdit_MaVT_CTPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPhatSinh, "MAVT", true));
            this.textEdit_MaVT_CTPS.Location = new System.Drawing.Point(634, 155);
            this.textEdit_MaVT_CTPS.MenuManager = this.barManager1;
            this.textEdit_MaVT_CTPS.Name = "textEdit_MaVT_CTPS";
            this.textEdit_MaVT_CTPS.Size = new System.Drawing.Size(143, 22);
            this.textEdit_MaVT_CTPS.TabIndex = 3;
            // 
            // textEdit_Phieu_CTPS
            // 
            this.textEdit_Phieu_CTPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPhatSinh, "PHIEU", true));
            this.textEdit_Phieu_CTPS.Location = new System.Drawing.Point(634, 56);
            this.textEdit_Phieu_CTPS.MenuManager = this.barManager1;
            this.textEdit_Phieu_CTPS.Name = "textEdit_Phieu_CTPS";
            this.textEdit_Phieu_CTPS.Size = new System.Drawing.Size(143, 22);
            this.textEdit_Phieu_CTPS.TabIndex = 1;
            // 
            // gc_CTPhatSinh
            // 
            this.gc_CTPhatSinh.DataSource = this.bds_CTPhatSinh;
            this.gc_CTPhatSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_CTPhatSinh.Location = new System.Drawing.Point(397, 0);
            this.gc_CTPhatSinh.MainView = this.gv_CTPhatSinh;
            this.gc_CTPhatSinh.MenuManager = this.barManager1;
            this.gc_CTPhatSinh.Name = "gc_CTPhatSinh";
            this.gc_CTPhatSinh.Size = new System.Drawing.Size(1286, 220);
            this.gc_CTPhatSinh.TabIndex = 1;
            this.gc_CTPhatSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTPhatSinh});
            this.gc_CTPhatSinh.Click += new System.EventHandler(this.gc_CTPhatSinh_Click);
            // 
            // gv_CTPhatSinh
            // 
            this.gv_CTPhatSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gv_CTPhatSinh.GridControl = this.gc_CTPhatSinh;
            this.gv_CTPhatSinh.GroupPanelText = "Chi tiết phát sinh";
            this.gv_CTPhatSinh.Name = "gv_CTPhatSinh";
            // 
            // colPHIEU1
            // 
            this.colPHIEU1.AppearanceCell.Options.UseTextOptions = true;
            this.colPHIEU1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHIEU1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHIEU1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHIEU1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHIEU1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHIEU1.FieldName = "PHIEU";
            this.colPHIEU1.MinWidth = 25;
            this.colPHIEU1.Name = "colPHIEU1";
            this.colPHIEU1.OptionsColumn.AllowEdit = false;
            this.colPHIEU1.Visible = true;
            this.colPHIEU1.VisibleIndex = 0;
            this.colPHIEU1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceCell.Options.UseTextOptions = true;
            this.colMAVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.colSOLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.AppearanceCell.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // groupBoxPhatSinh
            // 
            this.groupBoxPhatSinh.Controls.Add(lOAILabel);
            this.groupBoxPhatSinh.Controls.Add(this.cmb_Loai_PS);
            this.groupBoxPhatSinh.Controls.Add(mANVLabel);
            this.groupBoxPhatSinh.Controls.Add(this.textEdit_MaNV_PS);
            this.groupBoxPhatSinh.Controls.Add(hOTENKHLabel);
            this.groupBoxPhatSinh.Controls.Add(this.textEdit_HoTenKH_PS);
            this.groupBoxPhatSinh.Controls.Add(nGAYLabel);
            this.groupBoxPhatSinh.Controls.Add(this.dateEdit_Ngay_PS);
            this.groupBoxPhatSinh.Controls.Add(pHIEULabel);
            this.groupBoxPhatSinh.Controls.Add(this.textEdit_Phieu_PS);
            this.groupBoxPhatSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPhatSinh.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPhatSinh.Name = "groupBoxPhatSinh";
            this.groupBoxPhatSinh.Size = new System.Drawing.Size(397, 512);
            this.groupBoxPhatSinh.TabIndex = 0;
            this.groupBoxPhatSinh.TabStop = false;
            // 
            // cmb_Loai_PS
            // 
            this.cmb_Loai_PS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_PhatSinh, "LOAI", true));
            this.cmb_Loai_PS.FormattingEnabled = true;
            this.cmb_Loai_PS.Location = new System.Drawing.Point(201, 212);
            this.cmb_Loai_PS.Name = "cmb_Loai_PS";
            this.cmb_Loai_PS.Size = new System.Drawing.Size(148, 24);
            this.cmb_Loai_PS.TabIndex = 10;
            // 
            // textEdit_MaNV_PS
            // 
            this.textEdit_MaNV_PS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhatSinh, "MANV", true));
            this.textEdit_MaNV_PS.Location = new System.Drawing.Point(201, 340);
            this.textEdit_MaNV_PS.MenuManager = this.barManager1;
            this.textEdit_MaNV_PS.Name = "textEdit_MaNV_PS";
            this.textEdit_MaNV_PS.Size = new System.Drawing.Size(148, 22);
            this.textEdit_MaNV_PS.TabIndex = 9;
            // 
            // textEdit_HoTenKH_PS
            // 
            this.textEdit_HoTenKH_PS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhatSinh, "HOTENKH", true));
            this.textEdit_HoTenKH_PS.Location = new System.Drawing.Point(201, 276);
            this.textEdit_HoTenKH_PS.MenuManager = this.barManager1;
            this.textEdit_HoTenKH_PS.Name = "textEdit_HoTenKH_PS";
            this.textEdit_HoTenKH_PS.Size = new System.Drawing.Size(148, 22);
            this.textEdit_HoTenKH_PS.TabIndex = 7;
            // 
            // dateEdit_Ngay_PS
            // 
            this.dateEdit_Ngay_PS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhatSinh, "NGAY", true));
            this.dateEdit_Ngay_PS.EditValue = null;
            this.dateEdit_Ngay_PS.Location = new System.Drawing.Point(201, 148);
            this.dateEdit_Ngay_PS.MenuManager = this.barManager1;
            this.dateEdit_Ngay_PS.Name = "dateEdit_Ngay_PS";
            this.dateEdit_Ngay_PS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Ngay_PS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Ngay_PS.Size = new System.Drawing.Size(148, 22);
            this.dateEdit_Ngay_PS.TabIndex = 3;
            // 
            // textEdit_Phieu_PS
            // 
            this.textEdit_Phieu_PS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhatSinh, "PHIEU", true));
            this.textEdit_Phieu_PS.Location = new System.Drawing.Point(201, 84);
            this.textEdit_Phieu_PS.MenuManager = this.barManager1;
            this.textEdit_Phieu_PS.Name = "textEdit_Phieu_PS";
            this.textEdit_Phieu_PS.Size = new System.Drawing.Size(148, 22);
            this.textEdit_Phieu_PS.TabIndex = 1;
            // 
            // cT_PhatSinhTableAdapter
            // 
            this.cT_PhatSinhTableAdapter.ClearBeforeFill = true;
            // 
            // labelBangDangThaoTac
            // 
            this.labelBangDangThaoTac.Caption = "Đang thao tác bảng: PHÁT SINH.";
            this.labelBangDangThaoTac.Id = 8;
            this.labelBangDangThaoTac.Name = "labelBangDangThaoTac";
            this.labelBangDangThaoTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem1_ItemClick);
            // 
            // frmLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gc_PhatSinh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLapPhieu";
            this.Text = "frmLapPhieu";
            this.Load += new System.EventHandler(this.frmLapPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhatSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhatSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhatSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxCTPhatSinh.ResumeLayout(false);
            this.groupBoxCTPhatSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DonGia_CTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhatSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoLuong_CTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaVT_CTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Phieu_CTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPhatSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPhatSinh)).EndInit();
            this.groupBoxPhatSinh.ResumeLayout(false);
            this.groupBoxPhatSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaNV_PS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTenKH_PS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Ngay_PS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Ngay_PS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Phieu_PS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem buttonThem;
        private DevExpress.XtraBars.BarButtonItem buttonXoa;
        private DevExpress.XtraBars.BarButtonItem buttonSua;
        private DevExpress.XtraBars.BarButtonItem buttonGhi;
        private DevExpress.XtraBars.BarButtonItem buttonHuy;
        private DevExpress.XtraBars.BarButtonItem buttonThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bds_PhatSinh;
        private DS dS;
        private DSTableAdapters.PhatSinhTableAdapter phatSinhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_PhatSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PhatSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPhatSinh;
        private System.Windows.Forms.BindingSource bds_CTPhatSinh;
        private DSTableAdapters.CT_PhatSinhTableAdapter cT_PhatSinhTableAdapter;
        private DevExpress.XtraGrid.GridControl gc_CTPhatSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTPhatSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBoxCTPhatSinh;
        private DevExpress.XtraEditors.TextEdit textEdit_DonGia_CTPS;
        private DevExpress.XtraEditors.TextEdit textEdit_SoLuong_CTPS;
        private DevExpress.XtraEditors.TextEdit textEdit_Phieu_CTPS;
        private DevExpress.XtraEditors.TextEdit textEdit_MaNV_PS;
        private DevExpress.XtraEditors.TextEdit textEdit_HoTenKH_PS;
        private DevExpress.XtraEditors.DateEdit dateEdit_Ngay_PS;
        private DevExpress.XtraEditors.TextEdit textEdit_Phieu_PS;
        private DevExpress.XtraBars.BarButtonItem buttonRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox cmb_Loai_PS;
        private System.Windows.Forms.Button buttonTimVatTu;
        public DevExpress.XtraEditors.TextEdit textEdit_MaVT_CTPS;
        private DevExpress.XtraBars.BarStaticItem labelBangDangThaoTac;
    }
}